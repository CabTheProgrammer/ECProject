<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ProductData.aspx.cs" Inherits="ECProject.ProductData" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ProductsConnectionString %>" SelectCommand="SELECT * FROM [PRODUCT_INFO]"></asp:SqlDataSource>
    <div class ="row">
        
            <asp:Image ID="Image1" runat="server" class="img-fluid mx-auto d-block" style="max-width:50%"/>
        
            <asp:Label ID="Name" runat="server" Text="Label"></asp:Label>
        <asp:Label ID="Description" runat="server" Text="Label"></asp:Label>
        <asp:Label ID="Price" runat="server" Text="Label"></asp:Label>
        <asp:Label ID="Category" runat="server" Text="Label"></asp:Label>
        <asp:Label ID="ISBN" runat="server" Text="Label"></asp:Label>
    </div>

</asp:Content>
