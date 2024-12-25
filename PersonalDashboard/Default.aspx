<%@ Page Title="Personal Dashboard" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="PersonalDashboard._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <main>
        <!-- Welcome Section -->
        <section class="text-center my-4">
            <h1>Welcome to Your Personal Dashboard</h1>
            <p class="lead">Stay organized, track your progress, and manage your tasks all in one place.</p>
        </section>

        <!-- Dashboard Widgets -->
        <div class="row">
            <!-- Calendar Widget -->
            <section class="col-md-4 mb-4">
                <div class="card">
                    <div class="card-header text-center">
                        <h2>Calendar</h2>
                    </div>
                    <div class="card-body">
                        <p>Quick access to your schedule and upcoming events.</p>
                        <asp:Button ID="ViewCalendarButton" runat="server" CssClass="btn btn-primary" Text="View Calendar" PostBackUrl="~/Calendar.aspx" />
                    </div>
                </div>
            </section>

            <!-- Task Manager -->
            <section class="col-md-4 mb-4">
                <div class="card">
                    <div class="card-header text-center">
                        <h2>Tasks</h2>
                    </div>
                    <div class="card-body">
                        <p>Manage your to-do list and track progress.</p>
                        <asp:Button ID="ViewTasksButton" runat="server" CssClass="btn btn-primary" Text="View Tasks" PostBackUrl="~/GridViewPage" />
                    </div>
                </div>
            </section>

            <!-- Statistics Overview -->
            <section class="col-md-4 mb-4">
                <div class="card">
                    <div class="card-header text-center">
                        <h2>Statistics</h2>
                    </div>
                    <div class="card-body">
                        <p>View analytics and track your achievements.</p>
                        <asp:Button ID="ViewStatsButton" runat="server" CssClass="btn btn-primary" Text="View Statistics" PostBackUrl="~/Statistics.aspx" />
                    </div>
                </div>
            </section>
        </div>

        <!-- Quick Links Section -->
        <section class="text-center mt-5">
            <h2>Quick Links</h2>
            <div class="btn-group mt-3" role="group">
                <asp:Button ID="Link1" runat="server" CssClass="btn btn-secondary" Text="Notes" PostBackUrl="~/Notes.aspx" />
                <asp:Button ID="Link2" runat="server" CssClass="btn btn-secondary" Text="Settings" PostBackUrl="~/Settings.aspx" />
                <asp:Button ID="Link3" runat="server" CssClass="btn btn-secondary" Text="Profile" PostBackUrl="~/Profile.aspx" />
            </div>
        </section>
    </main>
</asp:Content>
