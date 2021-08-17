let nombre;
let correo;
let mensaje;
let button;
button = document.getElementById("send");
button?.addEventListener("click", sendmsg);
function sendmsg() {
    nombre = document.getElementById("nombre");
    correo = document.getElementById("email");
    mensaje = document.getElementById("mensaje");
}