<%@ Page Title="" Language="C#" MasterPageFile="~/PaginasMaestras/Layout.Master" AutoEventWireup="true" CodeBehind="EditarUsuarios.aspx.cs" Inherits="AplicacionWebAdministrador.WebForm3" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="Page_Seleccion">
            <h3 class="Pagina">Pagina&nbsp</h3>
            <h3 class="Seleccion">/&nbspUsuarios</h3>
            <h2 class="Titulo-Pagina">Editar Usuario</h>
        </div>
        <div class="Contenido">
            <div class="Area-InstruccionBuscar">
                <div class="Instrucciones Usuarios-Ins">
                    <h1>Activa o Desactiva al Usuario</h1>
                    <span><i class="fa-solid fa-pen"></i></span>
                </div>             
            </div>
            <div class="Informacion-Imagen">
                <div class="Area-Info_Usuario">
                    <div class="Area-Datos_Usuario">
                        <span><i class="fa-solid fa-user-large Icono-Usario Icono-Usuario-user"></i></span>
                        <h1>Nombre del Usuario:</h1>
                        <h3>Rodriguez Díaz Rodrigo</h3>
                    </div>
                    <div class="Area-Datos_Usuario">
                        <span><i class="fa-solid fa-calendar Icono-Usario Icono-Usuario-calendar"></i></span>
                        <h1>Edad:</h1>
                        <h3>19</h3>
                    </div>
                    <div class="Area-Datos_Usuario">
                        <span><i class="fa-solid fa-phone Icono-Usario Icono-Usuario-phone"></i></span>
                        <h1>Numero Telefonico:</h1>
                        <h3>5613067792</h3>
                    </div>
                    <div class="Area-Datos_Usuario">
                        <span><i class="fa-solid fa-star Icono-Usario Icono-Usuario-star"></i></span>
                        <h1>Calificación:</h1>
                        <h3>4.5</h3>
                    </div>
                    <form class="Activar-Desactivar Icono-Usario" ID="form1" runat="server">
                        <asp:Button class="button Desactivar" ID="Button1" runat="server" Text="Desactivar" />
                        <asp:Button class="button Activar" ID="Button2" runat="server" Text="Activar" />
                    </form>
                </div>
                <div class="Area-Imagen_Usuario">
                    <img class="Imagen-Usuario" src="https://images.pexels.com/photos/3585095/pexels-photo-3585095.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1" alt="">
                </div>
            </div>
        </div>
</asp:Content>
