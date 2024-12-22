<%@ Page Title="Tasks" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="GridViewPage.aspx.cs" Inherits="PersonalDashboard.GridViewPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Task List</h2>
     <asp:GridView ID="GridView1" HeaderStyle-BackColor="#3AC0F2" HeaderStyle-ForeColor="White"
     RowStyle-BackColor="#A1DCF2" AlternatingRowStyle-BackColor="White" AlternatingRowStyle-ForeColor="#000"
     runat="server" AutoGenerateColumns="false" AllowPaging="true" OnPageIndexChanging="OnPageIndexChanging">
     <Columns>
         <asp:BoundField DataField="Title" HeaderText="Title" ItemStyle-Width="150px" />
         <asp:BoundField DataField="Description" HeaderText="Description" ItemStyle-Width="100px" />
         <asp:BoundField DataField="Priority" HeaderText="Priority" ItemStyle-Width="100px" />
         <asp:BoundField DataField="DueDate" HeaderText="Due Date" ItemStyle-Width="100px"  DataFormatString="{0:yyyy-MM-dd}" />
         <asp:BoundField DataField="status" HeaderText="status" ItemStyle-Width="100px" />
     </Columns>
     
<PagerStyle HorizontalAlign = "Right" CssClass = "task-gridview" />

 </asp:GridView>
</asp:Content>

