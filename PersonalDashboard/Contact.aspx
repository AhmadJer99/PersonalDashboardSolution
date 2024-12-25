<%@ Page Title="Contact" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="PersonalDashboard.Contact" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <main aria-labelledby="title">
        <h2 id="title"><%: Title %>.</h2>
        <h3>Contact Us</h3>
        <p>
            If you have any questions, feedback, or suggestions about your personal dashboard, feel free to reach out to us. We're here to help!
        </p>

        <address>
            <strong>Support:</strong> <a href="mailto:support@personaldashboard.com">support@personaldashboard.com</a><br />
            <strong>General Inquiries:</strong> <a href="mailto:info@personaldashboard.com">info@personaldashboard.com</a><br />
        </address>

        <p>You can also follow us on social media for updates and tips:</p>
        <ul>
            <li><a href="https://www.facebook.com/PersonalDashboard" target="_blank">Facebook</a></li>
            <li><a href="https://www.twitter.com/PersonalDashboard" target="_blank">Twitter</a></li>
            <li><a href="https://www.instagram.com/PersonalDashboard" target="_blank">Instagram</a></li>
        </ul>
    </main>
</asp:Content>
