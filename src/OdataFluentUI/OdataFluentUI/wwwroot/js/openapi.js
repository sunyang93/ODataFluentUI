'use strict';

function analysisOpenApiDocument(openApiDocument,jsonDoc) {
    for (let schema in openApiDocument.components.schemas) {
        let schemaValue = openApiDocument.components.schemas[schema];
        let entityType = jsonDoc[0].entityTypes.find(d => d.name === schema);
        if (entityType != undefined) {
            var props = Object.keys(schemaValue.properties);
            entityType.displayName = schemaValue.description;
            for (let prop of entityType.properties) {
                var _prop = props.find(d => d.toUpperCase() === prop.name.toUpperCase())
                if (_prop != undefined) {
                    if (schemaValue.properties[_prop].hasOwnProperty('$ref')) {
                        let pathValues = schemaValue.properties[_prop]['$ref'].split('/');
                        let entityName = pathValues[pathValues.length - 1];
                        prop.displayName = openApiDocument.components.schemas[entityName].description;
                    } else {
                        prop.displayName = schemaValue.properties[_prop].description;
                    }
                }
            }
        }
    }
    console.log(openApiDocument);  
}