<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Datalist.aspx.cs" Inherits="ListView.Datalist" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        	<asp:DataList ID="DataList1" runat="server" BackColor="#DEBA84" BorderColor="#DEBA84" BorderWidth="1px" CellPadding="3" BorderStyle="None" GridLines="Both" OnSelectedIndexChanged="DataList1_SelectedIndexChanged" CellSpacing="2">
				<FooterStyle BackColor="#F7DFB5" ForeColor="#8C4510" />
				<HeaderStyle BackColor="#A55129" Font-Bold="True" ForeColor="White" />
				<SelectedItemStyle BackColor="#738A9C" ForeColor="White" Font-Bold="True" />
				<ItemStyle BackColor="#FFF7E7" ForeColor="#8C4510" />
				
				<AlternatingItemTemplate>
					<table>
					<tr style="background-color: #FAFAD2;color: #284775;">
						<td>
							<asp:Label ID="IDLabel" runat="server" Text='<%# Eval("ID") %>' />
						</td>
						</tr><tr>
						<td>
							<asp:Label ID="NameLabel" runat="server" Text='<%# Eval("Name") %>' />
						</td></tr>
						<tr>
						<td>
							<asp:Label ID="EmailLabel" runat="server" Text='<%# Eval("Email") %>' />
						</td></tr><tr>
						<td>
							<asp:Label ID="PhoneNoLabel" runat="server" Text='<%# Eval("PhoneNo") %>' />
						</td></tr><tr>
						<td>
							<asp:Label ID="DepartmentLabel" runat="server" Text='<%# Eval("Department") %>' />
						</td>
					</tr>
						</table>
				</AlternatingItemTemplate>
				
				
				<EditItemTemplate>
						<tr style="background-color: #FFCC66; color: #000080;">
							<td>
								<asp:Button ID="UpdateButton" runat="server" CommandName="Update" Text="Update" />
								<asp:Button ID="CancelButton" runat="server" CommandName="Cancel" Text="Cancel" />
							</td>
						</tr>
						<tr>
							<td>
								<asp:TextBox ID="IDTextBox" runat="server" Text='<%# Bind("ID") %>' />
							</td>
						</tr>
						<td>
							<tr>
								<asp:TextBox ID="NameTextBox" runat="server" Text='<%# Bind("Name") %>' />
						</td>
						</tr><tr>
							<td>
								<asp:TextBox ID="EmailTextBox" runat="server" Text='<%# Bind("Email") %>' />
							</td>
						</tr>
						<tr>
							<td>
								<asp:TextBox ID="PhoneNoTextBox" runat="server" Text='<%# Bind("PhoneNo") %>' />
							</td>
						</tr>
						<tr>
							<td>
								<asp:TextBox ID="DepartmentTextBox" runat="server" Text='<%# Bind("Department") %>' />
							</td>
						</tr>
					
				</EditItemTemplate>
				
	
				<ItemTemplate>
					<table>
					<tr style="background-color: #FFFBD6;color: #333333;">
						<td>
							<asp:Label ID="IDLabel" runat="server" Text='<%# Eval("ID") %>' />
						</td></tr>
						<tr>
				
						<td>
							<asp:Label ID="NameLabel" runat="server" Text='<%# Eval("Name") %>' />
						</td></tr>
						<tr>
						<td>
							<asp:Label ID="EmailLabel" runat="server" Text='<%# Eval("Email") %>' />
						</td></tr>
						<tr>
						<td>
							<asp:Label ID="PhoneNoLabel" runat="server" Text='<%# Eval("PhoneNo") %>' />
						</td></tr>
						<tr>
						<td>
							<asp:Label ID="DepartmentLabel" runat="server" Text='<%# Eval("Department") %>' />
						</td>
					</tr>
						</table>
				</ItemTemplate>
				
				<SelectedItemTemplate>
					<table>
					<tr style="background-color: #FFCC66;font-weight: bold;color: #000080;">
						<td>
							<asp:Label ID="IDLabel" runat="server" Text='<%# Eval("ID") %>' />
						</td></tr><tr>
						<td>
							<asp:Label ID="NameLabel" runat="server" Text='<%# Eval("Name") %>' />
						</td></tr><tr>
						<td>
							<asp:Label ID="EmailLabel" runat="server" Text='<%# Eval("Email") %>' />
						</td></tr><tr>
						<td>
							<asp:Label ID="PhoneNoLabel" runat="server" Text='<%# Eval("PhoneNo") %>' />
						</td></tr><tr>
						<td>
							<asp:Label ID="DepartmentLabel" runat="server" Text='<%# Eval("Department") %>' />
						</td>
					</tr>
						</table>
				</SelectedItemTemplate>
				
				
			</asp:DataList>
        	<br />
			<asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT * FROM [Student]"></asp:SqlDataSource>
        </div>
    </form>
</body>
</html>
