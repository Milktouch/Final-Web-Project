
function Load() {
    $(".circle1").fadeIn("fast");
    $(".circle2").fadeIn("fast");
    $(".circle3").fadeIn("fast");
}
var ret;
function checkfname() {
    
    if (document.getElementById("firstname").value.length >= 3) {
        document.getElementById("fnamev").textContent = "Valid";
        document.getElementById("fnamev").style.color = "green";
        return 0;
    }
    else {
        document.getElementById("fnamev").textContent = "Not valid. Too short!";
        document.getElementById("fnamev").style.color = "red";
        return 1;
    }
}
function checklname() {

    if (document.getElementById("lastname").value.length >= 3) {
        document.getElementById("lnamev").textContent = "Valid";
        document.getElementById("lnamev").style.color = "green";
        return 0;
    }
    else {
        document.getElementById("lnamev").textContent = "Not valid. Too short!";
        document.getElementById("lnamev").style.color = "red";
        return 1;
    }
}
function checkmail() {
    if (/[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?/.test(document.getElementById("mail").value)) {
        document.getElementById("emailv").style.color = "green";
        document.getElementById("emailv").textContent = "Valid";
        return 0;
    }
    else {
        document.getElementById("emailv").textContent = "Not valid";
        document.getElementById("emailv").style.color = "red";
        return 1;
    }
}
function checkage() {
    if (document.getElementById("age").value.length < 1) {
        document.getElementById("agev").textContent = "Not valid";
        document.getElementById("agev").style.color = "red";
        return 1;
    }
    for (let i = 0; i < document.getElementById("age").value.length; i++) {
        var letter = document.getElementById("age").value[i];
        if (letter < '0' || letter > '9') {
            document.getElementById("agev").textContent = "Not valid. Numbers only!";
            document.getElementById("agev").style.color = "red";
            return 1;
        }
        else {
            document.getElementById("agev").style.color = "green";
            document.getElementById("agev").textContent = "Valid";
            return 0;
        }
            


    }
}
function checkphone() {
    for (let i = 0; i < document.getElementById("phone").value.length; i++) {
        var letter = document.getElementById("phone").value[i];
        if (letter < '0' || letter > '9') {
            document.getElementById("phonev").textContent = "Not valid. Numbers only!";
            document.getElementById("phonev").style.color = "red";
            return 1;
        }
        else {
            document.getElementById("phonev").style.color = "green";
            document.getElementById("phonev").textContent = "Valid";
            

        }
            


    }
    if (document.getElementById("phone").value.length != 7) {
        document.getElementById("phonev").textContent = "Not valid. Wrong amount of numbers!";
        document.getElementById("phonev").style.color = "red";
        return 1;

    }
    else {
        document.getElementById("phonev").style.color = "green";
        document.getElementById("phonev").textContent = "Valid";
        return 0;

    }
}
function checkpass() {
    if (document.getElementById("password").value.length < 7) {
        document.getElementById("pass1").textContent = "Please type a stronger password";
        document.getElementById("pass1").style.color = "red";
        return 1;

    }
    else {
        document.getElementById("pass1").textContent = "Valid";
        document.getElementById("pass1").style.color = "green";
        return 0;
    }
        
    
}
function checkpass2() {
    if (document.getElementById("password").value != document.getElementById("password2").value) {
        document.getElementById("pass2").textContent = "Passwords don't match";
        document.getElementById("pass2").style.color = "red";
        return 1;

    }
    else {
        document.getElementById("pass2").textContent = "Valid";
        document.getElementById("pass2").style.color = "green";
        return 0;
    }


}
function checkall() {
    Load();
    ret += checkage();
    ret += checkfname();
    ret += checklname();
    ret += checkmail();
    ret += checkpass();
    ret += checkpass2();
    ret += checkphone();
    if (ret != 0) {
        return false;
    }
    else {
        return true;
    }
}