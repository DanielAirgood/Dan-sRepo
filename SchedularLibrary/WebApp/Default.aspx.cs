using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ExperimentalProc;
using ExperimentalProc.ClientManager;
using System.Diagnostics;

namespace WebApp
{
    public partial class _Default : Page
    {

        ExperimentalProc.DataBase.Server DataBase;

        protected void Page_Load(object sender, EventArgs e)
        {
            
            DataBase = new ExperimentalProc.DataBase.Server();//DataBase Communication Object
            /*
            string[] month = new string[] { };
            string[] week = new string[] { };
            string[] day = new string[] { };

            dat.InsertSchedualItem("2017", month, week, day, "404", "404", "05:00", "08:00");
            */

            //dat.InsertUserIntoDataBase();//test statement

        }
        

        protected void OnSubmit(object sender, EventArgs e)
        {
            //TODO:check user in database
            if(DataBase.RetriveUserFromDataBase(this.UserName.Text, this.Password.Text))
            {
                Global.ClientManager.RetriveClient(Session.SessionID).User = this.UserName.Text;

                Debug.WriteLine("WELL DONE YOU BANGEROF!" + Global.ClientManager.RetriveClient(Session.SessionID).User);

                Response.Redirect("Main.aspx");
            } else
            {
                Debug.WriteLine(this.UserName.Text, this.Password.Text);
                this.output.InnerText = "Invalid Login Credentials";
            }
           
        }
    }
}