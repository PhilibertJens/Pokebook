document.getElementById("test").addEventListener("click", myFunction);

function myFunction() {
    var selected = document.getElementById("userListValue").value;
    window.location = "/Profile/UserProfile/" + selected;
}