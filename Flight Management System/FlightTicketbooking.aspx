<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FlightTicketbooking.aspx.cs" Inherits="FlightAssignmenr.FlightTicketbooking" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
<style type="text/css">
        .auto-style1 {
            margin-left: 200px;
        }
    .auto-style2 {
		margin-left: 0px;
	}
    </style>
    </head>
<body >
    <form id="form1" runat="server">
		
        <div style="background-color:orange;background-repeat:no-repeat;background-size:cover">
			<h1 class="auto-style1">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Welcome to Flight Ticket Booking!!!!</h1>

            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
			<br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;

            <asp:Button ID="Button8" runat="server" OnClick="Button3_Click" Text="Register" Height="54px" Width="157px" BackColor="Lime" Font-Bold="True" Font-Italic="True" Font-Size="Large" ForeColor="Black" BorderColor="Lime" />&nbsp;&nbsp;&nbsp;<asp:Button ID="Button9" runat="server" OnClick="Button4_Click" Text="Login" Width="154px" Height="52px" BackColor="Lime" Font-Bold="True" Font-Italic="True" Font-Size="Large" BorderColor="Lime" />&nbsp;&nbsp;
            <asp:Button ID="Button10" runat="server" OnClick="Button5_Click" Text="Admin" Height="52px" Width="142px" BackColor="Lime" Font-Bold="True" Font-Italic="True" Font-Size="Large" BorderColor="Lime" />&nbsp;
            <asp:Button ID="Button11" runat="server" OnClick="Button6_Click" Text="Contact Us" Height="48px" Width="149px" BackColor="Lime" Font-Bold="True" Font-Italic="True" Font-Size="Large" BorderColor="Lime" />&nbsp;
            <asp:Button ID="Button12" runat="server" Text="Ticket Ready" Height="51px" Width="144px" BackColor="Lime" Font-Bold="True" Font-Italic="True" Font-Size="Large" OnClick="Button12_Click" BorderColor="Lime" CssClass="auto-style2" />
			&nbsp;</h1>
        <h1>&nbsp;</h1>
        <h1>&nbsp;</h1>
        <h1 class="auto-style1">&nbsp;</h1>
        
        
        
        <p>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            </p>
       
        </div>
        
           
         </form>
</body>
</html>
