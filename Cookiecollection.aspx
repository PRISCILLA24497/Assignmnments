<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Cookiecollection.aspx.cs" Inherits="cookies.Cookiecollection" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
			 <asp:Label ID="label1" runat="server" Text="select brand performance"></asp:Label><br />
            <asp:CheckBox ID="checkbox1" runat="server" Text="iphone" OnCheckedChanged="checkbox1_CheckedChanged"/><br />
            <asp:CheckBox ID="checkbox2" runat="server" Text="samsung" /><br />
            <asp:CheckBox ID="checkbox3" runat="server" Text="oppo" /><br />
            <asp:CheckBox ID="checkbox4" runat="server" Text="realme" /><br />
            <asp:CheckBox ID="checkbox5" runat="server" Text="nokia" /><br />
            <asp:CheckBox ID="checkbox6" runat="server" Text="lenovo" /><br />
            <asp:CheckBox ID="checkbox7" runat="server" Text="motorola" /><br />
            <asp:CheckBox ID="checkbox8" runat="server" Text="mi" /><br />
            <asp:CheckBox ID="checkbox9" runat="server" Text="lyf" /><br />
            <asp:CheckBox ID="checkbox10" runat="server" Text="nazro" /><br />
            <asp:Button ID="button1" runat="server" Text="Checkon" OnClick="button1_Click" />
        </div>
    </form>
	 <p>
        <asp:Label runat="server" ID="label2"></asp:Label>
    </p>
</body>
</html>
