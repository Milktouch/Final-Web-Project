

var user;
$("form").submit((e) => {
    e.preventDefault();
    window.history.back();
    $(document).ready(() => {
        openForm();
    })
})
function profile() {
    location.assign("mypage.aspx");
}
function register() {
    location.assign("register.aspx");
}
function signout() {

    localStorage.clear();
    location.reload();
}
function openForm() {
    
    $("#login").fadeIn("fast");
}
function closeForm() {
    
    $("#login").fadeOut("fast");

}

