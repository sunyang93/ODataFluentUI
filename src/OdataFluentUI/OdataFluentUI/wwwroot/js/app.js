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
    let tips = '';
    switch (type) {
        case "success":
            tips='成功'
            break
        case "danger":
            tips = '失败'
            break;
        case "warning":
            tips = '提示'
            break;
        default:
            break;
    }
    toastLiveExample.getElementsByClassName("me-auto")[0].innerText = tips;
    toastLiveExample.getElementsByClassName("toast-body")[0].innerText = message;
    var toast = new bootstrap.Toast(toastLiveExample)
    toast.show()
}

// 获取查询字符串
function queryStrings() {
    let url = location.href;
    if (url.indexOf('?') != -1) {
        let obj = {};
        let arr = url.slice(url.indexOf('?') + 1).split('&');
        arr.forEach(item => {
            let param = item.split('=');
            obj[param[0]] = param[1];
        })
        console.log(obj);
        return obj;
    } else {
        console.log('没有参数');
        return null;
    }
}