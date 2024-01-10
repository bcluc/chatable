function scrollMessagesListToBottom(behavior) {
    console.log("Call Cuon");
    var messagesList = document.querySelector('.messages-list');
    // messagesList.scrollTop = messagesList.scrollHeight;
    messagesList.scrollTo({ top: messagesList.scrollHeight, left: 0, behavior: behavior });
}

function triggerFileDownload(fileName, url) {
    const anchorElement = document.createElement('a');
    anchorElement.href = url;
    anchorElement.download = fileName ?? '';
    anchorElement.click();
    anchorElement.remove();
}

function downloadFile(fileName, fileUrl) {
    // T?o ??i t??ng XMLHttpRequest
    var xhr = new XMLHttpRequest();
    xhr.open('GET', fileUrl, true);
    xhr.responseType = 'blob'; // ??t ki?u d? li?u tr? v? là blob (binary data)

    xhr.onload = function () {
        // T?o m?t ???ng d?n ?nh t?m th?i ?? t?i v?
        var urlCreator = window.URL || window.webkitURL;
        var imageUrl = urlCreator.createObjectURL(this.response);

        // T?o m?t th? a ?? t?o và kích th??c t?i v?
        var link = document.createElement('a');
        link.href = imageUrl;
        link.download = fileName;
        document.body.appendChild(link);

        // Kích th??c và ch?y s? ki?n click t? ??ng
        link.click();

        // Lo?i b? th? a sau khi ?ã s? d?ng
        document.body.removeChild(link);
    };

    // G?i yêu c?u
    xhr.send();
}
