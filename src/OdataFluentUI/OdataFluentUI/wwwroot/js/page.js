'use strict';

let entityVm = new Vue({
    el: '#tableDiv',
    data: {
        schemaNamespaces: [],
        entityTypes: [],
        currentEntityType: {},
        currentEntitySet: [],
        readonlyProps: ['CreateTime', 'UpdateTime'] // Entity只读属性设置
    }
});

// OData Metadata元数据
let metadata = { _xml: null, _json: null };

// ODataApi地址
const defaultOdataApiUrl = 'http://localhost:5201/odata';
document.getElementById('odataUri').value = defaultOdataApiUrl;
const defaultOdataApiMetadataUrl = `${defaultOdataApiUrl}/$metadata`;
document.getElementById('odataMetadataXML').setAttribute('href', defaultOdataApiMetadataUrl);
document.getElementById('odataMetadataJSON').setAttribute('href', `${defaultOdataApiMetadataUrl}?$format=json`);

// handsontable
let container = document.querySelector('#handsontableContainer');
let hot = new Handsontable(container, {
    data: [{ a: 1, b: 2, c: 3,d:4 }],
    language: 'zh-CN',
    height: 'auto',
    width: 'auto',
    manualRowResize: true,
    className: 'htLeft htMiddle',
    colHeaders: ['a','b','c'],
    dropdownMenu: true,
    hiddenColumns: {
        indicators: true
    },
    fixedColumnsLeft: 1,
    search: true,
    columns: ['a', 'b', 'c'],
    contextMenu: true,
    multiColumnSorting: true,
    filters: true,
    rowHeaders: true,
    manualRowMove: true,
    manualColumnMove: true,
    manualColumnResize: true,
    licenseKey: "non-commercial-and-evaluation"
});

(function () {
    searchOdata();
})();

// 移除只读属性
function removeReadonlyProp(e) {
    let readonlyProp = e.parentElement.firstChild.value;
    entityVm._data.readonlyProps.splice(entityVm._data.readonlyProps.indexOf(readonlyProp), 1)
}

// 添加只读属性
function addReadonlyProp() {
    entityVm._data.readonlyProps.push('');
}

// 重置只读属性
function resetReadonlyProps() {
    entityVm._data.readonlyProps = ['CreateTime', 'UpdateTime'];
}

// 查询OData
function searchOdata() {
    queryOdataMetadata();
};

// 查询OData Metadata元数据
async function queryOdataMetadata() {
    let uri = `${document.getElementById('odataUri').value}/$metadata`;
    let request = new Request(uri, {
        method: "GET"
    });
    let result = await fetch(request);
    if (result.ok) {
        entityVm._data.entityTypes = [];
        entityVm._data.currentEntityType = {};
        entityVm._data.currentEntitySet = [];
        var data = await result.text();
        metadata._xml = (new DOMParser()).parseFromString(data, 'text/xml');
        metadata._json = mapperOdataMetadata(metadata._xml);
        generateEditorConfig(metadata._json);
        for (let schema of metadata._json) {
            entityVm._data.schemaNamespaces.push(schema.name);
        }
        entityVm._data.entityTypes = metadata._json[0].entityTypes;

        toastNotice('查询OdataWebApi元数据成功');
    }
    else {
        alert("Something went wrong");
    }
};

// Toast通知
function toastNotice(toastText) {
    document.getElementsByClassName('toast-body')[0].innerHTML = toastText;
    let toastLiveExample = document.getElementById('liveToast');
    let toast = new bootstrap.Toast(toastLiveExample)
    toast.show();
};

// EntityType下拉列表改变事件
function onEntityTypeChange(e) {
    let entityName = e.value;
    if (entityName !== '') {
        let namespace = document.getElementById('schemas').value;
        let entitySetName = metadata._json.find(d => d.name === namespace).entityContainer.entitySets.find(d => d.entityType === `${namespace}.${entityName}`).name;
        document.getElementById('odataEntityUri').value = `${document.getElementById('odataUri').value}/${entitySetName}`;
        let entityType = entityVm._data.entityTypes.find(d => d.name === entityName);
        if (entityType == undefined) {
            entityVm._data.currentEntityType = {};
        }
        else {
            entityVm._data.currentEntityType = entityType;
        }
        queryEntityDataset();
    }
    else {
        document.getElementById('odataEntityUri').value = '';
        entityVm._data.currentEntityType = {};
        entityVm._data.currentEntitySet = [];
    }
};

