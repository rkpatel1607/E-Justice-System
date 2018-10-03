<%@ Page Title="" Language="C#" MasterPageFile="~/Admin_Panel/Admin_MasterPage.master" AutoEventWireup="true" CodeFile="NewsEdit.aspx.cs" Inherits="Admin_Panel_NewsEdit" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    Add / Modify News
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table>
        <tr>
            <td>News Title</td>
            <td>
                <asp:TextBox ID="txtntname" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td>News Date</td>
            <td>
                <asp:TextBox ID="txtdate" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td>News Description</td>
            <td>
                <asp:TextBox ID="txtndname" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td>News Image</td>
            <td>
                <asp:FileUpload ID="fulnews" runat="server" />
                <asp:Image ID="Imgnews" runat="server" />
                <asp:HiddenField ID="Hdfnews" runat="server" />
            </td>
        </tr>
        <tr>
            <td colspan ="2" align="center">
                <asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="btnSubmit_Click" />
            </td>
        </tr>
    </table>

</asp:Content>

