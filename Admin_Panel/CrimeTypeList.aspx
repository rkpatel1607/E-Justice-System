<%@ Page Title="" Language="C#" MasterPageFile="~/Admin_Panel/Admin_MasterPage.master" AutoEventWireup="true" CodeFile="CrimeTypeList.aspx.cs" Inherits="Admin_Panel_CrimeTypeList" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    List Of Crime Types
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    <asp:Button ID="btnctadd" runat="server" Text="Add New" OnClick="btnctadd_Click" />
    <div id="display" runat ="server" ></div>
</asp:Content>

