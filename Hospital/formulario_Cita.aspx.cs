using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using CapaEntidad;
using CapaReglasNegocio;

namespace Hospital
{
    public partial class formulario_Cita : System.Web.UI.Page
    {

        CEntidadCitas oEntidadCitas = new CEntidadCitas();
        CReglasNegocioCita oRegNCitas = new CReglasNegocioCita();

        CEntidadPaceientes oEntidadPacientes=new CEntidadPaceientes();
        CReglasNegocioPaciente oRegPaciente = new CReglasNegocioPaciente();

        CEntidadMedico oEntidadMedico=new CEntidadMedico();
        CReglasNegocioMedico oReglasNegocioMedico=new CReglasNegocioMedico();



        protected void Limpiar()
        {
            TextBoxFecha.Text = "";
            TextBoxIdPaciente.Text = "";
            TextBoxIdMedico.Text = "";
            TextBoxHora.Text = "";
            TextBoxValor.Text = "";
            TextBoxDiagnostico.Text = "";
            TextBoxAcompañante.Text = "";
            TextBoxActivo.Text = "";
            LabelMensajeCita.Text = "";
            ButtonNombrePaciente.Text = "PACIENTE";
            ButtonNombreMedico.Text = "MEDICO";
        }
        protected void Activar()
        {
            TextBoxFecha.Enabled = true;
            TextBoxHora.Enabled = true;
            TextBoxIdPaciente.Enabled = true;
            TextBoxIdMedico.Enabled = true;
            TextBoxValor.Enabled = true;
            TextBoxDiagnostico.Enabled = true;
            TextBoxAcompañante.Enabled = true;
            TextBoxActivo.Enabled = true;
            ButtonNombrePaciente.Enabled = true;
            ButtonNombreMedico.Enabled = true;
            ButtonGuardar.Enabled = true;
        }
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

        }

        protected void ButtonConsultar_Click(object sender, EventArgs e)
        {

            if (TextBoxCodigoCita.Text == "")
            {
                LabelMensajeCita.Text = "No se ha Digitado codigo de cita";
                TextBoxCodigoCita.Focus();


            }
            else
            {
                DataSet ds = new DataSet();
               
                oEntidadCitas.Cod_cita = TextBoxCodigoCita.Text;
                ds = oRegNCitas.Consultar_cita(oEntidadCitas);
                if (ds.Tables[0].Rows.Count == 0)
                {
                    LabelMensajeCita.Text = "Cita Disponible";
                    TextBoxCodigoCita.Focus();
                    Limpiar();
                    Activar();
                }
                else
                {
                    TextBoxFecha.Text= ds.Tables[0].Rows[0]["fecha"].ToString();
                    TextBoxHora.Text = ds.Tables[0].Rows[0]["Hora"].ToString();
                    TextBoxIdPaciente.Text = ds.Tables[0].Rows[0]["Id_paciente"].ToString();
                    TextBoxIdMedico.Text = ds.Tables[0].Rows[0]["id_Medico"].ToString();
                    TextBoxValor.Text = ds.Tables[0].Rows[0]["valor"].ToString();
                    TextBoxDiagnostico.Text = ds.Tables[0].Rows[0]["diagnostico"].ToString();
                    TextBoxAcompañante.Text = ds.Tables[0].Rows[0]["nom_acompanante"].ToString();
                    ButtonNombreMedico.Text = ds.Tables[2].Rows[0]["nom_medico"].ToString();
                    ButtonNombrePaciente.Text = ds.Tables[1].Rows[0]["nom_paciente"].ToString();

                    TextBoxActivo.Text = ds.Tables[0].Rows[0]["activo"].ToString();
                   
                   


                }

                
            }

        }

        protected void ButtonLimpiar_Click(object sender, EventArgs e)

        {
            TextBoxCodigoCita.Text = "";
            Limpiar();
            TextBoxCodigoCita.Focus();
        }

        protected void ButtonNuevo_Click(object sender, EventArgs e)
        {
            TextBoxCodigoCita.Text = "";
            Limpiar();
            TextBoxCodigoCita.Focus();
        }

        protected void ButtonGuardar_Click(object sender, EventArgs e)
        {
            oEntidadCitas.Cod_cita = TextBoxCodigoCita.Text;
            oEntidadCitas.Fecha = Convert.ToDateTime(TextBoxFecha.Text);
            oEntidadCitas.Hora = Convert.ToDateTime(TextBoxHora.Text);
            oEntidadCitas.Id_paciente1 = TextBoxIdPaciente.Text;
            oEntidadCitas.Id_medico = TextBoxIdMedico.Text;
            oEntidadCitas.Valor=Convert.ToInt32(TextBoxValor.Text);
            oEntidadCitas.Nom_acompanante = TextBoxAcompañante.Text;
            oEntidadCitas.Diagnostico = TextBoxDiagnostico.Text;

            if (oRegNCitas.Guardar_Cita(oEntidadCitas))
            {
                LabelMensajeCita.Text = "Registro Guardado Exitosamente";
            }
            else
            {
                LabelMensajeCita.Text = "ERROR.......... al guardar el registro";
            }
        }

        protected void ButtonNombreMedico_Click(object sender, EventArgs e)
        {
            if (TextBoxIdMedico.Text == "")
            {
                TextBoxIdMedico.Text = "No se ha Digitado codigo de cita";
                TextBoxIdMedico.Focus();
            }


            else
            {

                DataSet ds = new DataSet();

                oEntidadMedico.Id_medico = TextBoxIdMedico.Text;
                ds = oReglasNegocioMedico.Consultar_Medico(oEntidadMedico);

                if (ds.Tables[0].Rows.Count == 0)
                {
                    TextBoxIdMedico.Text = "Medico no existe";
                    TextBoxIdMedico.Focus();

                    //Limpiar();
                    // Activar();
                   // ButtonNombreMedico.Text = ds.Tables[2].Rows[0]["nom_medico"].ToString();
                }
                else
                {
                    ButtonNombreMedico.Text = ds.Tables[0].Rows[0]["nom_medico"].ToString();
                }

            }

           
        }

        protected void ButtonNombrePaciente_Click(object sender, EventArgs e)
        {
           


            if (TextBoxIdPaciente.Text=="")
            {
                TextBoxIdPaciente.Text = "No se ha Digitado codigo de cita";
                TextBoxIdPaciente.Focus();
            }
            else
            {
                DataSet ds = new DataSet();

                oEntidadPacientes.Id_paciente1 = TextBoxIdPaciente.Text;
                ds = oRegPaciente.Consultar_Paciente(oEntidadPacientes);

                if (ds.Tables[0].Rows.Count == 0)
                {
                     TextBoxIdPaciente.Text = " Paciente no existe ";
                      TextBoxIdPaciente.Focus();
                    // Limpiar();
                    //  Activar();
                    //ButtonNombrePaciente.Text = ds.Tables[1].Rows[0]["nom_paciente"].ToString();
                }
                else
                {
                    ButtonNombrePaciente.Text = ds.Tables[0].Rows[0]["nom_paciente"].ToString();
                }
               
            }

            
        }
    }
}