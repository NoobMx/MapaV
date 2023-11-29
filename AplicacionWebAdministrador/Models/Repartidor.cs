using HTTPupt;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AplicacionWebAdministrador.Models
{
    public class Repartidor
    {
        PeticionHTTP peticion = new PeticionHTTP ("https://tienda.maiysal.com");

        public int ID { get; set; }
        public int PedidoID { get; set; }
        public string Nombre { get; set; }
        public string NombreUsuario { get; set; }
        public string Contraseña { get; set; }
        public string Correo { get; set; }
        public string Domicilio { get; set; }
        public long NumeroTelefono { get; set; }
        public bool Estatus { get; set; }

        public byte[] Foto { get; set; }
        public int? Calificacion { get; set; }


        public bool RegistrarRepartidor(Repartidor repartidor)
        {
            String seralized = JsonConvertidor.Objeto_Json(repartidor);
            peticion.PedirComunicacion("Repartidor/RegistrarRepartidor", MetodoHTTP.POST, TipoContenido.JSON);
            peticion.enviarDatos(seralized);
            return bool.Parse(peticion.ObtenerJson());
        }
        public bool DesactivarRepartidor(int repartidorID)
        {
            peticion.PedirComunicacion("Repartidor/BajaRepartidor?RepartidorID=" + repartidorID, MetodoHTTP.GET, TipoContenido.JSON);
            return bool.Parse(peticion.ObtenerJson());
        }

        public bool ActivarRepartidor(int repartidorID)
        {
            peticion.PedirComunicacion("Repartidor/AltaRepartidor?RepartidorID=" + repartidorID, MetodoHTTP.GET, TipoContenido.JSON);
            return bool.Parse(peticion.ObtenerJson());
        }
        public String MostrarRepartidor()
        {
            peticion.PedirComunicacion("Repartidor/MostrarRepartidores", MetodoHTTP.GET, TipoContenido.JSON);
            return peticion.ObtenerJson();
        }
        public string mostrarRepartidor()
        {
            peticion.PedirComunicacion("Repartidor/MostrarRepartidores", MetodoHTTP.GET, TipoContenido.JSON);
            return peticion.ObtenerJson();
        }

        public string DatosRepartidorConcatenados
        {
            get { return $"{ID} - {Nombre} - {Calificacion} - {PedidoID}"; }
        }
    }
    public class RepartidoresDTO
    {
        public int ID { get; set; }
        public string Nombre { get; set; }
        public string NombreUsuario { get; set; }
        public string Contraseña { get; set; }
        public string Correo { get; set; }
        public string Domicilio { get; set; }
        public long NumeroTelefono { get; set; }
        public string Estatus { get; set; }
        public byte[] Foto { get; set; }
        public int? Calificacion { get; set; }
    }
}