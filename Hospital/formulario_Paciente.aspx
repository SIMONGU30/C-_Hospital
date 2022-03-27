<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="formulario_Paciente.aspx.cs" Inherits="Hospital.formulario_Paciente" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <link href="estilos_Paciente.css" rel="stylesheet" />

    <title></title>
</head>
<body>
    <h1>Paciente</h1>
    <form id="form1" runat="server">


        <asp:Label ID="LabelPaicientePaciente" runat="server" Text="Identificacion Paciente "></asp:Label><br />
        <asp:TextBox ID="TextBoxPacientePaciente" runat="server"  ></asp:TextBox><br />
        <asp:Label ID="LabelMensajePaciente" runat="server" Text=""></asp:Label> <br />


        <asp:Label ID="LabelDocumentoPaciente"   runat="server" Text="Documento Paciente"></asp:Label><br />
        <asp:TextBox ID="TextBoxDocumentoPaciente" runat="server"  ></asp:TextBox><br />

        <asp:Label ID="LabelNombrePaceinte"  runat="server" Text="Nombre Paciente"></asp:Label><br />
        <asp:TextBox ID="TextBoxNombrePaciente" runat="server"  ></asp:TextBox><br />

        <asp:Label ID="LabelDireccionPaciente"  runat="server" Text="Direccion"></asp:Label><br />
        <asp:TextBox ID="TextBoxDireccionPaciente" runat="server"   ></asp:TextBox><br />

         <asp:Label ID="LabelTelefonoPaciente"  runat="server" Text="Telefono Paciente"></asp:Label><br />
        <asp:TextBox ID="TextBoxTelefonoPaciente" runat="server"  ></asp:TextBox><br />

        <asp:Label ID="LabelCelularPaciente"  runat="server" Text="Celular Paciente"></asp:Label><br />
        <asp:TextBox ID="TextBoxCelularPaciente" runat="server"   ></asp:TextBox><br />
     
     
           
        <asp:Label ID="LabelActivoPaciente"   runat="server" Text="Activo"></asp:Label><br />
        <asp:TextBox ID="TextBoxActivoPaciente" runat="server" CssClass="mb-4" ></asp:TextBox><br />

        <asp:Button ID="ButtonGuardarPaciente" runat="server" Text="Guardar" OnClick="ButtonGuardarPaciente_Click" />
        <asp:Button ID="ButtonLimpiarPaciente" runat="server" Text="Limpiar" OnClick="ButtonLimpiarPaciente_Click"  />

    </form>
    <script src="Scripts/bootstrap.min.js"></script>
</body>

</html>
