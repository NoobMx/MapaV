using AplicacionWebAdministrador.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AplicacionWebAdministrador
{
    public partial class WebForm15 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["nombreUsuario"] == null || Session["contraseña"] == null)
            {
                Response.Redirect("~/InicioSesión.aspx");
            }

        }

        protected void ConsultarPedidos(object sender, EventArgs e)
        {
            Pedido pedido = new Pedido();
            List<PedidoDTO> pedidoList = pedido.MostrarHistorialPedido(FechaInicio.Text, FechaFinal.Text);
            List<Producto> productos = new List<Producto>();
            pedidoList.ForEach(p =>
            {
                p.productos.ForEach(pr =>
                {
                    productos.Add(pr);
                });
            });
            List<PedidoProductoDTO> pedidoProductos = new List<PedidoProductoDTO>();
            pedidoList.ForEach((p) =>
            {
                pedidoProductos.Add(
                    new PedidoProductoDTO
                    {
                        ClienteNombre = p.ClienteNombre,
                        ClienteNumeroTelefono = p.ClienteNumeroTelefono,
                        PedidoID = p.PedidoID,
                        PrecioTotal = p.PrecioTotal,
                        RepartidorNombre = p.RepartidorNombre,
                        ProductoNombre_Cantidad = string.Join("\n ",p.productos.Select(pr => "/ " + pr.Cantidad + " " + pr.Nombre)),
                        DiaPedido = p.DiaPedido.ToShortDateString(),
                        Horario = p.Horario
                    });
            });
            tblPedidosEntregados.DataSource = pedidoProductos.OrderBy(p => p.PedidoID);
            tblPedidosEntregados.DataBind();

            if (pedidoProductos.Count > 0)
            {
                tblPedidosEntregados.HeaderRow.Cells[0].Text = "Pedido ID";
                tblPedidosEntregados.HeaderRow.Cells[1].Text = "Cliente";
                tblPedidosEntregados.HeaderRow.Cells[2].Text = "Teléfono";
                tblPedidosEntregados.HeaderRow.Cells[3].Text = "Total";
                tblPedidosEntregados.HeaderRow.Cells[4].Text = "Repartidor";
                tblPedidosEntregados.HeaderRow.Cells[5].Text = "Productos";
                tblPedidosEntregados.HeaderRow.Cells[6].Text = "Día";
                tblPedidosEntregados.HeaderRow.Cells[7].Text = "Horario";
            }

        }
    }
}