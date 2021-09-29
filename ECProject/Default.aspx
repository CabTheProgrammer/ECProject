<%@ Page Title="Welcome Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ECProject._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">


    <div class ="container">
        <div class ="row justify-content-center">
                <div class="cols jumbotron">
                    <h1>Fantasy BookStore Online</h1>
                    <p class="lead">Welcome to Fantasy Book Store Online, your premiere source of the hottest fantasy books online.
            We stock a wide range of books from authors you’ve never heard of to those at the top of the game, such as J.R.R Tolkien and Brandon Sanderson </p>
                </div>

                <div class="cols text-center">
    
                    <img src ="ImageAssets/Tribal-Dragon_grey_bg.png" class="img-fluid " style="max-width:30%; height:auto;" />
                </div>
    
    
                <div class ="cols">
                    <h2>Featured Books</h2>
                    <div class="row  ">  
                        <img src="ImageAssets/book (3).jpg" class="center-block img-responsive col-md-2 mx-1" />
                        <img src="ImageAssets/book (2).jpg" class="center-block img-responsive col-md-2 mx-1" />
                        <img src="ImageAssets/book (1).jpg" class="center-block img-responsive col-md-2 mx-1" />
                    </div>
                </div>
            </div>
        </div>
</asp:Content>
