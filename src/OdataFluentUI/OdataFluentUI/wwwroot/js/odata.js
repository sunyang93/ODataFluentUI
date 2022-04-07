'use strict';

let entityVm = new Vue({
    el: '#tableDiv',
    data: {
        handsonTableAccessories: [],
        currentHandsonTableAccessories: {},
        entityTypes: [],
        currentEntityType: {},
        currentEntitySet: []
    }
});

// OData Metadata元数据
let metadata = {_xml: null, _json: null, _entity: null };

// ODataApi地址
const defaultOdataApiUrl = 'http://localhost:5201/odata';
const defaultOdataApiMetadataUrl = `${defaultOdataApiUrl}/$metadata`;
document.getElementById('odataUri').value = defaultOdataApiMetadataUrl;
document.getElementById('odataXmlMetadataA').setAttribute('href', defaultOdataApiMetadataUrl);

searchOdata();

// 查询OData
function searchOdata() {
    queryOdataMetadata();
};

// 查询OData Metadata元数据
function queryOdataMetadata() {
    let uri = document.getElementById('odataUri').value;
    $.get(uri, function (data, status, xhr) {
        metadata._xml = data;
        metadata._json = mapperOdataMetadata(metadata._xml);
        metadata._entity = generateEditorConfig(metadata._json);

        entityVm._data.handsonTableAccessories = metadata._json.handsonTableAccessories;
        entityVm._data.entityTypes = metadata._entity;

        toastQueryResult();
    }, 'xml');
};

// Toast通知
function toastQueryResult() {
    let toastLiveExample = document.getElementById('liveToast');
    let toast = new bootstrap.Toast(toastLiveExample)
    toast.show();
};

// Entity下拉列表改变事件
function onEntityTypeChange(e) {
    let entityName = e.value;
    if (entityName !== '') {
        document.getElementById('odataEntityUri').value = `${defaultOdataApiUrl}/${entityName}`;
        let entityType = metadata._entity.find(d => d.name === entityName);
        if (entityType == undefined) {
            entityVm._data.currentEntityType = {};
        }
        else {
            entityVm._data.currentEntityType = entityType;
        }

        let accessories = metadata._json.handsonTableAccessories.find(d => d.entityName === entityName);
        if (accessories == undefined) {
            entityVm._data.currentHandsonTableAccessories = {};
        }
        else {
            entityVm._data.currentHandsonTableAccessories = accessories;
        }
        queryEntityDataset();
    }
    else {
        document.getElementById('odataEntityUri').value = '';
        entityVm._data.currentHandsonTableAccessories = {};
        entityVm._data.currentEntityType = {};
        entityVm._data.currentEntitySet = [];
    }
};

// Entity Dataset查询
function queryEntityDataset() {
    let url = document.getElementById("odataEntityUri").value;
    let top = document.getElementById("topOptions").value;
    let page = Number.parseInt(document.getElementById("pageOptions").value);
    let skip = (page - 1) * top;
    let orderBy = document.getElementById('orderByOptions').value;
    document.getElementById("skipOptions").value = skip;
    let uri = `${url}?$count=true&$orderby=${orderBy}&$top=${top}&$skip=${skip}`;
    let filter = document.getElementById('filterOptions').value.trim();
    if (filter !== '') {
        uri += `&$filter=${filter}`;
    }
    let select = document.getElementById('selectOptions').value.trim();
    if (select !== '') {
        uri += `&$select=${select}`;
    }
    //let search = document.getElementById('searchOptions').value.trim();
    //if (search !== '') {
    //    uri += `&$search=${search}`;
    //}
    let request = {
        requestUri: uri,
        method: "GET",
        headers: { Accept: "application/json;odata.metadata=full;odata.streaming=true" }
    };

    odatajs.oData.request(
        request,
        function (data, response) {
            let count = data['@odata.count'];
            document.getElementById("totalCountSpan").innerHTML = count;
            entityVm._data.currentEntitySet = data['value'];
        },
        function (err) {
            alert("Something went wrong");
        }
    );
};

// 上一页
function previousPage() {
    let page = Number.parseInt(document.getElementById("pageOptions").value);
    if (page > 1) {
        document.getElementById("pageOptions").value = (page - 1);
        queryEntityDataset();
    }
};

// 下一页
function nextPage() {
    let page = Number.parseInt(document.getElementById("pageOptions").value);
    document.getElementById("pageOptions").value = (page + 1);
    queryEntityDataset();
};

// 新建数据
function addNew() {
    let doms = document.getElementsByClassName('add-new');
    let props = {};
    for (let dom of doms) {
        let propId = dom.id;
        let propValue = dom.value;
        if (['MaterialId', 'CreateTime', 'UpdateTime'].includes(propId)) {
            continue;
        }
        if (dom.type === 'checkbox') {
            propValue = dom.checked;
        }
        let prop = {};
        prop[propId] = propValue;
        props = { ...props, ...prop };
    }

    let url = document.getElementById("odataEntityUri").value;
    var request = {
        requestUri: url,
        method: "POST",
        headers: { Accept: "application/json;odata.metadata=full;odata.streaming=true", "Content-Type": "application/json" },
        data: props
    };

    odatajs.oData.request(
        request,
        function (data, response) {

        },
        function (err) {
            alert("Something went wrong.");
        }
    );
};

