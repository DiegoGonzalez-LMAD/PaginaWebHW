<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RegistroHW.aspx.cs" Inherits="PaginaWebHW.RegistroHW" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Registro de Usuario</title>
    <link href="~/Content/bootstrap.min.css" rel="stylesheet" />
    <link href="~/Estilos/EstiloRegistros.css" rel="stylesheet"/>
    <script src="https://kit.fontawesome.com/81e957327f.js" crossorigin="anonymous"></script>
    <style>
        body{
            background-image:url('Archivos/wallPaperHW.jpg');
            background-size: cover;
            background-position: center; 
            background-repeat: no-repeat; 
        }
    </style>
    
    
    

</head>
<body>
    <div class="contInicio" id="contInicio">      
        <form  runat="server" class="container tarjRegistro">
            <h1>Registro de Usuario</h1>
            <div class="mb-3">
                <label  class="form-label">Nombre de Usuario</label>
               <asp:TextBox id="nombreUsuarioTxt" CssClass="form-control" runat="server" />
            </div>
            <div class="mb-3">
                <label  class="form-label">Correo Electronico</label>
                <asp:TextBox id="correoElectronicoTxt" CssClass="form-control" runat="server" TextMode="Email" type="email"/>
            </div>
            <div class="mb-3 password-container">
                <label  class="form-label">Contraseña</label>
                <asp:TextBox id="ContraOriginalTxt" CssClass="form-control" runat="server" TextMode="Password" type="password"  oncopy="return false;" oncut="return false;" onpaste="return false;" 
                    oncontextmenu="return false;" autocomplete="off" spellcheck="false"  />
                <i class="fa-regular fa-eye toggle-password" id="ojo" onclick="togglePassword('ContraOriginalTxt',this)"></i>

            </div>
            <div class="mb-3 password-container">
                <label  class="form-label">Ingresa nuevamente la contraseña</label>
                <asp:TextBox id="ContraDuplicTxt" CssClass="form-control" runat="server" TextMode="Password" type="password"  oncopy="return false;" oncut="return false;" onpaste="return false;" 
                    oncontextmenu="return false;" autocomplete="off" spellcheck="false"  />
                <i class="fa-regular fa-eye toggle-password" id="toggle-password"  onclick="togglePassword('ContraDuplicTxt',this)"></i>
            </div>
            <div class="conBut">
                 <asp:Button type="submit" class="btn btn-primary col-6 " Text="Registrarse" runat="server" OnClick="btnSubmit_Click"/>
            </div>
            <hr />
            <label style="color:#0172b6;font-size:22px;">Si ya tienes cuentra ingresa directamente <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Inicio_Sesion.aspx"> aqui </asp:HyperLink></label>
            <label style="color:#0172b6;">Pagina creada por Diego Gonzalez, Derechos Reservados.</label>
        </form>     
    </div>
    <script src="~/Scripts/jquery-3.5.1.min.js"></script>
    <script src="~/Scripts/popper.min.js"></script>
    <script src="~/Scripts/bootstrap.min.js"></script>
    <script src="/ScriptsPer/paginaRegistro.js"></script>
</body>
</html>
