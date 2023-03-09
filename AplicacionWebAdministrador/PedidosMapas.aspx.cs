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
                        ProductoNombre_Cantidad = string.Join(", ", p.productos.Select(pr => pr.Nombre + " " + pr.Cantidad)),
                        Dia = p.Fecha.ToShortDateString(),
                        Horario = p.Horario
                    });
            });
            tablaPedidos.DataSource = pedidoProductos;
            tablaPedidos.DataBind();
            //Repartidor repartidor = new Repartidor();
            //repartidors = JsonConvert.DeserializeObject<List<Repartidor>>(repartidor.mostrarRepartidor());
            //myListBox.DataSource = repartidors;
            //myListBox.DataTextField = "DatosRepartidorConcatenados";
            //myListBox.DataBind();
        }
    }
}