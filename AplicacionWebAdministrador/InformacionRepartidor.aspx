<%@ Page Title="" Language="C#" MasterPageFile="~/PaginasMaestras/Layout.Master" AutoEventWireup="true" CodeBehind="InformacionRepartidor.aspx.cs" Inherits="AplicacionWebAdministrador.WebForm6" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="Page_Seleccion">
            <h3 class="Pagina">Pagina&nbsp</h3>
            <h3 class="Seleccion">/&nbspRepartidores</h3>
            <h2 class="Titulo-Pagina">Información del Repartidor</h>
        </div>
        <div class="Contenido">
            <div class="Instrucciones">
                <h1>Edita la Información.</h1>
                <span><i class="fa-solid fa-pen"></i></span>
            </div>
            <form ID="fomr1" runat="server" class="Info-Repartidor">
                <div class="Area-Input_Nombre">
                    <h3 class="Tittles">Nombre Completo</h3>
                    <i class="fa-solid fa-user user-Icon IconsRR"></i>
                    <asp:TextBox class="Nombre-Input" type="text" required name="nombre" id="Nombre" value="Rodriguez Díaz Rodrigo" runat="server"></asp:TextBox>
                </div>
                <div class="numbers-Containers">
                    <div class="Area-Input_Edad">
                        <h3 class="Tittles">Edad</h3>
                        <i class="fa-solid fa-calendar IconsRR"></i>
                        <asp:TextBox class="Edad-Input" type="number" required name="Edad" ID="Edad" m="0" max="98" value="21" runat="server"></asp:TextBox>
                    </div>
                    <div class="Area-Input_Telefono">
                        <h3 class="Tittles">Numero Telefonico</h3>
                        <i class="fa-solid fa-phone IconsRR"></i>
                        <asp:TextBox class="Telefono-Input" type="number" name="name" ID="Telefono" value="5613067792" min="1" minlength="10" required runat="server" /></asp:TextBox>
                    </div> 
                </div>
                <div class="Area-Input_Direction">
                    <h3 class="Tittles">Dirección</h3>
                    <i class="fa-solid fa-location-dot IconsRR"></i>
                    <asp:TextBox  class="Direccion-Input" type="text" name="direccion" ID="Direccion" value="CDA. Rancho La Herradura Mz.74 Lt. C.100" required runat="server" /></asp:TextBox>
                </div>
                <div class="Area-Input_password">
                    <h3 class="Tittles" >Contraseña</h3>
                    <i class="fa-solid fa-lock IconsRR"></i>
                    <asp:TextBox class="input-Password" type="password" name="contraseña" ID="Contraseña" value="018938rodrigo" required  runat="server" /></asp:TextBox>
                    <i class="fa-solid fa-eye eye"></i>
                </div>
                <div class="Activar-Desactivar">
                    <asp:Button class="Desactivar" ID="Desactivar" Text="Desactivar" runat="server" />
                    <asp:Button class="Activar" ID="Activar" Text="Activar" runat="server" />
                </div>
                <div class="Area-Input_Button Button-Actualizar">
                    <asp:Button class="button Actualizar" ID="Actualizar" Text="Activar" type="submit" runat="server" />
                </div>
            </form>
        </div>
</asp:Content>
