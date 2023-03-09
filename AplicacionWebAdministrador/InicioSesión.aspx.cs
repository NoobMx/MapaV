using AplicacionWebAdministrador.Models;
using HTTPupt;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AplicacionWebAdministrador
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Send_Click(object sender, EventArgs e)
        {
            Administrador administrador = new Administrador()
            {
                NombreUsuario = NombreUsuario.Text,
                Contraseña  = Contraseña.Text
            };
            Administrador objAdmin = new Administrador();
            String adminV = objAdmin.ValidarAdministrador(administrador);
            if (adminV != "null")
            {
                Response.Redirect("~/Productos.aspx");
            }
            else
            {
                
            }
        }
    }
}