<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddRegionADO.aspx.cs" Inherits="WebAppASP.AddRegionADO" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label2" runat="server" style="z-index: 1; left: 75px; top: 70px; position: absolute" Text="ID"></asp:Label>
            <asp:Label ID="Label3" runat="server" style="z-index: 1; left: 75px; top: 110px; position: absolute; height: 19px" Text="Is Active Status"></asp:Label>
            <asp:Label ID="Label4" runat="server" style="z-index: 1; left: 77px; top: 152px; position: absolute; height: 20px" Text="Name"></asp:Label>
        </div>
        <asp:TextBox ID="TextBox1" runat="server" style="z-index: 1; left: 209px; top: 70px; position: absolute"></asp:TextBox>
        <asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="SqlDataSource1" DataTextField="IsActive" DataValueField="IsActive" style="z-index: 1; left: 211px; top: 112px; position: absolute; height: 36px; width: 149px">
            <asp:ListItem>Select</asp:ListItem>
            <asp:ListItem>0</asp:ListItem>
            <asp:ListItem>1</asp:ListItem>
        </asp:DropDownList>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:EmployeesConnectionString %>" SelectCommand="SELECT DISTINCT [IsActive] FROM [regions]"></asp:SqlDataSource>
        <asp:TextBox ID="TextBox2" runat="server" style="z-index: 1; left: 207px; top: 158px; position: absolute"></asp:TextBox>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" style="z-index: 1; left: 89px; top: 205px; position: absolute; width: 225px" Text="ADD REGION" />
    </form>
</body>
</html>
