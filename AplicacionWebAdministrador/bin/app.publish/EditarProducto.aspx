<%@ Page Title="" Language="C#" MasterPageFile="~/PaginasMaestras/Layout.Master" AutoEventWireup="true" CodeBehind="EditarProducto.aspx.cs" Inherits="AplicacionWebAdministrador.WebForm2" %>
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
                <form class="Formulario formulario" ID="FormularioNuevoProducto" runat="server">
                    <asp:Repeater ID="rptProducto" runat="server">
                        <ItemTemplate>
                            <div class="Area-Nombre">
                                <h3>Nombre del Producto:</h3>
                                <h2><%# Eval("Nombre") %></h2>
                            </div>
                            <div class="Area-Nombre">
                                <h3>Cantidad en el Stock:</h3>
                                <h2><%# Eval("Stock") %></h2>
                            </div>
                        </ItemTemplate>
                    </asp:Repeater>
                    <div class="Area-Stock">
                        <h3>Cambiar Cantidad en Stock:</h3>
                        <span><i class="fa-solid fa-list"></i></span>
                        <asp:TextBox class="Stock" type="number" ID="Txt_stock" runat="server" value="0"></asp:TextBox>
                    </div>
                    <div class="Area-Añadir">
                        <asp:Button class="Añadir" type="submit" runat="server" Text="Actualizar Stock" OnClick ="Actualizar_Click"/>
                    </div>
                    <div class="Area-Añadir">
                        <asp:Button class="Añadir" type="submit" runat="server" Text="Dar de baja Producto" OnClick="Desactivar"/>
                    </div>
                </form>     
                <asp:Repeater ID="rptProductoImagen" runat="server">
                    <ItemTemplate>
                        <div class="Imagenes">
                            <img class="Imagen-Producto" src="data:image/png;base64,<%# Convert.ToBase64String((byte[])Eval("Foto")) %>" />
                        </div>
                    </ItemTemplate>
                </asp:Repeater>
            </div>
        </div>
</asp:Content>
