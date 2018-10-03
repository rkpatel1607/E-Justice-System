<%@ Page Title="" Language="C#" MasterPageFile="~/Admin_Panel/Admin_MasterPage.master" AutoEventWireup="true" CodeFile="NewsList.aspx.cs" Inherits="Admin_Panel_NewsList" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    List Of News
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:Button ID="btnAdd" runat="server" Text="Add New" OnClick="btnAdd_Click"/>
    <div id="display" runat ="server" ></div>
</asp:Content>

