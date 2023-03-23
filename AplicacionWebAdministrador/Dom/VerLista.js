const btn = document.querySelector(".btn_ver");
const lista = document.querySelector(".Lista-Productos");


btn.addEventListener('click', () => {
    lista.classList.toggle("Abrir");
    btn.classList.toggle("Vuelta");
})


