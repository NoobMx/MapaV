using HTTPupt;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AplicacionWebAdministrador.Models
{
    public class Producto
    {
        PeticionHTTP peticion = new PeticionHTTP("https://ecommerce.administracion-op.com");
        public int ID { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public double Precio { get; set; }
        public double Stock { get; set; }
        public bool Estatus { get; set; }
        public string TipoUnidad { get; set; }
        public byte[] Foto { get; set; }
        public double Cantidad { get; set; }

        public bool AgregarProducto(Producto producto)
        {
            String serializedJson = JsonConvertidor.Objeto_Json(producto);
            peticion.PedirComunicacion("Producto/RegistrarProducto", MetodoHTTP.POST, TipoContenido.JSON);
            peticion.enviarDatos(serializedJson);
            return bool.Parse(peticion.ObtenerJson());
        }

        public String MostrarProductos()
        {
            peticion.PedirComunicacion("Producto/MostrarProductos", MetodoHTTP.GET, TipoContenido.JSON);
            return peticion.ObtenerJson();
        }
        public bool ActualizarStock(Producto producto)
        {
            String serializedJson = JsonConvertidor.Objeto_Json(producto);
            peticion.PedirComunicacion("Producto/ActualizarStock", MetodoHTTP.POST, TipoContenido.JSON);
            peticion.enviarDatos(serializedJson);
            return bool.Parse(peticion.ObtenerJson());
        }

        public bool DesactivarProducto(int productoID)
        {
            peticion.PedirComunicacion("Repartidor/BajaRepartidor?ProductoID=" + productoID, MetodoHTTP.GET, TipoContenido.JSON);
            return bool.Parse(peticion.ObtenerJson());
        }
    }
    public class ProductosDTO
    {
        public int ID { get; set; }
        public String Nombre { get; set; }
        public dynamic Foto { get; set; }
        public double Stock { get; set; }
    }
}