<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="FlightAssignmenr.Register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
	<style type="text/css">
		.auto-style5 {
			height: 63px;
		}
		.auto-style9 {
			height: 60px;
		}
		.auto-style11 {
			height: 65px;
		}
		.auto-style12 {
			height: 59px;
		}
		.auto-style14 {
			height: 63px;
			width: 274px;
		}
		.auto-style16 {
			height: 60px;
			width: 274px;
		}
		.auto-style17 {
			height: 65px;
			width: 274px;
		}
		.auto-style18 {
			height: 59px;
			width: 274px;
		}
		.auto-style19 {
			margin-top: 9px;
		}
		.auto-style27 {
			height: 73px;
			width: 274px;
		}
		.auto-style28 {
			height: 73px;
		}
		.auto-style40 {
			height: 63px;
			width: 322px;
		}
		.auto-style42 {
			height: 60px;
			width: 322px;
		}
		.auto-style43 {
			height: 65px;
			width: 322px;
		}
		.auto-style44 {
			height: 73px;
			width: 322px;
		}
		.auto-style45 {
			height: 59px;
			width: 322px;
		}
		.auto-style46 {
			height: 35px;
			width: 322px;
		}
		.auto-style47 {
			height: 35px;
			width: 274px;
		}
		.auto-style48 {
			height: 35px;
		}
		.auto-style49 {
			height: 51px;
			width: 322px;
		}
		.auto-style50 {
			height: 51px;
			width: 274px;
		}
		.auto-style51 {
			height: 51px;
		}
	</style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        	&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; REGISTER<br />
			<table style="width:100%;">
				<tr>
					<td class="auto-style46">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;USERID&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </td>
					<td class="auto-style47">
						<asp:TextBox ID="TextBox1" runat="server" BackColor="#FF9900" BorderColor="#FF3300" Height="59px" Width="262px"></asp:TextBox>
						<asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox1" ErrorMessage="Please Enter Your UserID" ForeColor="Red"></asp:RequiredFieldValidator>
					</td>
					<td class="auto-style48"></td>
				</tr>
				<tr>
					<td class="auto-style40">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; NAME&nbsp;</td>
					<td class="auto-style14">
						<asp:TextBox ID="TextBox2" runat="server" BackColor="#FF9900" BorderColor="#FF3300" CssClass="auto-style19" Height="55px" Width="256px"></asp:TextBox>
						<br />
						<asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBox2" ErrorMessage="Please Enter Your Name" ForeColor="#FF3300"></asp:RequiredFieldValidator>
					</td>
					<td class="auto-style5"></td>
				</tr>
				<tr>
					<td class="auto-style49">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; PASSWORD&nbsp;</td>
					<td class="auto-style50">
						<asp:TextBox ID="TextBox3" runat="server" BackColor="#FF9900" BorderColor="#FF3300" Height="55px" TextMode="Password" Width="253px"></asp:TextBox>
						<br />
						<asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="TextBox3" ErrorMessage="Please Enter Your Password" ForeColor="Red"></asp:RequiredFieldValidator>
					</td>
					<td class="auto-style51"></td>
				</tr>
				<tr>
					<td class="auto-style42">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; CONFIRM PASSWORD</td>
					<td class="auto-style16">
						<asp:TextBox ID="TextBox4" runat="server" BackColor="#FF9900" BorderColor="#FF3300" Height="51px" Width="256px" TextMode="Password"></asp:TextBox>
						<br />
						<asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="TextBox4" ErrorMessage="Please Confim Your Password" ForeColor="Red"></asp:RequiredFieldValidator>
					</td>
					<td class="auto-style9"></td>
				</tr>
				<tr>
					<td class="auto-style43">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; AGE</td>
					<td class="auto-style17">
						<asp:TextBox ID="TextBox5" runat="server" BackColor="#FF9900" BorderColor="#FF3300" Height="65px" Width="255px"></asp:TextBox>
						<br />
						<asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="TextBox5" ErrorMessage="Please Enter Your Age" ForeColor="Red"></asp:RequiredFieldValidator>
					</td>
					<td class="auto-style11"></td>
				</tr>
				<tr>
					<td class="auto-style44">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; GENDER</td>
					<td class="auto-style27">&nbsp;&nbsp;&nbsp;&nbsp;
						<asp:RadioButton ID="RadioButton1" runat="server" Font-Bold="True" ForeColor="#669900" GroupName="GENDER" Text="Male" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
						<asp:RadioButton ID="RadioButton2" runat="server" Font-Bold="True" ForeColor="#FF0066" GroupName="GENDER" Text="Female" />
					</td>
					<td class="auto-style28"></td>
				</tr>
				<tr>
					<td class="auto-style45">
						<asp:Button ID="Button1" runat="server" BackColor="Lime" BorderStyle="Groove" Font-Bold="True" Height="70px" Text="REGISTER" Width="179px" OnClick="Button1_Click" />
					</td>
					<td class="auto-style18">&nbsp;</td>
					<td class="auto-style12">&nbsp;</td>
				</tr>
			</table>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        	<asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT * FROM [Flight1]"></asp:SqlDataSource>
        </div>
    </form>
</body>
</html>
