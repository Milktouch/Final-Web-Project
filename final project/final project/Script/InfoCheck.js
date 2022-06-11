function firstname(name) {

    if (name.length >= 3) {
       
        return 0;
    }
    else {
        
        return 1;
    }
}
function city(city) {
    if (city.length < 4) return 1;
    for (let i = 0; i < city.length; i++) {
        if (((city[i] > 'Z' && city[i] < 'a') || city[i] > 'z' || city[i] < 'A') && city[i] != " " && city[i]!="-") {
            return 1;
        }
    }
    return 0;
}
function lastname(name) {

    if (name.length >= 3) {
        return 0;
    }
    else {
        return 1;
    }
}
function email(email) {
    if (/[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?/.test(email)) {
        return 0;
    }
    else {
        
        return 1;
    }
}
function age(age) {
    if (age.length < 1) {
        return 1;
    }
    for (let i = 0; i < age.length; i++) {
        var letter = age[i];
        if (letter < '0' || letter > '9') {
            return 1;
        }
    }
    return 0;
}
function phonenumber(phonenumber) {
    for (let i = 0; i < phonenumber.length; i++) {
        var letter = phonenuber[i];
        if (letter < '0' || letter > '9') {
            return 1;
        }
    }
    if (phonenumber.length != 7) {
        return 1;
    }
    else {
        return 0;
    }
}
function password(password) {
    if (password.length < 7) {
        return 1;
    }
    else {
        return 0;
    }


}