// SchemaNamespace下拉列表改变事件
function onSchemaNamespaceChange(e) {
    let schemaNamespaceName = e.value;
    let schemaNamespace = metadata.find(d => d.name === schemaNamespaceName);
    if (schemaNamespace == undefined) {

    }
    else {
        entityVm._data.entityTypes = schemaNamespace.entityTypes;
    }
}

// Entity Dataset查询
function queryEntityDataset() {
    let url = document.getElementById("odataEntityUri").value;
    let top = document.getElementById("topOptions").value;
    let page = Number.parseInt(document.getElementById("pageOptions").value);
    let skip = (page - 1) * top;
    document.getElementById("skipOptions").value = skip;
    let uri = `${url}?$count=true&$top=${top}&$skip=${skip}`;
    let orderBy = document.getElementById('orderByOptions').value.trim();
    if (orderBy !== '') {
        uri += `&$orderby=${orderBy}`;
    }
    let filter = document.getElementById('filterOptions').value.trim();
    if (filter !== '') {
        uri += `&$filter=${filter}`;
    }
    let select = document.getElementById('selectOptions').value.trim();
    if (select !== '') {
        uri += `&$select=${select}`;
    }
    document.getElementById('queryUrl').value = uri;
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

// 当前正在编辑Entity
let editEntity = {
    uri: '',
    original: {} // 原始值
};

// 显示 新建/编辑数据Modal
function showEntityDataModal(isEdit = false) {
    editEntity.uri = '';
    editEntity.original = {};
    if (isEdit) {
        let doms = document.getElementsByClassName('entity-old');
        let entityUri = '';
        for (let dom of doms) {
            if (dom.checked) {
                entityUri = dom.value;
                break;
            }
        }
        editEntity.uri = entityUri;
        if (entityUri === '') {
            alert('请选择需要编辑的数据');
            return;
        } else {
            queryEntityData(entityUri);
        }
    }
    let doms = document.getElementsByClassName('add-new-edit-old');
    for (let dom of doms) {
        if (dom.type === 'checkbox') {
            dom.checked = false;
        } else if (dom.type === 'select-one') {

        } else {
            dom.value = '';
        }
    }
    let myModal = new bootstrap.Modal(document.getElementById('staticBackdrop'));
    myModal.show();
}

// 查询Entity数据
function queryEntityData(entityUri) {
    let request = {
        requestUri: entityUri,
        method: "GET",
        headers: { Accept: "application/json;odata.metadata=full;odata.streaming=true", }
    };
    odatajs.oData.request(
        request,
        function (data, response) {
            let doms = document.getElementsByClassName('add-new-edit-old');
            let entity = {};
            for (let dom of doms) {
                let propId = dom.id;
                let propValue = data[propId];
                dom.value = propValue;
                if (dom.type === 'checkbox') {
                    dom.checked = propValue;
                }
                let canPostProp = entityVm._data.currentEntityType.propertys.find(d => d.name == propId && !d.readonly);
                if (canPostProp !== undefined) {
                    let prop = {};
                    prop[propId] = propValue;
                    entity = { ...entity, ...prop };
                }
            }
            editEntity.original = entity;
        },
        function (err) {
            alert("Something went wrong");
        }
    );
}

// 新建/编辑Entity数据
function addNewOrEditOldData() {
    let doms = document.getElementsByClassName('add-new-edit-old');
    let newEntity = {};
    for (let dom of doms) {
        let propId = dom.id;
        let propValue = dom.value;
        if (dom.type === 'checkbox') {
            propValue = dom.checked;
        }
        let canPostProp = entityVm._data.currentEntityType.propertys.find(d => d.name == propId && !d.readonly);
        if (canPostProp !== undefined) {
            let prop = {};
            if (['Edm.Decimal', 'Edm.Double'].includes(entityVm._data.currentEntityType.propertys.find(d => d.name === propId).dataType)) {
                prop[propId] = parseFloat(propValue);
            }
            else if (['Edm.Int16', 'Edm.Int32', 'Edm.Int64', 'Edm.Single'].includes(entityVm._data.currentEntityType.propertys.find(d => d.name === propId).dataType)) {
                prop[propId] = parseInt(propValue);
            }
            else {
                prop[propId] = propValue;
            }
            newEntity = { ...newEntity, ...prop };
        }
    }
    if (editEntity.uri === '') {
        let url = document.getElementById("odataEntityUri").value;
        let request = {
            requestUri: url,
            method: "POST",
            headers: { Accept: "application/json;odata.metadata=full;odata.streaming=true", "Content-Type": "application/json" },
            data: newEntity
        };
        odatajs.oData.request(
            request,
            function (data, response) {
                toastNotice('新建数据成功');
                queryEntityDataset();
            },
            function (err) {
                alert("Something went wrong.");
            }
        );
    } else {
        let isChanged = false;
        let changedEntity = {};
        for (let key in newEntity) {
            if (newEntity[key] !== editEntity.original[key]) {
                let prop = {};
                prop[key] = newEntity[key];
                changedEntity = { ...changedEntity, ...prop };
                isChanged = true;
            }
        }
        if (!isChanged) {
            alert('未检测到任何修改，无需保存');
            return;
        }
        let request = {
            requestUri: editEntity.uri,
            method: "PATCH",
            headers: { Accept: "application/json;odata.metadata=full;odata.streaming=true", "Content-Type": "application/json" },
            data: changedEntity
        };
        odatajs.oData.request(
            request,
            function (data, response) {
                toastNotice('编辑数据成功');
                queryEntityDataset();
            },
            function (err) {
                alert("Something went wrong.");
            }
        );
    }
};

// 删除Entity数据
function deleteEntityData() {
    let doms = document.getElementsByClassName('entity-old');
    let entityUri = '';
    for (let dom of doms) {
        if (dom.checked) {
            entityUri = dom.value;
            break;
        }
    }
    if (entityUri === '') {
        alert('请选择需要删除的数据');
        return;
    }
    if (confirm('确定要删除该条数据么？')) {
        let request = {
            requestUri: entityUri,
            method: "DELETE",
            headers: { Accept: "application/json;odata.metadata=full;odata.streaming=true" }
        };
        odatajs.oData.request(
            request,
            function (data, response) {
                toastNotice('删除数据成功');
                queryEntityDataset();
            },
            function (err) {
                alert("Something went wrong.");
            }
        );
    }
};

// 选择全部
function checkAll(e) {
    let doms = document.getElementsByClassName('entity-old');
    for (let dom of doms) {
        dom.checked = e.checked;
    }
};

// 获取OpenApiDocument JSON文档
async function searchOpenApi() {
    let uri = document.getElementById('openApiUri').value;
    let request = new Request(uri, {
        method: "GET"
    });
    let result = await fetch(request);
    if (result.ok) {
        var data = await result.json();
        analysisOpenApiDocument(data);
        toastNotice('查询OpenApiDocument成功');
    }
    else {
        alert("Something went wrong");
    }
}


// 根据解析后的OData Metadata元数据生成Entity配置数据
function generateEditorConfig(odataSchemas, printLog = true) {
    for (let odataSchema of odataSchemas) {
        let configs = odataSchema.entityTypes;
        for (let config of configs) {
            config.displayName = config.name;
            config.remark = '';
            for (let property of config.propertys) {
                property.displayName = property.name;
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
                    let enumType = odataSchema.enumTypes.find(d => d.name === property.dataType.split('.')[1])
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
                else if (entityVm._data.readonlyProps.includes(property.name)) {
                    property.readonly = true;
                    property.required = false;
                }
                else {
                    property.readonly = false;
                }
                property.remark = '';
            };
        };
    }
    if (printLog) {
        console.log(odataSchemas);
    };
};
