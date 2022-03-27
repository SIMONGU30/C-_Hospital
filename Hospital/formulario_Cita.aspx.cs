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



        protected void Limpiar()
        {
            TextBoxFecha.Text = "";
            TextBoxIdPaciente.Text = "";
            TextBoxIdMedico.Text = "";
            TextBoxValor.Text = "";
            TextBoxDiagnostico.Text = "";
            TextBoxAcompañante.Text = "";
            TextBoxActivo.Text = "";
            LabelNombrePaciente.Text = "";
            LabelNombreMedico.Text = "";
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
            LabelNombrePaciente.Enabled = true;
            LabelNombreMedico.Enabled = true;
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
                    TextBoxActivo.Text = ds.Tables[0].Rows[0]["activo"].ToString();
                    LabelNombrePaciente.Text = ds.Tables[1].Rows[0]["nom_paciente"].ToString();
                    LabelNombreMedico.Text = ds.Tables[2].Rows[0]["nom_medico"].ToString();


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
    }
}