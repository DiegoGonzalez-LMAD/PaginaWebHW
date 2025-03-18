function updatePadding() {
    var contInicio = document.getElementById("contInicio");
    var width = contInicio.offsetWidth;
    contInicio.style.padding = width > 500 ? "2%" : "5%";
}

function verificarContra() {
    var contra1 = document.getElementById("ContraOriginalTxt").value;
    var contra2 = document.getElementById("ContraDuplicTxt").value;
    var label = document.getElementById("labelError");

    if (!label) {
        label = document.createElement("label");
        label.id = "labelError";
        label.style.color = "red";
        document.getElementById("ContraDuplicTxt").parentElement.appendChild(label);
    }

    if (contra1 !== contra2) {
        label.textContent = "❌ Contraseñas diferentes";
        document.getElementById("toggle-password").style.top = "55%";
    } else {
        
        label.remove();
        var labelCon = document.getElementById("labelTamanio");
        if (!labelCon) {
            document.getElementById("toggle-password").style.top = "75%";
        } else {
           document.getElementById("toggle-password").style.top = "55%";
        }
       
    }
}

function tamanioContra() {
    var contra1 = document.getElementById("ContraOriginalTxt").value;
    var label = document.getElementById("labelTamanio");

    
    if (!label) {
        label = document.createElement("label");
        label.id = "labelTamanio";
        label.style.color = "red";
        document.getElementById("ContraOriginalTxt").parentElement.appendChild(label);

    }

   
    if (contra1.length < 8) {
        label.textContent = "❌ La contraseña debe tener al menos 8 caracteres.";
        document.getElementById("ojo").style.top = "55%";
    } else {
        label.remove();
        var labelCon = document.getElementById("labelTamanio");
        if (!labelCon) {
            document.getElementById("ojo").style.top = "75%";
        } else {
            document.getElementById("ojo").style.top = "55%";
        }
    }
}

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

function verificarCorreo() {
    var email = document.getElementById("correoElectronicoTxt").value;
    const emailPattern = /^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$/;
    var label = document.getElementById("labelEmail");

    if (!emailPattern.test(email)) {
        if (!label) {
            label = document.createElement("label");
            label.id = "labelEmail";
            label.style.color = "red";
            document.getElementById("correoElectronicoTxt").parentElement.appendChild(label);
        }
        label.textContent = "No es un correo válido";
    } else {
        if (label) {
            label.remove();
        }
    }
}


document.getElementById("ContraOriginalTxt").addEventListener("input", verificarContra);
document.getElementById("ContraOriginalTxt").addEventListener("input", tamanioContra);
document.getElementById("ContraDuplicTxt").addEventListener("input", verificarContra);
document.getElementById("correoElectronicoTxt").addEventListener("input", verificarCorreo);

window.addEventListener("load", updatePadding);
window.addEventListener("resize", updatePadding);
