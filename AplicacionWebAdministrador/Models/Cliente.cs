using HTTPupt;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AplicacionWebAdministrador.Models
{
    public class Cliente
    {
        PeticionHTTP peticion = new PeticionHTTP("https://tienda.maiysal.com");
        public int ID { get; set; }
        public string Nombre { get; set; }
        public string NombreUsuario { get; set; }
        public string Contraseña { get; set; }
        public string Correo { get; set; }
        public long NumeroTelefono { get; set; }
        public bool Estatus { get; set; }
        public double Latitud { get; set; }
        public double Longitud { get; set; }
        public int Calificacion { get; set; }
        public DateTime DiaPedido { get; set; }

        public String MostrarClientes()
        {
            peticion.PedirComunicacion("Cliente/MostrarClientes", MetodoHTTP.GET, TipoContenido.JSON);
            return peticion.ObtenerJson();
        }
        public bool DesactivarClientes(int clienteID)
        {
            peticion.PedirComunicacion("Cliente/BajaCliente?ClienteID=" + clienteID, MetodoHTTP.GET, TipoContenido.JSON);
            return bool.Parse(peticion.ObtenerJson());
        }
    }

    public class ClientesDTO
    {
        public int ID { get; set; }
        public string Nombre { get; set; }
        public string NombreUsuario { get; set; }
        public string Contraseña { get; set; }
        public string correo { get; set; }
        public long NumeroTelefono { get; set; }
        public string Estatus { get; set; }
        public double Latitud { get; set; }
        public double Longitud { get; set; }
        public int Calificacion { get; set; }
        public string DiaPedido { get; set; }
    }
}