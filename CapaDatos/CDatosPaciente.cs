using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using CapaEntidad;


namespace CapaDatos
{
    public class CDatosPaciente
    {
        CConexion oConexion = new CConexion();
        SqlCommand oCmd = new SqlCommand();



        public DataSet ConsultarPaciente(CEntidadPaceientes ocitas)
        {
            try
            {
                oCmd.Connection = oConexion.conectar("BDHospital");
                oCmd.CommandType = CommandType.StoredProcedure;
                oCmd.CommandText = "sp_consultar_paciente";
                oCmd.Parameters.Add("@pId_paciente", ocitas.Id_paciente1);

                // oCmd.Parameters.Add("@pId_paciente", ocitas.Id_paciente1);
                // oCmd.Parameters.Add("@pid_medico", ocitas.Id_medico);
                SqlDataAdapter da = new SqlDataAdapter(oCmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                return ds;
            }
            catch (Exception err)
            {
                throw new Exception(err.Message);
            }

        }

        public bool Guardar_Paciente(CEntidadPaceientes ocitas)
        {
            try
            {
                oCmd.Connection = oConexion.conectar("BDHospital");
                oCmd.CommandType = CommandType.StoredProcedure;
                oCmd.CommandText = "sp_guardar_paciente";
                oCmd.Parameters.Add("@pId_paciente", ocitas.Id_paciente1);
                oCmd.Parameters.Add("@ptip_doc ", ocitas.Tip_doc);
                oCmd.Parameters.Add("@pnom_paciente", ocitas.Nom_paciente);
                oCmd.Parameters.Add("@pdir_paciente", ocitas.Dir_paciente);
                oCmd.Parameters.Add("@ptel_paciente", ocitas.Tel_paciente);
                oCmd.Parameters.Add("@pcel_paciente", ocitas.Cel_paciente);
                oCmd.ExecuteNonQuery();


                return true;
            }
            catch (Exception err)
            {
                throw new Exception(err.Message);
            }


        }
    }
}
