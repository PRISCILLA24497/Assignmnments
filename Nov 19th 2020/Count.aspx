<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Count.aspx.cs" Inherits="WebApiregisterform.Count" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
           
            <asp:Button ID="Button1" runat="server" Text="Hit Count" ForeColor="#CC0000" Height="33px" Width="83px" OnClick="Button1_Click" />
        
            <asp:Button ID="Button2" runat="server" Text="Submit"  PostBackUrl="~/Hiddencount.aspx" OnClick="Button2_Click" style="width: 61px"/>
            <asp:HiddenField ID="HFCount" runat="server" Value="0" OnValueChanged="HFCount_ValueChanged" />
        </div>
    </form>
</body>
</html>
