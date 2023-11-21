<%@ Page Title="" Language="C#" MasterPageFile="~/PaginasMaestras/Layout.Master" AutoEventWireup="true" CodeBehind="PedidosMapas.aspx.cs" Inherits="AplicacionWebAdministrador.WebForm9" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script async
        src="https://maps.googleapis.com/maps/api/js?key=AIzaSyC-lMWBn1AxyjkF9G6ljsD2J07wpYlVWSk&libraries=places&callback=initMap">
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="Page_Seleccion">
        <h3 class="Pagina">Pagina&nbsp</h3>
        <h3 class="Seleccion">/&nbspPedidos</h3>
        <h2 class="Titulo-Pagina">Asignar Pedidos</h2>
    </div>
    <div class="Mapa-Tabla">
        <div id="map"></div>
        <div class="Area-Tabla">
            <form id="form1" runat="server">
                <script src="../Dom/Mapa.js"></script>
                <asp:GridView ID="tablaPedidos" runat="server" CssClass="gridview">
                </asp:GridView>
            </form>
            <%--Inicio--%>
            <div id="myModal" class="modal" onshow="myModal_Shown">
                <div class="modal-content">
                    <button class="btn-cross" onclick="cerrarModal()"><span><i class="fa-solid fa-xmark"></i></span></button>
                    <div id="formModal" class="inputs-content">
                        <h1>Selecciona un Repartidor:</h1>
                        <div id="listbox-container" class="listbox-container">
                            <select id="myListBox"></select>
                        </div>
                        <button id="enviarRepartidor" onclick="asignarRepartidor()">Asignar</button>
                    </div>
                </div>
            </div>
            <%--Fin--%>
        </div>
    </div>
</asp:Content>
