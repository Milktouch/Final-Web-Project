var ws = new WebSocket("ws://localhost:" + port + "/Mypage");
ws.onopen = () => {
    console.log("websocket open")
}
document.querySelectorAll('.Update.button').forEach(btn => {
    btn.addEventListener('click', e => {
        let key = e.target.parentElement.children[0].textContent
        key = key.substring(0, key.length - 1)

        let value = document.getElementById(`${String(key.toLowerCase()).replace(" ","")}`).value
        
        let valid = executeFunctionByName(String(key.toLowerCase()).replace(" ", ""), window, value)
        let query = "";
        if (valid == 0) {

            if (key == 'Age') {
                query=`Update Users set Age=${value} Where Id=${id}`
            }
            else {
                query = `Update Users set ${String(key.toLowerCase()).replace(" ", "")}='${value}' Where Id=${id}`
            }
            ws.send(query)
            e.target.parentElement.children[0].textContent = e.target.parentElement.children[0].textContent.substring(0, e.target.parentElement.children[0].textContent.length - 1)
            e.target.parentElement.children[3].textContent = ''
        }
        else {
            e.target.parentElement.children[3].textContent='Not Valid'
        }
    })
})
function executeFunctionByName(functionName, context, args) {
    var args = Array.prototype.slice.call(arguments, 2);
    var namespaces = functionName.split(".");
    var func = namespaces.pop();
    for (var i = 0; i < namespaces.length; i++) {
        context = context[namespaces[i]];
    }
    return context[func].apply(context, args);
}