using AplicacionWebAdministrador.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AplicacionWebAdministrador
{
    public partial class WebForm10 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["nombreUsuario"] == null || Session["contraseña"] == null)
            {
                Response.Redirect("~/Index.aspx");
            }
            else
            {
                Repartidor repartidorO = new Repartidor();
                var listarepartidores = JsonConvert.DeserializeObject<List<Repartidor>>(repartidorO.MostrarRepartidor());
                var listaOrdenada = listarepartidores.OrderBy(p => p.Calificacion);
                ObservableCollection<RepartidoresDTO> repartidoresDTO = new ObservableCollection<RepartidoresDTO>();
                foreach (var p in listaOrdenada)
                {
                    string s;
                    if (p.Estatus)
                    {
                        s = "Activo";
                    }
                    else
                    {
                        s = "Inactivo";
                    }
                    repartidoresDTO.Add(new RepartidoresDTO
                    {
                        ID = p.ID,
                        Nombre = p.Nombre,
                        Estatus = s,
                        Foto = p.Foto,
                        Calificacion = p.Calificacion
                    });
                }
                rptRepartidores.DataSource = repartidoresDTO;
                rptRepartidores.DataBind();
            }
        }
    }
}