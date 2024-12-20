<%@ Page Title="Log In" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="PersonalDashboard.WebForm1" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <h2 id="title"><%: Title %></h2>
    <br />
    <asp:Label ID="loginFeedbackMsg" runat="server" ForeColor="Red"></asp:Label><br />
    <label>Username </label>
    <br />
    <asp:TextBox runat="server" ID="userNameBox" /><br />
    <br />
    <label>Password </label>
    <br />
    <asp:TextBox runat="server" type="password" id="passwordBox"/><br />
    <br />
    <asp:button ID="LoginBtn" runat="server" onclick="BtnLogin_Clicked" text="Login"/>
</asp:Content>
