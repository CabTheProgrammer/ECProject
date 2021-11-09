<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Login2.aspx.cs" Inherits="ECProject.Login2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div class="row" style="width:50%; margin:auto;">
                <h3>Logins Page</h3>
            <asp:Label ID="Label1" runat="server" Text="Username" class="form-label"></asp:Label>
            <asp:TextBox ID="TextBox1" runat="server" class="form-control"></asp:TextBox>
   

            <asp:Label ID="Label2" runat="server" Text="Password" class="form-label"></asp:Label>
            <asp:TextBox ID="TextBox2" runat="server" class="form-control"></asp:TextBox>


            <div class ="row pt-4 text-center" style="width:50%; margin:auto;">
                <asp:Button ID="Button2" runat="server" Text="Cancel" class ="btn btn-danger" onClick="Button2_Click"/>&nbsp
                <asp:Button ID="Button1" runat="server" Text="Login" class="btn btn-success" onClick="Button1_Click"/>
            </div>
        <asp:Label ID="Label3" runat="server" Text=""></asp:Label>
    </div>
    



</asp:Content>
