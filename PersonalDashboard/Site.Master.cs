using System;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PersonalDashboard
{
    public partial class SiteMaster : MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Username"] != null)
            {
                LoginPage.Visible= false;
                welcomeLabel.Text = "Welcome, " + Session["Username"].ToString();
            }
        }
    }
}