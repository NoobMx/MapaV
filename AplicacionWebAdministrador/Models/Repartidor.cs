using HTTPupt;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AplicacionWebAdministrador.Models
{
    public class Repartidor
    {
        PeticionHTTP peticion = new PeticionHTTP ("https://ecommerce.administracion-op.com");

        public int ID { get; set; }

        public int PedidoID { get; set; }

        public int Calificacion { get; set; }
        public string Nombre {get; set; }

        public string mostrarRepartidor()
        {
            peticion.PedirComunicacion("Repartidor/MostrarRepartidores", MetodoHTTP.GET, TipoContenido.JSON);
            return peticion.ObtenerJson();
        }

        //Cadena que concatena todas las variables de repartidor
        public string DatosRepartidorConcatenados
        {
            get { return $"{ID} - {Nombre} - {Calificacion} - {PedidoID}"; }
        }
    }
   
}