<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication1._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <table style="width: 80%;">
        <caption>Exo CRUD</caption>
        <tr>
            <th style="margin:0 1rem"> Last Name </th>
            <th style="margin:0 1rem"> First Name </th>
            <th style="margin:0 1rem"> Age </th>
        </tr>
        <tr>
            <td> <asp:Label ID="LastName" runat="server"></asp:Label> </td>
            <td> <asp:Label ID="FirstName" runat="server"></asp:Label> </td>
            <td> <asp:Label ID="Age" runat="server"></asp:Label> </td>
        </tr>
    </table>

</asp:Content>
