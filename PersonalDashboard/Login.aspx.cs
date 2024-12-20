using System;

namespace PersonalDashboard
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        const string userName = "Amr";
        const string password = "admin";
        bool isLoggedIn;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnLogin_Clicked(object sender, EventArgs e)
        {
            if (userNameBox.Text == userName && passwordBox.Text == password)
            {
                isLoggedIn = true;
                // Store username in session
                Session["Username"] = userName;
                loginFeedbackMsg.Text = "";
                // Redirect to dashboard
                Response.Redirect("Default.aspx");
            }
            else
            {
                isLoggedIn = false;
                loginFeedbackMsg.Text = "Invalid username or password!";
            }
        }
    }
}