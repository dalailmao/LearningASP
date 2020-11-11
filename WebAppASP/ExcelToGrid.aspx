<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ExcelToGrid.aspx.cs" Inherits="WebAppASP.ExcelToGrid" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #File1 {
            z-index: 1;
            left: 584px;
            top: 18px;
            position: absolute;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="Label1" runat="server" style="z-index: 1; left: 66px; top: 19px; position: absolute; height: 23px; width: 74px" Text="Add Files"></asp:Label>
        <asp:FileUpload ID="FileUpload1" runat="server" style="z-index: 1; left: 179px; top: 18px; position: absolute; height: 23px" EnableviewState ="true" ViewStateMode="Enabled"/>
        <asp:Label ID="Label4" runat="server" Font-Bold="True" ForeColor="Red" style="z-index: 1; left: 539px; top: 21px; position: absolute; width: 206px" Text="File Uploaded Successfully !!" Visible="false"></asp:Label>
        <asp:Button ID="Button1" runat="server" style="z-index: 1; left: 415px; top: 17px; position: absolute" Text="Upload" OnClick="Button1_Click" />
        <asp:Label ID="Label2" runat="server" style="z-index: 1; left: 71px; top: 61px; position: absolute; width: 258px" Text="Label" Visible="false"></asp:Label>
        <asp:GridView ID="GridView1" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None" style="z-index: 1; left: 71px; top: 100px; position: absolute; height: 180px; width: 740px">
            <AlternatingRowStyle BackColor="White" />
            <EditRowStyle BackColor="#7C6F57" />
            <FooterStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#666666" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#E3EAEB" />
            <SelectedRowStyle BackColor="#C5BBAF" Font-Bold="True" ForeColor="#333333" />
            <SortedAscendingCellStyle BackColor="#F8FAFA" />
            <SortedAscendingHeaderStyle BackColor="#246B61" />
            <SortedDescendingCellStyle BackColor="#D4DFE1" />
            <SortedDescendingHeaderStyle BackColor="#15524A" />
        </asp:GridView>
        <asp:Button ID="Button2" runat="server" style="z-index: 1; left: 367px; top: 57px; position: absolute" Text="Preview " visible ="false" OnClick="Button2_Click"/>
        <p>
            &nbsp;</p>
    </form>
</body>
</html>
