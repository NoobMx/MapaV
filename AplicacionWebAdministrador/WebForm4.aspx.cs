using AplicacionWebAdministrador.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AplicacionWebAdministrador
{
    public partial class WebForm4 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            /*Horario horarioObj = new Horario();
            var listahorarios = JsonConvert.DeserializeObject<List<Horario>>(horarioObj.MostrarHorario());
            ObservableCollection<HorarioDTO> horarioDTO = new ObservableCollection<HorarioDTO>();
            listahorarios.ForEach(p =>
            {
                horarioDTO.Add(new HorarioDTO
                {
                    ID = p.ID,
                    Nombre = p.Nombre,
                    Estatus = p.Estatus
                });
            });*/
        }
    }
}