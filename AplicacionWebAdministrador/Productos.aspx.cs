using AplicacionWebAdministrador.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AplicacionWebAdministrador
{
    public partial class WebForm7 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["nombreUsuario"] == null || Session["contraseña"] == null)
            {
                Response.Redirect("~/InicioSesión.aspx");
            }
            else
            {
                Producto productoO = new Producto();
                var listaproductos = JsonConvert.DeserializeObject<List<Producto>>(productoO.MostrarProductos());
                ObservableCollection<ProductosDTO> productosDTO = new ObservableCollection<ProductosDTO>();
                listaproductos.ForEach(p =>
                {
                    if (p.Estatus == true)
                    {
                        productosDTO.Add(new ProductosDTO
                        {
                            ID = p.ID,
                            Nombre = p.Nombre,
                            Estatus = true,
                            Foto = p.Foto
                        });
                    }
                });
                NumeroProductos.Text = productosDTO.Count.ToString();
                rptProductos.DataSource = productosDTO;
                rptProductos.DataBind();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

        }
    }
}