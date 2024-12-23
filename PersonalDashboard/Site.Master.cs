using System;
using System.Web.UI;

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
                welcomeLabel.Visible = true;
                LogoutBtn.Visible = true;
            }
            else
            {
                GridViewPage.Visible = false;
                LoginPage.Visible = true;
                welcomeLabel.Visible = false;
                LogoutBtn.Visible = false;
            }
        }
        protected void BtnLogout_Clicked(object sender, EventArgs e)
        {
            Session.Clear();
            Session.Abandon();

            Response.Redirect("Login.aspx");
        }
    }
}