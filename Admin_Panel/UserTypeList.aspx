<%@ Page Title="" Language="C#" MasterPageFile="~/Admin_Panel/Admin_MasterPage.master" AutoEventWireup="true" CodeFile="UserTypeList.aspx.cs" Inherits="Admin_Panel_UserTypeList" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
     List Of User Types
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    
        <asp:Button ID="btnUTAdd" runat="server" Text="Add New" OnClick="btnUTAdd_Click" />
    <div id="display" runat ="server" ></div>
</asp:Content>

