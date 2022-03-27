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
    public class CDatosMedico
    {
        CConexion oConexion = new CConexion();
        SqlCommand oCmd = new SqlCommand();

        public DataSet ConsultarMedico(CEntidadMedico ocitas)
        {
            try
            {
                oCmd.Connection = oConexion.conectar("BDHospital");
                oCmd.CommandType = CommandType.StoredProcedure;
                oCmd.CommandText = "sp_consultar_medico";
                oCmd.Parameters.Add("@pid_medico", ocitas.Id_medico);
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

        public bool Guardar_Medico(CEntidadMedico ocitas)
        {
            try
            {
                oCmd.Connection = oConexion.conectar("BDHospital");
                oCmd.CommandType = CommandType.StoredProcedure;
                oCmd.CommandText = "sp_guardar_medico";
                oCmd.Parameters.Add("@pid_medico", ocitas.Id_medico);
                oCmd.Parameters.Add("@pnom_medico", ocitas.Nom_medico);
                oCmd.Parameters.Add("@pespecialidad", ocitas.Especialidad);
                oCmd.Parameters.Add("@ptel_medico", ocitas.Tel_medico);
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
