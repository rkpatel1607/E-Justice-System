<%@ Page Title="" Language="C#" MasterPageFile="~/Member_Panel/Member_master.master" AutoEventWireup="true" CodeFile="Police_Station.aspx.cs" Inherits="Member_Panel_Police_Station" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    
   
    
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

   

    <table class="auto-style1">
         <tr>
            <td colspan="2" align="center" class="auto-style2">
             
                Police Station Details</td>
        </tr>
        <tr>
            <td>City:</td>
            <td>
                <asp:DropDownList ID="ddlcity" runat="server">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td>Zone:</td>
            <td>
                <asp:DropDownList ID="dlzone" runat="server">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td>Area:</td>
            <td>
                <asp:DropDownList ID="ddlarea" runat="server">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td colspan="2" align="center" class="auto-style2">
           
                <asp:Button ID="btnsbmt" runat="server" Text="Submit" />
           
             </td>
        </tr>
       
    </table>

   

</asp:Content>

