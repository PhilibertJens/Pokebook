$(document).ready(function () {
    console.log("De DOM is geladen!!");
    $("#UploadedImage").on('change', showImagePreview);
});

function showImagePreview() {
    var input = this;
    if (input.files && input.files[0]) {
        var reader = new FileReader();
        reader.onload = function (e) {
            $('#preview').attr('src', e.target.result);
        };
        reader.readAsDataURL(input.files[0]);
    }
}


