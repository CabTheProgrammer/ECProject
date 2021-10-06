<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ProductPage.aspx.cs" Inherits="ECProject.ProductPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div class ="book">
        <div class ="bookpic">
            <div class ="center">
                <img src ="ImageAssets/Books/book (1).png"  class="img-responsive"/>
            </div>
        </div>
        <div class ="Description">
            <div class = "page-header"><h1>The Frost Eater</h1></div>
            <div class ="summary">
                    <div class="center-block"><h3><b>Summary</b></h3></div>
                    <p>A lonely princess.
                    A flying teen.
                    A kidnapped girl who only remembers what happens at night.
                    </p>

                    <p>Seventeen-year-old Princess Nora is a frost eater who creates magical ice. Her royal life is luxurious but stifling.</p>

                    <p>Krey West has a rare magical talent: when he eats feathers, he can fly. His one goal is to find his missing girlfriend, Zeisha. He thinks someone in power abducted her.</p>

                    <p>Krey’s daring feats of magic earn him an invitation to the palace. Craving adventure and friendship, Nora offers to help him find Zeisha. He’s desperate enough to accept—though he hates the monarchy.</p>

                    <p>The truth is more terrible than they could imagine.</p>

                    <p>Every night, Zeisha wakes in a dark room full of sleeping people, unable to remember what she did in the light. Her dreams provide violent glimpses into her forgotten days.</p>

                    <p> Krey and Nora can’t save her, Zeisha may lose herself forever.</p>

            </div>
             <h4><div class ="price"><b>
                 Price: </b>$<asp:Label ID="Label1" runat="server" Text="50"></asp:Label> <b>Category: </b>Urban Fantasy <b>ISBN: </b> 1-56619-909-3</div></h4>
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



    </div>
</asp:Content>
