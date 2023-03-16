using HTTPupt;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AplicacionWebAdministrador.Models
{
    public class Pedido
    {
        PeticionHTTP request = new PeticionHTTP("https://ecommerce.administracion-op.com/");
        public int PedidoID { get; set; }
        public int ID { get; set; }
        public double LongitudPedido { get; set; }
        public double LatitudPedido { get; set; }
        public String ClienteNombre { get; set; }
        public long ClienteNumeroTelefono { get; set; }
        public double PrecioTotal { get; set; }
        public int? RepartidorID { get; set; }
        public string RepartidorNombre { get; set; }
        public List<Producto> productos { get; set; }
        public List<PedidoDTO> MostrarPedidos()
        {
            request.PedirComunicacion("Pedidos/MostrarPedidosPendientes", MetodoHTTP.GET, TipoContenido.JSON);
            List<PedidoDTO> pedidos = JsonConvert.DeserializeObject<List<PedidoDTO>>(request.ObtenerJson());
            return pedidos;
        }
    }
    public class PedidoDTO
    {
        public int PedidoID { get; set; }
        public double LongitudPedido { get; set; }
        public double LatitudPedido { get; set; }
        public String ClienteNombre { get; set; }
        public long ClienteNumeroTelefono { get; set; }
        public double PrecioTotal { get; set; }
        public string RepartidorNombre { get; set; }
        public DateTime DiaPedido { get; set; }
        public String Horario { get; set; }
        public List<Producto> productos { get; set; }
    }

    public class PedidoProductoDTO
    {
        public int PedidoID { get; set; }
        public String ClienteNombre { get; set; }
        public long ClienteNumeroTelefono { get; set; }
        public double PrecioTotal { get; set; }
        public string RepartidorNombre { get; set; }
        public String ProductoNombre_Cantidad { get; set; }
        public String DiaPedido { get; set; }
        public String Horario { get; set; }
    }  
}