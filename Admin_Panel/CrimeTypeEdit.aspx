<%@ Page Title="" Language="C#" MasterPageFile="~/Admin_Panel/Admin_MasterPage.master" AutoEventWireup="true" CodeFile="CrimeTypeEdit.aspx.cs" Inherits="Admin_Panel_CrimeTypeEdit" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    Add / Modify Crime Type
   
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table>
        <tr>
            <td>Crime Type</td>
            <td>
                <asp:TextBox ID="txtctname" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td colspan ="2" align="center">
                <asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="btnSubmit_Click" />
        </tr>
    </table>
</asp:Content>

