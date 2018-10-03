<%@ Page Title="" Language="C#" MasterPageFile="~/LogIN/LogIN_MasterPage.master" AutoEventWireup="true" CodeFile="LogInPage.aspx.cs" Inherits="LogIN_LogInPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
   
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    <table class="auto-style1">
        <tr>
            <td>Email:</td>
            <td>
                <asp:TextBox ID="txtemail" runat="server" TextMode="Email"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>Password:</td>
            <td>
                <asp:TextBox ID="txtpass" runat="server" TextMode="Password"></asp:TextBox>
            </td>
        </tr>
         <tr>
            <td colspan="2" align="center" class="auto-style2">
           
                <asp:Button ID="btnfrgtpswd" runat="server" Text="Forget Password" />
           
                <asp:Button ID="btnsbmt" runat="server" Text="Submit" />
           
                <asp:Button ID="btncncl" runat="server" Text="Cancel" OnClick="btncncl_Click" />
           
             </td>
        </tr>
    </table>

</asp:Content>

