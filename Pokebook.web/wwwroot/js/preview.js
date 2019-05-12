﻿$(document).ready(function () {
    console.log("De DOM is geladen!!");
    $("#UploadedProfileImage").on('change', showProfileImagePreview);
    $("#UploadedCoverImage").on('change', showCoverImagePreview);
});

function showProfileImagePreview() {
    var input = this;
    if (input.files && input.files[0]) {
        var reader = new FileReader();
        reader.onload = function (e) {
            $('#preview-profile').attr('src', e.target.result);
        };
        reader.readAsDataURL(input.files[0]);
    }
}

function showCoverImagePreview() {
    var input = this;
    if (input.files && input.files[0]) {
        var reader = new FileReader();
        reader.onload = function (e) {
            $('#preview-cover').attr('src', e.target.result);
        };
        reader.readAsDataURL(input.files[0]);
    }
}