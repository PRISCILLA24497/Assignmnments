<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Flight1.aspx.cs" Inherits="FlightAssignmenr.Flight1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
<style type="text/css">
        .auto-style1 {
            width: 280px;
        }
        .auto-style2 {
            width: 253px;
        }
        .auto-style3 {
            width: 897px;
            height: 514px;
        }
        .auto-style4 {
            width: 108%;
            height: 253px;
        }
        .auto-style5 {
            margin-left: 29px;
        }
    </style>
</head>
<body  style="background-image:url('newbooking2.jfif');background-repeat:no-repeat;background-size:cover">
    <form id="form1" runat="server" class="auto-style3">
        <div>
        </div>
        <asp:GridView ID="GridView1" runat="server" Height="139px" Width="247px">
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT * FROM [Booking1]"></asp:SqlDataSource>
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        <table class="auto-style4">
            <tr>
                <td class="auto-style1">UserName</td>
                <td class="auto-style2">
                    <asp:TextBox ID="TextBox1" runat="server" Height="41px" Width="185px"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1">Age</td>
                <td class="auto-style2">
                    <asp:TextBox ID="TextBox2" runat="server" Height="36px" Width="180px"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1">Gender</td>
                <td class="auto-style2">
                    <asp:RadioButton ID="RadioButton1" runat="server" GroupName="gender" Text="Male" />
                    <asp:RadioButton ID="RadioButton2" runat="server" GroupName="gender" Text="Female" />
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1">Source</td>
                <td class="auto-style2">
                    <asp:TextBox ID="TextBox3" runat="server" Height="41px" Width="182px"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1">Destination</td>
                <td class="auto-style2">
                    <asp:TextBox ID="TextBox4" runat="server" Height="37px" Width="179px"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1">Class</td>
                <td class="auto-style2">
                    <asp:DropDownList ID="DropDownList1" runat="server" Height="20px" Width="108px">
                        <asp:ListItem>Select class</asp:ListItem>
                        <asp:ListItem>General Class</asp:ListItem>
                        <asp:ListItem>Common Class</asp:ListItem>
                        <asp:ListItem>Economy Class</asp:ListItem>
                    </asp:DropDownList>
                </td>
                <td>&nbsp;</td>
            </tr>
        </table>
        <asp:Button ID="Button2" runat="server" ForeColor="Black" OnClick="Button2_Click" Text="Book A Ticket" Height="46px" Width="150px" CssClass="auto-style5" BackColor="#0066FF" />
         &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;
        <asp:Button ID="Button1" runat="server" BackColor="#66FFFF" OnClick="Button1_Click" Text="Get a ticket" Height="48px" Width="152px" />
      
        
        <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT * FROM [Booking1]"></asp:SqlDataSource>
        <asp:SqlDataSource ID="SqlDataSource3" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT * FROM [Booking1]"></asp:SqlDataSource>
    </form>
</body>
</html>
