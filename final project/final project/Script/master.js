


function profile() {
    location.assign("mypage.aspx");
}
function register() {
    location.assign("register.aspx");
}
function signout() {

    $.post("/masterpage.Master/SignOut", () => {
        location.reload(true);
    })
    
}
function openForm() {
    
    $("#login").fadeIn("fast");
}
function closeForm() {
    
    $("#login").fadeOut("fast");

}

