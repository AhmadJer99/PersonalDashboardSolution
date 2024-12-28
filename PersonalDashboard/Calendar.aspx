<%@ Page Title="Calendar" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Calendar.aspx.cs" Inherits="PersonalDashboard.Calendar" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div>
        <p >
            <b></b>
            <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Names="Arial Black" Font-Size="Medium" ForeColor="#0066FF">My Calendar</asp:Label><br />
        </p>
        <asp:Calendar ID="Calendar1" runat="server" OnDayRender="Calendar1_DayRender" OnSelectionChanged="Calendar1_SelectionChanged"
            OnVisibleMonthChanged="Calendar1_VisibleMonthChanged" >
        </asp:Calendar>
        <br />
        <asp:Label ID="LabelAction" runat="server"></asp:Label><br />
        <asp:Label ID="TaskDueLabel" runat="server" Text="Select a day to see the task due on that date." Font-Bold="True" ForeColor="Green"></asp:Label>
    </div>
</asp:Content>
