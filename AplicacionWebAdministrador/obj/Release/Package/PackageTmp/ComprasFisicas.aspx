<%@ Page Title="" Language="C#" MasterPageFile="~/PaginasMaestras/Layout.Master" AutoEventWireup="true" CodeBehind="ComprasFisicas.aspx.cs" Inherits="AplicacionWebAdministrador.WebForm4" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="Page_Seleccion">
        <h3 class="Pagina">Pagina&nbsp</h3>
        <h3 class="Seleccion">/&nbspCompras Fisicas</h3>
        <h2 class="Titulo-Pagina">Compras Fisicas</h2>
    </div>
    <div class="Contenido">
        <div class="Barras">
            <div class="Titulo">
                <h1>Seleccione los Productos</h1>
                <label class="textoProductos"></label>
                <span class="div-cart"><i class="fa-solid fa-cart-shopping"></i></span>
            </div>
            <form action="./Carrito.aspx">
                <button class="Agregar-Productos" type="submit">
                    <h1>Ir al Carrito</h1>
                    <span><i class="fa-solid fa-caret-right"></i></span>
                </button>
            </form>
        </div>
        <div class="Lista-Productos">
            <asp:Repeater ID="rptProductos" runat="server">
                <ItemTemplate>
                    <div class="Producto">
                        <div class="Imagen-Area">
                            <img class="Imagen-Producto" src="data:image/png;base64,<%# Convert.ToBase64String((byte[])Eval("Foto")) %>" />
                            <h2><%# Eval("Nombre") %></h2>
                            <form method="post" action="./AgregarProducto.aspx">
                                <input class="ID-Producto" type="text" name="producto" value="<%# Eval("ID") %>"/>
                                <input class="ID-Producto" type="text" name="Nombre" value="<%# Eval("Nombre") %>"/>
                                <input class="ID-Producto" type="text" name="Precio" value="<%# Eval("Precio") %>"/>
                                <input class="ID-Producto" type="text" name="productoestatus" value="<%# Eval("Estatus") %>"/>
                                <button  class="Producto-Info" type="submit">+</button>
                            </form>
                        </div>
                    </div>
                </ItemTemplate>
            </asp:Repeater>
        </div>
</asp:Content>
