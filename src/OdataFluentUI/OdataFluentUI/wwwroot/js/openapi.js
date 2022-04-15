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

function analysisOpenApiDocument(openApiDocument, printLog = true) {
    for (let schema in openApiDocument.components.schemas) {
        let schemaValue = openApiDocument.components.schemas[schema];
        let entityType = entityVm._data.entityTypes.find(d => d.name === schema);
        if (entityType != undefined) {
            var props = Object.keys(schemaValue.properties);
            entityType.displayName = schemaValue.description;
            for (let prop of entityType.propertys) {
                var _prop = props.find(d => d.toUpperCase() === prop.name.toUpperCase())
                if (_prop != undefined) {
                    prop.displayName = schemaValue.properties[_prop].description;
                }
            }
        }
    }
    if (printLog) {
        console.log(openApiDocument);
    }
}