<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="textDB.aspx.cs" Inherits="Hospital.textDB" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
            <br />
            <asp:Button ID="btnTestDB" runat="server" Text="Probar conexion a SQL server" OnClick="btnTestDB_Click" />
           
        </div>
    </form>
</body>
</html>
