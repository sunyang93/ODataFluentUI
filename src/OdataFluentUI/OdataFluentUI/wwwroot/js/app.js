'use strict';

const odataServiceUri = 'http://localhost:5201/odata';

const odataWebApiOpenApiDocumentUri = 'http://localhost:5201/swagger/odata/swagger.json';
const webApiUri = 'http://localhost:5201/api/configs';

const entityTypeConfigsUri = `${webApiUri}/entityTypeConfigs`;
const enumTypeConfigsUri = `${webApiUri}/enumTypeConfigs`;
const entitySetConfigsUri = `${webApiUri}/entitySetConfigs`;


// 通知
function alertNotic(message, type) {
    var wrapper = document.createElement('div')
    wrapper.innerHTML = '<div class="alert alert-' + type + ' mt-1 mb-1 alert-dismissible" role="alert">' + message + '<button type="button" class="btn-close" data-bs-dismiss="alert" aria-label="Close"></button></div>'

    document.getElementById('liveAlertPlaceholder').append(wrapper);
    if (type === "success") {
        setTimeout(function () {
            wrapper.innerHTML = '';
        }, 2000);
    }
}