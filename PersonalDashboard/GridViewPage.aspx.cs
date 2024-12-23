using Microsoft.Extensions.DependencyInjection;
using PersonalDashboard.Models;
using System;
using System.Linq;
using System.Web.UI.WebControls;

namespace PersonalDashboard
{
    public partial class GridViewPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindGridView();
                DueDateCompareValidator.ValueToCompare = DateTime.Now.ToString("yyyy-MM-dd");
            }
        }
        protected void BindGridView()
        {
            using (var scope = Global.ServiceProvider.CreateScope())
            {
                var context = scope.ServiceProvider.GetRequiredService<PersonalDashboardContext>();

                var tasks = context.Tasks.ToList();

                // Bind tasks to GridView
                GridView1.DataSource = tasks;
                GridView1.DataBind();
            }
        }

        protected void OnPageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GridView1.PageIndex = e.NewPageIndex;
            BindGridView();
        }

        protected void OnSorting(object sender, GridViewSortEventArgs e)
        {
            using (var scope = Global.ServiceProvider.CreateScope())
            {
                var context = scope.ServiceProvider.GetRequiredService<PersonalDashboardContext>();

                var tasks = context.Tasks.AsQueryable();

                switch (e.SortExpression)
                {
                    case "Priority":
                        tasks = tasks.OrderBy(t => t.Priority);
                        break;
                    case "DueDate":
                        tasks = tasks.OrderBy(t => t.DueDate);
                        break;
                    case "Status":
                        tasks = tasks.OrderBy(t => t.status);
                        break;
                    default:
                        tasks = tasks.OrderBy(t => t.Title);
                        break;
                }

                // Bind tasks to GridView
                GridView1.DataSource = tasks.ToList();
                GridView1.DataBind();
            }
        }

        protected void StatusButton_Click(object sender, EventArgs e)
        {
            Button statusButton = (Button)sender;
            int taskId = Convert.ToInt32(statusButton.CommandArgument);

            using (var scope = Global.ServiceProvider.CreateScope())
            {
                var context = scope.ServiceProvider.GetRequiredService<PersonalDashboardContext>();
                var task = context.Tasks.FirstOrDefault(t => t.TaskId == taskId);

                if (task != null)
                {
                    // Toggle status (you can customize the status change logic as needed)
                    if (task.status == "Pending")
                        task.status = "In Progress";
                    else if (task.status == "In Progress")
                        task.status = "Done";
                    else
                        task.status = "Pending";

                    context.SaveChanges();
                    BindGridView(); // Rebind GridView to reflect status change
                }
            }
        }

        protected void SaveTaskButton_Click(object sender, EventArgs e)
        {
            // Retrieve the input values using server-side controls
            string title = TaskTitleTextBox.Text;
            string description = TaskDescriptionTextBox.Text;
            string priority = TaskPriorityDropDown.SelectedValue;
            DateTime dueDate = DateTime.Parse(TaskDueDateTextBox.Text);

            // Save the task to the database
            using (var scope = Global.ServiceProvider.CreateScope())
            {
                var context = scope.ServiceProvider.GetRequiredService<PersonalDashboardContext>();
                var newTask = new Task
                {
                    Title = title,
                    Description = description,
                    Priority = priority,
                    DueDate = dueDate,
                    status = "Pending" 
                };

                context.Tasks.Add(newTask);
                context.SaveChanges();
            }

            BindGridView();
        }
    }
}