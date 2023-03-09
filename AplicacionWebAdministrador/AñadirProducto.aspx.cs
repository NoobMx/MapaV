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

        }

        protected void Unnamed_Click(object sender, EventArgs e)
        {
            if(unidad1.Checked == false && unidad2.Checked == false)
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
            if (updImagenProducto.HasFile && updImagenProducto.PostedFile.ContentLength > 0)
            {
                using (var br = new BinaryReader(updImagenProducto.PostedFile.InputStream))
                {
                    ImagenProducto = br.ReadBytes(updImagenProducto.PostedFile.ContentLength);
                }
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
            if (respuesta) { 

            }
        }
    }
}