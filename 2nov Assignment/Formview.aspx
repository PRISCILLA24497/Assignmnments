<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Formview.aspx.cs" Inherits="ListView.Formview" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        	<asp:FormView ID="FormView1" runat="server" CellPadding="4" ForeColor="#333333" OnPageIndexChanging="FormView1_PageIndexChanging">
				<FooterStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
				<HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
				<PagerStyle BackColor="#FFCC66" ForeColor="#333333" HorizontalAlign="Center" />
				<RowStyle BackColor="#FFFBD6" ForeColor="#333333" />
				
				<EditItemTemplate>
					<tr style="background-color: #FFCC66;color: #000080;">
						<td>
							<asp:Button ID="UpdateButton" runat="server" CommandName="Update" Text="Update" />
							<asp:Button ID="CancelButton" runat="server" CommandName="Cancel" Text="Cancel" />
						</td>
						<td>
							<asp:TextBox ID="IDTextBox" runat="server" Text='<%# Bind("ID") %>' />
						</td>
						<td>
							<asp:TextBox ID="NameTextBox" runat="server" Text='<%# Bind("Name") %>' />
						</td>
						<td>
							<asp:TextBox ID="EmailTextBox" runat="server" Text='<%# Bind("Email") %>' />
						</td>
						<td>
							<asp:TextBox ID="PhoneNoTextBox" runat="server" Text='<%# Bind("PhoneNo") %>' />
						</td>
						<td>
							<asp:TextBox ID="DepartmentTextBox" runat="server" Text='<%# Bind("Department") %>' />
						</td>
					</tr>
				</EditItemTemplate>
				<EmptyDataTemplate>
					<table runat="server" style="background-color: #FFFFFF;border-collapse: collapse;border-color: #999999;border-style:none;border-width:1px;">
						<tr>
							<td>No data was returned.</td>
						</tr>
					</table>
				</EmptyDataTemplate>
				<InsertItemTemplate>
					<tr style="">
						<td>
							<asp:Button ID="InsertButton" runat="server" CommandName="Insert" Text="Insert" />
							<asp:Button ID="CancelButton" runat="server" CommandName="Cancel" Text="Clear" />
						</td>
						<td>
							<asp:TextBox ID="IDTextBox" runat="server" Text='<%# Bind("ID") %>' />
						</td>
						<td>
							<asp:TextBox ID="NameTextBox" runat="server" Text='<%# Bind("Name") %>' />
						</td>
						<td>
							<asp:TextBox ID="EmailTextBox" runat="server" Text='<%# Bind("Email") %>' />
						</td>
						<td>
							<asp:TextBox ID="PhoneNoTextBox" runat="server" Text='<%# Bind("PhoneNo") %>' />
						</td>
						<td>
							<asp:TextBox ID="DepartmentTextBox" runat="server" Text='<%# Bind("Department") %>' />
						</td>
					</tr>
				</InsertItemTemplate>
				<ItemTemplate>
					<tr style="background-color: #FFFBD6;color: #333333;">
						<td>
							<asp:Label ID="IDLabel" runat="server" Text='<%# Eval("ID") %>' />
						</td>
						<td>
							<asp:Label ID="NameLabel" runat="server" Text='<%# Eval("Name") %>' />
						</td>
						<td>
							<asp:Label ID="EmailLabel" runat="server" Text='<%# Eval("Email") %>' />
						</td>
						<td>
							<asp:Label ID="PhoneNoLabel" runat="server" Text='<%# Eval("PhoneNo") %>' />
						</td>
						<td>
							<asp:Label ID="DepartmentLabel" runat="server" Text='<%# Eval("Department") %>' />
						</td>
					</tr>
				</ItemTemplate>
				
			</asp:FormView>
			<br />
			<asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT * FROM [Student]"></asp:SqlDataSource>
        </div>
    </form>
</body>
</html>
