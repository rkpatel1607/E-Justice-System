﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Admin_Panel/Admin_MasterPage.master" AutoEventWireup="true" CodeFile="AreaList.aspx.cs" Inherits="Admin_Panel_AreaList" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    List Of Area
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    <asp:Button ID="btnaradd" runat="server" Text="Add New" OnClick="btnaradd_Click" />
    <div id="display" runat ="server" ></div>

</asp:Content>

