<%@ Page Title="Log In" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="PersonalDashboard.WebForm1" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <h2 id="title"><%: Title %></h2>
    <br />
    <asp:Label ID="loginFeedbackMsg" runat="server" ForeColor="Red"></asp:Label><br />
    <label>Username </label>
    <br />
    <asp:TextBox runat="server" ID="userNameBox" />
    <asp:RequiredFieldValidator ID="UsernameValidator" runat="server" ControlToValidate="userNameBox" ErrorMessage="Username is required" CssClass="text-danger"/>
    <br />
    <br />
    <label>Password </label>
    <br />
    <asp:TextBox runat="server" type="password" ID="passwordBox" />
    <asp:RequiredFieldValidator ID="PasswordValidator" runat="server" ControlToValidate="passwordBox" ErrorMessage="Password is required" CssClass="text-danger"/><br />
    <br />
    <asp:Button ID="LoginBtn" runat="server" OnClick="BtnLogin_Clicked" Text="Login" />
</asp:Content>
