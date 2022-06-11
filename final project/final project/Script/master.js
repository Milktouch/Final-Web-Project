
$("#search").on('keyup',  (e)=> {
    if (e.key === 'Enter' || e.keyCode === 13) {
        let url = 'Search.aspx?p=' + $('#search').val();
        
        location.assign(url)
    }
});
$("#searchbtn").on('click', (e) => {
    
        let url = 'Search.aspx?p=' + $('#search').val();

        location.assign(url)
    
});
function admin() {
    location.assign("Admin.aspx");
}
function profile() {
    location.assign("mypage.aspx");
}
function register() {
    location.assign("register.aspx");
}
function logout() {

    location.assign("logout.aspx")
    
}
function openForm() {
    
    $("#login").fadeIn("fast");
}
function closeForm() {
    
    $("#login").fadeOut("fast");

}

