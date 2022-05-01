'use strict';

const odataServiceUri = `${location.origin}/odata`;

const odataWebApiOpenApiDocumentUri = `${location.origin}/swagger/odata/swagger.json`;
const webApiUri = `${location.origin}/api/configs`;

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