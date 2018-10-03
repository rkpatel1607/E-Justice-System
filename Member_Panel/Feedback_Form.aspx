<%@ Page Title="" Language="C#" MasterPageFile="~/Member_Panel/Member_master.master" AutoEventWireup="true" CodeFile="Feedback_Form.aspx.cs" Inherits="Member_Panel_Feedback_Form" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    Feedback Form
    
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table class="auto-style1">
        <tr>
            <td>First Name:</td>
            <td>
                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>Last Name:</td>
            <td>
                <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>Email:</td>
            <td>
                <asp:TextBox ID="TextBox3" runat="server" TextMode="Email"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>Feedback:</td>
            <td>
                <asp:TextBox ID="TextBox4" runat="server" TextMode="MultiLine"></asp:TextBox>
            </td>
        </tr>
         <tr>
            
            <td colspan="2" align="center" class="auto-style2">
            
                
            
                <asp:Button ID="btnsbmit" runat="server" Text="Submit" />
                <asp:Button ID="btncncl" runat="server" Text="Cancel" />
            
                
            
            </td>
     
       
        </tr>
    </table>
</asp:Content>

