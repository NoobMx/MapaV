using AplicacionWebAdministrador.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AplicacionWebAdministrador
{
    public partial class Carrito : System.Web.UI.Page
    {
        List<Producto> listaProductos = new List<Producto>();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["nombreUsuario"] == null || Session["contraseña"] == null)
            {
                Response.Redirect("~/Index.aspx");
            }
            else
            {
                if (Session["listaProductos"] != null)
                {
                    listaProductos = (List<Producto>)Session["listaProductos"];
                }
                else
                {
                    listaProductos = new List<Producto>();
                }

                rptProductos.DataSource = listaProductos;
                rptProductos.DataBind();

                double total = 0;
                foreach (Producto producto in listaProductos)
                {
                    total += producto.Precio;
                }

                lblTotal.Text = total.ToString("0.00");
            }
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            DateTime dateTime = DateTime.Now;
            Pedido pedido = new Pedido();
            Pedido pedidoR = new Pedido()
            {
                ClienteID = 4,
                HorarioID = 8,
                LatitudPedido = 19.696076,
                LongitudPedido = -99.064347,
                DiaPedido = dateTime,
                Estatus = false,
                TotalPrecioProductos = listaProductos.Sum(p => p.Precio),
            };
            Pedido pedidoP = pedido.CompraFisica(pedidoR);
            PedidoProducto pedidoProducto = new PedidoProducto();
            List<PedidoProducto> pedidoProductoR = new List<PedidoProducto>();
            listaProductos.ForEach(p =>
            {
                pedidoProductoR.Add(new PedidoProducto
                {
                    Cantidad = p.Cantidad,
                    PedidoID = pedidoP.ID,
                    ProductoID = p.ID
                });
            });
            bool resp = pedidoProducto.RegistrarPedidoProducto(pedidoProductoR);
            if (resp)
            {
                ClientScript.RegisterStartupScript(this.GetType(), "Alerta", "alert('Compra realizada');", true);
                listaProductos.Clear();
                Response.Redirect("~/ComprasFisicas.aspx");
            }
        }
    }
}