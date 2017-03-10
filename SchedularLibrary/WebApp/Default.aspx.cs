using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ExperimentalProc;


namespace WebApp
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            /*
            ExperimentalProc.DataBase.Server dat = new ExperimentalProc.DataBase.Server();

            string[] month = new string[] { };
            string[] week = new string[] { };
            string[] day = new string[] { };

            dat.InsertSchedualItem("2017", month, week, day, "404", "404", "05:00", "08:00");
            */
        }

        public void  openWin(object sender, EventArgs e)
        {
            
            Response.Redirect("http://localhost:53291/signuppage.html");
        }
        public void openWin2(object sender, EventArgs e)
        {

            Response.Redirect("http://localhost:51538/Main.aspx");
        }

        protected void OnSubmit(object sender, EventArgs e)
        {
            //TODO:check user in database
        }
    }
}