const APP_ID = "c5ba0d5021ca49a4989abd70a2bc0ea9";
const TOKEN = "007eJxTYPC27d+qPYex4/y7B8udwu/wOZguT749V36Wn1aw5JzJjW8VGJJNkxINUkwNjAyTE00sgcjCMjEpxdwg0Sgp2SA10XLt56WpDYGMDN+Co5kYGSAQxGdhyE3MzGNgAABONiAy";
// Token expires on December 5, 2023 9:21 AM UTC

const CHANNEL = "main";

const client = AgoraRTC.createClient({ mode: 'rtc', codec: 'vp8' });

let localTracks = []
/*
localTracks[0] is audio (voice),
localTracks[1] is video,
*/

async function joinAndDisplayLocalStream(uid, typeCall, instanceObject) {

    client.on('user-left', (user) => {
        console.log(user.uid + " has left the chanel");
    });

    /* 
    Cực kỳ ảo:
    Phải lắng nghe sự kiện "user-published" trước khi mình publish *local track*
    thì cả 2 mới có thể nghe được audio của nhau :)
    */
    client.on('user-published', handleUserPublished);

    await client.join(APP_ID, CHANNEL, TOKEN, uid);

    if (typeCall == "voice") {
        localTracks.push(await AgoraRTC.createMicrophoneAudioTrack());
        /*
        Phân biệt:
        - MicrophoneAudioTrack: là theo dõi âm thanh từ mic
        - AudioTrack: là âm thanh phát ra từ máy tính
        */
        await client.publish(localTracks[0])
    }

    if (typeCall == "video") {
        // Lấy cả Mic Audio và Camera Video Track
        localTracks = await AgoraRTC.createMicrophoneAndCameraTracks();

        // Display local video
        localTracks[1].play(`my-frame`);

        // Publish localTracks to Channel
        await client.publish([localTracks[0], localTracks[1]]);
    }

    instanceObject.invokeMethodAsync("setIsProcessingToFalse");
}

async function handleUserPublished(user, mediaType) {

    await client.subscribe(user, mediaType)

    if (mediaType == 'video') {
        user.videoTrack.play(`peer-${user.uid}`)
        // document.getElementById(`peerInfo-${user.uid}`).style = "z-index: 0";
    }

    if (mediaType == 'audio') {
        user.audioTrack.play();
    }
}

async function toggleMic() {
    if (localTracks[0].muted) {
        await localTracks[0].setMuted(false);
    } else {
        await localTracks[0].setMuted(true);
    }
}

async function toggleVideo() {
    // Kiểm tra xem đã có có video track chưa
    if (localTracks.length == 1) {
        /*
        Chưa có video track
        tức là video-btn đang turn off
        => Thêm video track, play video & kết thúc
        */
        localTracks.push(await AgoraRTC.createCameraVideoTrack());
        localTracks[1].play(`my-frame`);
        await client.publish([localTracks[1]]);
        return;
    }

    console.log("localTracks[1].muted: " + localTracks[1].muted);

    if (localTracks[1].muted) {
        await localTracks[1].setMuted(false);
    } else {
        await localTracks[1].setMuted(true);
    }
}

async function leaveAndRemoveLocalStream() {
    console.log("leaveAndRemoveLocalStream");
    for (let i = 0; i < localTracks.length; ++i) {
        localTracks[i].stop();
        localTracks[i].close();
    }

    await client.leave();
}