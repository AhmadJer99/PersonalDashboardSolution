using System;
using System.Web;
using System.Web.Optimization;
using Microsoft.Extensions.DependencyInjection;
using System.Web.Routing;
using PersonalDashboard.Models;
using Microsoft.EntityFrameworkCore;
using System.Configuration;

namespace PersonalDashboard
{

    public class Global : HttpApplication
    {
        public static IServiceProvider ServiceProvider { get; private set; }
        void Application_Start(object sender, EventArgs e)
        {
            var services = new ServiceCollection();

            services.AddDbContext<PersonalDashboardContext>(options =>
                options.UseSqlServer(ConfigurationManager.ConnectionStrings["Default"].ConnectionString));


            // Code that runs on application startup
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            ServiceProvider = services.BuildServiceProvider();
        }
    }
}