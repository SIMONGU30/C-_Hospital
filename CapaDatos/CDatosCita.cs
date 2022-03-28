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
    public class CDatosCita
    {
        CConexion oConexion=new CConexion();
        SqlCommand oCmd=new SqlCommand();

        public DataSet Consultar(CEntidadCitas ocitas)
        {
            try
            {
                oCmd.Connection = oConexion.conectar("BDHospital");
                oCmd.CommandType = CommandType.StoredProcedure;
                oCmd.CommandText = "sp_consultar_citas";
                oCmd.Parameters.Add("@pcod_cita", ocitas.Cod_cita);
               // oCmd.Parameters.Add("@pId_paciente", ocitas.Id_paciente1);
               // oCmd.Parameters.Add("@pid_medico", ocitas.Id_medico);
                SqlDataAdapter da=new  SqlDataAdapter(oCmd);
                DataSet ds= new DataSet();
                da.Fill(ds);
                return ds;
            }
            catch (Exception err)
            {
                throw new Exception(err.Message);
            }
            
        }

        public bool Guardar_Cita(CEntidadCitas ocitas)
        {
            try
            {
                oCmd.Connection = oConexion.conectar("BDHospital");
                oCmd.CommandType = CommandType.StoredProcedure;
                oCmd.CommandText = "sp_guardar_citas";
                oCmd.Parameters.Add("@pcod_cita", ocitas.Cod_cita);
                oCmd.Parameters.Add("@pfecha", ocitas.Fecha);
                oCmd.Parameters.Add("@phora", ocitas.Hora);
                oCmd.Parameters.Add("@pId_paciente", ocitas.Id_paciente1);             
                oCmd.Parameters.Add("@pid_medico", ocitas.Id_medico);
                oCmd.Parameters.Add("@pvalor", ocitas.Valor);
                oCmd.Parameters.Add("@pdiagnostico", ocitas.Diagnostico);
                oCmd.Parameters.Add("@pNom_acompanante", ocitas.Nom_acompanante);
                oCmd.ExecuteNonQuery();
                

                return true;
            }
            catch(Exception err)
            {
                throw new Exception(err.Message);
            }

            
        }
    }
}

