<%@ Page Title="" Language="C#" MasterPageFile="~/Admin_Panel/Admin_MasterPage.master" AutoEventWireup="true" CodeFile="UserTypeEdit.aspx.cs" Inherits="Admin_Panel_UserTypeEdit" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    Add / Modify User Type
   
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
   
    <table>
        <tr>
            <td class="auto-style1">User Type</td>
            <td>
                <asp:TextBox ID="txtUtypename" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td colspan ="2" align="center">

                <asp:Button ID="btnutypesbmt" runat="server" Text="Submit" OnClick="btnutypesbmt_Click" />

        </tr>
    </table>
   
</asp:Content>

