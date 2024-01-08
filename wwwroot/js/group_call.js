function tatNhacChuong() {
    console.log('tatNhacChuong');
    window.opener.postMessage('tatNhacChuong', '*');
}

function thietLapKhiDongCuocGoi() {
    console.log("thietLapKhiDongCuocGoi()");
    onbeforeunload = function () {
         // console.log("finishCall");
        tatNhacChuong();
        finishCall();
    }
}

function finishCall() {
    console.log("finishCall");
    window.opener.postMessage('childWindowCancle', '*');
}
