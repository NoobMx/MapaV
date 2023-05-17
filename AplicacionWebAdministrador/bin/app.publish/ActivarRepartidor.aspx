<%@ Page Title="" Language="C#" MasterPageFile="~/PaginasMaestras/Layout.Master" AutoEventWireup="true" CodeBehind="ActivarRepartidor.aspx.cs" Inherits="AplicacionWebAdministrador.WebForm17" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="Page_Seleccion">
        <h3 class="Pagina">Pagina&nbsp</h3>
        <h3 class="Seleccion">/&nbspProductos</h3>
        <h2 class="Titulo-Pagina">Información del Producto</h2>
    </div>
        <div class="Contenido">
            <div class="Instrucciones">
                <h1>Edita la Información.</h1>
                <span><i class="fa-solid fa-pen"></i></span>
            </div>
            <div class="Formulario-Imagenes ">
                <form ID="fomr1" runat="server" class="Info-Repartidor">
                    <asp:Repeater ID="rptRepartidor" runat="server">
                        <ItemTemplate>
                            <div class="Area-Nombre">
                                <h3>Nombre del repartidor:</h3>
                                <h2><%# Eval("Nombre") %></h2>
                            </div>
                            <div class="Area-Nombre">
                                <h3>Telefono:</h3>
                                <h2><%# Eval("NumeroTelefono") %></h2>
                            </div>
                            <div class="Area-Nombre">
                                <h3>Calificación:</h3>
                                <h2><%# Eval("Calificacion") %></h2>
                            </div>
                        </ItemTemplate>
                    </asp:Repeater>
                    <div class="Area-Añadir">
                        <asp:Button class="Añadir" type="submit" runat="server" Text="Activar" OnClick="Activar"/>
                    </div>
                </form>   
                <asp:Repeater ID="rptRepartidorFoto" runat="server">
                    <ItemTemplate>
                        <div class="Imagenes">
                            <img class="Imagen-Producto" src="data:image/png;base64,<%# Convert.ToBase64String((byte[])Eval("Foto")) %>" />
                        </div>
                    </ItemTemplate>
                </asp:Repeater>
            </div>
        </div>
</asp:Content>
