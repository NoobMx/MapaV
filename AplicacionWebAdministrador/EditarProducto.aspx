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
                <%--<div class="Area-File file-select" id="src-file1">
                    <h3>Cambiar la Imagen del Producto</h3>
                    <asp:FileUpload class="File SeleccionarImagen" accept="image/jpeg" ID="updImagenProducto" runat="server" arial-label="Imagen" required/>
                </div>--%>
                <%--<div class="Area-Nombre">
                    <h3>Cambiar Nombre:</h3>
                    <span><i class="fa-solid fa-file-signature"></i></span>
                    <asp:TextBox class="Nombre" type="text" ID="Txt_nombre" runat="server" required></asp:TextBox>
                </div>
                <div class="Area-Radio">
                        <h3>Cambiar el Tipo de Unidad</h3>
                        <asp:RadioButton class="Radio" type="radio" GroupName="unidad" ID="unidad1" runat="server" value="Kilo" Text="Kilo" />
                        <asp:RadioButton class="Radio" type="radio" GroupName="unidad" ID="unidad2" runat="server" value="Unidad" Text="Unidad" />
                </div>
                <div class="Area-Precio">
                    <h3>Cambiar Precio del Producto:</h3>
                    <span><i class="fa-solid fa-dollar-sign"></i></span>
                    <asp:TextBox class="Precio" type="number" ID="Txt_precio" runat="server" required></asp:TextBox>
                </div>--%>
                <div class="Area-Stock">
                    <h3>Cambiar Cantidad en Stock:</h3>
                    <span><i class="fa-solid fa-list"></i></span>
                        <asp:TextBox class="Stock" type="number" ID="Txt_stock" runat="server" required></asp:TextBox>
                </div>
                <%--<div class="Area-Descripcion">
                    <h3>Cambiar la Descripcion:</h3>
                    <asp:TextBox class="textarea" ID="Txt_Descripcion" required runat="server"></asp:TextBox>
                </div>
                <div class="Area-Ocultar-Desocultar">
                    <div class="Espacio-Ocultar">
                        <asp:Button class="Ocultar" ID="Ocultar" runat="server" Text="Ocultar de la lista" />
                    </div>
                    <div class="Espacio-Desocultar">
                        <asp:Button class="Desocultar" ID="Desocultar" runat="server" Text="Des-Ocultar de la lista" />
                    </div>
                </div>--%>
                <div class="Area-Añadir">
                </div><asp:Button class="Añadir" type="submit" runat="server" Text="Añadir Producto" OnClick ="Actualizar_Click"/>
            </form>     
            <div class="Imagenes">
                <img class="previsulizacion" src="https://images.pexels.com/photos/3735149/pexels-photo-3735149.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1" alt="Alternate Text" />
            </div>
        </div>
    </div>
</asp:Content>
