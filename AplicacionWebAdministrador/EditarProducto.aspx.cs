using AplicacionWebAdministrador.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AplicacionWebAdministrador
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        public static int ProductoID;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["nombreUsuario"] == null || Session["contraseña"] == null)
            {
                Response.Redirect("~/InicioSesión.aspx");
            }
            else {
                if (!string.IsNullOrEmpty(Request.Form["producto"]))
                {
                    ProductoID = int.Parse(Request.Form["producto"]);
                    Producto productoO = new Producto();
                    var listaproductos = JsonConvert.DeserializeObject<List<Producto>>(productoO.MostrarProductos());
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
        protected void Actualizar_Click(object sender, EventArgs e)
        {
            Producto producto = new Producto();
            double stock = double.Parse(Txt_stock.Text);
            Producto productoStock = new Producto()
            {
                ID = ProductoID,
                Stock = stock
            };
            if (producto.ActualizarStock(productoStock))
            {
                //Alerta
            }
            Response.Redirect("~/Productos.aspx");
        }
        protected void Desactivar(object sender, EventArgs e)
        {
            Producto producto = new Producto();
            int? productoID = ProductoID;
            bool resp = producto.DesactivarProducto(productoID.Value);

            if (productoID.HasValue && resp)
            {
                //Alerta
            }
            Response.Redirect("~/Productos.aspx");
        }
    }

}