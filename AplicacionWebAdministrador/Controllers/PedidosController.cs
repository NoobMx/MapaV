using AplicacionWebAdministrador.Models;
using HTTPupt;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Security.Cryptography.X509Certificates;
using System.Web.Http;

namespace AplicacionWebAdministrador.Controllers
{
    public class PedidosController : ApiController
    {
        PeticionHTTP request = new PeticionHTTP("https://ecommerce.administracion-op.com/");
        [HttpGet]
        public List<Pedido> MostrarPedido()
        {
            request.PedirComunicacion("Pedidos/MostrarPedidosPendientes", MetodoHTTP.GET, TipoContenido.JSON);
            List<Pedido> pedidos = JsonConvert.DeserializeObject<List<Pedido>>(request.ObtenerJson());
            return pedidos;
        }
        public List<Pedido> MostrarHistorialPedido()
        {
            request.PedirComunicacion("Pedidos/MostrarHistorialPedidosAdmin", MetodoHTTP.GET, TipoContenido.JSON);
            List<Pedido> pedidos = JsonConvert.DeserializeObject<List<Pedido>>(request.ObtenerJson());
            return pedidos;
        }


        //Comunicacion con el Server...
        [HttpPost]
        public bool AsignarRepartidor(Pedido pedido)
        {
            var serealizedJson = JsonConvertidor.Objeto_Json(pedido);
            request.PedirComunicacion("Repartidor/AsignarRepartidor", MetodoHTTP.POST, TipoContenido.JSON);
            request.enviarDatos(serealizedJson);
            return bool.Parse(request.ObtenerJson());
        }
        [HttpGet]
        public List<Repartidor> mostrarRepartidor()
        {
            request.PedirComunicacion("Repartidor/MostrarRepartidores", MetodoHTTP.GET, TipoContenido.JSON);
            List<Repartidor> repartidores = JsonConvert.DeserializeObject<List<Repartidor>>(request.ObtenerJson());
            return repartidores;
        }



    }
}
