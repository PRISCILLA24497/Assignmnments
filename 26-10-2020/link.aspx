<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="link.aspx.cs" Inherits="linkexample.link" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
			<asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click">Instagram</asp:LinkButton><br />
			<asp:LinkButton ID="string" runat="server" OnClientClick="string" OnClick="LinkButton2_Click" >Facebook</asp:LinkButton><br />
			<asp:LinkButton ID="LinkButton2" runat="server" OnLoad="LinkButton2_Load">Twitter</asp:LinkButton><br /><br />
			<p>
				<asp:Label ID="Label1" runat="server"></asp:Label><br />
				<asp:Label ID="Label2" runat="server"></asp:Label><br />
				<asp:Label ID="Label3" runat="server" ></asp:Label>
			</p>
        </div>
    </form>
</body>
</html>
