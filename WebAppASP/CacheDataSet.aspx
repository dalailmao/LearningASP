<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CacheDataSet.aspx.cs" Inherits="WebAppASP.CacheDataSet" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:GridView ID="gvRegions" runat="server" style="z-index: 1; left: 245px; top: 167px; position: absolute; height: 133px; width: 187px">
            </asp:GridView>
            <asp:Button ID="btnLoadData" runat="server" style="z-index: 1; left: 46px; top: 39px; position: absolute; height: 19px" Text="Load data" OnClick="btnLoadData_Click" />
            <asp:Button ID="btnClearCache" runat="server" style="z-index: 1; left: 169px; top: 39px; position: absolute" Text="Clr cache" OnClick="btnClearCache_Click" />
            <asp:Label ID="lblMessage" runat="server" style="z-index: 1; left: 73px; top: 108px; position: absolute"></asp:Label>
        </div>
    </form>
</body>
</html>
