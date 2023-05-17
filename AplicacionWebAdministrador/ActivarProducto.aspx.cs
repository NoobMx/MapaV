using AplicacionWebAdministrador.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AplicacionWebAdministrador
{
    public partial class WebForm16 : System.Web.UI.Page
    {
        public static int ProductoID;
        public static bool ProductoEstatus;
        protected void Page_Load(object sender, EventArgs e)
        {   
            if (Session["nombreUsuario"] == null || Session["contraseña"] == null)
            {
                Response.Redirect("~/Index.aspx");
            }
            else
            {
                if (!string.IsNullOrEmpty(Request.Form["producto"]))
                {
                    ProductoID = int.Parse(Request.Form["producto"]);
                    ProductoEstatus = bool.TryParse(Request.Form["productoestatus"].ToString(), out ProductoEstatus);
                    Producto productoO = new Producto();
                    var listaproductos = JsonConvert.DeserializeObject<List<Producto>>(productoO.MostrarProductosInactivos());
                    ObservableCollection<ProductosDTO> productosDTO = new ObservableCollection<ProductosDTO>();
                    listaproductos.ForEach(p =>
                    {
                        productosDTO.Add(new ProductosDTO
                        {
                            ID = p.ID,
                            Nombre = p.Nombre,
                            Foto = p.Foto,
                            Stock = p.Stock,
                        });
                    });
                    ProductosDTO productoEncontrado = productosDTO.FirstOrDefault(p => p.ID == ProductoID);
                    if (productoEncontrado != null)
                    {
                        rptProducto.DataSource = new List<ProductosDTO>() { productoEncontrado };
                        rptProducto.DataBind();
                    }
                    if (productoEncontrado != null)
                    {
                        rptProductoImagen.DataSource = new List<ProductosDTO>() { productoEncontrado };
                        rptProductoImagen.DataBind();
                    }
                }
            }
        }

        protected void Activar(object sender, EventArgs e)
        {
            Producto producto = new Producto();
            int? productoID = ProductoID;
            bool productoEstatus = ProductoEstatus;
            bool resp = producto.CambiarEstatusProducto(productoID.Value, productoEstatus);

            if (productoID.HasValue && resp)
            {

            }
            Response.Redirect("~/Productos.aspx");
        }
    }
}