using HTTPupt;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

namespace AplicacionWebAdministrador.Models
{
    public class Horario
    {
        PeticionHTTP peticion = new PeticionHTTP("https://tienda.maiysal.com");
        public int ID { get; set; }
        public string Nombre { get; set; }
        public bool Estatus { get; set; }
        public String MostrarHorario()
        {
            peticion.PedirComunicacion("Horario/MostrarHorarios", MetodoHTTP.GET, TipoContenido.JSON);
            return peticion.ObtenerJson();
        }
        public bool ActualizarHorario(List<HorarioDTO> horarios)
        {
            String serializedJson = JsonConvertidor.Objeto_Json(horarios);
            peticion.PedirComunicacion("Horario/HorariosAtencion", MetodoHTTP.POST, TipoContenido.JSON);
            peticion.enviarDatos(serializedJson);
            return bool.Parse(peticion.ObtenerJson());
        }


    }

    public class HorarioDTO
    {
        public int ID { get; set; }
        public string Nombre { get; set; }
        public bool Estatus { get; set; }
    }
    public static class Horarios
    {
        public static List<HorarioDTO> horarios = new List<HorarioDTO>();
    }
}