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
    public partial class WebForm17 : System.Web.UI.Page
    {
        public static int RepartidorID;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["nombreUsuario"] == null || Session["contraseña"] == null)
            {
                Response.Redirect("~/Index.aspx");
            }
            else
            {
                if (!string.IsNullOrEmpty(Request.Form["repartidor"]))
                {
                    RepartidorID = int.Parse(Request.Form["repartidor"]);
                    Repartidor repartidorO = new Repartidor();
                    String huevos = repartidorO.MostrarRepartidor();
                    var listarepartidores = JsonConvert.DeserializeObject<List<Repartidor>>(repartidorO.MostrarRepartidor());
                    ObservableCollection<RepartidoresDTO> repartidoresDTO = new ObservableCollection<RepartidoresDTO>();
                    listarepartidores.ForEach(p =>
                    {
                        repartidoresDTO.Add(new RepartidoresDTO
                        {
                            ID = p.ID,
                            Nombre = p.Nombre,
                            NombreUsuario = p.NombreUsuario,
                            Domicilio = p.Domicilio,
                            Foto = p.Foto,
                            Calificacion = p.Calificacion,
                            Correo = p.Correo,
                            NumeroTelefono = p.NumeroTelefono
                        });
                    });
                    RepartidoresDTO repartidorEncontrado = repartidoresDTO.FirstOrDefault(p => p.ID == RepartidorID);
                    if (repartidorEncontrado != null)
                    {
                        rptRepartidor.DataSource = new List<RepartidoresDTO>() { repartidorEncontrado };
                        rptRepartidor.DataBind();
                    }
                    if (repartidorEncontrado != null)
                    {
                        rptRepartidorFoto.DataSource = new List<RepartidoresDTO>() { repartidorEncontrado };
                        rptRepartidorFoto.DataBind();
                    }
                }
            }
        }
        protected void Activar(object sender, EventArgs e)
        {
            Repartidor repartidor = new Repartidor();
            int? repartidorID = RepartidorID;

            if (repartidorID.HasValue && repartidor.ActivarRepartidor(repartidorID.Value))
            {
                //Alerta
            }
        }
    }
}