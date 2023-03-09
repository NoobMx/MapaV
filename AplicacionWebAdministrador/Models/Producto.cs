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
        public string Descripcion { get; set;}
        public double Precio { get; set;}
        public double Stock { get; set;}
        public bool Estatus { get; set;}
        public string TipoUnidad { get; set;}
        public byte[] Foto { get; set;}
        public double Cantidad { get; set;}

        public bool AgregarProducto(Producto producto)
        {
            String serializedJson = JsonConvertidor.Objeto_Json(producto);
            peticion.PedirComunicacion("Producto/RegistrarProducto", MetodoHTTP.POST, TipoContenido.JSON);
            peticion.enviarDatos(serializedJson);
            return bool.Parse(peticion.ObtenerJson());
        }
    }
}