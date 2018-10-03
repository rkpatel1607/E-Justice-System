<%@ Page Title="" Language="C#" MasterPageFile="~/Member_Panel/Member_master.master" AutoEventWireup="true" CodeFile="Crime_Report.aspx.cs" Inherits="Member_Panel_Crime_Report" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    Report The Crime
   
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table class="auto-style1">
        <tr>
            <td>Email:</td>
            <td>
                <asp:TextBox ID="txtemail" runat="server" TextMode="Email"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>Crime Type:</td>
            <td>
                <asp:DropDownList ID="ddlctname" runat="server">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td>Crime City:</td>
            <td>
                <asp:DropDownList ID="ddlcity" runat="server">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td>Crime Zone:</td>
            <td>
                <asp:DropDownList ID="ddlzone" runat="server">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td>Crime Area:</td>
            <td>
                <asp:DropDownList ID="ddlarea" runat="server">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td>Date Of Crime:</td>
            <td>
                <asp:TextBox ID="txtdate" runat="server" TextMode="Date"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>Crime Details:</td>
            <td>
                <asp:TextBox ID="txtdetails" runat="server" TextMode="MultiLine"></asp:TextBox>
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

