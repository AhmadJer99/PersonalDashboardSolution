<%@ Page Title="Tasks" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="GridViewPage.aspx.cs" Inherits="PersonalDashboard.GridViewPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Task List</h2>
    <asp:GridView ID="GridView1" HeaderStyle-BackColor="#3AC0F2" HeaderStyle-ForeColor="White"
        RowStyle-BackColor="#A1DCF2" AlternatingRowStyle-BackColor="White" AlternatingRowStyle-ForeColor="#000"
        runat="server" AutoGenerateColumns="false" AllowPaging="true" AllowSorting="true"
        OnPageIndexChanging="OnPageIndexChanging" OnSorting="OnSorting">
        <Columns>
            <asp:BoundField DataField="Title" HeaderText="Title" ItemStyle-Width="150px" />
            <asp:BoundField DataField="Description" HeaderText="Description" ItemStyle-Width="500px" />
            <asp:BoundField DataField="Priority" HeaderText="Priority" SortExpression="Priority" ItemStyle-Width="100px" />
            <asp:BoundField DataField="DueDate" HeaderText="Due Date" SortExpression="DueDate" ItemStyle-Width="100px" DataFormatString="{0:yyyy-MM-dd}" />
            <asp:TemplateField HeaderText="Status" SortExpression="Status">
                <ItemTemplate>
                    <asp:Button ID="StatusButton" runat="server" Text='<%# Eval("Status") %>' CommandName="ChangeStatus" CommandArgument='<%# Eval("TaskId") %>' OnClick="StatusButton_Click" />
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>

        <PagerStyle HorizontalAlign="Center" CssClass="gridview" />

    </asp:GridView>
    <!-- Button to Open the Modal -->
    <button type="button" class="btn btn-primary" data-bs-toggle="modal" data-bs-target="#addTaskModal">
        Add Task
    </button>

    <!-- Modal -->
    <div class="modal fade" id="addTaskModal" tabindex="-1" aria-labelledby="addTaskModalLabel" aria-hidden="true">
        <div class="modal-dialog">
            <div class="modal-content">
                <!-- Modal Header -->
                <div class="modal-header">
                    <h5 class="modal-title" id="addTaskModalLabel">Add Task</h5>
                    <button type="button" class="btn-close" data-bs-dismiss="modal" aria-label="Close"></button>
                </div>

                <!-- Modal Body -->
                <div class="modal-body">
                    <asp:TextBox ID="TaskTitleTextBox" runat="server" CssClass="form-control" placeholder="Task Title"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="TitleValidator" runat="server" ControlToValidate="TaskTitleTextBox" ErrorMessage="Task Title is required" CssClass="text-danger" ValidationGroup="AddTaskGroup" />

                    <asp:TextBox ID="TaskDescriptionTextBox" runat="server" CssClass="form-control" TextMode="MultiLine" Rows="3" placeholder="Description"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="DescriptionValidator" runat="server" ControlToValidate="TaskDescriptionTextBox" ErrorMessage="Description is required" CssClass="text-danger" ValidationGroup="AddTaskGroup" />

                    <asp:DropDownList ID="TaskPriorityDropDown" runat="server" CssClass="form-select">
                        <asp:ListItem Value="" Text="Select Priority"></asp:ListItem>
                        <asp:ListItem Value="Low" Text="Low"></asp:ListItem>
                        <asp:ListItem Value="Medium" Text="Medium"></asp:ListItem>
                        <asp:ListItem Value="High" Text="High"></asp:ListItem>
                    </asp:DropDownList>
                    <asp:RequiredFieldValidator ID="PriorityValidator" runat="server" ControlToValidate="TaskPriorityDropDown" InitialValue="" ErrorMessage="Priority is required" CssClass="text-danger" ValidationGroup="AddTaskGroup" />

                    <asp:TextBox ID="TaskDueDateTextBox" runat="server" CssClass="form-control" TextMode="Date"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="DueDateValidator" runat="server"
                        ControlToValidate="TaskDueDateTextBox"
                        ErrorMessage="Due Date is required"
                        CssClass="text-danger" ValidationGroup="AddTaskGroup" />
                    <asp:CompareValidator ID="DueDateCompareValidator" runat="server"
                        ControlToValidate="TaskDueDateTextBox"
                        Operator="GreaterThan"
                        ValueToCompare=""
                        Type="Date"
                        ErrorMessage="Due Date must be in the future"
                        CssClass="text-danger" ValidationGroup="AddTaskGroup" />
                </div>

                <!-- Modal Footer -->
                <div class="modal-footer">
                    <button type="button" class="btn btn-secondary" data-bs-dismiss="modal">Cancel</button>
                    <asp:Button ID="SaveTaskButton" runat="server" Text="Save Task" CssClass="btn btn-primary" OnClick="SaveTaskButton_Click" ValidationGroup="AddTaskGroup" />
                </div>
            </div>
        </div>
    </div>
</asp:Content>

