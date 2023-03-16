<%@ Page Title="" Language="C#" MasterPageFile="~/PaginasMaestras/layout.Master" AutoEventWireup="true" CodeBehind="Productos.aspx.cs" Inherits="AplicacionWebAdministrador.WebForm12" %>
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
             <form class="Formulario-Hora" ID="FormularioNuevoProducto" runat="server">
                 <div>
                     <asp:CheckBox ID="CheckBox1" runat="server" Text="07:00 a.m."/>
                     <asp:Label ID="Label1" runat="server" for="CheckBox1" ></asp:Label>
                 </div>
                 <div>
                     <asp:CheckBox ID="CheckBox2" runat="server" Text="08:00 a.m."/>
                     <asp:Label ID="Label2" runat="server" for="CheckBox1" ></asp:Label>
                 </div>
                 <div>
                     <asp:CheckBox ID="CheckBox3" runat="server" Text="09:00 a.m."/>
                     <asp:Label ID="Label3" runat="server" for="CheckBox1" ></asp:Label>
                 </div>
                 <div>
                     <asp:CheckBox ID="CheckBox4" runat="server" Text="10:00 a.m."/>
                     <asp:Label ID="Label4" runat="server" for="CheckBox1" ></asp:Label>
                 </div>
                 <div>
                     <asp:CheckBox ID="CheckBox5" runat="server" Text="11:00 a.m."/>
                     <asp:Label ID="Label5" runat="server" for="CheckBox1" ></asp:Label>
                 </div>
                 <div>
                     <asp:CheckBox ID="CheckBox6" runat="server" Text="12:00 a.m."/>
                     <asp:Label ID="Label6" runat="server" for="CheckBox1" ></asp:Label>
                 </div>
                 <div>
                     <asp:CheckBox ID="CheckBox7" runat="server" Text="01:00 p.m."/>
                     <asp:Label ID="Label7" runat="server" for="CheckBox1" ></asp:Label>
                 </div>
                 <div>
                     <asp:CheckBox ID="CheckBox8" runat="server" Text="02:00 p.m."/>
                     <asp:Label ID="Label8" runat="server" for="CheckBox1" ></asp:Label>
                 </div>
                 <div>
                     <asp:CheckBox ID="CheckBox9" runat="server" Text="03:00 p.m."/>
                     <asp:Label ID="Label9" runat="server" for="CheckBox1" ></asp:Label>
                 </div>
                 <div>
                     <asp:CheckBox ID="CheckBox10" runat="server" Text="04:00 p.m."/>
                     <asp:Label ID="Label10" runat="server" for="CheckBox1" ></asp:Label>
                 </div>
                 <div>
                     <asp:CheckBox ID="CheckBox11" runat="server" Text="05:00 p.m."/>
                     <asp:Label ID="Label11" runat="server" for="CheckBox1" ></asp:Label>
                 </div>
                 <div>
                     <asp:CheckBox ID="CheckBox12" runat="server" Text="06:00 p.m."/>
                     <asp:Label ID="Label12" runat="server" for="CheckBox1" ></asp:Label>
                 </div>
                 <div>
                     <asp:CheckBox ID="CheckBox13" runat="server" Text="07:00 p.m."/>
                     <asp:Label ID="Label13" runat="server" for="CheckBox1" ></asp:Label>
                 </div>
                 <div>
                     <asp:CheckBox ID="CheckBox14" runat="server" Text="08:00 p.m."/>
                     <asp:Label ID="Label14" runat="server" for="CheckBox1" ></asp:Label>
                 </div>
                 <div>
                     <asp:CheckBox ID="CheckBox15" runat="server" Text="09:00 p.m."/>
                     <asp:Label ID="Label15" runat="server" for="CheckBox1" ></asp:Label>
                 </div>
                 <div>
                     <asp:CheckBox ID="CheckBox16" runat="server" Text="10:00 p.m."/>
                     <asp:Label ID="Label16" runat="server" for="CheckBox1" ></asp:Label>
                 </div>
                 <div class="Button-Horas">
                     <asp:Button class="EnviarHoras" ID="Button1" runat="server" Text="Enviar Horas" />
                 </div>
             </form>
        </div>
    </div>
</asp:Content>