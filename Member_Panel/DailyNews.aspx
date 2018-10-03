<%@ Page Title="" Language="C#" MasterPageFile="~/Member_Panel/Member_master.master" AutoEventWireup="true" CodeFile="DailyNews.aspx.cs" Inherits="Member_Panel_DailyNews" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div id="Display" runat="server" >
        <asp:Label ID="lbldate" runat="server" Visible="false"></asp:Label>
    </div>
</asp:Content>

