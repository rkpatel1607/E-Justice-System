<%@ Page Title="" Language="C#" MasterPageFile="~/Admin_Panel/Admin_MasterPage.master" AutoEventWireup="true" CodeFile="LawEdit.aspx.cs" Inherits="Admin_Panel_LawEdit" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    Add / Modify Law
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table>
        <tr>
            <td>Law Type</td>
            <td>
                
                <asp:DropDownList ID="Ddlawtype" runat="server" AutoPostBack="True">
                </asp:DropDownList>
                
        </tr>
         <tr>
            <td>Law Title</td>
            <td>
                <asp:TextBox ID="txttitle" runat="server"></asp:TextBox></td>
        </tr>
         <tr>
            <td>Law Description</td>
            <td>
                <asp:TextBox ID="txtdesc" runat="server" TextMode="MultiLine"></asp:TextBox></td>
        </tr>
        <tr>
            <td colspan ="2" align="center">
                <asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="btnSubmit_Click" />
            </td>
        </tr>
    </table>
</asp:Content>

