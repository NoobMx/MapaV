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
    public partial class WebForm11 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["nombreUsuario"] == null || Session["contraseña"] == null)
            {
                Response.Redirect("~/Index.aspx");
            }
            else
            {

            }
        }

        protected void Btn_Registrar_Click(object sender, EventArgs e)
        {
            byte[] ImagenRepartidor = null;
            if (updImagenRepartidor.HasFile && updImagenRepartidor.PostedFile.ContentLength > 0 && updImagenRepartidor.PostedFile.ContentLength < 1000000)
            {
                using (var br = new BinaryReader(updImagenRepartidor.PostedFile.InputStream))
                {
                    ImagenRepartidor = br.ReadBytes(updImagenRepartidor.PostedFile.ContentLength);
                }
                Repartidor repartidorR = new Repartidor()
                {
                    Nombre = Txt_nombre.Text,
                    NombreUsuario = Txt_nombreUsuario.Text,
                    Contraseña = Txt_contraseña.Text,
                    Correo = Txt_correo.Text,
                    Domicilio = Txt_direccion.Text,
                    NumeroTelefono = long.Parse(Txt_telefono.Text),
                    Estatus = true,
                    Foto = ImagenRepartidor
                };
                Repartidor repartidor = new Repartidor();
                bool respuesta = repartidor.RegistrarRepartidor(repartidorR);
                if (respuesta)
                {
                    ClientScript.RegisterStartupScript(this.GetType(), "Alerta", "alert('Repartidor Registrado');", true);
                }

                Response.Redirect("~/ListaRepartidores.aspx");
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