<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PaginaPrincipal.aspx.cs" Inherits="PaginaWebHW.PaginaPrincipalaspx" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Pagina Principal</title>
    <link href="~/Content/bootstrap.min.css" rel="stylesheet" />
    <link href="~/Estilos/EstiloPaginaPrincipal.css" rel="stylesheet"/>
    <script src="https://kit.fontawesome.com/81e957327f.js" crossorigin="anonymous"></script>
</head>
<body>

    <form id="form1" runat="server">
        <nav class="navbar" style="background-color: #0172b6;">
            <nav class="navbar navbar-expand-lg">
                <div class="container-fluid">
                    <a class="navbar-brand" href="#">Collection House</a>
                    <button class="navbar-toggler" type="button" data-bs-toggle="collapse" data-bs-target="#navbarNavAltMarkup" aria-controls="navbarNavAltMarkup" aria-expanded="false" aria-label="Toggle navigation">
                        <span class="navbar-toggler-icon"></span>
                    </button>
                    <div class="collapse navbar-collapse" id="navbarNavAltMarkup">
                        <div class="navbar-nav">
                            <a class="nav-link" href="#">Inicio</a>
                            <a class="nav-link" href="#">Comunidad</a>
                            <a class="nav-link" href="#">Biblioteca</a>
                            <a class="nav-link" href="#">Ventas</a>
                            <a class="nav-link" href="#">Perfil</a>
                        </div>
                    </div>
                </div>
            </nav>
        </nav>
    </form>




    

    <script src="/Scripts/jquery-3.5.1.min.js"></script>
    <script src="/Scripts/popper.min.js"></script>
    <script src="/Scripts/bootstrap.min.js"></script>
</body>
</html>
