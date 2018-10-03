<%@ Page Title="" Language="C#" MasterPageFile="~/Admin_Panel/Admin_MasterPage.master" AutoEventWireup="true" CodeFile="AreaEdit.aspx.cs" Inherits="Admin_Panel_AreaEdit" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    Add / Modify Area
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">

    <table>
        <tr>
            <td>City
            </td>
            <td>
                <asp:DropDownList ID="ddlCity" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlCity_SelectedIndexChanged"></asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td>Zone
            </td>
            <td>
                <asp:DropDownList ID="ddlZone" runat="server" AutoPostBack="True"></asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td>Area Name</td>
            <td>
                <asp:TextBox ID="txtareaname" runat="server"></asp:TextBox>
            </td>
        </tr>

        <tr>
            <td colspan="2" align="center" class="auto-style2">
                <asp:Button ID="btnarsbmt" runat="server" Text="Submit" OnClick="btnarsbmt_Click" />
            </td>
        </tr>
    </table>

</asp:Content>

