﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CarnetsDigitales
{
    public partial class Menu : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if ()
        }

        protected void btnConsultas_Click(object sender, EventArgs e)
        {
            Server.Transfer("Consultas.aspx");
        }
    }
}