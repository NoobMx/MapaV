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
    public partial class WebForm7 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["nombreUsuario"] == null || Session["contraseña"] == null)
            {
                Response.Redirect("~/Index.aspx");
            }
            else
            {
                Producto productoO = new Producto();
                var listaproductos = JsonConvert.DeserializeObject<List<Producto>>(productoO.MostrarProductosActivos());
                ObservableCollection<ProductosDTO> productosDTO = new ObservableCollection<ProductosDTO>();
                listaproductos.ForEach(p =>
                {
                        productosDTO.Add(new ProductosDTO
                        {
                            ID = p.ID,
                            Nombre = p.Nombre,
                            Estatus = p.Estatus,
                            Foto = p.Foto
                        });
                });
                NumeroProductos.Text = productosDTO.Count.ToString();
                rptProductos.DataSource = productosDTO;
                rptProductos.DataBind();

                Producto productoOI = new Producto();
                var listaproductosI = JsonConvert.DeserializeObject<List<Producto>>(productoOI.MostrarProductosInactivos());
                ObservableCollection<ProductosDTO> productosDTOI = new ObservableCollection<ProductosDTO>();
                listaproductosI.ForEach(p =>
                {
                    productosDTOI.Add(new ProductosDTO
                    {
                        ID = p.ID,
                        Nombre = p.Nombre,
                        Estatus = p.Estatus,
                        Foto = p.Foto
                    });
                });
                rpt_ProductosDesactivados.DataSource = productosDTOI;
                rpt_ProductosDesactivados.DataBind();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

        }
    }
}