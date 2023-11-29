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
                Response.Redirect("~/Index.aspx");
            }
            else
            {
                Cliente clienteO = new Cliente();
                var Clientes = clienteO.MostrarClientes();
                var listaclientes = JsonConvert.DeserializeObject<List<Cliente>>(Clientes);
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
                    if (p.Estatus == true)
                    {
                        if (p.Calificacion == null)
                        {
                            p.Calificacion = 0;
                        }
                        clientesDTO.Add(new ClientesDTO
                        {
                            ID = p.ID,
                            Nombre = p.Nombre,
                            Estatus = s,
                            Calificacion = p.Calificacion,
                            DiaPedido = p.DiaPedido.ToString()
                        });
                    }
                });
                rptClientes.DataSource = clientesDTO;
                rptClientes.DataBind();
            }
        }
    }
}