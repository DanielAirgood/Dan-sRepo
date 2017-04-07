using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ExperimentalProc.Calandar;
using ExperimentalProc.DataBase;

namespace WebApp
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        CalanderFormater CF;

        int month;//monthID of data too display
        int year;//year to be displayed

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["Month"] != null)//checks if user specified a month
                {
                    MonthList.SelectedIndex = int.Parse(Session["Month"].ToString()) - 1;
                }
            }

            month = int.Parse(MonthList.SelectedValue);
            year = int.Parse(this.YearList.SelectedValue);
            

            CF = new CalanderFormater(year);

            UpdateContent(sender, e);//fills the calandar with relevent data
        }

        //Returns name of month based on monthID
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

        //returns monthID based on month name
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


        //form actions
        
        //Retrives dayItem data from database and fills the calandar
        public void UpdateContent(object sender, EventArgs e)
        {
            Server dataBase = new Server();

            string dayItemText;
            int curWeek = 1;
            for (int i = CF.getMonthByYear(month)[1].getDayID(); i <= CF.getMonthByYear(month).Days.Last<Day>().getDayID(); i++)//TODO: clean this mess
            {
                switch (curWeek)
                {
                    case 1:
                        switch (CF.getDayOfWeek(i))
                        {
                            case 1:
                                if (dataBase.RetriveDayItem(year, i, out dayItemText))
                                {
                                    D1W1.Text = dayItemText;
                                }
                                else
                                {
                                    D1W1.Text = "Failed to Excecute DataBase Query";
                                }
                                break;
                            case 2:
                                if (dataBase.RetriveDayItem(year, i, out dayItemText))
                                {
                                    D2W1.Text = dayItemText;
                                }
                                else
                                {
                                    D2W1.Text = "Failed to Excecute DataBase Query";
                                }
                                break;
                            case 3:
                                if (dataBase.RetriveDayItem(year, i, out dayItemText))
                                {
                                    D3W1.Text = dayItemText;
                                }
                                else
                                {
                                    D3W1.Text = "Failed to Excecute DataBase Query";
                                }
                                break;
                            case 4:
                                if (dataBase.RetriveDayItem(year, i, out dayItemText))
                                {
                                    D4W1.Text = dayItemText;
                                }
                                else
                                {
                                    D4W1.Text = "Failed to Excecute DataBase Query";
                                }
                                break;
                            case 5:
                                if (dataBase.RetriveDayItem(year, i, out dayItemText))
                                {
                                    D5W1.Text = dayItemText;
                                }
                                else
                                {
                                    D5W1.Text = "Failed to Excecute DataBase Query";
                                }
                                break;
                            case 6:
                                if (dataBase.RetriveDayItem(year, i, out dayItemText))
                                {
                                    D6W1.Text = dayItemText;
                                }
                                else
                                {
                                    D6W1.Text = "Failed to Excecute DataBase Query";
                                }
                                break;
                            case 7:
                                curWeek++;
                                if (dataBase.RetriveDayItem(year, i, out dayItemText))
                                {
                                    D7W1.Text = dayItemText;
                                }
                                else
                                {
                                    D7W1.Text = "Failed to Excecute DataBase Query";
                                }
                                break;

                        }//end day of week switch block
                        break;

                    case 2:
                        switch (CF.getDayOfWeek(i))
                        {
                            case 1:
                                if (dataBase.RetriveDayItem(year, i, out dayItemText))
                                {
                                    D1W2.Text = dayItemText;
                                }
                                else
                                {
                                    D1W2.Text = "Failed to Excecute DataBase Query";
                                }
                                break;
                            case 2:
                                if (dataBase.RetriveDayItem(year, i, out dayItemText))
                                {
                                    D2W2.Text = dayItemText;
                                }
                                else
                                {
                                    D2W2.Text = "Failed to Excecute DataBase Query";
                                }
                                break;
                            case 3:
                                if (dataBase.RetriveDayItem(year, i, out dayItemText))
                                {
                                    D3W2.Text = dayItemText;
                                }
                                else
                                {
                                    D3W2.Text = "Failed to Excecute DataBase Query";
                                }
                                break;
                            case 4:
                                if (dataBase.RetriveDayItem(year, i, out dayItemText))
                                {
                                    D4W2.Text = dayItemText;
                                }
                                else
                                {
                                    D4W2.Text = "Failed to Excecute DataBase Query";
                                }
                                break;
                            case 5:
                                if (dataBase.RetriveDayItem(year, i, out dayItemText))
                                {
                                    D5W2.Text = dayItemText;
                                }
                                else
                                {
                                    D5W2.Text = "Failed to Excecute DataBase Query";
                                }
                                break;
                            case 6:
                                if (dataBase.RetriveDayItem(year, i, out dayItemText))
                                {
                                    D6W2.Text = dayItemText;
                                }
                                else
                                {
                                    D6W2.Text = "Failed to Excecute DataBase Query";
                                }
                                break;
                            case 7:
                                curWeek++;
                                if (dataBase.RetriveDayItem(year, i, out dayItemText))
                                {
                                    D7W2.Text = dayItemText;
                                }
                                else
                                {
                                    D7W2.Text = "Failed to Excecute DataBase Query";
                                }
                                break;

                        }//end day of week switch block
                        break;

                    case 3:
                        switch (CF.getDayOfWeek(i))
                        {
                            case 1:
                                if (dataBase.RetriveDayItem(year, i, out dayItemText))
                                {
                                    D1W3.Text = dayItemText;
                                }
                                else
                                {
                                    D1W3.Text = "Failed to Excecute DataBase Query";
                                }
                                break;
                            case 2:
                                if (dataBase.RetriveDayItem(year, i, out dayItemText))
                                {
                                    D2W3.Text = dayItemText;
                                }
                                else
                                {
                                    D2W3.Text = "Failed to Excecute DataBase Query";
                                }
                                break;
                            case 3:
                                if (dataBase.RetriveDayItem(year, i, out dayItemText))
                                {
                                    D3W3.Text = dayItemText;
                                }
                                else
                                {
                                    D3W3.Text = "Failed to Excecute DataBase Query";
                                }
                                break;
                            case 4:
                                if (dataBase.RetriveDayItem(year, i, out dayItemText))
                                {
                                    D4W3.Text = dayItemText;
                                }
                                else
                                {
                                    D4W3.Text = "Failed to Excecute DataBase Query";
                                }
                                break;
                            case 5:
                                if (dataBase.RetriveDayItem(year, i, out dayItemText))
                                {
                                    D5W3.Text = dayItemText;
                                }
                                else
                                {
                                    D5W3.Text = "Failed to Excecute DataBase Query";
                                }
                                break;
                            case 6:
                                if (dataBase.RetriveDayItem(year, i, out dayItemText))
                                {
                                    D6W3.Text = dayItemText;
                                }
                                else
                                {
                                    D6W3.Text = "Failed to Excecute DataBase Query";
                                }
                                break;
                            case 7:
                                curWeek++;
                                if (dataBase.RetriveDayItem(year, i, out dayItemText))
                                {
                                    D7W3.Text = dayItemText;
                                }
                                else
                                {
                                    D7W3.Text = "Failed to Excecute DataBase Query";
                                }
                                break;

                        }//end day of week switch block
                        break;

                    case 4:
                        switch (CF.getDayOfWeek(i))
                        {
                            case 1:
                                if (dataBase.RetriveDayItem(year, i, out dayItemText))
                                {
                                    D1W4.Text = dayItemText;
                                }
                                else
                                {
                                    D1W4.Text = "Failed to Excecute DataBase Query";
                                }
                                break;
                            case 2:
                                if (dataBase.RetriveDayItem(year, i, out dayItemText))
                                {
                                    D2W4.Text = dayItemText;
                                }
                                else
                                {
                                    D2W4.Text = "Failed to Excecute DataBase Query";
                                }
                                break;
                            case 3:
                                if (dataBase.RetriveDayItem(year, i, out dayItemText))
                                {
                                    D3W4.Text = dayItemText;
                                }
                                else
                                {
                                    D3W4.Text = "Failed to Excecute DataBase Query";
                                }
                                break;
                            case 4:
                                if (dataBase.RetriveDayItem(year, i, out dayItemText))
                                {
                                    D4W4.Text = dayItemText;
                                }
                                else
                                {
                                    D4W4.Text = "Failed to Excecute DataBase Query";
                                }
                                break;
                            case 5:
                                if (dataBase.RetriveDayItem(year, i, out dayItemText))
                                {
                                    D5W4.Text = dayItemText;
                                }
                                else
                                {
                                    D5W4.Text = "Failed to Excecute DataBase Query";
                                }
                                break;
                            case 6:
                                if (dataBase.RetriveDayItem(year, i, out dayItemText))
                                {
                                    D6W4.Text = dayItemText;
                                }
                                else
                                {
                                    D6W4.Text = "Failed to Excecute DataBase Query";
                                }
                                break;
                            case 7:
                                curWeek++;
                                if (dataBase.RetriveDayItem(year, i, out dayItemText))
                                {
                                    D7W4.Text = dayItemText;
                                }
                                else
                                {
                                    D7W4.Text = "Failed to Excecute DataBase Query";
                                }
                                break;
                        }//end day of week switch block
                        break;

                    case 5:
                        switch (CF.getDayOfWeek(i))
                        {
                            case 1:
                                if (dataBase.RetriveDayItem(year, i, out dayItemText))
                                {
                                    D1W5.Text = dayItemText;
                                }
                                else
                                {
                                    D1W5.Text = "Failed to Excecute DataBase Query";
                                }
                                break;
                            case 2:
                                if (dataBase.RetriveDayItem(year, i, out dayItemText))
                                {
                                    D2W5.Text = dayItemText;
                                }
                                else
                                {
                                    D2W5.Text = "Failed to Excecute DataBase Query";
                                }
                                break;
                            case 3:
                                if (dataBase.RetriveDayItem(year, i, out dayItemText))
                                {
                                    D3W5.Text = dayItemText;
                                }
                                else
                                {
                                    D3W5.Text = "Failed to Excecute DataBase Query";
                                }
                                break;
                            case 4:
                                if (dataBase.RetriveDayItem(year, i, out dayItemText))
                                {
                                    D4W5.Text = dayItemText;
                                }
                                else
                                {
                                    D4W5.Text = "Failed to Excecute DataBase Query";
                                }
                                break;
                            case 5:
                                if (dataBase.RetriveDayItem(year, i, out dayItemText))
                                {
                                    D5W5.Text = dayItemText;
                                }
                                else
                                {
                                    D5W5.Text = "Failed to Excecute DataBase Query";
                                }
                                break;
                            case 6:
                                if (dataBase.RetriveDayItem(year, i, out dayItemText))
                                {
                                    D6W5.Text = dayItemText;
                                }
                                else
                                {
                                    D6W5.Text = "Failed to Excecute DataBase Query";
                                }
                                break;
                            case 7:
                                curWeek++;
                                if (dataBase.RetriveDayItem(year, i, out dayItemText))
                                {
                                    D7W5.Text = dayItemText;
                                }
                                else
                                {
                                    D7W5.Text = "Failed to Excecute DataBase Query";
                                }
                                break;

                        }//end day of week switch block
                        break;
                }//end week switch block
            }
        }

        //allows user to specify a month to display on page: called by Element(MonthList)
        protected void UpdateMonth(object sender, EventArgs e)
        {
            Session["Month"] = MonthList.SelectedValue;
            Response.Redirect(Request.RawUrl);
        }

        protected void UpdateYear(object sender, EventArgs e)
        {
            Session["Year"] = YearList.SelectedValue;
            Response.Redirect(Request.RawUrl);
        }

        protected void Upload(object sender, EventArgs e)
        {
            Server DataBase = new Server();
            
            string[] month = targetMonths.Text.Split(' ');
            if (month[0] == "")
            {
                month = new string[0];
            }

            string[] week = targetWeekDays.Text.Split(' ');
            if (week[0] == "")
            {
                week = new string[0];
            }

            string[] day = targetDays.Text.Split(' ');
            if (day[0] == "")
            {
                day = new string[0];
            }

            



            if(DataBase.InsertSchedualItem(targetYear.Text, month, week, day, targetRoom.Text, targetCourse.Text, targetStart.Text, targetEnd.Text))
            {
                Response.Redirect(Request.RawUrl);
            }else
            {
                MessageText.Text = "Failed to upload content too database. (check your syntax?)";
                //Message.Update();
            }
        }
    }
}
