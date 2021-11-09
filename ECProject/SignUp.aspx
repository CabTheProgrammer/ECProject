<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="SignUp.aspx.cs" Inherits="ECProject.SignUp" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">


    <div class="row" style="width:50%; margin:auto;">
                <h3>Sign Up Page</h3>
            <asp:Label ID="Label1" runat="server" Text="Username" class="form-label"></asp:Label>
            <asp:TextBox ID="TextBox1" runat="server" class="form-control"></asp:TextBox>
    
                <asp:Label ID="Label4" runat="server" Text="Email Address" class="form-label"></asp:Label>
            <asp:TextBox ID="TextBox4" runat="server" class="form-control"></asp:TextBox>

            <asp:Label ID="Label2" runat="server" Text="Password" class="form-label"></asp:Label>
            <asp:TextBox ID="TextBox2" runat="server" class="form-control"></asp:TextBox>

            <asp:Label ID="Label3" runat="server" Text="Confirm Password" class="form-label"></asp:Label>
            <asp:TextBox ID="TextBox3" runat="server" class="form-control"></asp:TextBox>

    <asp:CompareValidator ID="CompareValidator1" runat="server" ErrorMessage="Passwords must match!" ControlToCompare="TextBox3" ControlToValidate="TextBox2" ForeColor="Fuchsia"></asp:CompareValidator>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="TextBox2" ErrorMessage="Password is too weak!" ForeColor="#FF3300" ValidationExpression="^(?=.*[A-Z].*[A-Z])(?=.*[!@#$&amp;*])(?=.*[0-9].*[0-9])(?=.*[a-z].*[a-z].*[a-z]).{8}$"></asp:RegularExpressionValidator>
            <div class ="row pt-4 text-center" style="width:50%; margin:auto;">
                <asp:Button ID="Button2" runat="server" Text="Cancel" class ="btn btn-danger" onClick="Button2_Click"/>&nbsp
                <asp:Button ID="Button1" runat="server" Text="Sign-Up" class="btn btn-success" onClick="Button1_Click"/>
            </div>
         <asp:Label ID="Label5" runat="server" Text=""></asp:Label>
    </div>

    </asp:Content>
