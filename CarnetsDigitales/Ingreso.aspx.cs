using System;
using System.Collections.Generic;
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
            string selectSQL = "Select Nombre, Clave FROM Usuarios where Usuario = '" + txtUsuario.Text + "' and Clave = '" + txtContraseña.Text + "'";
            con.Open();
        SqlCommand cmd = new SqlCommand(selectSQL, con);
            SqlDataReader dr = cmd.ExecuteReader();

        if (dr.HasRows)
                {
                Server.Transfer("Menu.aspx");
                SessionParameter("")
                
                    }
            else
            {
                lblError.Text = "El Usuario o la Contraseña son incorrectos";
                /*string script = string.Format("alert('El Usuario o la Contraseña son incorrectos');");
                ClientScript.RegisterStartupScript(this.GetType(), "alert", script, true);*/
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