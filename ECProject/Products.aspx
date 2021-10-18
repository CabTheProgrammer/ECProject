<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Products.aspx.cs" Inherits="ECProject.Products" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h3>"The Hottest Ebooks Online"</h3>
    <div class="book-shelf container">
        <!--
       <div class ="row justify-content-center row-cols-1 row-cols-sm-2 row-cols-md-4 g-5" >
            <div class ="book col">
            <a href ="ProductPage.aspx">
                <img src ="ImageAssets/Books/book (1).png" class="img-fluid" />
            </a>
                Price: $50
               </div>

            <div class ="book col ">
                <img src ="ImageAssets/Books/book (2).jpg" class="img-fluid" />
                Price: $60
            </div>

            <div class ="book col">
                <img src ="ImageAssets/Books/book (3).jpg" class="img-fluid" />
                Price: $35
            </div>

            <div class ="book col">
                <img src ="ImageAssets/Books/book (4).png" class="img-fluid" />
                Price: $90
            </div>
           

            <div class ="book col">
                <img src ="ImageAssets/Books/book (5).jpg" class="img-fluid" />
                Price: $12
            </div>

            <div class ="book col">
                <img src ="ImageAssets/Books/book (6).jpg" class="img-fluid" />
                Price: $19
            </div>
            <div class ="book col">
                <img src ="ImageAssets/Books/book (7).jpg" class="img-fluid" />
                Price: $50
            </div>
            <div class ="book col">
                <img src ="ImageAssets/Books/book (8).jpg" class="img-fluid" />
                Price: $15
            </div>

    
            <div class ="book col">
                <img src ="ImageAssets/Books/book (9).jpg" class="img-fluid" />
                Price: $50
            </div>
            <div class ="book col" >
                <img src ="ImageAssets/Books/book (10).jpg" class="img-fluid" />
                Price: $30
            </div>
            <div class ="book col ">
                <div class="image">
                    <img src ="ImageAssets/Books/book (11).jpg" class="img-fluid" />
                </div>
                <div class ="info">
                    Price: $20
                </div>
            </div>
     
       
      </div> -->


<asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ProductsConnectionString %>" SelectCommand="SELECT * FROM [PRODUCT_INFO]"></asp:SqlDataSource>
<asp:Repeater ID="Repeater1" runat="server" DataSourceID="SqlDataSource1">
    <ItemTemplate>
         <div class ="row justify-content-center">
             <img src=<%# Eval("IMG_LOCATION") %> class="img-fluid" style="max-width:25%;"/>             
             <h4>Product Name: <%#DataBinder.Eval(Container,"DataItem.Name")%></h4>
             <h4>Category: <%#DataBinder.Eval(Container,"DataItem.Category")%></h4>
             <h4>Author: <%#DataBinder.Eval(Container,"DataItem.Author")%></h4>
             <h4>Price: <%#DataBinder.Eval(Container,"DataItem.Price")%></h4>
             <asp:Button ID="Button1" runat="server" Text="Buy Now" class ="btn btn-primary"/><br>
         </div>                                              
    </ItemTemplate>
</asp:Repeater>

    </div>  
</asp:Content>

