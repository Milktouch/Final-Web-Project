const sched = document.getElementById('sched')
let dates = []
for (let i = 0; i < sched.children.length; i++) {
    let fulldatetext = sched.children[i].children[0].textContent
    let datetext = fulldatetext.substring(fulldatetext.indexOf(': ') + 2, fulldatetext.indexOf(' H'))
    let date = new Date()
    let year = parseInt(datetext.substring(0, datetext.indexOf('/')))
    let month = parseInt(datetext.substring(datetext.indexOf('/') + 1, datetext.lastIndexOf('/')))
    let day = parseInt(datetext.substring(datetext.indexOf('/')+1))
    date.setFullYear(year, month, day)
    let time = fulldatetext.substring(fulldatetext.lastIndexOf(': ') + 2)
    let hour = parseInt(time.substring(0, time.indexOf(':')))
    let min = parseInt(time.substring(time.indexOf(':') + 1))
    date.setHours(hour, min)
    dates.push(date)
}
function checkdate(date) {
    
    let isvalid= true
    dates.forEach(d => {
        if (date == d || date <= new Date()) {
            isvalid = false
            document.querySelector('[schederr]').textContent =' the date cannot be in the past and can\'t conflict with other meetings
        }
   })
    return isvalid
}
function validate() {
    const date = document.getElementById('date').children[0].value;
    const time = document.getElementById('date').children[1].value;
    return checkdate(new Date(date).setHours(time.split(':')[0], time.split(':')[0]))
}