window.setTitle = (title) => {
    document.title = title + " - StudioManager.";
}

function focusInputFromBlazor(selector) {
    var input = document.querySelector(selector);
    if (!focusInput(input)) {
        input = input.querySelector("input");
        focusInput(input);
    }
}

function focusInput(input) {
    if (input && input.focus) {
        setTimeout(function () {
            input.focus();
        }, 30);
    }
    else {
        return false;
    }
}

function goBack() {
    window.history.back();
}

function goForward() {
    window.history.forward();
}

function changeImage(imageElementId, newPictureNumber) {
    $('#' + imageElementId).attr('src', newPictureNumber);
}

window.browserResize = {
    getInnerHeight: function () {
        return window.innerHeight;
    },
    getInnerWidth: function () {
        return window.innerWidth;
    },
    registerResizeCallback: function () {
        window.addEventListener("resize", browserResize.resized);
    },
    resized: function () {
        DotNet.invokeMethodAsync("BlazorStudioManager.Client", 'OnBrowserResize').then(data => data);
    }
}

window.getDimensions = function () {
    return {
        width: window.innerWidth,
        height: window.innerHeight
    };
};

window.MyInterop = (function () {
    const _changeTheme = function (isDark) {
        if (isDark)
            document.body.classList.add('dark-theme');
        else
            document.body.classList.remove('dark-theme');
    };

    return {
        ChangeTheme: _changeTheme
    };
})();

function triggerFormSubmit(SubmitButtonWrapper) {
    $("." + SubmitButtonWrapper).find(".k-button").trigger('click');
}

function addImageControl(ImageUploadWrapper) {
    $("." + ImageUploadWrapper).find(".k-upload-button input").trigger('click');
}

function CreateCustomTheme() {
    //window.location.href = "https://themebuilder.telerik.com/blazor-ui";
    window.open("https://themebuilder.telerik.com/blazor-ui", "_blank");
}

function addPdf() {
    $(".PdgUploadWrapper").find(".k-upload-button input").trigger('click');
}

function contactImportUpload() {
    $(".ContactImportUploadWrapper").find(".k-upload-button input").trigger('click');
}

function themeUpload() {
    $(".ThemeUploadWrapper").find(".k-upload-button input").trigger('click');
}

function fileUpload() {
    $(".FileUploadWrapper").find(".k-upload-button input").trigger('click');
}

function scriptUpdatesUpload() {
    $(".ScriptUpdatesUploadWrapper").find(".k-upload-button input").trigger('click');
}

function SetLocation() {
    if (navigator.geolocation) {

        navigator.geolocation.getCurrentPosition(function (position) {
            showPosition(position);
        }, showLocationError);
    }
    else { x.innerHTML = "Geolocation is not supported by this browser."; }
}
function showPosition(position) {
    $.ajax({
        url: "/api/Productions/StoreLocation",
        data: { latitude: position.coords.latitude, longitude: position.coords.longitude },
        success: function (success) {
            if (success) {
                var latlondata = position.coords.latitude + "," + position.coords.longitude;
                var latlon = "The production's location has been updated.";
                alert(latlon);
            }
        }
    });
}
function GetLocationToCompare() {
    if (navigator.geolocation) {

        navigator.geolocation.getCurrentPosition(function (position) {
            compareLocation(position);
        }, showLocationError);
    }
    else { x.innerHTML = "Geolocation is not supported by this browser."; }
}
function compareLocation(position) {
    $.ajax({
        url: "/api/Productions/CompareLocation",
        data: { comparelatitude: position.coords.latitude, comparelongitude: position.coords.longitude },
        success: function (success) {
            if (success) {
                alert("You are signed in.");
            }
            else {
                alert("You are not at the theater.  You cannot sign in unless you are in the theater.");
            }
        }
    });
}

function showLocationError(error) {
    if (error.code == 1) {
        x.innerHTML = "User denied the request for Geolocation."
    }
    else if (err.code == 2) {
        x.innerHTML = "Location information is unavailable."
    }
    else if (err.code == 3) {
        x.innerHTML = "The request to get user location timed out."
    }
    else {
        x.innerHTML = "An unknown error occurred."
    }
}

function reloadPage() {
    location.reload(true);
}

function blazorGetTimezoneOffset() {
    return new Date().getTimezoneOffset();
}

function downloadFile(fileUrl, fileName) {
    //console.log(fileName);
    var file = document.createElement('a');
    file.target = '_blank';
    file.href = fileUrl;
    file.download = fileName;
    document.body.appendChild(file);
    file.click();
    document.body.removeChild(file);
}

function get_time_zone_offset() {
    var current_date = new Date();
    return -current_date.getTimezoneOffset() / 60;
}

function showStudioManagerTemplates(value) {
    var documentSave = $("li[data-action=documentSave]");
    if (!documentSave) {
        console.log("documentSave element not found in the DOM!")
        return;
    }

    if (value)
        documentSave.hide();
    else
        documentSave.show();
}