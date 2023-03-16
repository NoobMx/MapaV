using AplicacionWebAdministrador.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AplicacionWebAdministrador
{
    public partial class WebForm8 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["nombreUsuario"] == null || Session["contraseña"] == null)
            {
                Response.Redirect("~/InicioSesión.aspx");
            }
            else
            {

            }

        }

        protected void Unnamed_Click(object sender, EventArgs e)
        {
            if (unidad1.Checked == false && unidad2.Checked == false)
            {

            }
            String unidad = "";
            if (unidad1.Checked)
            {
                unidad = unidad1.Text;
            }
            else if (unidad2.Checked)
            {
                unidad = unidad2.Text;
            }
            byte[] ImagenProducto = null;
            if (updImagenProducto.HasFile && updImagenProducto.PostedFile.ContentLength > 0 && updImagenProducto.PostedFile.ContentLength < 1000000)
            {
                using (var br = new BinaryReader(updImagenProducto.PostedFile.InputStream))
                {
                    ImagenProducto = br.ReadBytes(updImagenProducto.PostedFile.ContentLength);
                }
                Producto productoR = new Producto()
                {
                    Descripcion = Txt_Descripcion.Text,
                    Estatus = true,
                    Nombre = Txt_nombre.Text,
                    Precio = double.Parse(Txt_precio.Text),
                    Stock = double.Parse(Txt_stock.Text),
                    TipoUnidad = unidad,
                    Foto = ImagenProducto
                };
                Producto producto = new Producto();
                bool respuesta = producto.AgregarProducto(productoR);
                if (respuesta)
                {

                }
            }
            else
            {
                string script = "const espacio = document.querySelector('.Area-Añadir');" +
                    "espacio.innerHTML += `<p class='alerta'>No se pueden subir archivos mayor a un 1mb</p>`;";
                ClientScriptManager cs = Page.ClientScript;
                cs.RegisterStartupScript(this.GetType(), "MyScript", script, true);
            }
        }
    }
}