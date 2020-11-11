<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ExportToExcel.aspx.cs" Inherits="WebAppASP.ExportToExcel" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" style="z-index: 1; left: 10px; top: 15px; position: absolute" Text="Button" />
            <asp:GridView ID="GridView1" runat="server" style="z-index: 1; left: 190px; top: 50px; position: absolute; height: 133px; width: 187px">
            </asp:GridView>
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" style="z-index: 1; left: 136px; top: 300px; position: absolute" Text="Button" />
        </div>
    </form>
</body>
</html>
