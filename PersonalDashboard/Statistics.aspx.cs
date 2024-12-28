using System;
using System.Linq;
using Microsoft.Extensions.DependencyInjection;
using PersonalDashboard.Models;

namespace PersonalDashboard
{
    public partial class Statistics : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadStatistics();
            }
        }

        private void LoadStatistics()
        {
            using (var scope = Global.ServiceProvider.CreateScope())
            {
                var context = scope.ServiceProvider.GetRequiredService<PersonalDashboardContext>();

                //// Total Users
                //var totalUsers = context.Users.Count();
                lblTotalUsers.Text = 1.ToString();

                // Total Tasks
                var totalTasks = context.Tasks.Count();
                lblTotalTasks.Text = totalTasks.ToString();

                // Completed Tasks
                var completedTasks = context.Tasks.Count(t => t.status == "Done");
                lblCompletedTasks.Text = completedTasks.ToString();
            }
        }
    }
}
