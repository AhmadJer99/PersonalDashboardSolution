using System;

namespace PersonalDashboard
{
    public partial class Settings : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadSettings();
            }
        }

        protected void btnSaveSettings_Click(object sender, EventArgs e)
        {
            // Save preferences (in this example, using Session for simplicity)
            Session["Theme"] = ddlTheme.SelectedValue;
            Session["Notifications"] = chkNotifications.Checked;

            // Feedback to the user
            Response.Write("<script>alert('Settings saved successfully!');</script>");
        }

        private void LoadSettings()
        {
            // Load preferences (from Session in this example)
            if (Session["Theme"] != null)
            {
                ddlTheme.SelectedValue = Session["Theme"].ToString();
            }
            if (Session["Notifications"] != null)
            {
                chkNotifications.Checked = (bool)Session["Notifications"];
            }
        }
    }
}
