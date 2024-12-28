<%@ Page Title="Profile" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Profile.aspx.cs" Inherits="PersonalDashboard.Profile" %>

<asp:Content ID="ProfileContent" ContentPlaceHolderID="MainContent" runat="server">
    <main class="container mt-4">
        <h1 class="text-center">Profile</h1>
        <p class="lead text-center">View and update your personal information.</p>
            <div class="mb-3">
                <label for="txtName" class="form-label">Name:</label>
                <asp:TextBox ID="txtName" runat="server" CssClass="form-control" placeholder="Enter your name"></asp:TextBox>
            </div>
            <div class="mb-3">
                <label for="txtEmail" class="form-label">Email:</label>
                <asp:TextBox ID="txtEmail" runat="server" CssClass="form-control" placeholder="Enter your email"></asp:TextBox>
            </div>
            <div class="mb-3">
                <label for="txtBio" class="form-label">Bio:</label>
                <asp:TextBox ID="txtBio" runat="server" CssClass="form-control" TextMode="MultiLine" Rows="3" placeholder="Tell us something about yourself..."></asp:TextBox>
            </div>
            <div class="text-center">
                <asp:Button OnClick="btnSaveProfile_Click" ID="btnSaveProfile" runat="server" CssClass="btn btn-primary" Text="Save Changes" />
            </div>
    </main>
</asp:Content>
