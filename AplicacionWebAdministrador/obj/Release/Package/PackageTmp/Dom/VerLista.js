const btn = document.querySelector(".btn_ver");
const lista = document.querySelector(".Lista-Productos");
const btnd = document.querySelector(".btn_verD");
const listad = document.querySelector(".Lista-ProductosD");


btn.addEventListener('click', () => {
    lista.classList.toggle("Abrir");
    btn.classList.toggle("Vuelta");
});

btnd.addEventListener('click', () => {
    listad.classList.toggle("AbrirD");
    btnd.classList.toggle("VueltaD");
});