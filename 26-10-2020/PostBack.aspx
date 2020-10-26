<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PostBack.aspx.cs" Inherits="linkexample.PostBack" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
			<asp:LinkButton ID="LinkButton1" runat="server" PostBackUrl= "~/About.aspx" OnClick="LinkButton1_Click" >Click me</asp:LinkButton>
        </div>
    </form>
</body>
</html>
