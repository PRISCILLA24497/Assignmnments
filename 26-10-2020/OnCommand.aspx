<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="OnCommand.aspx.cs" Inherits="linkexample.OnCommand" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
			<asp:LinkButton ID="LinkButton1" runat="server" OnCommand="LinkButton1_Command" Text="Orderitem1" CommandName="Order" CommandArgument="1"></asp:LinkButton><br />
			<asp:LinkButton ID="LinkButton2" runat="server" OnCommand="LinkButton2_Command" Text="Orderitem2" CommandName="Order" CommandArgument="2"></asp:LinkButton><br /><br />
        </div>
		<asp:Label ID="Label1" runat="server"></asp:Label>
    </form>
</body>
</html>
