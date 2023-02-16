using System;
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
            int rolId = Int32.Parse((string)Session["rolId"]);


            switch (rolId)
            {
                case 1: btnJugadores.Visible = false;
                    break;

                case 2: btnArbitros.Visible = false;
                        btnConsultas.Visible = false;
                    break;

                case (3): btnConsultas.Visible = false;
                        btnArbitros.Visible = false;
                        btnClubes.Visible = false;
                        btnEntrenadores.Visible = false;
                        btnEquipos.Visible = false;
                        btnJugadores.Visible = false;
                    break ;
                case 4:
                    btnConsultas.Visible = false;
                    btnArbitros.Visible = false;
                    btnClubes.Visible = false;
                    btnEntrenadores.Visible = false;
                    btnEquipos.Visible = false;
                    btnJugadores.Visible = false;
                    break;
                case 5:
                    btnConsultas.Visible = false;
                    btnArbitros.Visible = false;
                    btnClubes.Visible = false;
                    btnEntrenadores.Visible = false;
                    btnEquipos.Visible = false;
                    btnJugadores.Visible = false;
                    break;
            }
        }
        protected void btnConsultas_Click(object sender, EventArgs e)
        {
            Server.Transfer("Consultas.aspx");
        }
    }
}