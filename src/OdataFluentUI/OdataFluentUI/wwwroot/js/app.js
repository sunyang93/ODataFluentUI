'use strict';

const odataServiceUri = 'http://localhost:5201/odata';

const odataWebApiOpenApiDocumentUri = 'http://localhost:5201/swagger/odata/swagger.json';
const webApiUri = 'http://localhost:5201/api/configs';

const entityTypeConfigsUri = `${webApiUri}/entityTypeConfigs`;
const enumTypeConfigsUri = `${webApiUri}/enumTypeConfigs`;
const entitySetConfigsUri = `${webApiUri}/entitySetConfigs`;

var toastLiveExample = document.getElementById('liveToast');
// 通知
function alertNotic(message, type) {
    toastLiveExample.getElementsByClassName("me-auto")[0].innerText = type;
    toastLiveExample.getElementsByClassName("toast-body")[0].innerText = message;
    var toast = new bootstrap.Toast(toastLiveExample)
    toast.show()
}