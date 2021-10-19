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

         <asp:Label runat="server" Text="Quantity"></asp:Label>
          <asp:DropDownList ID="DropDownList1" runat="server">
                <asp:ListItem>1</asp:ListItem>
                <asp:ListItem>2</asp:ListItem>
                <asp:ListItem>3</asp:ListItem>
                <asp:ListItem>4</asp:ListItem>
                <asp:ListItem>5</asp:ListItem>
            </asp:DropDownList><br /><br />

        <asp:Button ID="Button2" runat="server" Text="Add to Cart" class="btn btn-primary" onClick="Button1_Click" />

    </div>

</asp:Content>
