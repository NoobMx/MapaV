<%@ Page Title="" Language="C#" MasterPageFile="~/PaginasMaestras/Layout.Master" AutoEventWireup="true" CodeBehind="AsignarHoras.aspx.cs" Inherits="AplicacionWebAdministrador.AsignarHoras" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="Page_Seleccion">
        <h3 class="Pagina">Pagina&nbsp</h3>
        <h3 class="Seleccion">/&nbspHoras</h3>
        <h2 class="Titulo-Pagina">Asignar Horas</h2>
    </div>
    <div class="Contenido">
        <div class="Instrucciones">
            <h1>Seleccione las horas de reparto.</h1>
            <span><i class="fa-solid fa-clock-rotate-left"></i></span>
        </div>
        <div class="Formulario-Horas">
            <form class="Formulario-Hora" id="FormularioNuevoProducto" runat="server">
                <asp:Repeater ID="rptHorario" runat="server">
                    <ItemTemplate>
                        <div>
                            <asp:CheckBox ID="ChekBox2" OnCheckedChanged="ChekBox2_CheckedChanged" runat="server" Text='<%# Eval("Nombre") %>' Checked='<%# Eval("Estatus") %>' value='<%# Eval("ID") %>' AutoPostBack="true" />
                        </div>
                    </ItemTemplate>
                </asp:Repeater>
                <div class="Button-Horas">
                    <asp:Button class="EnviarHoras" ID="Button1" runat="server" Text="Enviar Horas" OnClick="Actualizar" />
                </div>
            </form>
        </div>
    </div>
</asp:Content>
