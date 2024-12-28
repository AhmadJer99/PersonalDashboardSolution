<%@ Page Title="Notes" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Notes.aspx.cs" Inherits="PersonalDashboard.Notes" %>

<asp:Content ID="NotesContent" ContentPlaceHolderID="MainContent" runat="server">
    <main class="container mt-4">
        <h1 class="text-center">Your Notes</h1>
        <p class="lead text-center">Keep track of important details and ideas here.</p>
        <div class="mb-3">
            <asp:TextBox ID="txtNote" runat="server" CssClass="form-control" TextMode="MultiLine" Rows="5" placeholder="Write your note here..."></asp:TextBox>
        </div>
        <div class="text-center">
            <asp:Button OnClick="btnSaveNote_Click" ID="btnSaveNote" runat="server" CssClass="btn btn-primary" Text="Save Note" />
            <asp:Button OnClick="btnClearNote_Click" ID="btnClearNote" runat="server" CssClass="btn btn-secondary" Text="Clear" />
        </div>
        <hr />
        <h2 class="mt-4">Saved Notes</h2>
        <asp:Repeater ID="rptNotes" runat="server">
            <ItemTemplate>
                <div class="card mb-3">
                    <div class="card-body">
                        <p class="card-text"><%# Eval("NoteText") %></p>
                        <small class="text-muted">Saved on <%# Eval("CreatedDate", "{0:MMMM dd, yyyy hh:mm tt}") %></small>
                    </div>
                </div>
            </ItemTemplate>
        </asp:Repeater>
    </main>
</asp:Content>
