<%@ Page Title="" Language="C#" MasterPageFile="~/Admin_Panel/Admin_MasterPage.master" AutoEventWireup="true" CodeFile="ZoneList.aspx.cs" Inherits="Admin_Panel_ZoneList" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    List Of Zone
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    
        <asp:Button ID="btnzone" runat="server" Text="Add Zone" OnClick="btnzone_Click" />
    <div id="display" runat ="server" ></div>

    
</asp:Content>

