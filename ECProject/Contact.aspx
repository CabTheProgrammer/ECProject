<%@ Page Title="Contact" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="ECProject.Contact" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %>.</h2>
    <h3>How to Contact Us</h3>
    <address>
        Dragon Over the Bridge<br />
        Dairy Castle, NY<br />
        <abbr title="Phone">P:</abbr>
        876.555.0042
    </address>
    We do <b>not</b> accept messages via owl
    <address>
        <strong>Support:</strong>   <a href="mailto:Support@example.com">Support@FBO.com</a><br />
        <strong>Marketing:</strong> <a href="mailto:Marketing@example.com">Marketing@FBO.com</a>
    </address>
</asp:Content>
