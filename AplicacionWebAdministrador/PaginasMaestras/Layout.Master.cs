using AplicacionWebAdministrador.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AplicacionWebAdministrador.PaginasMaestras
{
    public partial class Site1 : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            NombreAdministrador.Text = Session["nombreUsuario"].ToString();
        }

        protected void Cerrar(object sender, EventArgs e)
        {
            Session.Abandon();
            Response.Redirect("~/InicioSesión.aspx");
        }
    }
}