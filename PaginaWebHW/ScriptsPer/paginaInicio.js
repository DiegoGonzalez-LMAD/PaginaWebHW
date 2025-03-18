function togglePassword(inputId, icon) {
    var input = document.getElementById(inputId);
    if (input.type === "password") {
        input.type = "text";
        icon.classList.remove("fa-eye");
        icon.classList.add("fa-eye-slash");
    } else {
        input.type = "password";
        icon.classList.remove("fa-eye-slash");
        icon.classList.add("fa-eye");
    }
}
function updatePadding() {
    var contInicio = document.getElementById("contInicio");
    var width = contInicio.offsetWidth;
    contInicio.style.padding = width > 500 ? "2%" : "5%";
}

window.addEventListener("load", updatePadding);
window.addEventListener("resize", updatePadding);