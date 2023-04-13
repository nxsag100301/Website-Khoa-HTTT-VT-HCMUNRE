let navbarDiv = document.querySelector('.navbar');
window.addEventListener('scroll', () => {
    if (document.body.scrollTop > 40 || document.documentElement.scrollTop > 40) {
        navbarDiv.classList.add('navbar-cng');
    } else {
        navbarDiv.classList.remove('navbar-cng');
    }
});


const navbarCollapseDiv = document.getElementById('navbar-collapse');
const navbarShowBtn = document.getElementById('navbar-show-btn');
const navbarCloseBtn = document.getElementById('navbar-close-btn');
// show navbar
const menuBar = document.querySelector(".menu-bar")
menuBar.addEventListener("click", function () {
    menuBar.classList.toggle("active")
    document.querySelector(".menu-items").classList.toggle("active")
})
const toP = document.querySelector(".top")
window.addEventListener("scroll", function () {
    const x = this.pageYOffset
    if (x > 80) { toP.classList.add("active") }
    else { toP.classList.remove("active") }
});
//hide side bar
navbarCloseBtn.addEventListener('click', () => {
    navbarCollapseDiv.classList.remove('navbar-collapse-rmw');
});

document.addEventListener('click', (e) => {
    if (e.target.id != "navbar-collapse" && e.target.id != "navbar-show-btn" && e.target.parentElement.id != "navbar-show-btn") {
        navbarCollapseDiv.classList.remove('navbar-collapse-rmw');
    }
});

// stop transition and animatino during window resizing
let resizeTimer;
window.addEventListener('resize', () => {
    document.body.classList.add("resize-animation-stopper");
    clearTimeout(resizeTimer);
    resizeTimer = setTimeout(() => {
        document.body.classList.remove("resize-animation-stopper");
    }, 400);
});