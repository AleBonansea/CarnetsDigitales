using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CarnetsDigitales
{
    public partial class Ingreso : System.Web.UI.Page
    {
        string connectionString = "Data Source=ALGE-PF27D6ZT;Initial Catalog=CarnetsFCV;Integrated Security=True";
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnIngresar_Click(object sender, EventArgs e)
        {
            
            SqlConnection con =  new SqlConnection(connectionString);
            string selectSQL = "Select Usuario, Contraseña, RolId FROM Usuarios where Usuario = '" + txtUsuario.Text + "' and Contraseña = '" + txtContraseña.Text + "'";
            con.Open();
        SqlCommand cmd = new SqlCommand(selectSQL, con);
            SqlDataReader dr = cmd.ExecuteReader();

        if (dr.HasRows)
               
                while (dr.Read())
                {
                    Session["rolId"] = dr["RolId"].ToString();
                    Server.Transfer("Menu.aspx");
                }
                
            else
            {
                lblError.Text = "El Usuario o la Contraseña son incorrectos";
            }

            con.Close();
        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            txtContraseña.Text = "";
            txtUsuario.Text = "";
            lblError.Text = "";
        }

        
    }
}