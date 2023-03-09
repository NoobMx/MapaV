<%@ Page Title="" Language="C#" MasterPageFile="~/PaginasMaestras/layout.Master" AutoEventWireup="true" CodeBehind="Productos.aspx.cs" Inherits="AplicacionWebAdministrador.WebForm7" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
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
                <h4>Numero de Productos: 48</h4>
                <span><i class="fa-solid fa-boxes-stacked"></i></span>
            </div>
            <form action="./AñadirProducto.aspx" >
                <button class="Agregar-Productos" type="submit">
                    <h1>Agregar Productos</h1>
                    <span><i class="fa-solid fa-plus"></i></span>
                </button>
            </form>
        </div>
        <div class="Lista-Productos">
            <div class="Producto">
                <div class="Imagen-Area">
                    <img class="Imagen-Producto" src="https://images.pexels.com/photos/2983100/pexels-photo-2983100.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1" alt="Alternate Text" />
                    <h2>Coca Cola</h2>
                    <form action="./EditarProducto.aspx">
                        <button class="Producto-Info"><i class="fa-solid fa-chevron-right"></i></button>
                    </form>
                </div>
            </div> 
            <div class="Producto">
                <div class="Imagen-Area">
                    <img class="Imagen-Producto" src="https://images.pexels.com/photos/3735149/pexels-photo-3735149.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1" alt="Alternate Text" />
                    <h2 class="h2">Jabón</h2>
                    <form action="./EditarProducto.aspx">
                        <button class="Producto-Info"><i class="fa-solid fa-chevron-right"></i></button>
                    </form>
                </div>
            </div> 
        </div>
    </div>
</asp:Content>
