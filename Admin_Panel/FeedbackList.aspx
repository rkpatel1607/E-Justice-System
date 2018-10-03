<%@ Page Title="" Language="C#" MasterPageFile="~/Admin_Panel/Admin_MasterPage.master" AutoEventWireup="true" CodeFile="FeedbackList.aspx.cs" Inherits="Admin_Panel_FeedbackList" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    List of Feedback
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:Button ID="btnAdd" runat="server" Text="Add New" Height="26px" OnClick="btnAdd_Click" />
    <div id="display" runat ="server" ></div>
</asp:Content>

