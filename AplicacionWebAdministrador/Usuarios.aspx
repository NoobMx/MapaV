<%@ Page Title="" Language="C#" MasterPageFile="~/PaginasMaestras/Layout.Master" AutoEventWireup="true" CodeBehind="Usuarios.aspx.cs" Inherits="AplicacionWebAdministrador.WebForm12" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="Page_Seleccion">
        <h3 class="Pagina">Pagina&nbsp</h3>
        <h3 class="Seleccion">/&nbspUsuarios</h3>
        <h2 class="Titulo-Pagina">Usuarios</h>
    </div>
    <div class="Contenido">
        <div class="Area-InstruccionBuscar">
            <div class="Instrucciones Usuarios-Ins">
                <h1>Lista de Usuarios.</h1>
                <span><i class="fa-solid fa-user-group"></i></span>
            </div>
            <form class="Area-Buscar" action="./InformacionRepartidor.aspx" runat="server">
                <asp:TextBox class="Input-Search" type="text" name="Buscar-Usuario" placeholder="Busque al usuario" ID="buscar" runat="server" /></asp:TextBox>
                <asp:Button class="Button-Search" type="submit" Text=">" runat="server" />
            </form>                
        </div>
        <div class="Lista-Usuarios">
            <div class="Usuario-Area">
                <span class="IconoUsuario"><i class="fa-solid fa-user-large"></i></span>
                <h1 class="NombreRepartidor">1. Rodriguez Diaz Rodrigo</h1>
                <form action="./EditarUsuarios.html">
                    <input class="Input-NombreUsuario" type="text" value="RodrigoRodriguezDiaz" name="RodrigoRodriguezDiaz">
                    <button class="Button-InfoUsuario" type="submit"><i class="fa-solid fa-angle-right"></i></button>
                </form>
            </div>
            <div class="Repartidor-Area">
                <span class="IconoUsuario"><i class="fa-solid fa-user-large"></i></span>
                <h1 class="NombreRepartidor">2. Garcia Alvarado Juan Daniel</h1>
                <form action="./EditarUsuarios.html">
                    <input class="Input-NombreRepartidor" type="text" value="RodrigoRodriguezDiaz" name="RodrigoRodriguezDiaz">
                    <button class="Button-InfoUsuario" type="submit"><i class="fa-solid fa-angle-right"></i></button>
                </form>
            </div>
        </div>
    </div>
</asp:Content>
