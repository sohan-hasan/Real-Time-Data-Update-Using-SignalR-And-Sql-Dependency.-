using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace TestSqlToSignalRCommunication
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            string connString = "Server=DESKTOP-3EILP70;Database=Employee; Integrated Security=True;";
            string connString1 = "user id=trackyourtruck60;password=dbuser;data source=10.152.158.4;initial catalog=employeedb";
            SqlDependency.Start(connString1);
        }
    }
}
