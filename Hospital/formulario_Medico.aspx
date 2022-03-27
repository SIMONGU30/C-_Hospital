<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="formulario_Medico.aspx.cs" Inherits="Hospital.formulario_Medico" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <link href="estilos_Medico.css" rel="stylesheet" />
    <title></title>
</head>
<body>
    <h1>
        Medico
    </h1>
    <form id="form1" runat="server">

         <asp:Label ID="LabelIdMedicoMedico" runat="server" Text="Identificacion Medico "></asp:Label><br />
        <asp:TextBox ID="TextBoxIdMedicoMedico" runat="server"  ></asp:TextBox><br />
        <asp:Label ID="LabelMensajeMedico" runat="server" Text=""></asp:Label>


        <asp:Label ID="LabelNombreMedico"   runat="server" Text="Nombre Medico"></asp:Label><br />
        <asp:TextBox ID="TextBoxNombreMedico" runat="server"  ></asp:TextBox><br />

        <asp:Label ID="LabelEspecialidadMedico"  runat="server" Text="Especialidad Medico"></asp:Label><br />
        <asp:TextBox ID="TextBoxEspecialidadMedico" runat="server"  ></asp:TextBox><br />

        <asp:Label ID="LabelTelefonoMedico"  runat="server" Text="Telefono"></asp:Label><br />
        <asp:TextBox ID="TextBoxTelefonoMedico" runat="server"   ></asp:TextBox><br />
     
           
        <asp:Label ID="LabelActivoMedico"   runat="server" Text="Activo"></asp:Label><br />
        <asp:TextBox ID="TextBoxActivoMedico" runat="server" CssClass="mb-4" ></asp:TextBox><br />

        <asp:Button ID="ButtonGuardarMedico" runat="server" Text="Guardar" OnClick="ButtonGuardarMedico_Click" />
        <asp:Button ID="ButtonConsultarMedico" runat="server" Text="Consultar" OnClick="ButtonConsultarMedico_Click" />
        <asp:Button ID="ButtonLimpiarMedico" runat="server" Text="Limpiar" OnClick="ButtonLimpiarMedico_Click" />

    </form>
    <script src="Scripts/bootstrap.min.js"></script>
</body>
</html>
