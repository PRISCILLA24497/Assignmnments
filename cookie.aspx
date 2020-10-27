<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="cookie.aspx.cs" Inherits="cookies.cookie" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
			 <h3>select the course of the programming you want to learn</h3>
            <asp:CheckBox ID="checkbox1" runat="server" Text="PythonProgramming" />
            <asp:CheckBox ID="checkbox2" runat="server" Text="Asp.net Programming" />
            <asp:CheckBox ID="checkbox3" runat="server" Text="c Programming" />
            <asp:CheckBox ID="checkbox4" runat="server" Text="java Programming" />
            <asp:CheckBox ID="checkbox5" runat="server" Text="R Programming" />

        </div>
		 <p>
            <asp:Button ID="button1" runat="server" Text="submit" OnClick="button1_Click" />
        </p>
        <p>
            <asp:Label ID="showcourses" runat="server" Text="You are selected: "></asp:Label>
        </p>
    </form>
</body>
</html>
