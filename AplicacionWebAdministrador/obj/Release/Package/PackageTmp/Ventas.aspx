<%@ Page Title="" Language="C#" MasterPageFile="~/PaginasMaestras/Layout.Master" AutoEventWireup="true" CodeBehind="Ventas.aspx.cs" Inherits="AplicacionWebAdministrador.Ventas" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="Page_Seleccion">
        <h3 class="Pagina">Pagina&nbsp</h3>
        <h3 class="Seleccion">/&nbspVentas</h3>
        <h2 class="Titulo-Pagina">Historial Ventas</h2>
    </div>
    <div class="Area-VistaVentas">
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
                    <asp:Button ID="Button1" runat="server" class="btn-enviarFecha" Text="Consultar Ventas" OnClick="ConsultarPedidos" />
                </div>
                </asp:GridView>
                <asp:GridView ID="tblPedidosEntregados" runat="server" CssClass="gridview">
                </asp:GridView>
            </form>
            <div class="total-container">
                <h3>Total: $
                    <asp:Label ID="lblTotal" runat="server"></asp:Label>

                </h3>
            </div>
        </div>
    </div>
</asp:Content>
