<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ShoppingCart.aspx.cs" Inherits="ECProject.Shopping_Cart" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div class ="container">
        <h3>Shopping Cart</h3>

        <script runat ="server">
         void GridView2_RowCommand(Object sender, GridViewCommandEventArgs e)
            {

                int index = Convert.ToInt32(e.CommandArgument); // This gives us the index of the rows
                if (e.CommandName == "add")
                {
                    Label3.Text = index.ToString();
                    table_mod(index, 1);
                }
                else
                {
                    Label3.Text = "PLZ";
                    table_mod(index, -1);
                }   
            }
        </script>

        <asp:GridView ID="GridView2" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None" onRowCommand="GridView2_RowCommand">
            <AlternatingRowStyle BackColor="White" />
            <Columns>
                <asp:ButtonField ButtonType="Button" CommandName="rem" Text="Remove" HeaderText="Modify" />
                <asp:ButtonField ButtonType="Button" CommandName="add" Text="Add"  HeaderText="Order"/>
            </Columns>
            <EditRowStyle BackColor="#2461BF" />
            <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#EFF3FB" HorizontalAlign="Center"/>
            <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
            <SortedAscendingCellStyle BackColor="#F5F7FB" />
            <SortedAscendingHeaderStyle BackColor="#6D95E1" />
            <SortedDescendingCellStyle BackColor="#E9EBEF" />
            <SortedDescendingHeaderStyle BackColor="#4870BE" />
        </asp:GridView>
       <asp:Label ID="Label3" runat="server" Text=""></asp:Label>
    </div>
</asp:Content>
