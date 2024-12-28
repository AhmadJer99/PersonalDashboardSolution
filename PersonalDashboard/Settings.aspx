<%@ Page Title="Settings" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Settings.aspx.cs" Inherits="PersonalDashboard.Settings" %>

<asp:Content ID="SettingsContent" ContentPlaceHolderID="MainContent" runat="server">
    <main class="container mt-4">
        <h1 class="text-center">Settings</h1>
        <p class="lead text-center">Customize your dashboard to suit your needs.</p>
            <div class="mb-3">
                <label for="themeDropdown" class="form-label">Theme:</label>
                <asp:DropDownList ID="ddlTheme" runat="server" CssClass="form-control">
                    <asp:ListItem Text="Light" Value="Light" />
                    <asp:ListItem Text="Dark" Value="Dark" />
                </asp:DropDownList>
            </div>
            <div class="mb-3">
                <label for="notifDropdown" class="form-label">Notifications:</label>
                <asp:CheckBox ID="chkNotifications" runat="server" Text="Enable notifications" CssClass="form-check-input" />
            </div>
            <div class="text-center">
                <asp:Button OnClick="btnSaveSettings_Click" ID="btnSaveSettings" runat="server" CssClass="btn btn-primary" Text="Save Settings" />
            </div>
    </main>
</asp:Content>
