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
    public partial class formulario_Paciente : System.Web.UI.Page
    {
        CReglasNegocioPaciente oReglaPaciente = new CReglasNegocioPaciente();
        CEntidadPaceientes oEntidadPaciente = new CEntidadPaceientes();

        protected void Limpiar()
        {
            TextBoxPacientePaciente.Text = "";
            TextBoxDocumentoPaciente.Text = "";
            TextBoxNombrePaciente.Text = "";
            TextBoxDireccionPaciente.Text = "";
            TextBoxTelefonoPaciente.Text = "";
            TextBoxCelularPaciente.Text = "";
            LabelMensajePaciente.Text = "";
        }


        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButtonGuardarPaciente_Click(object sender, EventArgs e)
        {

            oEntidadPaciente.Id_paciente1 = TextBoxPacientePaciente.Text;
            oEntidadPaciente.Tip_doc = TextBoxDocumentoPaciente.Text;
            oEntidadPaciente.Nom_paciente = TextBoxNombrePaciente.Text;
            oEntidadPaciente.Dir_paciente = TextBoxDireccionPaciente.Text;
            oEntidadPaciente.Cel_paciente = TextBoxCelularPaciente.Text;
            oEntidadPaciente.Tel_paciente = TextBoxTelefonoPaciente.Text;


            if (oReglaPaciente.Guardar_Pacientes(oEntidadPaciente))
            {
                LabelMensajePaciente.Text = "  paciente  Registrado Exitosamente";
            }
            else
            {
                LabelMensajePaciente.Text = "ERROR.......... al guardar el paciente";
            }

        }

        protected void ButtonLimpiarPaciente_Click(object sender, EventArgs e)
        {
            TextBoxPacientePaciente.Text = "";
            Limpiar();
            TextBoxPacientePaciente.Focus();
        }
    }
}