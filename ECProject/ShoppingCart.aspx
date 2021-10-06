<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ShoppingCart.aspx.cs" Inherits="ECProject.Shopping_Cart" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div class ="container">
        <h3>Shopping Cart</h3>

      <!--  <script runat ="server" src="ShoppingCart.aspx.cs">
           
        </script> -->

        <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
        <asp:GridView ID="GridView1" runat="server" onRowCommand="GridView1_RowCommand" CellPadding="4" AlternatingRowStyle-Wrap="True" AlternatingRowStyle-VerticalAlign="NotSet" FooterStyle-HorizontalAlign="Center" HeaderStyle-HorizontalAlign="Center" RowStyle-HorizontalAlign="Center"  datakeynames="Item" ForeColor="#333333" GridLines="None" > 
<AlternatingRowStyle Wrap="True" BackColor="White"></AlternatingRowStyle>
                <Columns>
                    <asp:CommandField ShowSelectButton="True" SelectText="Add" HeaderText="Modify" ButtonType= "Button"  />
                    <asp:CommandField ShowSelectButton="True" SelectText="Remove" HeaderText="Order" ButtonType="Button" /> 
                    <asp:ButtonField ButtonType="Button" CommandName="add" HeaderText="Modify" Text="Add" />
                    <asp:ButtonField ButtonType="Button" CommandName="remove" HeaderText="Order" Text="Remove" />
                </Columns>
                <EditRowStyle BackColor="#2461BF" />

<FooterStyle HorizontalAlign="Center" BackColor="#507CD1" Font-Bold="True" ForeColor="White"></FooterStyle>

<HeaderStyle HorizontalAlign="Center" BackColor="#507CD1" Font-Bold="True" ForeColor="White"></HeaderStyle>

                <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />

<RowStyle HorizontalAlign="Center" BackColor="#EFF3FB"></RowStyle>
                <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                <SortedAscendingCellStyle BackColor="#F5F7FB" />
                <SortedAscendingHeaderStyle BackColor="#6D95E1" />
                <SortedDescendingCellStyle BackColor="#E9EBEF" />
                <SortedDescendingHeaderStyle BackColor="#4870BE" />
        </asp:GridView>


        <asp:ListView ID="ListView1" runat="server" DataSourceID="SqlDataSource1"></asp:ListView>

        <asp:SqlDataSource ID="SqlDataSource1" runat="server"></asp:SqlDataSource>

        <asp:Label ID="Label2" runat="server" Text=""></asp:Label>

       
    </div>
</asp:Content>
