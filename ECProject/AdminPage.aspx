<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AdminPage.aspx.cs" Inherits="ECProject.AdminPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    
    <div>
        <h1>Admin Page</h1>
        <asp:HyperLink ID="HyperLink2" runat="server" href="EditProduct.aspx">Edit Product</asp:HyperLink><br>
        <asp:HyperLink ID="HyperLink3" runat="server" href="AddProduct.aspx">Add Product</asp:HyperLink><br>
        <asp:HyperLink ID="HyperLink1" runat="server" href="RemoveProduct.aspx">Remove Product</asp:HyperLink>

    </div>
</asp:Content>
