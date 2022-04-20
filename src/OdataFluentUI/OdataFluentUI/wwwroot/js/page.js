'use strict';

const entityVm = new Vue({
    el: '#tableDiv',
    data: {
        schemaNamespaces: [],
        entityTypes: [],
        currentEntityType: {},
        currentEntitySet: [],
        handsontable: {
            colHeaders: [],
            columns:[],
        },
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
    data: [],
    language: 'zh-CN',
    height: 'auto',
    width: 'auto',
    className: 'htLeft htMiddle',
    colHeaders: entityVm._data.handsontable.colHeaders,
    dropdownMenu: true,
    fixedColumnsLeft: 1,
    columns: entityVm._data.handsontable.columns,
    contextMenu: true,
    multiColumnSorting: true,
    filters: true,
    rowHeaders: true,
    manualRowMove: true,
    manualRowResize: true,
    manualColumnMove: true,
    manualColumnResize: true,
    licenseKey: "non-commercial-and-evaluation"
});

// 列排序事件
hot.addHook('afterColumnSort', function (currentSortConfig, destinationSortConfigs) {
    console.log(currentSortConfig);
    console.log(destinationSortConfigs);
    let currentOrderByOptions = document.getElementById('orderByOptions').value;  
    if (currentOrderByOptions !== '') {
        let orderByOptions = currentOrderByOptions.split(',');
        for (let option of orderByOptions) {
            if (currentSortConfig.length > 0) {
                let propertyName = entityVm.currentEntityType.propertys[currentSortConfig[0].column].name;
                let orderByOption = `${propertyName} ${currentSortConfig[0].sortOrder}`;
                if (option.toLowerCase() === orderByOption.toLowerCase()) {
                    orderByOptions.splice(orderByOptions.indexOf(option), 1);
                }
            }
            if (destinationSortConfigs.length > 0) {
                let propertyName = entityVm.currentEntityType.propertys[destinationSortConfigs[0].column].name;
                let orderByOption = `${propertyName} ${destinationSortConfigs[0].sortOrder}`;
                orderByOptions.push(orderByOption);
            }
        }
        document.getElementById('orderByOptions').value = orderByOptions.join(',');
    }
    else {
        let propertyName = entityVm.currentEntityType.propertys[destinationSortConfigs[0].column].name;
        let orderByOption = `${propertyName} ${destinationSortConfigs[0].sortOrder}`;
        document.getElementById('orderByOptions').value = orderByOption;
    }
    queryEntityDataset();
});

// 列移动事件
hot.addHook("afterColumnMove", function (movedColumns, finalIndex, dropIndex, movePossible, orderChanged) {
    console.log(movedColumns);
    console.log(finalIndex);
    console.log(dropIndex);
    console.log(movePossible);
    console.log(orderChanged);
    if (orderChanged) {
        let duplicatedEntityPropertys = entityVm._data.currentEntityType.propertys.slice();       
    }
});


// 列筛选事件
hot.addHook('afterFilter', function (conditionsStack) {
    console.log(conditionsStack);
    let filterOptions = [];

    for (let conditionStack of conditionsStack) {        
        let property = entityVm.currentEntityType.propertys[conditionStack.column];
        let propertyName = property.name;
        let propertyEditorType = property.editorType;
        for (let condition of conditionStack.conditions) {
            switch (condition.name) {
                case 'begins_with': // startsWith
                    filterOptions.push(`startsWith(${propertyName},'${condition.args[0].toString()}')`);
                    break;
                case 'between':
                    filterOptions.push(`${propertyName} ge ${condition.args[0].toString()} and ${propertyName} le ${condition.args[1].toString()}`);
                    break;
                case 'by_value':// in
                    let values = '';
                    if (propertyEditorType === 'number')
                        values = condition.args[0].join(',');
                    else {
                        let _args = [];
                        for (let arg of condition.args[0]) {
                            _args.push(`\'${arg}\'`);
                        }
                        values = _args.join(',');
                    }
                    filterOptions.push(`${propertyName} in (${values})`);
                    break;
                case 'contains':
                    filterOptions.push(`contains(${propertyName},'${condition.args[0].toString()}')`);
                    break;
                case 'empty': // eq null
                    filterOptions.push(`${propertyName} eq null`);
                    break;
                case 'ends_with': // endsWith
                    filterOptions.push(`endsWith(${propertyName},'${condition.args[0].toString()}')`);
                    break;
                case 'eq':
                    if (propertyEditorType === 'number')
                        filterOptions.push(`${propertyName} eq ${condition.args[0].toString()}`);
                    else
                        filterOptions.push(`${propertyName} eq '${condition.args[0].toString()}'`);
                    break;
                case 'gt':
                    filterOptions.push(`${propertyName} gt ${condition.args[0].toString()}`);
                    break;
                case 'gte': // ge
                    filterOptions.push(`${propertyName} ge ${condition.args[0].toString()}`);
                    break;
                case 'lt':
                    filterOptions.push(`${propertyName} lt ${condition.args[0].toString()}`);
                    break;
                case 'lte': // le
                    filterOptions.push(`${propertyName} le ${condition.args[0].toString()}`);
                    break;
                case 'none':
                    break;
                case 'not_between':
                    break;
                case 'not_contains':
                    filterOptions.push(`not contains(${propertyName},'${condition.args[0].toString()}')`);
                    break;
                case 'not_empty':// ne null
                    filterOptions.push(`${propertyName} ne null`);
                    break;
                case 'neq': // ne
                    if (propertyEditorType === 'number')
                        filterOptions.push(`${propertyName} ne ${condition.args[0].toString()}`);
                    else
                        filterOptions.push(`${propertyName} ne '${condition.args[0].toString()}'`);
                    break;
                default:
                    break;
            }
        }        
    }
    document.getElementById('filterOptions').value = filterOptions.join(' and ');
    queryEntityDataset();
});

(function () {
    searchOdata();
})();

// 移除只读属性
function removeReadonlyProp(e) {
    let readonlyProp = e.parentElement.firstChild.value;
    entityVm._data.readonlyProps.splice(entityVm._data.readonlyProps.indexOf(readonlyProp), 1);
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
function queryOdataMetadata() {
    entityVm._data.entityTypes = [];
    entityVm._data.currentEntityType = {};
    entityVm._data.currentEntitySet = [];

    let uri = `${document.getElementById('odataUri').value}/$metadata`;
    let request = new Request(uri, {
        method: "GET"
    });
    fetch(request)
        .then(response => response.text())
        .then(data => {
            metadata._xml = (new DOMParser()).parseFromString(data, 'text/xml');
            metadata._json = mapperOdataMetadata(metadata._xml);
            generateEditorConfig(metadata._json);
            for (let schema of metadata._json) {
                entityVm._data.schemaNamespaces.push(schema.name);
            }
            entityVm._data.entityTypes = metadata._json[0].entityTypes;

            toastNotice('查询OdataWebApi元数据成功');
        })
        .catch((error) => {
            console.error('Error:', error);
            alert("Something went wrong");
        });
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
    ResetQueryOptions();
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
            // handsontable
            entityVm._data.handsontable.colHeaders = [];
            columns: entityVm._data.handsontable.columns = [];
            for (let prop of entityVm._data.currentEntityType.propertys) {
                entityVm._data.handsontable.colHeaders.push(`${prop.displayName}[${prop.name}]`);
                let column = { data: prop.name, filteringCaseSensitive: true};
                if (['Edm.Decimal', 'Edm.Double', 'Edm.Int16', 'Edm.Int32', 'Edm.Int64', 'Edm.Single',].includes(prop.dataType)) {
                    column.type = 'numeric';
                }
                else if (prop.dataType === 'Edm.Date') {
                    column.type = 'date';
                    column.dateFormat = 'YYYY-MM-DD';
                }
                else if (prop.dataType === 'Edm.DateTimeOffset') {
                    column.type = 'time';
                }
                else if (prop.dataType === 'Edm.Boolean') {
                    column.type = 'checkbox';
                }
                else {
                    let enumType = metadata._json.find(d => d.name === document.getElementById('schemas').value).enumTypes.find(d => d.name === prop.name);
                    if (enumType != undefined) {
                        column.type = 'dropdown';
                        column.source = [];
                        enumType.enums.forEach(function (enumItem) {
                            column.source.push(enumItem.name);
                        })
                    } else {
                        column.type = 'text';
                    }
                }
                entityVm._data.handsontable.columns.push(column);
            }
            hot.updateSettings({
                colHeaders: entityVm._data.handsontable.colHeaders,
                columns: entityVm._data.handsontable.columns
            });
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
            // handsontable
            hot.updateData(entityVm._data.currentEntitySet);
        },
        function (err) {
            alert("Something went wrong");
        }
    );
};

// 重置查询选项
function ResetQueryOptions() {
    document.getElementById("pageOptions").value = 1;
    document.getElementById("skipOptions").value = 0;
    document.getElementById('orderByOptions').value = '';
    document.getElementById('filterOptions').value = '';
    document.getElementById('selectOptions').value = '';
}

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
                prop[propId] = Number.parseFloat(propValue);
            }
            else if (['Edm.Int16', 'Edm.Int32', 'Edm.Int64', 'Edm.Single'].includes(entityVm._data.currentEntityType.propertys.find(d => d.name === propId).dataType)) {
                prop[propId] = Number.parseInt(propValue);
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
function searchOpenApi() {
    let uri = document.getElementById('openApiUri').value;
    let request = new Request(uri, {
        method: "GET"
    });
    fetch(request)
        .then(response => response.json())
        .then(data => {
            analysisOpenApiDocument(data);
            toastNotice('查询OpenApiDocument成功');
        })
        .catch((error) => {
            console.error('Error:', error);
            alert("Something went wrong");
        });
};


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
