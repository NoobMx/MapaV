<%@ Page Title="" Language="C#" MasterPageFile="~/PaginasMaestras/Layout.Master" AutoEventWireup="true" CodeBehind="HistorialPedidos.aspx.cs" Inherits="AplicacionWebAdministrador.WebForm15" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script async
        src="https://maps.googleapis.com/maps/api/js?key=AIzaSyAHvurKpkmk7qWjNtAt8MAW-En9ezyYoaM&callback=initMap">
    </script>

    <script src="../Dom/mapaComp.js"></script>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="Page_Seleccion">
        <h3 class="Pagina">Pagina&nbsp</h3>
        <h3 class="Seleccion">/&nbspPedidos</h3>
        <h2 class="Titulo-Pagina">Historial de Pedidos</h2>
    </div>
    <div class="Contenido">
        <div class="Barras">
            <div class="Titulo">
                <h1>Lista de Pedidos Realizados</h1>
                <span><i class="fa-solid fa-pen"></i></span>
            </div>
        </div>
        <div class="Mapa-Tabla">
            <div class="Area-Tabla">
                <form id="formOne" runat="server">
                    <div class="Area-Inputs_Fechas">
                        <div class="Area-Inputs_Fechas-containers">
                            <h4>Fecha de Inicial:</h4>
                            <asp:TextBox ID="FechaInicio" TextMode="DateTimeLocal" cultureinfo="en-US" runat="server" required></asp:TextBox>
                        </div>
                        <div class="Area-Inputs_Fechas-containers">
                            <h4>Fecha Final:</h4>
                            <asp:TextBox ID="FechaFinal" TextMode="DateTimeLocal" cultureinfo="en-US" runat="server" required></asp:TextBox>
                        </div>
                        <asp:Button ID="Button1" runat="server" class="btn-enviarFecha" Text="Consultar Pedidos" OnClick="ConsultarPedidos" />
                    </div>
                    <div id="map"></div>
                    <asp:GridView ID="tblPedidosEntregados" runat="server" CssClass="gridview">
                    </asp:GridView>
                </form>
                <div class="total-container">
                    <h3>Total: $
                    <asp:Label ID="lblTotal" runat="server"></asp:Label></h3>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
