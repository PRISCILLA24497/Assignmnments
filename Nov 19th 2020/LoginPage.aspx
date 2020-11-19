<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LoginPage.aspx.cs" Inherits="WebApiregisterform.LoginPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style4 {
            width: 33px;
        }
        .auto-style5 {
            height: 23px;
            width: 33px;
        }
        .auto-style6 {
            margin-left: 19px;
        }
        .auto-style8 {
            height: 23px;
            width: 21px;
        }
        .auto-style9 {
            width: 21px;
        }
        .auto-style10 {
            margin-left: 17px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Hi!!Welcome</h2>
            <h3>Please Login to Continue</h3>
            <p>Login</p>
          
                <table>
                    <tr>
                        <td class="auto-style9">Username</td>
                        <td class="auto-style4">
                            <asp:TextBox ID="TextBox1" runat="server" Width="151px" CssClass="auto-style6" Height="22px"></asp:TextBox>
                        </td>
                      
                    </tr>
                    <tr>
                        <td class="auto-style8">Password</td>
                        <td class="auto-style5">
                            <asp:TextBox ID="TextBox2" runat="server" Width="153px" TextMode="Password" CssClass="auto-style10" Height="29px"></asp:TextBox>
                        </td>
                      
                    </tr>
                    <tr>
                        <td class="auto-style9">
                            <asp:Button ID="Button1" runat="server" ForeColor="Blue" OnClick="Button1_Click" Text="Submit" />
                              
                        </td>
                        
                    </tr>
                    <asp:HiddenField ID="HFCount" runat="server"  Value="0"/>
                </table>
           
        </div>
        <asp:Label ID="Label2" runat="server"></asp:Label>
    </form>
</body>
</html>
