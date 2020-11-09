<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TicketGeneration.aspx.cs" Inherits="FlightAssignmenr.TicketGeneration" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
	</head>
<body>
    <form id="form1" runat="server">
         <h1>Ticket Generated Successfully</h1>
       
            Welcome
            <asp:Label ID="Label1" runat="server" Text="Label" Font-Bold="True" Font-Italic="True" Font-Size="XX-Large" ForeColor="#990033"></asp:Label>
            <br />
            <br />
 Name:<asp:Label ID="Label2" runat="server" Text="Label" BackColor="#CCCCCC" Font-Bold="True" Font-Italic="True" Font-Size="X-Large" ForeColor="Red"></asp:Label><br /><br />

 Age:<asp:Label ID="Label4" runat="server" Text="Label" Font-Size="X-Large" ForeColor="Red"></asp:Label><br /><br />
 Gender:<asp:Label ID="Label5" runat="server" Text="Label" Font-Bold="True" Font-Italic="True" Font-Size="X-Large" ForeColor="Red"></asp:Label><br /><br />
            <br />
            <br />
            <br />
            <br />
		Source:<asp:Label ID="Label6" runat="server" Text="Label" Font-Bold="True" Font-Italic="True" Font-Size="X-Large" ForeColor="Red"></asp:Label>
            <br />
            <br />
		Destination:<asp:Label ID="Label7" runat="server" Text="Label" Font-Bold="True" Font-Italic="True" Font-Size="X-Large" ForeColor="Red"></asp:Label>
            <br />
            <br />
		Class:<asp:Label ID="Label8" runat="server" Text="Label" Font-Bold="True" Font-Italic="True" Font-Size="X-Large" ForeColor="Red"></asp:Label>
      
    </form>
</body>
</html>
