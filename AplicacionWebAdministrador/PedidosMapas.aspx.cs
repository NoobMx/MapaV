using AplicacionWebAdministrador.Models;
using HTTPupt;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Timers;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace AplicacionWebAdministrador
{
    public partial class WebForm9 : System.Web.UI.Page
    {
        public List<Repartidor> repartidors;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["nombreUsuario"] == null || Session["contraseña"] == null)
            {
                Response.Redirect("~/Index.aspx");
            }
            else
            {
                Pedido pedido = new Pedido();
                List<PedidoDTO> pedidoList = pedido.MostrarPedidos();
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
                            ProductoNombre_Cantidad = string.Join("\n ", p.productos.Select(pr => "/ "+ pr.Cantidad + " " + pr.Nombre)),
                            DiaPedido = p.DiaPedido.ToShortDateString(),
                            Horario = p.Horario
                        });
                });
                tablaPedidos.DataSource = pedidoProductos.OrderBy(p => p.PedidoID);
                tablaPedidos.DataBind();

                if (pedidoProductos.Count>0)
                {
                    tablaPedidos.HeaderRow.Cells[0].Text = "Pedido ID";
                    tablaPedidos.HeaderRow.Cells[1].Text = "Cliente";
                    tablaPedidos.HeaderRow.Cells[2].Text = "Teléfono";
                    tablaPedidos.HeaderRow.Cells[3].Text = "Total";
                    tablaPedidos.HeaderRow.Cells[4].Text = "Repartidor";
                    tablaPedidos.HeaderRow.Cells[5].Text = "Productos";
                    tablaPedidos.HeaderRow.Cells[6].Text = "Día";
                    tablaPedidos.HeaderRow.Cells[7].Text = "Horario";
                }
                //Repartidor repartidor = new Repartidor();
                //repartidors = JsonConvert.DeserializeObject<List<Repartidor>>(repartidor.mostrarRepartidor());
                //myListBox.DataSource = repartidors;
                //myListBox.DataTextField = "DatosRepartidorConcatenados";
                //myListBox.DataBind();
            }
        }
    }
}