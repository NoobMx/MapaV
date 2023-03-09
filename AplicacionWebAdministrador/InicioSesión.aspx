<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="InicioSesión.aspx.cs" Inherits="AplicacionWebAdministrador.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    
    <meta http-equiv="X-UA-Compatible" content="IE=edge" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <script src="https://kit.fontawesome.com/a3c9717c3d.js" crossorigin="anonymous"></script>
    <link href="./css/EstilosLogin.css" rel="stylesheet" />
    <title>Inicio de Sesion</title>
</head>
<body>
    <section class="grid-Section">
        <div class="Section-Tittle">
            <i class="fa-solid fa-right-to-bracket"></i>
            <h1>Iniciar Sesión</h1>
        </div>
        <div class="Section-Inputs">
            <form ID="form1" runat ="server">
                <div class="Area-Input_Name">
                    <h3 class="Tittles">Usuario</h3>
                    <i class="fa-solid fa-user Icons"></i>
                    <asp:TextBox  class="input-Text" type="text"  value="" required ID="NombreUsuario" runat="server" placeHolder="Nombre de Usuario"></asp:TextBox>
                </div>
                <div class="Area-Input_password">
                    <h3 class="Tittles" >Contraseña</h3>
                    <i class="fa-solid fa-lock Icons"></i>
                    <asp:TextBox  class="input-Password" type="password"  value="" required ID="Contraseña" runat="server" placeHolder="Contraseña"></asp:TextBox>
                    <i class="fa-solid fa-eye"></i>
                </div>
                <div class="Area-Input_Button">
                    <asp:Button class="button" type="submit" ID="Enviar" runat="server" Text="Iniciar Sesión" OnClick="Send_Click" />
                </div>
            </form>
        </div>
    </section>
    <section class="Image-Section">
        <div class="Area-Image">
            <img class="Image" src="https://images.pexels.com/photos/3423860/pexels-photo-3423860.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1" alt="Alternate Text" />
        </div>
    </section>
    <script src="./Dom/DOMLogin.js"></script>
</body>
</html>
