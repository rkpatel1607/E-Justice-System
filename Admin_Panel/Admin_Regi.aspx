<%@ Page Title="" Language="C#" MasterPageFile="~/Admin_Panel/Admin_MasterPage.master" AutoEventWireup="true" CodeFile="Admin_Regi.aspx.cs" Inherits="Admin_Panel_Admin_Regi" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
     <table class="auto-style1">
         <tr>
            
            <td colspan="2" align="center" class="auto-style2">
            Admin Registration
            </td>
     
       
        </tr>
        <tr>
            <td>First Name:</td>
            <td class="input-small" style="width: 54px">
                <asp:TextBox ID="txtFname" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>Last Name:</td>
            <td class="input-small" style="width: 54px">
                <asp:TextBox ID="txtLname" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>Address:</td>
            <td class="input-small" style="width: 54px">
                <asp:TextBox ID="txtAdd" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>Phone Num:</td>
            <td class="input-small" style="width: 54px">
                <asp:TextBox ID="txtPh" runat="server" TextMode="Phone"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>Gender:</td>
            <td class="input-small" style="width: 54px">
                <asp:RadioButton ID="rbMale" runat="server" AutoPostBack="True" GroupName="a" Text="Male" />
                <asp:RadioButton ID="rbFemale" runat="server" AutoPostBack="True" GroupName="a" Text="Female" />
            </td>
        </tr>
        <tr>
            <td>Email Id:</td>
            <td class="input-small" style="width: 54px">
                <asp:TextBox ID="txtEmail" runat="server" TextMode="Email"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>Password:</td>
            <td class="input-small" style="width: 54px">
                <asp:TextBox ID="txtPass" runat="server" TextMode="Password"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>Conform password:</td>
            <td class="input-small" style="width: 54px">
                <asp:TextBox ID="txtConPass" runat="server" TextMode="Password"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>Photo:</td>
            <td class="input-small" style="width: 54px">
                <asp:FileUpload ID="FUuser" runat="server" />
            </td>
        </tr>
        <tr>
            
            <td colspan="2" align="center" class="auto-style2">
            
                <asp:Button ID="btnSubmit" runat="server" Text="Submit" />
                <asp:Button ID="btnLogin" runat="server" Text="Log In" />
                <asp:Button ID="btnCncl" runat="server" Text="Cancel"/>
            
            </td>
     
       
        </tr>
    </table>
</asp:Content>

