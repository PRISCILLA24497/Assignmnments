﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Student.aspx.cs" Inherits="Databoundcontrol.Student" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
         <div style="background-color:lime">
            <asp:Repeater ID="RP1" runat="server">
                <HeaderTemplate>
                    <table>
                        <tr>
                            <td>Student Data</td>
                        </tr>
                    </table>
                    
                </HeaderTemplate>
                <ItemTemplate>
                    <table style="width:100%; border:solid 2px;background-color:lightblue">
            <tr>
                <td class="auto-style1">
                    <asp:Label ID="Label1" runat="server" Text="StudentId"></asp:Label>
                </td>
                <td><asp:Label ID="Label11" runat="server" Text='<% #Eval("StudentId")%>'></asp:Label></td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1"><asp:Label ID="Label2" runat="server" Text="StudentName"></asp:Label></td>
                <td><asp:Label ID="Label10" runat="server" Text='<% #Eval("StudentName")%>'></asp:Label></td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1"><asp:Label ID="Label3" runat="server" Text="StudentEmail"></asp:Label></td>
                <td><asp:Label ID="Label12" runat="server" Text='<% #Eval("StudentEmail")%>'></asp:Label></td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1"><asp:Label ID="Label4" runat="server" Text="StudentMbl"></asp:Label></td>
                <td><asp:Label ID="Label13" runat="server" Text='<% #Eval("StudentMbl")%>'></asp:Label></td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1"><asp:Label ID="Label5" runat="server" Text="StudentGender"></asp:Label></td>
                <td><asp:Label ID="Label14" runat="server" Text='<% #Eval("StudentGender")%>'></asp:Label></td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1"><asp:Label ID="Label6" runat="server" Text="StudentRollNo"></asp:Label></td>
                <td><asp:Label ID="Label15" runat="server" Text='<% #Eval("StudentRollNo")%>'></asp:Label></td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1"><asp:Label ID="Label7" runat="server" Text="StudentCity"></asp:Label></td>
                <td><asp:Label ID="Label16" runat="server" Text='<% #Eval("StudentCity")%>'></asp:Label></td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1"><asp:Label ID="Label8" runat="server" Text="StudentAddress"></asp:Label></td>
                <td><asp:Label ID="Label17" runat="server" Text='<% #Eval("StudentAddress")%>'></asp:Label></td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1"><asp:Label ID="Label9" runat="server" Text="StudentImage"></asp:Label></td>
                <td rowspan="5"><asp:Image ID="image1" runat="server" Width="100px" ImageUrl='cloud.jpg<% #Eval("StudentImage")%>'></asp:Image></td>
                <td>&nbsp;</td>
            </tr>
        </table>

                </ItemTemplate>
                <FooterTemplate>
                    <table style="background-color:aqua;border:solid 2px;color:red">
                        <tr>
                            <td>
                                 @developed by Priscilla
                            </td>
                           
                        </tr>
                    </table>
                </FooterTemplate>
                
            </asp:Repeater>
        </div>
        
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT * FROM [Student]"></asp:SqlDataSource>
        
    </form>
</body>
</html>
