<%@ Page Title="" Language="C#" MasterPageFile="~/PaginasMaestras/Layout.Master" AutoEventWireup="true" CodeBehind="RegistrarRepartidor.aspx.cs" Inherits="AplicacionWebAdministrador.WebForm11" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="Page_Seleccion">
        <h3 class="Pagina">Pagina&nbsp</h3>
        <h3 class="Seleccion">/&nbspRepartidores</h3>
        <h2 class="Titulo-Pagina">Registrar Repartidor</h2>
    </div>
    <div class="Contenido">
        <div class="Instrucciones">
            <h1>Complete los campos.</h1>
            <span><i class="fa-solid fa-pen"></i></span>
        </div>
        <div class="Formulario-Imagenes">
            <form class="Formulario formulario" ID="form1" runat="server">
                <div class="Area-File file-select" id="src-file1">
                    <h3>Foto del Repartidor</h3>
                    <asp:FileUpload class="File SeleccionarImagen" accept="image/*" ID="updImagenRepartidor" runat="server"  arial-label="Imagen" required/>
                </div>
                <div class="Area-Input_Nombre">
                    <h3 class="Tittles">Nombre Completo</h3>
                    <span class="IconsRR"> <i class="fa-solid fa-user user-Icon"></i></span>
                    <asp:TextBox runat="server" ID="Txt_nombre"  name="nombre" type="text" class="Nombre-Input Input_RU" required/></asp:TextBox>
                </div>
                <div class="Area-Input_Nombre">
                    <h3 class="Tittles">Nombre de Usuario</h3>
                    <span class="IconsRR"><i class="fa-solid fa-user user-Icon"></i></span>
                    <asp:TextBox runat="server" ID="Txt_nombreUsuario"  name="nombre" type="text" class="Nombre-Input Input_RU" required/></asp:TextBox>
                </div>
                <div class="Area-Input_Telefono">
                    <h3 class="Tittles">Numero Telefonico</h3>
                    <span class="IconsRR"><i class="fa-solid fa-phone"></i></span>
                    <asp:TextBox runat="server" ID="Txt_telefono" class="Nombre-Input Input_RU" type="number" name="telefono Input_RU" value="" min="1" minlength="10" required/></asp:TextBox>
                </div>
                <div class="Area-Input_Telefono">
                    <h3 class="Tittles">Corre Electronico</h3>
                    <span class="IconsRR"><i class="fa-solid fa-envelope"></i></span>
                    <asp:TextBox runat="server" ID="Txt_correo" class="Nombre-Input Input_RU" type="mail" name="telefono" value="" min="1" minlength="10" required/></asp:TextBox>
                </div>
                <div class="Area-Input_Direction">
                    <h3 class="Tittles">Dirección</h3>
                    <span class="IconsRR"><i class="fa-solid fa-location-dot"></i></span>
                    <asp:TextBox runat="server" ID="Txt_direccion" class="Direccion-Input Input_RU" type="text" name="direccion" value="" required /></asp:TextBox>
                </div>
                <div class="Area-Input_password">
                    <h3 class="Tittles" >Contraseña</h3>
                    <span class="IconsRR"><i class="fa-solid fa-lock"></i></span>
                    <asp:TextBox runat="server" ID="Txt_contraseña" class="input-Password InputC_RU" type="password" name="contraseña" value="" required  /></asp:TextBox>
                    <span class="eye"><i class="fa-solid fa-eye"></i></span>
                </div>
                <div class="Area-Input_Button">
                    <asp:Button class="button" type="submit" ID="Btn_Registrar" Text="Registrar" runat="server" Onclick="Btn_Registrar_Click"/>
                </div>
            </form>
            <div class="Imagenes">
                <img class="previsulizacion" src="https://images.pexels.com/photos/64613/pexels-photo-64613.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1" alt="Alternate Text" />
            </div>
        </div>
    </div>
    <script src="../Dom/DOMLogin.js"></script>
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
