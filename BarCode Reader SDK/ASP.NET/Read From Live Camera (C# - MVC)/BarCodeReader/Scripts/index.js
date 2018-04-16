//*****************************************************************************************//
//                                                                                         //
// Download offline evaluation version (DLL): https://bytescout.com/download/web-installer //
//                                                                                         //
// Signup Web API free trial: https://secure.bytescout.com/users/sign_up                   //
//                                                                                         //
// Copyright © 2017-2018 ByteScout Inc. All rights reserved.                               //
// http://www.bytescout.com                                                                //
//                                                                                         //
//*****************************************************************************************//


var canvas, context, timer;
//  (HTML5 based camera only) this portion of code will be used when browser supports navigator.getUserMedia  *********     */
window.addEventListener("DOMContentLoaded", function () {
    canvas = document.getElementById("canvasU"),
    context = canvas.getContext("2d"),
    video = document.getElementById("video"),
    videoObj = { "video": true },
    errBack = function (error) {
        console.log("Video capture error: ", error.code);
    };

    // check if we can use HTML5 based camera (through .getUserMedia() function)
    if (navigator.getUserMedia) { // Standard browser (Opera)
        // display HTML5 camera
        document.getElementById("userMedia").style.display = '';
        // adding click event to take photo from webcam
        document.getElementById("snap").addEventListener("click", function () {
            context.drawImage(video, 0, 0, 640, 480);
        });
        navigator.getUserMedia(videoObj, function (stream) {
            video.src = window.URL.createObjectURL(stream);
            video.play();
        }, errBack);
    }
        // check if we can use HTML5 based camera (through .getUserMedia() function in Webkit based browser)
    else if (navigator.webkitGetUserMedia) { // WebKit-prefixed for Google Chrome
        // display HTML5 camera
        document.getElementById("userMedia").style.display = '';
        // adding click event to take photo from webcam
        document.getElementById("snap").addEventListener("click", function () {
            context.drawImage(video, 0, 0, 640, 480);
        });
        navigator.webkitGetUserMedia(videoObj, function (stream) {
            video.src = window.webkitURL.createObjectURL(stream);
            video.play();
        }, errBack);
    }
        // check if we can use HTML5 based camera (through .getUserMedia() function in Firefox based browser)
    else if (navigator.mozGetUserMedia) { // moz-prefixed for Firefox 
        // display HTML5 camera
        document.getElementById("userMedia").style.display = '';
        // adding click event to take photo from webcam
        document.getElementById("snap").addEventListener("click", function () {
            context.drawImage(video, 0, 0, 640, 480);
        });
        navigator.mozGetUserMedia(videoObj, function (stream) {
            video.mozSrcObject = stream;
            video.play();
        }, errBack);
    }
    else
        // if we can not use any of HTML5 based camera ways then we use Flash based camera
    {
        // display Flash camera
        document.getElementById("flashDiv").style.display = '';
        document.getElementById("flashOut").innerHTML = (webcam.get_html(640, 480));
    }

}, false);

// (all type of camera) set the default selection of barcode type
var selection = "All barcodes (slow)";

// (all type of camera) gets the selection text of "barcode type to scan" combobox
function selectType(type) {
    selection = type.options[type.selectedIndex].text;
}

// (HTML5 based camera only)
// uploads the image to the server 
function UploadToCloud() {
    document.getElementById('report').innerHTML = "scanning the current frame......";
    context.drawImage(video, 0, 0, 640, 480);
    $("#upload").attr('disabled', 'disabled');
    $("#upload").attr("value", "Uploading...");
    var img = canvas.toDataURL('image/jpeg', 0.9).split(',')[1];
    // send AJAX request to the server with image data 
    $.ajax({
        url: "/Home/UploadHtml5",
        type: "POST",
        data: "{ 'image': '" + img + "' , 'type': '" + selection + "'}",
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        // on success output the result returned by the server side (See HTML5Camera.aspx)
        success: function (data, status) {
            $("#upload").removeAttr('disabled');
            $("#upload").attr("value", "Upload");
            if (data.d.length != 0) {
                var htmlSelect = document.getElementById('OutListBoxHTML5');
                var selectBoxOption = document.createElement("option");
                selectBoxOption.text = data.d;
                selectBoxOption.id = "child";
                htmlSelect.insertBefore(selectBoxOption, htmlSelect.childNodes[0]);
            }
        },
        // on error just show the message that no barcodes were found
        error: function (data) {
            document.getElementById('report').innerHTML = "no barcode found, scanning.....";
            $("#upload").removeAttr('disabled');
            $("#upload").attr("value", "Upload");
        },
        async: false
    });
    timer = setTimeout(UploadToCloud, 3000);  // will capture new image to detect barcode after 3000 mili second
}

// (flash based camera only) stop the capturing 
function stopCall() {
    document.getElementById('report').innerHTML = "STOPPED Scanning."
    clearTimeout(timer);
}

// (flash based camera only) sets the handler for callback completition to output the result
webcam.set_hook('onComplete', 'my_completion_handler');

// (flash based camera only) this function will start flash to capture image and send the image to the server for further processing (for IE)
function take_snapshot() {
    // set api to be called by flash camera
    webcam.set_api_url('/home/UploadFlash?type=' + selection);
    webcam.set_quality(100);
    // enable the shutter sound
    webcam.set_shutter_sound(true);
    document.getElementById('upload_results').innerHTML = '<h4>Scanning...</h4>';
    // capture image from the webcam
    webcam.snap();
    // set timout to capter new image (interval between captures)
    timer = setTimeout(take_snapshot, 3000);
}

// (flash based camera only) this one will work after recieving barcode from server
// this function writes the output result back to the front page (from server side)
function my_completion_handler(msg) {
    var str = msg;
    // encode into html compatible string
    var result = str.match(/<d>(.*?)<\/d>/g).map(function (val) {
        return val.replace(/<\/?d>/g, '');
    });
    // add new result into the listbox 
    var htmlSelect = document.getElementById('OutListBoxFlash');
    var selectBoxOption = document.createElement("option");
    selectBoxOption.text = result;
    selectBoxOption.id = "child";
    htmlSelect.insertBefore(selectBoxOption, htmlSelect.childNodes[0]);
    // reset webcam and flash to capture new image. this reset process flickers a little
    webcam.reset();
}

// (flash based camera only) stop the scan and set the message on the page
function stopScanning() {
    document.getElementById('upload_results').innerHTML = "STOPPED Scanning."
    clearTimeout(timer);
}
