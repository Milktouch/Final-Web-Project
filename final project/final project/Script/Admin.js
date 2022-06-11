function UpdateTable() {
    // re-renders the user table based on the json array "users"

    let table = document.getElementById("UserTable");
    table.innerHTML = '<tr id="headers"> <th class= "property" > Id</th ><th class="property">FirstName</th><th class="property">LastName</th> <th class="property">Email</th><th class="property">Age</th><th class="property">PhoneNumber</th><th class="property">City</th><th class="property">PassWord</th></tr > ';
    for (let i = 0; i < users.length; i++) {
        table.innerHTML += `<tr id="user${i}" class="datarow"></tr>`;
        let row = document.getElementById(`user${i}`);
        let user = users[i];
        if (user === undefined || user === null) continue;
        
        Object.keys(user).forEach(key => {

            row.innerHTML += `<td class="info">${user[key]}</td>`;
        })
        row.innerHTML+=`<td class="X">X</td>`
    }
    //if an element with the class X is clicked:
    //remove user from the databse an the table
    document.querySelectorAll('.X').forEach(element => {
        element.addEventListener('click', (elem) => {
            let index = elem.target.parentElement.id;
            index = parseInt(String(index).substring(String(index).lastIndexOf("r") + 1))
            let id = users[index]["Id"]
            users.splice(index, 1);
            //send a query to the server with a websocket
            //to be then used in the database
            ws.send(`DELETE FROM Users WHERE Id=${id}`)
            ws.send(`DROP TABLE SchedueleForUser${id}`)
            //re-render the table
            UpdateTable();
        })
    })
    document.querySelectorAll('.info').forEach((element) => {
        
            element.setAttributeNode(document.createAttribute('contenteditable'));
        
        element.addEventListener('focusout', (elem) => {
            

            let index = elem.target.parentElement.id;
            index = parseInt(String(index).substring(String(index).lastIndexOf("r") + 1))
            let key = document.querySelector('#headers').children[elem.target.cellIndex].textContent;
            if (key.toLowerCase() == 'id') return;
            let value = elem.target.textContent
            let valid = executeFunctionByName(key.toLowerCase(), window, value)
            if (valid == 0) {
                
                if (key == 'Age') {
                    ws.send(`Update Users set Age=${value} Where Id=${elem.target.parentElement.children[0].textContent}`)
                }
                else {
                    ws.send(`Update Users set ${key}='${value}' Where Id=${elem.target.parentElement.children[0].textContent}`)
                        UpdateJson(index, key, value);
                }
            }
            else {
                alert(`${value} is not a valid value for ${key}`)
            }
            
            UpdateTable();
        });
    });
}
document.getElementById('UserTable').addEventListener('mouseover', (event) => {
    document.querySelectorAll('#headers>.property:hover').forEach((element) => {
        let index = element.cellIndex
        document.querySelectorAll('.datarow').forEach(elem => {
            let children = elem.children
            children[index].classList.add('selected')
        })
    });
    document.querySelectorAll('.datarow>.info:hover').forEach((element) => {
        let index = element.cellIndex
        let elem = document.querySelectorAll('#headers>.property')[index];
        elem.classList.add('hselected');
    });
});
document.getElementById('UserTable').addEventListener('mouseout', (event) => {
    document.querySelectorAll('#headers>.property:not(:hover)').forEach((element) => {
        let index = element.cellIndex
        document.querySelectorAll('.datarow').forEach(elem => {
            let children = elem.children
            children[index].classList.remove('selected')
        })
    });
    document.querySelectorAll('.datarow>.info:not(:hover)').forEach((element) => {
        let index = element.cellIndex;
        let elem = document.querySelectorAll('#headers>.property')[index];
        elem.classList.remove('hselected');
    });
});
UpdateTable();
function UpdateJson(index, key, value) {
    let user = users[index];
    delete users[index]
    user[Object.keys(user).find(k => k.toLowerCase() == key.toLowerCase())] = value;
    users[index] = user;
}
var ws = new WebSocket("ws://localhost:" + port+"/admin");
/*ws.onmessage = (e) => {
    usersArr = String(e.data).substring(String(e.data).indexOf('['))
    len = parseInt(String(e.data).substring(0, String(e.data).indexOf('['))
        users = new Array()
        for (let i = 0; i < len; i++) {
            let place = i * 8;
            users.push({ "Id": `${usersArr[place]}`, "Firstname": `${usersArr[place + 1]}`, "Lastname": `${usersArr[place + 2]}`, "Email": `${usersArr[place + 3]}`, "Age": `${usersArr[place + 4]}`, "Phonenumber": `${usersArr[place + 5]}`, "City": `${usersArr[place + 6]}`, "Password": `${usersArr[place + 7]}` })
        }
}*/
ws.onopen = () => {
    console.log("websocket open")
}
function executeFunctionByName(functionName, context , args ) {
    var args = Array.prototype.slice.call(arguments, 2);
    var namespaces = functionName.split(".");
    var func = namespaces.pop();
    for (var i = 0; i < namespaces.length; i++) {
        context = context[namespaces[i]];
    }
    return context[func].apply(context, args);
}