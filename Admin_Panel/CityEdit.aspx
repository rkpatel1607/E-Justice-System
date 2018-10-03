<%@ Page Title="" Language="C#" MasterPageFile="~/Admin_Panel/Admin_MasterPage.master" AutoEventWireup="true" CodeFile="CityEdit.aspx.cs" Inherits="Admin_Panel_CityEdit" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    Add / Modify City
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <table>
        <tr>
            <td>City Name</td>
            <td>
                <asp:TextBox ID="txtCName" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td colspan ="2" align="center">
                <asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="btnSubmit_Click" />
            </td>
        </tr>
    </table>
</asp:Content>