// 解析OData Metadata元数据并生成handsontable配置数据
function mapperOdataMetadata(odataXml, printLog = true) {
    let odataXmlDocuments = odataXml;// $.parseXML(odataXml);
    let entityTypes = $(odataXmlDocuments).find('EntityType');
    let handsonTableAccessories = [];
    let odata = { entityTypes: [], enumTypes: [] };
    $(entityTypes).each(function (entityTypeIndex, entityType) {
        let accessories = {}, entityT = { propertys: [] };
        let entityName = entityType.attributes.Name.value;
        accessories.entityName = entityName;
        entityT.name = entityName;
        let Propertys = $(entityType).find('Property');
        let colHeaders = [], columns = [];
        $(Propertys).each(function (propertyIndex, Property) {
            let key = $($(entityType).find('Key')).first();
            let propertyRefs = $(key).find('PropertyRef');
            let keyRefs = [];
            $(propertyRefs).each(function (refIndex, propertyRef) {
                let keyName = propertyRef.attributes.Name.value;
                keyRefs.push(keyName);
            });
            entityT.keys = keyRefs;
            let column = {}, property = {};
            let propertyAttributeName = Property.attributes.Name.value;
            colHeaders.push(propertyAttributeName);
            column.data = propertyAttributeName;
            property.name = propertyAttributeName;
            let propertyAttributeType = Property.attributes.Type.value;
            property.dataType = propertyAttributeType;
            if (Property.attributes.hasOwnProperty('Nullable')) {
                let propertyAttributeNullable = Property.attributes.Nullable.value;
                property.required = propertyAttributeNullable === "false" ? true : false;
            }
            else {
                property.required = false;
            }
            if (Property.attributes.hasOwnProperty('DefaultValue')) {
                let propertyAttributeDefaultValue = Property.attributes.DefaultValue.value;
                property.defaultValue = propertyAttributeDefaultValue;
            }
            if (Property.attributes.hasOwnProperty('MaxLength')) {
                let propertyAttributeMaxLength = Property.attributes.MaxLength.value;
                property.maxLength = propertyAttributeMaxLength;
            }
            // https://docs.oasis-open.org/odata/odata-csdl-xml/v4.01/os/odata-csdl-xml-v4.01-os.html#sec_PrimitiveTypes
            if (['Edm.Decimal', 'Edm.Double', 'Edm.Int16', 'Edm.Int32', 'Edm.Int64', 'Edm.Single',].includes(propertyAttributeType)) {
                column.type = 'numeric';
            }
            else if (propertyAttributeType === 'Edm.Date') {
                column.type = 'date';
                column.dateFormat = 'YYYY-MM-DD';
            }
            else if (propertyAttributeType === 'Edm.DateTimeOffset') {
                column.type = 'time';
            }
            else if (propertyAttributeType === 'Edm.Boolean') {
                column.type = 'checkbox';
            }
            else if (propertyAttributeType.endsWith('EnumType')) {
                column.type = 'dropdown';
                let enumTypeName = propertyAttributeType.split('.')[1];
                let enumTypes = $(odataXmlDocuments).find('EnumType');
                $(enumTypes).each(function (enumTypeIndex, enumType) {
                    if (enumType.attributes.Name.value === enumTypeName) {
                        column.source = [];
                        property.enums = [];
                        let members = $(enumType).find('Member');
                        $(members).each(function (memberIndex, member) {
                            let memberName = member.attributes.Name.value;
                            let memberValue = member.attributes.Value.value;
                            column.source.push(memberName);

                            property.enums.push({ name: memberName, value: memberValue });
                        });
                    }
                });
            }
            else {
                column.type = 'text';
            }
            columns.push(column);

            entityT.propertys.push(property);
        });
        accessories.colHeaders = colHeaders;
        accessories.columns = columns;
        handsonTableAccessories.push(accessories);

        odata.entityTypes.push(entityT);
    });

    let enumTypes = $(odataXmlDocuments).find('EnumType');
    $(enumTypes).each(function (enumTypeIndex, enumType) {
        let enumT = { enums: [] };
        let enumName = enumType.attributes.Name.value;
        enumT.name = enumName;
        let members = $(enumType).find('Member');
        $(members).each(function (memberIndex, member) {
            let memberName = member.attributes.Name.value;
            let memberValue = member.attributes.Value.value;
            enumT.enums.push({ name: memberName, value: memberValue });
        });
        odata.enumTypes.push(enumT);
    });

    if (printLog) {
        console.log(JSON.stringify(handsonTableAccessories));
        console.log(JSON.stringify(odata));
    };
    return { handsonTableAccessories: handsonTableAccessories, odata: odata };
};

// 根据解析后的OData Metadata元数据生成Entity配置数据
function generateEditorConfig(odataJson, printLog = true) {
    let configs = odataJson.odata.entityTypes;//JSON.parse(JSON.stringify(odata.entityTypes));
    $(configs).each(function (configIndex, config) {
        $(config.propertys).each(function (propertyIndex, property) {
            property.editor = 'input';
            if (['Edm.Decimal', 'Edm.Double', 'Edm.Int16', 'Edm.Int32', 'Edm.Int64', 'Edm.Single',].includes(property.dataType)) {
                property.editorType = 'number';
            }
            else if (property.dataType === 'Edm.Date') {
                property.editorType = 'date';
            }
            else if (property.dataType === 'Edm.DateTimeOffset') {
                property.editorType = 'datetime';
            }
            else if (property.dataType === 'Edm.Boolean') {
                property.editorType = 'checkbox';
            }
            else {
                let enumType = odataJson.odata.enumTypes.find(d => d.name === property.dataType.split('.')[1])
                if (enumType === undefined) {
                    property.editorType = 'text';
                }
                else {
                    property.editor = 'select';
                    property.enumValues = enumType.enums;
                }
            }
            if (config.keys.includes(property.name)) {
                property.readonly = true;
                property.required = false;
            }
            else {
                property.readonly = false;
            }
        });
    });

    if (printLog) {
        console.log(JSON.stringify(configs));
    };
    return configs;
};
