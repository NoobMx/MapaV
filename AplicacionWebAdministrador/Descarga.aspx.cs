using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AplicacionWebAdministrador
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Descargar(object sender, EventArgs e)
        {
            Response.Clear();
            Response.ContentType = "application/vnd.android.package-archive";
            Response.AddHeader("Content-Disposition", "attachment; filename=Tienda.apk");
            Response.WriteFile(Server.MapPath(@"~/Aplicacion/Tienda.apk"));
            Response.Flush();
            Response.End();
        }
    }
}