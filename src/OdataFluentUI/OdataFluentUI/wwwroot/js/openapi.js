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