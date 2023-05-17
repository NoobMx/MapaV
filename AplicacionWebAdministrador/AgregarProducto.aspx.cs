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
    public partial class AgregarProducto : System.Web.UI.Page
    {
        private List<Producto> listaProductos;
        public static int ProductoID;
        public static bool ProductoEstatus;
        public static string ProductoNombre;
        public static double ProductoPrecio;

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
                    ProductoNombre = Request.Form["Nombre"];
                    ProductoPrecio = double.Parse(Request.Form["Precio"]);
                    ProductoEstatus = bool.TryParse(Request.Form["productoestatus"], out ProductoEstatus);
                    Producto productoO = new Producto();
                    var listaproductos = JsonConvert.DeserializeObject<List<Producto>>(productoO.MostrarProductosActivos());
                    ObservableCollection<ProductosDTO> productosDTO = new ObservableCollection<ProductosDTO>();
                    listaproductos.ForEach(p =>
                    {
                        productosDTO.Add(new ProductosDTO
                        {
                            ID = p.ID,
                            Nombre = p.Nombre,
                            Foto = p.Foto,
                            Cantidad = p.Cantidad,
                            Precio = p.Precio,
                            Stock = p.Stock
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
                    if (Session["listaProductos"] != null)
                    {
                        listaProductos = (List<Producto>)Session["listaProductos"];
                    }
                    else
                    {
                        listaProductos = new List<Producto>();
                    }
                }
            }
        }

        protected void ActualizarStock(object sender, EventArgs e)
        {
            double stock;
            if (double.TryParse(Txt_stock.Text, out stock) && stock >= 0)
            {
                Producto producto = new Producto()
                {
                    ID = ProductoID,
                    Stock = stock,
                    Nombre = ProductoNombre,
                    Cantidad = stock,
                    Precio = (ProductoPrecio * stock),
                    Foto = GetProductoFoto(ProductoID)
                };

                if (Session["listaProductos"] != null)
                {
                    listaProductos = (List<Producto>)Session["listaProductos"];

                    Producto productoExistente = listaProductos.FirstOrDefault(p => p.ID == producto.ID);
                    if (productoExistente != null)
                    {
                        productoExistente.Stock += producto.Stock;
                    }
                    else
                    {
                        listaProductos.Add(producto);
                    }
                }
                else
                {
                    listaProductos = new List<Producto>();
                    listaProductos.Add(producto);
                }

                Session["listaProductos"] = listaProductos;

                Response.Redirect("~/ComprasFisicas.aspx");
            }
            else
            {
                Response.Redirect("~/ComprasFisicas.aspx");
            }
        }





        private byte[] GetProductoFoto(int productoID)
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
                    Precio = p.Precio,
                    Foto = p.Foto,
                    Cantidad = p.Cantidad,
                    Stock = p.Stock,
                });
            });
            var productoEncontrado = productosDTO.FirstOrDefault(p => p.ID == productoID);
            if (productoEncontrado != null)
            {
               
                return productoEncontrado.Foto;
            }
            else
            {
                return null;

            }
        }
    }
}