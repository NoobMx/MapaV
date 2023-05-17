using AplicacionWebAdministrador.Models;
using HTTPupt;
using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AplicacionWebAdministrador
{
    public partial class WebForm4 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["nombreUsuario"] == null || Session["contraseña"] == null)
            {
                Response.Redirect("~/Index.aspx");

            }
            else
            {
                Producto productoO = new Producto();
                var listaproductos = JsonConvert.DeserializeObject<List<Producto>>(productoO.MostrarProductosActivos());
                ObservableCollection<ProductosDTO> productosDTO = new ObservableCollection<ProductosDTO>();
                listaproductos.ForEach(p =>
                {
                    productosDTO.Add(new ProductosDTO
                    {
                        ID = p.ID,
                        Nombre = p.Nombre,
                        Estatus = p.Estatus,
                        Precio = p.Precio,
                        Foto = p.Foto
                    });
                });
                rptProductos.DataSource = productosDTO;
                rptProductos.DataBind();
            }
        }

        

        protected void Button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}