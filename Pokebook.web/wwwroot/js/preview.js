$(document).ready(function () {
    console.log("De DOM is geladen!!");
    $("#UploadedProfileImage").on('change', showProfileImagePreview);
    $("#UploadedCoverImage").on('change', showCoverImagePreview);
    $("#Chat_Image").on('change', showChatImagePreview);
    $("#newImage").on('change', showMessageImagePreview);
    $(".speech-bubbles").on('click', 'img', showModal);
    $("#profilePicture").on('click', showModal);
    $(".closeModal").on('click', closeModal);
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

function showChatImagePreview() {
    var input = this;
    if (input.files && input.files[0]) {
        var reader = new FileReader();
        reader.onload = function (e) {
            $('#preview-chatImage').attr('src', e.target.result);
        };
        reader.readAsDataURL(input.files[0]);
    }
}

function showMessageImagePreview() {
    var input = this;
    if (input.files && input.files[0]) {
        var reader = new FileReader();
        reader.onload = function (e) {
            $('#preview-messageImage').attr('src', e.target.result);
            $('#currentChatImage').hide();
            $('#divPreview-messageImage').show();
        };
        reader.readAsDataURL(input.files[0]);
    }
}

function showModal() {
    var modal = document.getElementById("imageModal");
    var img = $(this);
    var modalImg = document.getElementById("img01");
    var captionText = document.getElementById("caption");

    modal.style.display = "block";
    modalImg.src = img.attr('src');
    captionText.innerHTML = img.attr('alt');
}

function closeModal() {
    var modal = document.getElementById("imageModal");
    modal.style.display = "none";
}