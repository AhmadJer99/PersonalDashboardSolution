using System;
using System.Web;

namespace PersonalDashboard
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        const string userName = "Amr";
        const string password = "admin";
        //bool isLoggedIn;
        protected void Page_Load(object sender, EventArgs e)
        {
            HttpCookie loginCookie = Request.Cookies["LoginCookie"];
            if (loginCookie != null && !string.IsNullOrEmpty(loginCookie.Values["Username"]))
            {
                // Restore session from cookie
                Session["Username"] = loginCookie.Values["Username"];
                Response.Redirect("Default.aspx");
            }
        }

        protected void BtnLogin_Clicked(object sender, EventArgs e)
        {
            if (userNameBox.Text == userName && passwordBox.Text == password)
            {

                Session["Username"] = userName;
                loginFeedbackMsg.Text = "";

                if (rememberMeCheckbox.Checked) // Ensure you have a checkbox with this ID in your login form
                {
                    // Create a persistent cookie
                    HttpCookie loginCookie = new HttpCookie("LoginCookie");
                    loginCookie.Values["Username"] = userName;
                    loginCookie.Expires = DateTime.Now.AddDays(7); // Cookie valid for 7 days
                    Response.Cookies.Add(loginCookie);
                }

                Response.Redirect("Default.aspx");
            }
            else
            {
                //isLoggedIn = false;
                loginFeedbackMsg.Text = "Invalid username or password!";
            }
        }
    }
}