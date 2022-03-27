using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CapaReglasNegocio;
using CapaEntidad;
using System.Data;


namespace Hospital
{
    public partial class formulario_Medico : System.Web.UI.Page


    {
        CReglasNegocioMedico oReglaMedico = new CReglasNegocioMedico();
        CEntidadMedico oEntidadMedico= new CEntidadMedico();


        protected void Limpiar()
        {
            TextBoxIdMedicoMedico.Text = "";
            TextBoxNombreMedico.Text = "";
            TextBoxEspecialidadMedico.Text = "";
            TextBoxTelefonoMedico.Text = "";
            LabelMensajeMedico.Text = "";
        }

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButtonGuardarMedico_Click(object sender, EventArgs e)
        {

            oEntidadMedico.Id_medico = TextBoxIdMedicoMedico.Text;
            oEntidadMedico.Nom_medico =TextBoxNombreMedico.Text;
            oEntidadMedico.Especialidad =TextBoxEspecialidadMedico.Text;
            oEntidadMedico.Tel_medico = TextBoxTelefonoMedico.Text;

            if (oReglaMedico.Guardar_Medico(oEntidadMedico))
            {
                LabelMensajeMedico.Text = "  Medico  Registro  Exitosamente";
            }
            else
            {
                LabelMensajeMedico.Text = "ERROR.......... al guardar el Medico";
            }

        }

        protected void ButtonConsultarMedico_Click(object sender, EventArgs e)
        {
            if (TextBoxIdMedicoMedico.Text ==" ")
            {
                LabelMensajeMedico.Text = " No se ha digitado el ID de medico ";
                TextBoxIdMedicoMedico.Focus();
            }
            else
            {
                DataSet ds = new DataSet();

                oEntidadMedico.Id_medico = TextBoxIdMedicoMedico.Text;
                ds = oReglaMedico.Consultar_Medico(oEntidadMedico);
                if (ds.Tables[0].Rows.Count == 0)
                {
                    LabelMensajeMedico.Text = "Medico Disponible";
                    TextBoxNombreMedico.Focus();
                    Limpiar();
                    //Activar();
                }
                else
                {
                    TextBoxNombreMedico.Text = ds.Tables[0].Rows[0]["nom_medico"].ToString();
                    TextBoxEspecialidadMedico.Text = ds.Tables[0].Rows[0]["especialidad"].ToString();
                    TextBoxTelefonoMedico.Text = ds.Tables[0].Rows[0]["tel_medico"].ToString();

                }
            }
        }

        protected void ButtonLimpiarMedico_Click(object sender, EventArgs e)
        {

            TextBoxIdMedicoMedico.Text = "";
            Limpiar();
            TextBoxIdMedicoMedico.Focus();

        }
    }
}