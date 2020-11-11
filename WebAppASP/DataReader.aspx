<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DataReader.aspx.cs" Inherits="WebAppASP.DataReader" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <asp:GridView ID="GridView1" runat="server" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" style="z-index: 1; left: 10px; top: 15px; position: absolute; height: 133px; width: 187px">
            </asp:GridView>

        </div>
    </form>
</body>
</html>
