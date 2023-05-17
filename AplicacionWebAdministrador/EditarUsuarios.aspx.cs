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
    public partial class WebForm3 : System.Web.UI.Page
    {
        public static int UsuarioID;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["nombreUsuario"] == null || Session["contraseña"] == null)
            {
                Response.Redirect("~/Index.aspx");
            }
            else 
            {
                if (!string.IsNullOrEmpty(Request.Form["usuario"]))
                {
                    UsuarioID = int.Parse(Request.Form["usuario"]);
                    Cliente clienteO = new Cliente();
                    var listaclientes = JsonConvert.DeserializeObject<List<Cliente>>(clienteO.MostrarClientes());
                    ObservableCollection<ClientesDTO> clientesDTO = new ObservableCollection<ClientesDTO>();
                    listaclientes.ForEach(p =>
                    {
                        clientesDTO.Add(new ClientesDTO
                        {
                            ID = p.ID,
                            Nombre = p.Nombre,
                            NumeroTelefono = p.NumeroTelefono
                        });
                    });
                    ClientesDTO clienteEncontrado = clientesDTO.FirstOrDefault(p => p.ID == UsuarioID);
                    if (clienteEncontrado != null)
                    {
                        rptUsuario.DataSource = new List<ClientesDTO>() { clienteEncontrado };
                        rptUsuario.DataBind();
                    }
                }
            }
        }
        protected void Desactivar_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();
            int? clienteID = UsuarioID;

            if (clienteID.HasValue && cliente.DesactivarClientes(clienteID.Value))
            {
                //Alerta
            }
            Response.Redirect("~/Usuarios.aspx");
        }

    }
}