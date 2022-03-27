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
    public class CReglasNegocioCita
    {

        CDatosCita oDatosCitas=new CDatosCita();

        public DataSet Consultar_cita(CEntidadCitas oCitas)
        {
            return oDatosCitas.Consultar(oCitas);
        }
        public bool Guardar_Cita(CEntidadCitas ocitas)
        {
             return oDatosCitas.Guardar_Cita(ocitas);
        }
            
        
    }

}

