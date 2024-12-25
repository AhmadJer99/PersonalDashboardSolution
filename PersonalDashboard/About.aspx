<%@ Page Title="About" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="About.aspx.cs" Inherits="PersonalDashboard.About" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <main aria-labelledby="title">
        <h2 id="title"><%: Title %>.</h2>
        <h3>About Your Personal Dashboard</h3>
        <p>
            Welcome to your personal dashboard! This application is designed to help you manage your daily activities, tasks, and schedules in one convenient place.
        </p>
        <p>
            With features like a calendar, task management, statistics tracking, and quick access to frequently used tools, the dashboard empowers you to stay organized and productive. 
            It's built using ASP.NET Web Forms to ensure a dynamic and responsive user experience.
        </p>
        <p>
            The dashboard is continuously evolving, with more features and enhancements planned to make it even more useful and intuitive.
        </p>
    </main>
</asp:Content>
