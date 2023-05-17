﻿const navMenu = document.querySelector(".nav__menu");
const navToggle = document.getElementById('nav__img');
const navClose = document.getElementById("nav-close");

navToggle.addEventListener('click', () => {
    navMenu.classList.toggle('open');
});

//SWIPER
let homeSwiper = new Swiper(".home-swiper", {
    spaceBetween: 10,
    loop: "true",
    pagination: {
        el: ".swiper-pagination",
        clickable: true,
    },
});
let newSwiper = new Swiper(".new-swiper", {
    centeredSlides: true,
    slidesPerView: "auto",
    loop: "true",
    spaceBetween: 16,
});

//Scroll up
function scrollUp() {
    const scrollup = document.getElementById("scroll-up");
    if (this.scrollY >= 460) scrollup.classList.add("show-scroll");
    else scrollup.classList.remove("show-scroll");
}
window.addEventListener("scroll", scrollUp);

//Sections active
const sections = document.querySelectorAll("section[id]");
function scrollActive() {
    const scrollY = window.pageYOffset

    sections.forEach(current => {
        const sectionHeight = current.offsetHeight,
            sectionTop = current.offsetTop - 58,
            sectionId = current.getAttribute('id')

        if (scrollY > sectionTop && scrollY <= sectionTop + sectionHeight) {
            document.querySelector('.nav__menu a[href*=' + sectionId + ']').classList.add('active-link')
        } else {
            document.querySelector('.nav__menu a[href*=' + sectionId + ']').classList.remove('active-link')
        }
    })
}
window.addEventListener("scroll", scrollActive)
//Scroll reveal
const sr = ScrollReveal({
    origin: "top",
    distance: "60px",
    duration: 2500,
    delay: 400,

});
sr.reveal(`.home-swiper,.new-swiper, .newsletter__container`);
sr.reveal(`.category__data, .trick__content, .footer__content`, {
    interval: 100,
});
sr.reveal(`.about__data, .discount__img`, { origin: "left" });
sr.reveal(`.about__img, .discount__data`, { origin: "right" });