<%@ Page Title="" Language="C#" MasterPageFile="~/PaginasMaestras/Layout.Master" AutoEventWireup="true" CodeBehind="ListaRepartidores.aspx.cs" Inherits="AplicacionWebAdministrador.WebForm10" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="Page_Seleccion">
        <h3 class="Pagina">Pagina&nbsp</h3>
        <h3 class="Seleccion">/&nbspRepartidores</h3>
        <h2 class="Titulo-Pagina">Repartidores</h2>
    </div>
    <div class="Contenido">
        <div class="Area-InstruccionBuscar">
            <div class="Instrucciones Repartidores-Ins">
                <h1>Lista de Repartidores.</h1>
                <span><i class="fa-solid fa-people-carry-box"></i></span>
            </div>            
        </div>
        <div class="Lista-Repartidores">
                <asp:Repeater ID="rptRepartidores" runat="server">
                    <ItemTemplate>
                        <div class="Repartidor-Area">
                            <div class="Contenedor-Imagen_Repartidor">
                                <img class="Imagen-Repartidor" src="data:image/png;base64,<%# Convert.ToBase64String((byte[])Eval("Foto")) %>" alt="Alternate Text" />
                            </div>
                            <h1 class="NombreRepartidor"><%# Eval("Nombre") %></h1>
                            <h3 class="EstatusRepartidor">Estatus: <%# Eval("Estatus") %></h3>
                            <h3 class="EstatusRepartidor">Calificacion: <%# Eval("Calificacion") %></h3>
                            <form method="post" action="./InformacionRepartidor.aspx">
                                <input class="ID-Producto" type="text" name="repartidor" value="<%# Eval("ID") %>"/>
                                <input class="ID-Producto" type="text" name="repartidorestatus" value="<%# Eval("Estatus") %>"/>
                                <button  class="Button-InfoUsuario" type="submit"><i class="fa-solid fa-chevron-right"></i></button>
                            </form>                           
                        </div>
                    </ItemTemplate>
                </asp:Repeater>
        </div>
    </div>
</asp:Content>
