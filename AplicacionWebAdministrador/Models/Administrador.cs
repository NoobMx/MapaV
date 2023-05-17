using HTTPupt;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AplicacionWebAdministrador.Models
{
    public class Administrador
    {
        PeticionHTTP peticion = new PeticionHTTP("https://tienda.maiysal.com");
        public int ID { get; set; }
        public string NombreUsuario { get; set; }
        public string Nombre { get; set; }
        public string Contraseña { get; set; }
        public String ValidarAdministrador(Administrador administrador)
        {
            String serializedJson = JsonConvertidor.Objeto_Json(administrador);
            peticion.PedirComunicacion("Administrador/ValidarAdministrador", MetodoHTTP.POST, TipoContenido.JSON);
            peticion.enviarDatos(serializedJson);
            return peticion.ObtenerJson();
        }
    }
}