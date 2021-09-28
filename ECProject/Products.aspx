<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Products.aspx.cs" Inherits="ECProject.Products" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h3>"The Hottest Ebooks Online"</h3>


    <!-- <div class="book-shelf container-fluid" style="background-color:pink;">

       <div class ="row justify-content-center" style="display:flex;">
            <div class ="book col-md-2 mr-auto">
            <a href ="ProductPage.aspx">
                <img src ="ImageAssets/Books/book (1).png" class="img-responsive" />
            </a>
                Price: $50
            </div>

            <div class ="book col-md-2 mr-auto ">
                <img src ="ImageAssets/Books/book (2).jpg" class="img-responsive" />
                Price: $60
            </div>

            <div class ="book col-md-2 mr-auto ">
                <img src ="ImageAssets/Books/book (3).jpg" class="img-responsive" />
                Price: $35
            </div>

            <div class ="book col-md-2 mr-auto ">
                <img src ="ImageAssets/Books/book (4).png" class="img-responsive" />
                Price: $90
            </div>
           </div>

        <div class ="row justify-content-center">
                <div class ="book col-md-2 mx-1 ">
                    <img src ="ImageAssets/Books/book (5).jpg" class="img-responsive" />
                    Price: $12
                </div>

               <div class ="book col-md-2 mx-1 ">
                    <img src ="ImageAssets/Books/book (6).jpg" class="img-responsive" />
                    Price: $19
                </div>
               <div class ="book col-md-2 mx-1 ">
                    <img src ="ImageAssets/Books/book (7).jpg" class="img-responsive" />
                    Price: $50
                </div>
               <div class ="book col-md-2 mx-1 ">
                    <img src ="ImageAssets/Books/book (8).jpg" class="img-responsive" />
                    Price: $15
                </div>
            </div>

        <div class ="row justify-content-center">
                <div class ="book col-md-2 mx-1 ">
                    <img src ="ImageAssets/Books/book (9).jpg" class="img-responsive" />
                    Price: $50
                </div>
                <div class ="book col-md-2 mx-1 " >
                    <img src ="ImageAssets/Books/book (10).jpg" class="img-responsive" />
                    Price: $30
                </div>
               <div class ="book col-md-2 mx-1 ">
                    <div class="image">
                        <img src ="ImageAssets/Books/book (11).jpg" class="img-responsive" />
                    </div>
                    <div class ="info">
                        Price: $20
                    </div>
              </div>
                </div>
       
      </div> -->

    <div class="book-shelf container" style="background-color:pink;">

       <div class ="row justify-content-center row-cols-4 g-12" >
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
        
       
      </div>
    </div>
</asp:Content>
