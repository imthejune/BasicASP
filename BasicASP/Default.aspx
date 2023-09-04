<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="BasicASP._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <main>
        <h1 class="text-center">Member</h1>
         <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="true" Width="682px"></asp:GridView>
    </main>
    
</asp:Content>
