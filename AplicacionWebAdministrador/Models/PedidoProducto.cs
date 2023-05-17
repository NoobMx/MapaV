using HTTPupt;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AplicacionWebAdministrador.Models
{
    public class PedidoProducto
    {
        PeticionHTTP request = new PeticionHTTP("https://tienda.maiysal.com");
        public int ID { get; set; }
        public double Cantidad { get; set; }
        public int PedidoID { get; set; }
        public int ProductoID { get; set;}
        public bool RegistrarPedidoProducto (List<PedidoProducto> lista)
        {
            String serializedJson = JsonConvertidor.Objeto_Json(lista);
            request.PedirComunicacion("PedidoProducto/RegistrarPedido", MetodoHTTP.POST, TipoContenido.JSON);
            request.enviarDatos(serializedJson);
            return bool.Parse(request.ObtenerJson());
        }
    }
    public class PedidoProductoVentaDTO
    {
        public string Nombre { get; set;}
        public double Cantidad { get; set; }
        public double TotalVendido { get; set; }
    }
}