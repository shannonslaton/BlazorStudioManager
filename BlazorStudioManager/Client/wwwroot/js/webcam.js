let videEle = null;
let canvasEle = null;
let context = null;
let streaming = false;

let width = 100;    // We will scale the photo width to this.
let height = 0;     // This will be computed based on the input stream

function onStart(options, video, canvas, cameraLoadingElement, WhichCamera){
    
    if ('mediaDevices' in navigator && 'getUserMedia' in navigator.mediaDevices) {

        navigator.mediaDevices.enumerateDevices()
            .then(function (devices) {
                const filtered = devices.filter(device => device.kind === 'videoinput');
                if (filtered.length > 0) {

                    videEle = video;
                    canvasEle = canvas;
                    context = canvas.getContext('2d');
                    width = options.width;

                    cameraLoadingElement.style.visibility = "visible";

                    navigator.mediaDevices.getUserMedia({ video: { facingMode: { exact: WhichCamera } }, audio: false })
                        .then(function (stream) {

                            video.srcObject = stream;
                            video.play();
                        })
                        .catch(function (err) {
                            console.log("An error occurred: " + err);
                        });

                    video.addEventListener('canplay', function () {
                        if (!streaming) {
                            height = video.videoHeight / (video.videoWidth / width);

                            if (isNaN(height)) {
                                height = width / (4 / 3);
                            }

                            video.setAttribute('width', width);
                            video.setAttribute('height', height);
                            canvas.setAttribute('width', width);
                            canvas.setAttribute('height', height);
                            streaming = true;
                        }
                        cameraLoadingElement.style.visibility = "hidden";


                    }, false);

                    video.addEventListener("play", function () {
                        timercallback();
                    }, false);
                }
            });
    }
    else {
        return "Your browser does not support using a camera for this website.";
    }
}

function onStop(videoElement) {
    if (videoElement.srcObject != null) {
        videoElement.srcObject.getTracks().forEach(function (track) {
            if (track.readyState == 'live') {
                track.stop();
            }
        });

        videoElement.srcObject = null;
        context = null;
    }
}

function onTakeSnapshot(options, video, canvas, imageName, userId, isProductionFile) {
    width = options.width;

    if (width && height) {
        canvas.width = width;
        canvas.height = height;
        context.drawImage(video, 0, 0, width, height);

        var data = canvas.toDataURL('image/png');
        //photo.setAttribute('src', data);

        var formdata = new FormData();
        formdata.append("base64image", data);
        formdata.append("imageName", imageName);
        formdata.append("fileExtension", ".png");
        formdata.append("userId", userId);
        formdata.append("isProductionFile", isProductionFile);
        formdata.append("FolderName", "images");

        $.ajax({
            url: "/api/Upload/UpdateSaveImage",
            type: "POST",
            data: formdata,
            processData: false,
            contentType: false,
            success: function (success) {
                onStop(video);
                return "Good";
            }
        });
    } else {
        clearphoto();
    }
}

function timercallback() {
    if (videEle.paused || videEle.ended) {
        return;
    }
    computeFrame();
    setTimeout(function () {
        timercallback();
    }, 0);
}

function computeFrame() {
    context.drawImage(videEle, 0, 0, width, height);
}

window.WebCamFunctions = {
    start: (options, videoElement, canvasElement, cameraLoadingElement, WhichCamera) => { onStart(options, videoElement, canvasElement, cameraLoadingElement, WhichCamera); },
    stop: (videoElement) => { onStop(videoElement); },
    take: (options, videoElement, canvasElement, imageName, userId, isProductionFile) => { onTakeSnapshot(options, videoElement, canvasElement, imageName, userId, isProductionFile); }
};