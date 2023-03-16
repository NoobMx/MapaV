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
    public partial class WebForm12 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["nombreUsuario"] == null || Session["contraseña"] == null)
            {
                Response.Redirect("~/InicioSesión.aspx");
            }
            else
            {
                Cliente clienteO = new Cliente();
                var listaclientes = JsonConvert.DeserializeObject<List<Cliente>>(clienteO.MostrarClientes());
                ObservableCollection<ClientesDTO> clientesDTO = new ObservableCollection<ClientesDTO>();
                listaclientes.ForEach(p =>
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
                    clientesDTO.Add(new ClientesDTO
                    {
                        ID = p.ID,
                        Nombre = p.Nombre,
                        Estatus = s
                    });
                });
                rptClientes.DataSource = clientesDTO;
                rptClientes.DataBind();
            }
        }
    }
}