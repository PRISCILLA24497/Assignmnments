<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Listview.aspx.cs" Inherits="ListView.Listview" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        	<asp:ListView ID="LV1" runat="server" OnSelectedIndexChanged="ListView1_SelectedIndexChanged">
				<AlternatingItemTemplate>
					<tr style="background-color: #FAFAD2;color: #284775;">
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
				</AlternatingItemTemplate>
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
				<LayoutTemplate>
					<table runat="server">
						<tr runat="server">
							<td runat="server">
								<table id="itemPlaceholderContainer" runat="server" border="1" style="background-color: #FFFFFF;border-collapse: collapse;border-color: #999999;border-style:none;border-width:1px;font-family: Verdana, Arial, Helvetica, sans-serif;">
									<tr runat="server" style="background-color: #FFFBD6;color: #333333;">
										<th runat="server">ID</th>
										<th runat="server">Name</th>
										<th runat="server">Email</th>
										<th runat="server">PhoneNo</th>
										<th runat="server">Department</th>
									</tr>
									<tr id="itemPlaceholder" runat="server">
									</tr>
								</table>
							</td>
						</tr>
						<tr runat="server">
							<td runat="server" style="text-align: center;background-color: #FFCC66;font-family: Verdana, Arial, Helvetica, sans-serif;color: #333333;"></td>
						</tr>
					</table>
				</LayoutTemplate>
				<SelectedItemTemplate>
					<tr style="background-color: #FFCC66;font-weight: bold;color: #000080;">
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
				</SelectedItemTemplate>
			</asp:ListView>
        </div>
    	<asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT * FROM [Student]"></asp:SqlDataSource>
    </form>
</body>
</html>
