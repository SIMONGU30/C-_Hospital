using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class CConexion
    {
        public SqlConnection conectar(string conexion)//establecer conexion con la base de datos
        {
            try
            {
                SqlConnection oconectar = new SqlConnection(ConfigurationSettings.AppSettings[conexion].ToString());
                oconectar.Open();
                return oconectar;
            }
            catch(Exception err)
            {
                throw new Exception(err.Message);//solo si no se conecta a la base de datos

            }
        }
    }
}
