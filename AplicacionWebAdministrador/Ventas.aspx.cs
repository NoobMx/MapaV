using AplicacionWebAdministrador.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AplicacionWebAdministrador
{
    public partial class Ventas : System.Web.UI.Page
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
        protected void ConsultarPedidos(object sender, EventArgs e)
        {
            Pedido pedido = new Pedido();
            List<PedidoProductoVentaDTO> ventaList = pedido.MostrarVentas(FechaInicio.Text, FechaFinal.Text);
            List<PedidoProductoVentaDTO> productos = new List<PedidoProductoVentaDTO>();
            ventaList.ForEach(p =>
            {
                    productos.Add(p);
            });
            List<PedidoProductoVentaDTO> pedidoProductos = new List<PedidoProductoVentaDTO>();
            ventaList.ForEach((p) =>
            {
                pedidoProductos.Add(
                    new PedidoProductoVentaDTO
                    {
                        Nombre = p.Nombre,
                        Cantidad = p.Cantidad,
                        TotalVendido = p.TotalVendido
                    });
            });
            tblPedidosEntregados.DataSource = pedidoProductos.OrderBy(p => p.Nombre);
            tblPedidosEntregados.DataBind();

            if (pedidoProductos.Count > 0)
            {
                tblPedidosEntregados.HeaderRow.Cells[1].Text = "Nombre";
                tblPedidosEntregados.HeaderRow.Cells[2].Text = "Cantidad";
                tblPedidosEntregados.HeaderRow.Cells[2].Text = "Total Vendido";
            }

            double total = 0;
            foreach (PedidoProductoVentaDTO producto in pedidoProductos)
            {
                total += producto.TotalVendido;
            }

            lblTotal.Text = total.ToString("0.00");
        }
    }
}