<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="RemoveProduct.aspx.cs" Inherits="ECProject.RemoveProduct" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class ="row">
        <h2> Remove Product</h2>
        <asp:Label ID="Label1" runat="server" Text="Please enter the product id of the product to be deleted"></asp:Label>
        <asp:TextBox ID="TextBox1" runat="server" style="width:25%;"></asp:TextBox><br><br>
        <asp:Button ID="Button1" runat="server" Text="Delete" class ="btn btn-danger" OnClick="Button1_Click" />
        <asp:Label ID="Label2" runat="server" ForeColor="Red"></asp:Label>
    </div>
</asp:Content>
