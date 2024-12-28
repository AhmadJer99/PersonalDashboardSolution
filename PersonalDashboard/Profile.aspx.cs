using System;

namespace PersonalDashboard
{
    public partial class Profile : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadProfile();
            }
        }

        protected void btnSaveProfile_Click(object sender, EventArgs e)
        {
            // Save profile details (in Session for demonstration)
            Session["Name"] = txtName.Text;
            Session["Email"] = txtEmail.Text;
            Session["Bio"] = txtBio.Text;

            // Feedback to the user
            Response.Write("<script>alert('Profile updated successfully!');</script>");
        }

        private void LoadProfile()
        {
            // Load profile details (from Session in this example)
            if (Session["Name"] != null) txtName.Text = Session["Name"].ToString();
            if (Session["Email"] != null) txtEmail.Text = Session["Email"].ToString();
            if (Session["Bio"] != null) txtBio.Text = Session["Bio"].ToString();
        }
    }
}
