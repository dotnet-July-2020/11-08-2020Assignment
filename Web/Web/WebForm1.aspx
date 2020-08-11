<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Web.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:RadioButton ID="RadioButton1" runat="server" AutoPostBack="True" GroupName="a" OnCheckedChanged="RadioButton1_CheckedChanged" Text="Cricket Players" />
        <div>
        </div>
        <asp:RadioButton ID="RadioButton2" runat="server" AutoPostBack="True" GroupName="a" OnCheckedChanged="RadioButton2_CheckedChanged" Text="Tennis Players" />
        <br />
        <p>
            &nbsp;</p>
        <asp:Panel ID="Panel1" runat="server">
            <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/HtmlSachinTendulkar.html">SachinTendulkar</asp:HyperLink>
            <br />
            <br />
            <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="~/HtmlSureshRaina.html">Suresh Raina</asp:HyperLink>
            <br />
            <br />
            <asp:HyperLink ID="HyperLink3" runat="server" NavigateUrl="~/HtmlViratKohli.html">Virat Kohli</asp:HyperLink>
        </asp:Panel>
        
        <asp:Panel ID="Panel2" runat="server">
            <asp:HyperLink ID="HyperLink4" runat="server" NavigateUrl="~/HtmlAndre.html">Andre</asp:HyperLink>
            <br />
            <br />
            <asp:HyperLink ID="HyperLink5" runat="server" NavigateUrl="~/HTMLBillie.html">Billie</asp:HyperLink>
            <br />
            <br />
            <asp:HyperLink ID="HyperLink6" runat="server" NavigateUrl="~/HtmlMartina.html">Martina</asp:HyperLink>
        </asp:Panel>
        
        </form>
    </body>
    </html>
        