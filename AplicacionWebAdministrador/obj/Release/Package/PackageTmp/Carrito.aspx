<%@ Page Title="" Language="C#" MasterPageFile="~/PaginasMaestras/Layout.Master" AutoEventWireup="true" CodeBehind="Carrito.aspx.cs" Inherits="AplicacionWebAdministrador.Carrito" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="Page_Seleccion">
        <h3 class="Pagina">Pagina&nbsp</h3>
        <h3 class="Seleccion">/&nbspCompras Fisicas</h3>
        <h2 class="Titulo-Pagina">Carrito</h2>
    </div>
    <div class="Contenido">
        <div class="Barras">
            <div class="Titulo">
                <h1>Compre los Productos</h1>
                <label class="textoProductos"></label>
                <span class="div-cart"><i class="fa-solid fa-cart-shopping"></i></span>
            </div>
        </div>
        <div class="listaCarrito">
            <asp:Repeater ID="rptProductos" runat="server">
                <ItemTemplate>
                    <div class="listaCarrito__producto-container">
                        <div class="listaCarrito__nombre-producto">
                            <h2><%# Eval("Nombre") %></h2>
                        </div>
                        <div class="listaCarrito__numero-productos">
                            <h4>Numero de Productos:</h4>
                            <p><%# Eval("Stock") %></p>
                        </div>
                        <div class="listaCarrito__numero-productos">
                            <h4>Precio</h4>
                            <p>$ <%# Eval("Precio") %></p>
                        </div>
                        <div class="listaCarrito__producto-image">
                            <img class="Imagen-Producto-carrito" src="data:image/png;base64,<%# Convert.ToBase64String((byte[])Eval("Foto")) %>" />
                        </div>
                    </div>
                    <div class="line"></div>
                </ItemTemplate>
            </asp:Repeater>
            <div class="total-container">
                <h3>Total: $
                    <asp:Label ID="lblTotal" runat="server"></asp:Label></h3>
            </div>
            <form runat="server">
                <asp:Button class="Añadir" ID="Button1" runat="server" Text="Realizar Compra" OnClick="Button1_Click" />
            </form>
        </div>
    </div>
</asp:Content>
