<%@ Page Title="" Language="C#" MasterPageFile="~/PaginasMaestras/Layout.Master" AutoEventWireup="true" CodeBehind="RegistrarRepartidor.aspx.cs" Inherits="AplicacionWebAdministrador.WebForm11" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="Page_Seleccion">
        <h3 class="Pagina">Pagina&nbsp</h3>
        <h3 class="Seleccion">/&nbspRepartidores</h3>
        <h2 class="Titulo-Pagina">Registrar Repartidor</h2>
    </div>
    <div class="Contenido">
        <div class="Instrucciones">
            <h1>Complete los campos.</h1>
            <span><i class="fa-solid fa-pen"></i></span>
        </div>
        <div class="Formulario-Imagenes">
            <form class="Formulario formulario" ID="form1" runat="server">
                <div class="Area-Input_Nombre">
                    <h3 class="Tittles">Nombre Completo</h3>
                    <i class="fa-solid fa-user user-Icon IconsRR"></i>
                    <asp:TextBox runat="server" ID="Nombre"  name="nombre" type="text" class="Nombre-Input" required/></asp:TextBox>
                </div>
                <div class="numbers-Containers">
                    <div class="Area-Input_Edad">
                        <h3 class="Tittles">Edad</h3>
                        <i class="fa-solid fa-calendar IconsRR"></i>
                        <asp:TextBox runat="server" ID="Edad" name="edad" class="Edad-Input" type="number" m="0" max="98" required/></asp:TextBox>
                    </div>
                    <div class="Area-Input_Telefono">
                        <h3 class="Tittles">Numero Telefonico</h3>
                        <i class="fa-solid fa-phone IconsRR"></i>
                        <asp:TextBox runat="server" ID="Telefono" class="Telefono-Input" type="number" name="telefono" value="" min="1" minlength="10" required/></asp:TextBox>
                    </div>
                </div>
                <div class="Area-Input_Direction">
                    <h3 class="Tittles">Dirección</h3>
                    <i class="fa-solid fa-location-dot IconsRR"></i>
                    <asp:TextBox runat="server" ID="Direccion" class="Direccion-Input" type="text" name="direccion" value="" required/></asp:TextBox>
                </div>
                <div class="Area-Input_password">
                    <h3 class="Tittles" >Contraseña</h3>
                    <i class="fa-solid fa-lock IconsRR"></i>
                    <asp:TextBox runat="server" ID="Contraseña" class="input-Password" type="password" name="contraseña" value="" required  /></asp:TextBox>
                    <i class="fa-solid fa-eye eye"></i>
                </div>
                <div class="Area-Input_Button">
                    <asp:Button class="button" type="submit" ID="Registrar" Text="Registrar" runat="server" />
                </div>
            </form>
            <div class="Imagenes">
                <div class="Imagen-Repartidor">
                </div>
            </div>
        </div>
    </div>
</asp:Content>
