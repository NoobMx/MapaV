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
        PeticionHTTP request = new PeticionHTTP("https://tienda.maiysal.com");
        public int PedidoID { get; set; }
        public int ID { get; set; }
        public bool Estatus { get; set; }
        public double LongitudPedido { get; set; }
        public double LatitudPedido { get; set; }
        public String ClienteNombre { get; set; }
        public int ClienteID { get; set; }
        public long ClienteNumeroTelefono { get; set; }
        public double TotalPrecioProductos { get; set; }
        public DateTime DiaPedido { get; set; }
        public int? RepartidorID { get; set; }
        public int HorarioID { get; set; }
        public string RepartidorNombre { get; set; }
        public List<Producto> productos { get; set; }
        public List<PedidoDTO> MostrarPedidos()
        {
            request.PedirComunicacion("Pedidos/MostrarPedidosPendientes", MetodoHTTP.GET, TipoContenido.JSON);
            List<PedidoDTO> pedidos = JsonConvert.DeserializeObject<List<PedidoDTO>>(request.ObtenerJson());
            return pedidos;
        }
        public List<PedidoDTO> MostrarHistorialPedido(String Inicio, String Final)
        {
            Console.WriteLine(Inicio);
            request.PedirComunicacion("Pedidos/MostrarHistorialPedidosAdmin?inicio="+Inicio + "&final="+Final, MetodoHTTP.GET, TipoContenido.JSON);
            List<PedidoDTO> pedidos = JsonConvert.DeserializeObject<List<PedidoDTO>>(request.ObtenerJson());
            

            return pedidos;
        }
        public bool AgregarProducto(Pedido pedido)
        {
            String serializedJson = JsonConvertidor.Objeto_Json(pedido);
            request.PedirComunicacion("Producto/RegistrarPedido", MetodoHTTP.POST, TipoContenido.JSON);
            request.enviarDatos(serializedJson);
            return bool.Parse(request.ObtenerJson());
        }
        public Pedido CompraFisica(Pedido pedido)
        {
            String serializedJson = JsonConvertidor.Objeto_Json(pedido);
            request.PedirComunicacion("Pedidos/RegistrarPedido", MetodoHTTP.POST, TipoContenido.JSON);
            request.enviarDatos(serializedJson);
            return JsonConvert.DeserializeObject<Pedido>(request.ObtenerJson());
        }
        public List<PedidoProductoVentaDTO> MostrarVentas(String Inicio, String Final)
        {
            Console.WriteLine(Inicio);
            request.PedirComunicacion("Venta/MostrarVenta?inicio=" + Inicio + "&final=" + Final, MetodoHTTP.GET, TipoContenido.JSON);
            List<PedidoProductoVentaDTO> pedidos = JsonConvert.DeserializeObject<List<PedidoProductoVentaDTO>>(request.ObtenerJson());
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
        public bool Estatus { get; set; }
        public int HorarioID { get; set; }
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

    public class ProductoPedidoDTO
    {
        public int PedidoID { get; set; }
        public int CalificacionCliente { get; set; }
        public int CalificacionRepartidor { get; set; }
        public String NombrePersona { get; set; }
        public String Estatus { get; set; }
        public double TotalPrecioProductos { get; set; }
        public int ClienteID { get; set; }
        public int? RepartidorID { get; set; }
        public String Fecha { get; set; }

        public List<Producto> productos { get; set; }
    }
}