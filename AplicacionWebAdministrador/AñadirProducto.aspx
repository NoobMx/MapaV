<%@ Page Title="" Language="C#" MasterPageFile="~/PaginasMaestras/Layout.Master" AutoEventWireup="true" CodeBehind="AñadirProducto.aspx.cs" Inherits="AplicacionWebAdministrador.WebForm8" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="Page_Seleccion">
            <h3 class="Pagina">Pagina&nbsp</h3>
            <h3 class="Seleccion">/&nbspProductos</h3>
            <h2 class="Titulo-Pagina">Agregar Productos</h2>
        </div>
        <div class="Contenido">
            <div class="Instrucciones">
                <h1>Complete los campos solicitados.</h1>
                <span><i class="fa-solid fa-pen"></i></span>
            </div>
            <div class="Formulario-Imagenes">
                <form class="Formulario formulario" id="form1" runat="server">
                    <div class="Area-Nombre">
                        <h3>Asignar Nombre:</h3>
                        <span><i class="fa-solid fa-file-signature"></i></span>
                        <asp:TextBox class="Nombre" type="text" ID="Txt_nombre" runat="server" MaxLength="20" required></asp:TextBox>
                    </div>
                    <div class="Area-File file-select" id="src-file1">
                        <h3>Seleccione la Imagen del Producto:</h3>
                        <asp:FileUpload class="File SeleccionarImagen" accept="image/*" ID="updImagenProducto" runat="server"  arial-label="Imagen" required/>
                    </div>
                    <div class="Area-Radio">
                        <h3>Tipo de Unidad:</h3>
                        <asp:RadioButton class="Radio" type="radio" GroupName="unidad" ID="unidad1" runat="server" value="Kilo" Text="Kilo" required/>
                        <asp:RadioButton class="Radio" type="radio" GroupName="unidad" ID="unidad2" runat="server" value="Unidad" Text="Unidad" required/>
                    </div>
                    <div class="Area-Precio">
                        <h3>Precio del Producto:</h3>
                        <span><i class="fa-solid fa-dollar-sign"></i></span>
                        <asp:TextBox class="Precio" type="number" ID="Txt_precio" runat="server" required></asp:TextBox>
                    </div>
                    <div class="Area-Stock">
                        <h3>Cantidad en Stock:</h3>
                        <span><i class="fa-solid fa-list"></i></span>
                        <asp:TextBox class="Stock" type="number" ID="Txt_stock" runat="server" required></asp:TextBox>
                    </div>
                    <div class="Area-Descripcion">
                        <h3>Asignar Descripción:</h3>
                        <asp:TextBox class="textarea" ID="Txt_Descripcion" required runat="server"></asp:TextBox>
                    </div>
                    <div class="Area-Añadir">
                        <asp:Button class="Añadir" type="submit" runat="server" Text="Añadir Producto" OnClick ="Unnamed_Click"/>
                    </div>
                </form>     
                <div class="Imagenes">
                    <img class="previsulizacion" src="https://images.pexels.com/photos/64613/pexels-photo-64613.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1" alt="Alternate Text" />
                </div>
            </div>
        </div>
    <script>
        const archivo = document.querySelector(".SeleccionarImagen"),
            previsualizacion = document.querySelector(".previsulizacion");

        archivo.addEventListener("change", () => {
            const archivos = archivo.files;

            if (!archivos || !archivos.length) {
                previsualizacion.src = "";
                return;
            }

            const primerArchivo = archivos[0];

            const objectUrl = URL.createObjectURL(primerArchivo);

            previsualizacion.src = objectUrl;
        })
    </script>
</asp:Content>
