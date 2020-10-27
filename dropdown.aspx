<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="dropdown.aspx.cs" Inherits="cookies.dropdown" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
			<asp:DropDownList ID="dropdownlist1" runat="server" OnSelectedIndexChanged="dropdownlist1_SelectedIndexChanged">
                <asp:ListItem Value="please select"></asp:ListItem>
                <asp:ListItem>Visakhapatnam</asp:ListItem>
                <asp:ListItem>Banglore</asp:ListItem>
                <asp:ListItem>pune</asp:ListItem>
                <asp:ListItem>Hyderabad</asp:ListItem>
                <asp:ListItem>Kolkata</asp:ListItem>
            </asp:DropDownList><br />
            <br />
            <asp:Button ID="button1" Text="submit" runat="server" OnClick="button1_Click" />

        </div>
		 <p>
            <asp:Label ID="label1" runat="server"></asp:Label>
        </p>
        <asp:DropDownList ID="kavya" runat="server" Height="112px" Width="195px">
            <asp:ListItem>Please select</asp:ListItem>
            <asp:ListItem>This is working</asp:ListItem>
            <asp:ListItem>This is also working</asp:ListItem>
            <asp:ListItem>This is crazy</asp:ListItem>
            <asp:ListItem>This is something amazing</asp:ListItem>
            <asp:ListItem>Im loving it</asp:ListItem>
            <asp:ListItem>This coding is wonderful</asp:ListItem>
        </asp:DropDownList>
    </form>
</body>
</html>
