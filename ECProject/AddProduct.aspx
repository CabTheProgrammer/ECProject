<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AddProduct.aspx.cs" Inherits="ECProject.AddProduct" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class ="row"  style="width:50%; margin:auto;">
        <h2>Add Products</h2>
         <asp:Label ID="Label8" runat="server" Text="Book ID"></asp:Label>
        <asp:TextBox ID="BookID" runat="server"></asp:TextBox><br>

         <asp:Label ID="Label7" runat="server" Text="Book Name"></asp:Label>
        <asp:TextBox ID="BookName" runat="server"></asp:TextBox><br>

         <asp:Label ID="Label6" runat="server" Text="Description"></asp:Label>
        <asp:TextBox ID="Description" runat="server"></asp:TextBox><br>

         <asp:Label ID="Label5" runat="server" Text="Price"></asp:Label>
        <asp:TextBox ID="Price" runat="server"></asp:TextBox><br>
        
        <asp:Label ID="Label2" runat="server" Text="ISBN"></asp:Label>
        <asp:TextBox ID="ISBN" runat="server"></asp:TextBox><br>
        
       

         <asp:Label ID="Label4" runat="server" Text="Category"></asp:Label>
        <asp:TextBox ID="Category" runat="server"></asp:TextBox> <br>
        
        <asp:Label ID="Label3" runat="server" Text="Author"></asp:Label>
        <asp:TextBox ID="Author" runat="server"></asp:TextBox><br>

         <asp:Label ID="Label1" runat="server" Text="Book Cover Upload"></asp:Label>
        <asp:FileUpload ID="BookImage" runat="server" />
        
        

        <asp:Button ID="Button1" runat="server" Text="Add New Product" class="btn btn-success" style="margin-top:10px;"/>
    </div>
</asp:Content>
