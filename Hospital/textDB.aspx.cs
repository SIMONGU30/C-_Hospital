using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Hospital
{
    public partial class textDB : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnTestDB_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["SQLDbConnection"].ToString();
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
                if ((connection.State & ConnectionState.Open) > 0)
                {
                    Label1.Text = "Conexión se realizo exitosamente......OK!";
                    connection.Close();
                }
                else
                {
                    Label1.Text = ("Conexión falló");
                }
            }
            catch
            {
                Label1.Text = ("Conexión falló por catch");
            }
        }
    }
}