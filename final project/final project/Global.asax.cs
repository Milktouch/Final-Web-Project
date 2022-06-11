using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.Security;
using System.Web.SessionState;
using System.IO;

namespace final_project
{
    public class Global : HttpApplication
    {
        public void UpdateSession(string[] data)
        {
            Session["UserData"] = data;
        }
        public string[] GetSession()
        {
            return (string[])Session["UserData"];
        }
        void Application_Start(object sender, EventArgs e)
        {

            
            // Code that runs on application startup
            
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            

        }
    }
}