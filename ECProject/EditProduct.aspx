<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="EditProduct.aspx.cs" Inherits="ECProject.EditProduct" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class ="row">
        <h2> Edit Product</h2>
        <asp:Label ID="Label1" runat="server" Text="Please enter the product id of the product to be edited"></asp:Label>
        <asp:TextBox ID="BookID" runat="server" style="width:80%;"></asp:TextBox><br><br>

         <asp:Label ID="Label7" runat="server" Text="Book Name"></asp:Label>
        <asp:TextBox ID="BookName" runat="server"></asp:TextBox><br>

         <asp:Label ID="Label6" runat="server" Text="Description"></asp:Label>
        <asp:TextBox ID="Description" runat="server"></asp:TextBox><br>

         <asp:Label ID="Label5" runat="server" Text="Price"></asp:Label>
        <asp:TextBox ID="Price" runat="server"></asp:TextBox><br>
        
        <asp:Label ID="Label3" runat="server" Text="ISBN"></asp:Label>
        <asp:TextBox ID="ISBN" runat="server"></asp:TextBox><br>
        
       

         <asp:Label ID="Label4" runat="server" Text="Category"></asp:Label>
        <asp:TextBox ID="Category" runat="server"></asp:TextBox> <br>
        
        <asp:Label ID="Label8" runat="server" Text="Author"></asp:Label>
        <asp:TextBox ID="Author" runat="server"></asp:TextBox><br>

         <asp:Label ID="Label9" runat="server" Text="Book Cover Upload"></asp:Label>
        <asp:FileUpload ID="BookImage" runat="server" />
        
        

       
        <asp:Button ID="Button1" runat="server" Text="Edit" class ="btn btn-danger" OnClick="Button1_Click" style="margin-top:10px;"/>
        <asp:Label ID="Label2" runat="server" ForeColor="Red"></asp:Label>
    </div>
</asp:Content>
