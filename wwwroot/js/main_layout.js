var myInstanceObject;
var audio;

function phatNhacChuong() {
    audio = document.getElementById("audioPlayer");
    audio.play();
}

function moCuaSoGoiDien(callerId, callerName, callerAvt, receiverId, receiverName, receiverAvt, typeCall, conversationType, instanceObject) {

    myInstanceObject = instanceObject;

    const top = (screen.height - 1280) / 2;
    const left = (screen.width - 720) / 2;

    // Cửa sổ con
    const roomId = callerId + "." + receiverId;
    var urlToOpen = `https://localhost:7154/groupCall/${roomId}/${callerName}/${callerAvt}/${typeCall}/${conversationType}/${receiverName}/${receiverAvt}`;
    window.open(urlToOpen, "_blank", "left = " + left + ", top = " + top + ", width=1280, height=720");

    // Đăng ký sự kiện nhận thông điệp từ cửa sổ con
    window.addEventListener('message', receiveMessageFromGroupCall, false);

}

function joinRoomGoiDien(roomId, callerName, callerAvt, typeCall, instanceObject) {

    myInstanceObject = instanceObject;

    const top = (screen.height - 1280) / 2;
    const left = (screen.width - 720) / 2;

    var urlToOpen = `https://localhost:7154/groupCall/${roomId}/${callerName}/${callerAvt}/${typeCall}`;
    window.open(urlToOpen, "_blank", "left = " + left + ", top = " + top + ", width=1280, height=720");

    window.addEventListener('message', receiveMessageFromGroupCall, false);
}


function receiveMessageFromGroupCall(event) {

    if (event.data == 'tatNhacChuong') {
        if (audio != undefined) {
            console.log("Tắt nhạc chuông");

            /*
            Trường hợp này là của người nhận cuộc gọi,
            Mà người nhận cuộc gọi đâu có phát nhạc chuông :v
            */
            audio.pause();
        }
    }

    // Kiểm tra xem thông điệp có phải là từ cửa sổ con đã đóng hay không
    if (event.data == 'childWindowCancle') {

        console.log("Đã kết thúc cuộc gọi");
        console.log("Thiết lập trạng thái isIdle = true");

        myInstanceObject.invokeMethodAsync("setIdleToTrue")

        // Gỡ Đăng ký sự kiện nhận thông điệp từ cửa sổ con
        window.removeEventListener('message', receiveMessageFromGroupCall, false);
    }
}