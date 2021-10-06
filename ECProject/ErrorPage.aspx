<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ErrorPage.aspx.cs" Inherits="ECProject.Error_Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container text-center">
        <h2>Sorry, the page you are looking for is in another castle!</h2>
        <p>Error: No such page exists</p>
    <div class ="row">
        <img src ="ImageAssets/castle.png" />
    </div>
    <asp:Button ID="Button1" class ="btn btn-danger" runat="server" Text="Return Home" OnClick="Button1_Click" />
</div>




</asp:Content>
