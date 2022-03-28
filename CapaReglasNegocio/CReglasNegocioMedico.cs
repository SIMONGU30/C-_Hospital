using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidad;
using System.Data;

namespace CapaReglasNegocio
{
    public class CReglasNegocioMedico
    {
        CDatosMedico oDatosMedico = new CDatosMedico();

        public DataSet Consultar_Medico(CEntidadMedico oCitas)
        {
            return oDatosMedico.ConsultarMedico(oCitas);
        }

        public bool Guardar_Medico(CEntidadMedico ocitas)
        {
            return oDatosMedico.Guardar_Medico(ocitas);
        }
    }
}
