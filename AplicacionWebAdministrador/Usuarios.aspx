<%@ Page Title="" Language="C#" MasterPageFile="~/PaginasMaestras/Layout.Master" AutoEventWireup="true" CodeBehind="Usuarios.aspx.cs" Inherits="AplicacionWebAdministrador.WebForm12" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="Page_Seleccion">
        <h3 class="Pagina">Pagina&nbsp</h3>
        <h3 class="Seleccion">/&nbspUsuarios</h3>
        <h2 class="Titulo-Pagina">Usuarios</h>
    </div>
    <div class="Contenido">
        <div class="Area-InstruccionBuscar">
            <div class="Instrucciones Usuarios-Ins">
                <h1>Lista de Clientes.</h1>
                <span><i class="fa-solid fa-user-group"></i></span>
            </div>             
        </div>
        <div class="Lista-Usuarios">
            <asp:Repeater ID="rptClientes" runat="server">
                <ItemTemplate>
                    <div class="Usuario-Area">
                        <h1 class="NombreUsuario"><%# Eval("Nombre") %></h1>
                        <h3 class="EstatusUsuario">Estatus: <%# Eval("Estatus") %></h3>
                        <form method="post" action="./EditarUsuarios.aspx">
                             <input class="ID-Producto" type="text" name="usuario" value="<%# Eval("ID") %>"/>
                            <button class="Button-InfoUsuario" type="submit"><i class="fa-solid fa-angle-right"></i></button>
                        </form>
                    </div>
                </ItemTemplate>
            </asp:Repeater>
            </div>
        </div>
    </div>
</asp:Content>
