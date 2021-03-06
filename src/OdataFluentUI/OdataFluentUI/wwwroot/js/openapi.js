'use strict';

function analysisOpenApiDocument(openApiDocument,jsonDoc) {
    for (let schema in openApiDocument.components.schemas) {
        let schemaValue = openApiDocument.components.schemas[schema];
        // EntityType
        let entityType = jsonDoc[0].entityTypes.find(d => d.name === schema);
        if (entityType != undefined) {
            let props = Object.keys(schemaValue.properties);
            entityType.displayName = schemaValue.description;
            for (let prop of entityType.properties) {
                var _prop = props.find(d => d.toUpperCase() === prop.name.toUpperCase())
                if (_prop != undefined) {
                    if (schemaValue.properties[_prop].hasOwnProperty('$ref')) {
                        let pathValues = schemaValue.properties[_prop]['$ref'].split('/');
                        let entityName = pathValues[pathValues.length - 1];
                        if (openApiDocument.components.schemas[entityName].hasOwnProperty('description')) {
                            prop.displayName = openApiDocument.components.schemas[entityName].description;
                        }
                    } else {
                        if (schemaValue.properties[_prop].hasOwnProperty('description')) {
                            prop.displayName = schemaValue.properties[_prop].description;
                        }
                    }
                }
            }
        }
        // EnumType
        let enumType = jsonDoc[0].enumTypes.find(d => d.name === schema);
        if (enumType != undefined) {
            enumType.displayName = schemaValue.description;
        }
        // EntitySet
        let entitySet = jsonDoc[0].entityContainer.entitySets.find(d => d.entityType.split('.')[1] === schema);
        if (entitySet != undefined) {
            let props = Object.keys(schemaValue.properties);
            entitySet.displayName = schemaValue.description;
            for (let prop of entitySet.properties) {
                var _prop = props.find(d => d.toUpperCase() === prop.name.toUpperCase())
                if (_prop != undefined) {
                    if (schemaValue.properties[_prop].hasOwnProperty('$ref')) {
                        let pathValues = schemaValue.properties[_prop]['$ref'].split('/');
                        let entityName = pathValues[pathValues.length - 1];
                        if (openApiDocument.components.schemas[entityName].hasOwnProperty('description')) {
                            prop.displayName = openApiDocument.components.schemas[entityName].description;
                        }
                    } else {
                        if (schemaValue.properties[_prop].hasOwnProperty('description')) {
                            prop.displayName = schemaValue.properties[_prop].description;
                        }
                    }
                }
            }
        }
    }
    console.log(openApiDocument);  
}