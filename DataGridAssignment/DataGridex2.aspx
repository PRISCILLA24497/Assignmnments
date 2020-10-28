<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DataGridex2.aspx.cs" Inherits="Aspgrid.DataGridex2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
				<asp:DataGrid ID="DataGrid1" runat="server" OnSelectedIndexChanged="DataGrid1_SelectedIndexChanged"></asp:DataGrid>
        </div>
		
		 
		<br /><br />

		<div>
				<asp:DataGrid ID="DataGrid3" runat="server" OnSelectedIndexChanged="DataGrid1_SelectedIndexChanged"></asp:DataGrid>
        </div>
    </form>
</body>
</html>
