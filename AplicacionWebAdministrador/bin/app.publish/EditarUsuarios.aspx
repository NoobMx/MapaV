<%@ Page Title="" Language="C#" MasterPageFile="~/PaginasMaestras/Layout.Master" AutoEventWireup="true" CodeBehind="EditarUsuarios.aspx.cs" Inherits="AplicacionWebAdministrador.WebForm3" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="Page_Seleccion">
            <h3 class="Pagina">Pagina&nbsp</h3>
            <h3 class="Seleccion">/&nbspUsuarios</h3>
            <h2 class="Titulo-Pagina">Editar Usuario</h2>
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
                  <form ID="fomr1" runat="server" class="Info-Usuario">
                    <asp:Repeater ID="rptUsuario" runat="server">
                        <ItemTemplate>
                            <div class="Area-Nombre">
                                <h3>Nombre del Cliente:</h3>
                                <h2><%# Eval("Nombre") %></h2>
                            </div>
                            <div class="Area-Nombre">
                                <h3>Telefono:</h3>
                                <h2><%# Eval("NumeroTelefono") %></h2>
                            </div>
                        </ItemTemplate>
                    </asp:Repeater>
                    <div class="Area-Añadir">
                        <asp:Button class="Añadir" type="submit" runat="server" Text="Desactivar" OnClick="Desactivar_Click"/>
                    </div>
                </form>   
                </div>
                <div class="Area-Imagen_Usuario">
                    <img class="Imagen-Usuario" src="https://images.pexels.com/photos/3585095/pexels-photo-3585095.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1" alt="">
                </div>
            </div>
        </div>
</asp:Content>
