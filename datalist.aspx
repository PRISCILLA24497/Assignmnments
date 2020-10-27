<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="datalist.aspx.cs" Inherits="cookies.datalist" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
			<p>The datalist shows the data of datatable</p>
            <asp:DataList ID="datalist1" runat="server" Width="100px" Height="98px">
                <ItemTemplate>
                    <asp:Table ID="table1" runat="server" CellPadding="2" CellSpacing="0"
                        Border="1" BorderStyle="Double" style="width:50px;height:50px;background-color:mediumpurple"></asp:Table>
                    <tr>
                        <td>
                            <strong>FirstName</strong><span class="Cse"><%# Eval("FirstName")%></span><br />
                            <strong>LastName</strong><span class="Ece"><%# Eval("LastName")%></span><br />
                            <strong>Designation</strong><span class="Eee"><%# Eval("Designation")%></span><br />
                            <strong>Location</strong><span class="Mech"><%# Eval("Location")%></span><br />
                            <strong>Country</strong><span class="Civil"><%# Eval("Country")%></span><br />
                        </td>
                    </tr>
                </ItemTemplate>
            </asp:DataList>
        </div>
    </form>
</body>
</html>
