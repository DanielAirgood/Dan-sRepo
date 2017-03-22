using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ExperimentalProc.Calandar;

namespace WebApp
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        CalanderFormater CF;

        protected void Page_Load(object sender, EventArgs e)
        {
            CF = new CalanderFormater(2017);
            
            //this.Month.InnerText = GetMonth(1);

            
        }

        public string GetMonth(int monthID)//current content is temporay, meant only to be used as referance
        {
            switch (monthID)
            {
                case 1:
                    return @"January";//the @ allows the string to be placed on page
                    break;//these breaks are redundant because of the return
                case 2:
                    return @"Febuary";
                    break;
                case 3:
                    return @"March";
                    break;
                case 4:
                    return @"April";
                    break;
                case 5:
                    return @"May";
                    break;
            }
            return "Month Data Not recognize";
        }

        public void GetDay(int dayID)
        {
            

        }

        //form actions
        public void UpdateContent(object sender, EventArgs e)
        {

        }
    }
}