<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ShoppingCart.aspx.cs" Inherits="ECProject.Shopping_Cart" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div class ="container">
        <h3>Shopping Cart</h3>

        <script runat ="server">
            void GridView1_RowCommand(Object sender, GridViewCommandEventArgs e)
            {
                if (e.CommandName == "add")
                {
                    int index = Convert.ToInt32(e.CommandArgument); // This gives us the index of the row
                    Label2.Text = index.ToString();
                    add(index);
                }
                else if (e.CommandName == "remove")
                    Label2.Text = "PLZ";
            }
        </script>

        <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
        <asp:GridView ID="GridView1" runat="server" onRowCommand="GridView1_RowCommand" CellPadding="4" AlternatingRowStyle-Wrap="True" AlternatingRowStyle-VerticalAlign="NotSet" FooterStyle-HorizontalAlign="Center" HeaderStyle-HorizontalAlign="Center" RowStyle-HorizontalAlign="Center"  datakeynames="Item" ForeColor="#333333" GridLines="None" > 
<AlternatingRowStyle Wrap="True" BackColor="White"></AlternatingRowStyle>
                <Columns>
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


        
        <asp:Label ID="Label2" runat="server" Text=""></asp:Label>
        <!--
        <asp:ListView ID="ListView2" runat="server">
            <LayoutTemplate>
                <table runat="server">
                <tr runat="server">
                    <th runat="server">Item</th>
                    <th runat="server">Price</th>
                    <th runat="server">Quantity</th>
                </tr>
                <tr runat="server" id ="itemPlaceholder" /></tr>
               </table>
            </LayoutTemplate>

            <ItemTemplate>
                <td>
                    <asp:Label ID="FirstNameLabel" runat="Server" Text='<%#Eval("Price") %>' />
                </td>
                <td>
                    <asp:Label ID="Label3" runat="Server" Text='<%#Eval("Quantity") %>' />
                </td>

            </ItemTemplate>

        </asp:ListView>
        -->

        <asp:GridView ID="GridView2" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None">
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
       
    </div>
</asp:Content>
