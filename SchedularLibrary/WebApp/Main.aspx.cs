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
        int month;

        protected void Page_Load(object sender, EventArgs e)
        {
            CF = new CalanderFormater(int.Parse(this.YearList.SelectedValue));

            month = int.Parse(MonthList.SelectedValue);

            
        }

        public string GetMonth(int monthID)//current content is temporay, meant only to be used as referance
        {
            switch (monthID)
            {
                case 1:
                    return "January";//the @ allows the string to be placed on page
                    break;//these breaks are redundant because of the return
                case 2:
                    return "Febuary";
                    break;
                case 3:
                    return "March";
                    break;
                case 4:
                    return "April";
                    break;
                case 5:
                    return "May";
                    break;
                case 6:
                    return "June";
                    break;
                case 7:
                    return "July";
                    break;
                case 8:
                    return "August";
                    break;
                case 9:
                    return "September";
                    break;
                case 10:
                    return "October";
                    break;
                case 11:
                    return "November";
                    break;
                case 12:
                    return "December";
                    break;
            }
            return "Month Data Not recognize";
        }

        public int GetMonthID(string month)//current content is temporay, meant only to be used as referance
        {
            switch (month)
            {
                case "January":
                    return 1;//the @ allows the string to be placed on page
                    break;//these breaks are redundant because of the return
                case "Febuary":
                    return 2;
                    break;
                case "March":
                    return 3;
                    break;
                case "April":
                    return 4;
                    break;
                case "May":
                    return 5;
                    break;
                case "June":
                    return 6;
                    break;
                case "July":
                    return 7;
                    break;
                case "August":
                    return 8;
                    break;
                case "September":
                    return 9;
                    break;
                case "October":
                    return 10;
                    break;
                case "November":
                    return 11;
                    break;
                case "December":
                    return 12;
                    break;
            }
            return 0;
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