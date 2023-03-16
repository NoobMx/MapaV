using AplicacionWebAdministrador.Models;
using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AplicacionWebAdministrador
{
	public partial class AsignarHoras : System.Web.UI.Page
	{
        
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["nombreUsuario"] == null || Session["contraseña"] == null)
            {
                Response.Redirect("~/InicioSesión.aspx");
            }
            else
            {
                if (!IsPostBack)
                {
                    Horario horarioObj = new Horario();
                    var listahorarios = JsonConvert.DeserializeObject<List<HorarioDTO>>(horarioObj.MostrarHorario());
                    rptHorario.DataSource = listahorarios;
                    rptHorario.DataBind();
                }

                foreach (RepeaterItem item in rptHorario.Items)
                {
                    if (item.ItemType == ListItemType.Item || item.ItemType == ListItemType.AlternatingItem)
                    {
                        CheckBox checkBox = item.FindControl("ChekBox2") as CheckBox;
                        checkBox.CheckedChanged += ChekBox2_CheckedChanged;
                    }
                }
            }
            
        }

        protected void Actualizar(object sender, EventArgs e)
        {
            Horario horario = new Horario();
            bool resp = horario.ActualizarHorario(Horarios.horarios);
            if (resp)
            {
                ClientScript.RegisterStartupScript(this.GetType(), "Alerta", "alert('Horas actualizadas correctamente');", true);
                Horarios.horarios.Clear();
            }
        }

        protected void ChekBox2_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = sender as CheckBox;
            Horarios.horarios.Add(new HorarioDTO
            {
                Estatus = checkBox.Checked,
                ID = Convert.ToInt32(checkBox.Attributes["value"])
            });
        }
    }
}