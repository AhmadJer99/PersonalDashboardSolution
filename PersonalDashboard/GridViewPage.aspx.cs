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
                using (var scope = Global.ServiceProvider.CreateScope())
                {
                    var context = scope.ServiceProvider.GetRequiredService<PersonalDashboardContext>();

                    var tasks = context.Tasks.ToList();

                    // Bind to GridView
                    //GridView1.DataSource = tasks;
                    //GridView1.DataBind();
                }
            }
        }
    }
}