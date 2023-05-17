<%@ Page Title="" Language="C#" MasterPageFile="~/PaginasMaestras/layout.Master" AutoEventWireup="true" CodeBehind="Productos.aspx.cs" Inherits="AplicacionWebAdministrador.WebForm7" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script src="js/Productos.js"></script>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="Page_Seleccion">
        <h3 class="Pagina">Pagina&nbsp</h3>
        <h3 class="Seleccion">/&nbspProductos</h3>
        <h2 class="Titulo-Pagina">Productos</h2>
    </div>
    <div class="Contenido">
        <div class="Barras">
            <div class="Titulo">
                <h1>Lista de Productos</h1>
                <label class="textoProductos">Numero de Productos:</label>
                <asp:Label class="numeroProductos" ID="NumeroProductos" runat="server" ></asp:Label>
                <span><i class="fa-solid fa-boxes-stacked"></i></span>
            </div>
            <form action="./AñadirProducto.aspx">
                <button class="Agregar-Productos" type="submit">
                    <h1>Agregar Productos</h1>
                    <span><i class="fa-solid fa-plus"></i></span>
                </button>
            </form>
        </div>  
        <div class="aparecer-lista-AP">
            <h1>Productos Activados:</h1>
            <button class="btn_ver"><span><i class="fa-solid fa-caret-down"></i></span></button>
        </div>
        <div class="Lista-Productos">
            <asp:Repeater ID="rptProductos" runat="server">
                <ItemTemplate>
                    <div class="Producto">
                        <div class="Imagen-Area">
                            <img class="Imagen-Producto" src="data:image/png;base64,<%# Convert.ToBase64String((byte[])Eval("Foto")) %>" />
                            <h2><%# Eval("Nombre") %></h2>
                            <form method="post" action="./EditarProducto.aspx">
                                <input class="ID-Producto" type="text" name="producto" value="<%# Eval("ID") %>"/>
                                <input class="ID-Producto" type="text" name="productoestatus" value="<%# Eval("Estatus") %>"/>
                                <button  class="Producto-Info" type="submit"><i class="fa-solid fa-chevron-right"></i></button>
                            </form>
                        </div>
                    </div>
                </ItemTemplate>
            </asp:Repeater>
        </div>
        <div class="aparecer-lista-AP">
            <h1>Productos Desactivados:</h1>
            <button class="btn_verD"><span><i class="fa-solid fa-caret-down"></i></span></button>
        </div>
        <div class="Lista-ProductosD">
            <asp:Repeater ID="rpt_ProductosDesactivados" runat="server">
                <ItemTemplate>
                    <div class="Producto">
                        <div class="Imagen-Area">
                            <img class="Imagen-Producto" src="data:image/png;base64,<%# Convert.ToBase64String((byte[])Eval("Foto")) %>" />
                            <h2><%# Eval("Nombre") %></h2>
                            <form method="post" action="./ActivarProducto.aspx">
                                <input class="ID-Producto" type="text" name="producto" value="<%# Eval("ID") %>"/>
                                <input class="ID-Producto" type="text" name="productoestatus" value="<%# Eval("Estatus") %>"/>
                                <button  class="Producto-Info" type="submit"><i class="fa-solid fa-chevron-right"></i></button>
                            </form>
                        </div>
                    </div>
                </ItemTemplate>
            </asp:Repeater>
        </div>
    </div>
    <script src="../Dom/VerLista.js"></script>
</asp:Content>
