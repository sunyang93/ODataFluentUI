// 解析OData Metadata元数据 XML->JSON
function mapperOdataMetadata(odataXml, printLog = true) {
    let odataXmlDocument = odataXml;
    let odataSchemas = [];
    // Schema
    let schemas = odataXmlDocument.getElementsByTagName('Schema');
    for (let schema of schemas) {
        let odataSchema = { name: schema.attributes.Namespace.value,entityTypes: [], enumTypes: []};
        let entityTypes = schema.getElementsByTagName('EntityType');
        let enumTypes = schema.getElementsByTagName('EnumType');
        // EnumType 
        for (let enumType of enumTypes) {
            let enumT = { enums: [] };
            let enumName = enumType.attributes.Name.value;
            enumT.name = enumName;
            let members = enumType.getElementsByTagName('Member');
            for (let member of members) {
                let memberName = member.attributes.Name.value;
                let memberValue = member.attributes.Value.value;
                enumT.enums.push({ name: memberName, value: memberValue });
            };
            odataSchema.enumTypes.push(enumT);
        };
        // EntityType 
        for (let entityType of entityTypes) {
            let entityT = { propertys: [] };
            let entityName = entityType.attributes.Name.value;
            entityT.name = entityName;
            let Propertys = entityType.getElementsByTagName('Property');
            for (let _property of Propertys) {
                let keyEle = entityType.getElementsByTagName('Key');
                if (keyEle.length > 0) {
                    let key = keyEle[0];
                    let propertyRefs = key.getElementsByTagName('PropertyRef');
                    let keyRefs = [];
                    for (let propertyRef of propertyRefs) {
                        let keyName = propertyRef.attributes.Name.value;
                        keyRefs.push(keyName);
                    };
                    entityT.keys = keyRefs;
                }
                let property = {};
                let propertyAttributeName = _property.attributes.Name.value;
                property.name = propertyAttributeName;
                let propertyAttributeType = _property.attributes.Type.value;
                property.dataType = propertyAttributeType;
                if (_property.attributes.hasOwnProperty('Nullable')) {
                    let propertyAttributeNullable = _property.attributes.Nullable.value;
                    property.required = propertyAttributeNullable === "false" ? true : false;
                }
                else {
                    property.required = false;
                }
                if (_property.attributes.hasOwnProperty('DefaultValue')) {
                    let propertyAttributeDefaultValue = _property.attributes.DefaultValue.value;
                    property.defaultValue = propertyAttributeDefaultValue;
                }
                if (_property.attributes.hasOwnProperty('MaxLength')) {
                    let propertyAttributeMaxLength = _property.attributes.MaxLength.value;
                    property.maxLength = propertyAttributeMaxLength;
                }
                entityT.propertys.push(property);
            };
            let navigationPropertys = entityType.getElementsByTagName('NavigationProperty');
            if (navigationPropertys.length > 0) {
                entityT.navigationProperty = [];                
                for (let navigationProperty of navigationPropertys) {                    
                    let odataNavigationProperty = { name: navigationProperty.attributes.Name.value, type: navigationProperty.attributes.Type.value };
                    let referentialConstraints = navigationProperty.getElementsByTagName('ReferentialConstraint');
                    if (referentialConstraints.length > 0) {
                        entityT.pkeys = [];
                        let referentialConstraint = referentialConstraints[0];
                        odataNavigationProperty.referentialConstraint = {
                            property: referentialConstraint.attributes.Property.value,
                            referencedProperty: referentialConstraint.attributes.ReferencedProperty.value
                        };
                        entityT.pkeys.push(odataNavigationProperty.referentialConstraint.property);
                    }
                    entityT.navigationProperty.push(odataNavigationProperty);
                }
            }
            odataSchema.entityTypes.push(entityT);
        };
        // EntityContainer 
        let containers = schema.getElementsByTagName('EntityContainer');
        if (containers.length > 0) {
            // EntitySet
            let container = containers[0];
            let odataContainer = { name: container.attributes.Name.value, entitySets: [] };
            let containerEntitySets = container.getElementsByTagName('EntitySet');
            for (let containerEntitySet of containerEntitySets) {
                let entitySet = {
                    name: containerEntitySet.attributes.Name.value,
                    entityType: containerEntitySet.attributes.EntityType.value
                };
                let navigationPropertyBindings = containerEntitySet.getElementsByTagName('NavigationPropertyBinding');
                if (navigationPropertyBindings.length > 0) {
                    entitySet.navigationPropertyBindings = [];
                    for (let navigationPropertyBinding of navigationPropertyBindings) {
                        let odataNavigationPropertyBinding = { path: navigationPropertyBinding.attributes.Path.value, target: navigationPropertyBinding.attributes.Target.value };
                        entitySet.navigationPropertyBindings.push(odataNavigationPropertyBinding);
                    }
                }
                odataContainer.entitySets.push(entitySet);
            }
            odataSchema.entityContainer = odataContainer;
        }
        odataSchemas.push(odataSchema);
    }
    if (printLog) {
        console.log(odataSchemas);
    };
    return odataSchemas;
};

