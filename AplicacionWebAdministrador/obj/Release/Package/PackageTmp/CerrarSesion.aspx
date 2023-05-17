<%@ Page Title="" Language="C#" MasterPageFile="~/PaginasMaestras/Layout.Master" AutoEventWireup="true" CodeBehind="CerrarSesion.aspx.cs" Inherits="AplicacionWebAdministrador.WebForm14" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="Page_Seleccion">
        <h3 class="Pagina">Pagina&nbsp</h3>
        <h3 class="Seleccion">/&nbspSesión</h3>
        <h2 class="Titulo-Pagina">Cerrar Sesión</h2>
    </div>
    <div class="Contenido">
        <div class="Instrucciones">
            <h1>¿Estas seguro de cerrar sesión?</h1>
            <span><i class="fa-solid fa-clock-rotate-left"></i></span>
        </div>
        <form runat="server" class="btns-cerrarsesion">
            <div>
                <asp:Button ID="Cerrar" runat="server" Text="Si" class="btn-si" OnClick="Cerrar_Click"/>
            </div>
            <div>
                <asp:Button ID="Redirigir" runat="server" Text="No" class="btn-no" OnClick="Redirigir_Click"/>
            </div>
        </form>
    </div>
</asp:Content>
