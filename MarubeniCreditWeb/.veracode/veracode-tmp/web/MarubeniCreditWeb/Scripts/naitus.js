let burguerBtn = document.querySelector('.navbar-toggler');

burguerBtn.addEventListener('touchstart', function () {
    let atr = burguerBtn.children[0].getAttribute('src');
    if (atr === '../img/icons/cerrar.png') {
        burguerBtn.children[0].setAttribute('src', '../img/icons/burger-menu.png');
    } else {
        burguerBtn.children[0].setAttribute('src', '../img/icons/cerrar.png');
    }
})


const listContainer = document.querySelector('.list-container');
const bodyContainer = document.querySelector('.body-container');

listContainer.addEventListener('click', (e) => {
    let value = e.target.attributes[1].nodeValue;
    let regexValue = /(\w+)/gi;
    let id = value.match(regexValue);
    let bodyChildren = [...bodyContainer.children];
    let arrList = [...listContainer.children];
    arrList.forEach(el => {
        if (el.children[0].attributes[1].value === e.target.attributes[1].value) {
            if ([...el.children[0].classList].indexOf("fw-bold") === -1) {
                el.children[0].classList.add("fw-bold");
            }
        } else {
            el.children[0].classList.remove("fw-bold");
        }
    })
    bodyChildren.forEach(elem => {
        if (elem.classList[1] === "show") {
            if (elem.id !== id[0]) {
                elem.classList.toggle("show");
            }
        } else {
            if (elem.id === id[0]) {
                elem.classList.toggle("show");
            }
        }
    })
})

const listContainer2 = document.querySelector('.list-container2');
const bodyContainer2 = document.querySelector('.body-container2');

listContainer2.addEventListener('click', (e) => {
    let value = e.target.attributes[1].nodeValue;
    let regexValue = /(\w+)/gi;
    let id = value.match(regexValue);
    let bodyChildren = [...bodyContainer2.children];
    let arrList = [...listContainer2.children];
    arrList.forEach(el => {
        if (el.children[0].attributes[1].value === e.target.attributes[1].value) {
            if ([...el.children[0].classList].indexOf("fw-bold") === -1) {
                el.children[0].classList.add("fw-bold");
            }
        } else {
            el.children[0].classList.remove("fw-bold");
        }
    })
    bodyChildren.forEach(elem => {
        if (elem.classList[1] === "show") {
            if (elem.id !== id[0]) {
                elem.classList.toggle("show");
            }
        } else {
            if (elem.id === id[0]) {
                elem.classList.toggle("show");
            }
        }
    })
})

const listContainer3 = document.querySelector('.list-container3');
const bodyContainer3 = document.querySelector('.body-container3');

listContainer3.addEventListener('click', (e) => {
    let value = e.target.attributes[1].nodeValue;
    let regexValue = /(\w+)/gi;
    let id = value.match(regexValue);
    let bodyChildren = [...bodyContainer3.children];
    let arrList = [...listContainer3.children];
    arrList.forEach(el => {
        if (el.children[0].attributes[1].value === e.target.attributes[1].value) {
            if ([...el.children[0].classList].indexOf("fw-bold") === -1) {
                el.children[0].classList.add("fw-bold");
            }
        } else {
            el.children[0].classList.remove("fw-bold");
        }
    })
    bodyChildren.forEach(elem => {
        if (elem.classList[1] === "show") {
            if (elem.id !== id[0]) {
                elem.classList.toggle("show");
            }
        } else {
            if (elem.id === id[0]) {
                elem.classList.toggle("show");
            }
        }
    })
})