<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="formulario_Cita.aspx.cs" Inherits="Hospital.formulario_Cita" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <link href="estilos_Cita.css" rel="stylesheet" />
   
    <title></title>
</head>
<body>
     <h1>CITAS</h1>
    <form id="form1" runat="server" >

        

        <asp:Label ID="LabelCodigoCita"  runat="server" Text="Codigo Cita"></asp:Label> <br />
        <asp:TextBox ID="TextBoxCodigoCita" runat="server" ></asp:TextBox><br />
         <asp:Label ID="LabelMensajeCita" runat="server" Text=""></asp:Label> <br />

        <asp:Label ID="LabelFecha"   runat="server" Text="Fecha"></asp:Label><br />
        <asp:TextBox ID="TextBoxFecha" runat="server" Enabled="False" ></asp:TextBox><br />

        <asp:Label ID="LabelHora"  runat="server" Text="Hora"></asp:Label><br />
        <asp:TextBox ID="TextBoxHora" runat="server" Enabled="False" ></asp:TextBox><br />

        <asp:Label ID="LabelIdPaciente"  runat="server" Text="Identificacion Paciente"></asp:Label><br />
        <asp:TextBox ID="TextBoxIdPaciente" runat="server" Enabled="False"  ></asp:TextBox>
        <asp:Button ID="ButtonNombrePaciente" runat="server" Text="PACIENTE" OnClick="ButtonNombrePaciente_Click" />  <br />

        <asp:Label ID="LabelIdMedico" runat="server" Text="Identificacion Medico "></asp:Label><br />
        <asp:TextBox ID="TextBoxIdMedico" runat="server" Enabled="False" ></asp:TextBox>
        <asp:Button ID="ButtonNombreMedico" runat="server" Text="MEDICO" OnClick="ButtonNombreMedico_Click" />
        <br />

        <asp:Label ID="LabelValor"  runat="server" Text="Valor de la Cita"></asp:Label><br />
        <asp:TextBox ID="TextBoxValor" runat="server" Enabled="False" ></asp:TextBox><br />

        <asp:Label ID="LabelDiagnostico"  runat="server" Text="Diagnostico de la Cita"></asp:Label><br />
        <asp:TextBox ID="TextBoxDiagnostico" runat="server" Enabled="False"></asp:TextBox><br />

         <asp:Label ID="LabelAcompañante"  runat="server" Text="Acompañante"></asp:Label><br />
        <asp:TextBox ID="TextBoxAcompañante" runat="server" Enabled="False"></asp:TextBox><br />

        <asp:Label ID="LabelActivo"   runat="server" Text="Activo"></asp:Label><br />
        <asp:TextBox ID="TextBoxActivo" runat="server" CssClass="mb-4" Enabled="False"></asp:TextBox><br />

       

        <asp:Button ID="ButtonConsultar" runat="server" CssClass="form-control-sm  mt-4" Text="Consultar" OnClick="ButtonConsultar_Click" />

        <asp:Button ID="ButtonNuevo" runat="server"  CssClass="form-control-sm  mt-4" Text="Nuevo" Enabled="False" OnClick="ButtonNuevo_Click"  />

        <asp:Button ID="ButtonGuardar" runat="server" CssClass="form-control-sm  mt-4" Text="Guardar" Enabled="False" OnClick="ButtonGuardar_Click" />

        <asp:Button ID="ButtonLimpiar" runat="server" CssClass="form-control-sm  mt-4" Text="Limpiar" OnClick="ButtonLimpiar_Click"  />
       
       
    </form>

    <script src="Scripts/bootstrap.min.js"></script>
</body>
</html>
