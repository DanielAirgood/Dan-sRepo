using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.Security;
using System.Web.SessionState;
using ExperimentalProc.ClientManager;
using System.Diagnostics;//Debug: remove for release


namespace WebApp
{
    public class Global : HttpApplication
    {
        public static Manager ClientManager;

        void Application_Start(object sender, EventArgs e)
        {
            // Code that runs on application startup
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            ClientManager = new Manager();
        }

        void Session_Start(object sender, EventArgs e)
        {
            Debug.WriteLine("New Session: " + Session.SessionID);//Debug

            ClientManager.AddUser(Session.SessionID);
            
            //TODO: redirect user to active page recall
        }

        void Session_End(object sender, EventArgs e)
        {
            Debug.WriteLine("End Session: " + Session.SessionID);//Debug
            
            ClientManager.RemoveUser(Session.SessionID);

            //TODO: add active page recall
        }
    }
}