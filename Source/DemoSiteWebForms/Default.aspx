﻿<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeBehind="Default.aspx.cs" Inherits="DemoSiteWebForms._Default" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <h2>
        Welcome to ASP.NET!
    </h2>
    <p>
        To learn more about ASP.NET visit <a href="http://www.asp.net" title="ASP.NET Website">www.asp.net</a>.
    </p>
    <p>
        You can also find <a href="http://go.microsoft.com/fwlink/?LinkID=152368&amp;clcid=0x409"
            title="MSDN ASP.NET Docs">documentation on ASP.NET at MSDN</a>.
        <asp:ListBox ID="ListBox1" runat="server" AutoPostBack="True">
            <asp:ListItem>Test1</asp:ListItem>
            <asp:ListItem>test2</asp:ListItem>
        </asp:ListBox>
        <asp:TextBox ID="TextBox1" runat="server" AutoPostBack="True" CausesValidation="True"></asp:TextBox>
    </p>
</asp:Content>
