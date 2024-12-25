using System;
using System.Web;
using System.Web.UI;

namespace PersonalDashboard
{
    public partial class SiteMaster : MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.Cookies["consent"] == null)
            {
                cookieConsentBanner.Style["display"] = "block";
            }

            // Apply theme from cookie
            HttpCookie themeCookie = Request.Cookies["theme"];
            if (Request.Cookies["consent"]?.Value != "accepted")
            {
                // Default to light theme if no consent
                ApplyTheme("light");
                cookieConsentBanner.Style["display"] = "block";
            }

            if (themeCookie != null)
            {
                string theme = themeCookie.Value;
                ApplyTheme(theme);
            }
            if (Session["Username"] != null)
            {
                LoginPage.Visible= false;
                welcomeLabel.Text = "Welcome, " + Session["Username"].ToString();
                welcomeLabel.Visible = true;
                LogoutBtn.Visible = true;
            }
            else
            {
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
        protected void AcceptCookiesButton_Click(object sender, EventArgs e)
        {
            // Set consent cookie
            HttpCookie consentCookie = new HttpCookie("consent", "accepted");
            consentCookie.Expires = DateTime.Now.AddYears(1);
            Response.Cookies.Add(consentCookie);

            // Hide the banner
            cookieConsentBanner.Style["display"] = "none";
        }

        protected void LightThemeButton_Click(object sender, EventArgs e)
        {
            SetThemeCookie("light");
            ApplyTheme("light");
        }

        protected void DarkThemeButton_Click(object sender, EventArgs e)
        {
            SetThemeCookie("dark");
            ApplyTheme("dark");
        }

        private void SetThemeCookie(string theme)
        {
            HttpCookie themeCookie = new HttpCookie("theme", theme);
            themeCookie.Expires = DateTime.Now.AddYears(1);
            Response.Cookies.Add(themeCookie);
        }

        private void ApplyTheme(string theme)
        {
            if (theme == "dark")
            {
                MainBody.Attributes["class"] = "bg-dark text-white";
            }
            else
            {
                MainBody.Attributes["class"] = "bg-light text-dark";
            }
        }
        protected void DeclineCookiesButton_Click(object sender, EventArgs e)
        {
            // Clear cookies for consent and theme
            if (Request.Cookies["consent"] != null)
            {
                HttpCookie consentCookie = new HttpCookie("consent")
                {
                    Expires = DateTime.Now.AddDays(-1) // Expire immediately
                };
                Response.Cookies.Add(consentCookie);
            }

            if (Request.Cookies["theme"] != null)
            {
                HttpCookie themeCookie = new HttpCookie("theme")
                {
                    Expires = DateTime.Now.AddDays(-1)
                };
                Response.Cookies.Add(themeCookie);
            }

            cookieConsentBanner.Style["display"] = "none";

        }

    }
}