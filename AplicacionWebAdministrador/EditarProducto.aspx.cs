﻿using AplicacionWebAdministrador.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AplicacionWebAdministrador
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void Actualizar_Click(object sender, EventArgs e)
        {
            Producto productoR = new Producto()
            {
                Stock = double.Parse(Txt_stock.Text)
            };
        }
    }
}