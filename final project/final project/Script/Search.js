

const userCardContainer = document.querySelector("[data-user-cards-container]")
const searchInput = document.querySelector("[data-search]")
const params = new Proxy(new URLSearchParams(window.location.search), {
    get: (searchParams, prop) => searchParams.get(prop),
})

let users = [];
document.querySelectorAll(".card").forEach(card => {
    const name = card.children[0].textContent
    const mail = card.children[1].textContent
    users.push({ name: name, email: mail, element: card })
    card.addEventListener('click', (e) => {
        let id = e.target.id
        if (id == "") {
            id = e.target.parentElement.id;
        }
        location.assign('Profile.aspx?id=' + id)
    })
})
if (params.p !== null && params.p !== undefined) {
    filter(params.p.toLowerCase().trim())
    searchInput.value = params.p
}
searchInput.addEventListener("input", e => {
    const value = e.target.value.toLowerCase().trim()
    filter(value)
})
function filter(value) {
    users.forEach(user => {
        const isVisible =
            user.name.toLowerCase().trim().includes(value) ||
            user.email.toLowerCase().trim().includes(value)
        
        user.element.classList.toggle("hide", !isVisible)
    })
}