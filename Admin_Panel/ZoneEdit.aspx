<%@ Page Title="" Language="C#" MasterPageFile="~/Admin_Panel/Admin_MasterPage.master" AutoEventWireup="true" CodeFile="ZoneEdit.aspx.cs" Inherits="Admin_Panel_ZoneEdit" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    Add / Modify Zone
    
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table>
        <tr>
            <td>Zone Name</td>
            <td>
                <asp:TextBox ID="txtzName" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td colspan ="2" align="center">
                
                <asp:Button ID="btnzsbmt" runat="server" Text="Submit" OnClick="btnzsbmt_Click" />
                
            </td>
        </tr>
    </table>
</asp:Content>      