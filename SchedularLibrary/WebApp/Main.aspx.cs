﻿using System;
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
        Month month;

        protected void Page_Load(object sender, EventArgs e)
        {
            CF = new CalanderFormater(int.Parse(this.YearList.SelectedValue));

            month = CF.getMonthByYear(int.Parse(MonthList.SelectedValue));

            UpdateContent(sender, e);
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

        
        //form actions
        public void UpdateContent(object sender, EventArgs e)
        {
            Server dataBase = new Server();

            int curWeek = 1;
            string TempDayItem;

            for (int i = month.Days.First<Day>().getDayID(); i <= month.Days.Last<Day>().getDayID(); i++)
            {
                switch(curWeek)
                {
                    case 1:
                        switch (CF.getDayOfWeek(i))
                        {
                            case 1:
                                if(dataBase.RetriveDayItem(CF.getYear(),i,out TempDayItem))
                                {
                                    this.Su_W1.Text = i +  ":<hr>" + TempDayItem;
                                } else
                                {
                                    this.Su_W1.Text = "Failed To Retrive Data";
                                }
                                break;
                            case 2:
                                if (dataBase.RetriveDayItem(CF.getYear(), i, out TempDayItem))
                                {
                                    this.M_W1.Text = i + ":<hr>" + TempDayItem;
                                }
                                else
                                {
                                    this.M_W1.Text = "Failed To Retrive Data";
                                }
                                break;
                            case 3:
                                if (dataBase.RetriveDayItem(CF.getYear(), i, out TempDayItem))
                                {
                                    this.Tu_W1.Text = i + ":<hr>" + TempDayItem;
                                }
                                else
                                {
                                    this.Tu_W1.Text = "Failed To Retrive Data";
                                }
                                break;
                            case 4:
                                if (dataBase.RetriveDayItem(CF.getYear(), i, out TempDayItem))
                                {
                                    this.W_W1.Text = i + ":<hr>" + TempDayItem;
                                }
                                else
                                {
                                    this.W_W1.Text = "Failed To Retrive Data";
                                }
                                break;
                            case 5:
                                if (dataBase.RetriveDayItem(CF.getYear(), i, out TempDayItem))
                                {
                                    this.Th_W1.Text = i + ":<hr>" + TempDayItem;
                                }
                                else
                                {
                                    this.Th_W1.Text = "Failed To Retrive Data";
                                }
                                break;
                            case 6:
                                if (dataBase.RetriveDayItem(CF.getYear(), i, out TempDayItem))
                                {
                                    this.F_W1.Text = i + ":<hr>" + TempDayItem;
                                }
                                else
                                {
                                    this.F_W1.Text = "Failed To Retrive Data";
                                }
                                break;
                            case 7:
                                if (dataBase.RetriveDayItem(CF.getYear(), i, out TempDayItem))
                                {
                                    this.Sa_W1.Text = i + ":<hr>" + TempDayItem;
                                }
                                else
                                {
                                    this.Sa_W1.Text = "Failed To Retrive Data";
                                }
                                curWeek++;
                                break;
                        }
                        break;

                    case 2:
                        switch (CF.getDayOfWeek(i))
                        {
                            case 1:
                                if (dataBase.RetriveDayItem(CF.getYear(), i, out TempDayItem))
                                {
                                    this.Su_W2.Text = i + ":<hr>" + TempDayItem;
                                }
                                else
                                {
                                    this.Su_W2.Text = "Failed To Retrive Data";
                                }
                                break;
                            case 2:
                                if (dataBase.RetriveDayItem(CF.getYear(), i, out TempDayItem))
                                {
                                    this.M_W2.Text = i + ":<hr>" + TempDayItem;
                                }
                                else
                                {
                                    this.M_W2.Text = "Failed To Retrive Data";
                                }
                                break;
                            case 3:
                                if (dataBase.RetriveDayItem(CF.getYear(), i, out TempDayItem))
                                {
                                    this.Tu_W2.Text = i + ":<hr>" + TempDayItem;
                                }
                                else
                                {
                                    this.Tu_W2.Text = "Failed To Retrive Data";
                                }
                                break;
                            case 4:
                                if (dataBase.RetriveDayItem(CF.getYear(), i, out TempDayItem))
                                {
                                    this.W_W2.Text = i + ":<hr>" + TempDayItem;
                                }
                                else
                                {
                                    this.W_W2.Text = "Failed To Retrive Data";
                                }
                                break;
                            case 5:
                                if (dataBase.RetriveDayItem(CF.getYear(), i, out TempDayItem))
                                {
                                    this.Th_W2.Text = i + ":<hr>" + TempDayItem;
                                }
                                else
                                {
                                    this.Th_W2.Text = "Failed To Retrive Data";
                                }
                                break;
                            case 6:
                                if (dataBase.RetriveDayItem(CF.getYear(), i, out TempDayItem))
                                {
                                    this.F_W2.Text = i + ":<hr>" + TempDayItem;
                                }
                                else
                                {
                                    this.F_W2.Text = "Failed To Retrive Data";
                                }
                                break;
                            case 7:
                                if (dataBase.RetriveDayItem(CF.getYear(), i, out TempDayItem))
                                {
                                    this.Sa_W2.Text = i + ":<hr>" + TempDayItem;
                                }
                                else
                                {
                                    this.Sa_W2.Text = "Failed To Retrive Data";
                                }
                                curWeek++;
                                break;
                        }
                        break;

                    case 3:
                        switch (CF.getDayOfWeek(i))
                        {
                            case 1:
                                if (dataBase.RetriveDayItem(CF.getYear(), i, out TempDayItem))
                                {
                                    this.Su_W3.Text = i + ":<hr>" + TempDayItem;
                                }
                                else
                                {
                                    this.Su_W3.Text = "Failed To Retrive Data";
                                }
                                break;
                            case 2:
                                if (dataBase.RetriveDayItem(CF.getYear(), i, out TempDayItem))
                                {
                                    this.M_W3.Text = i + ":<hr>" + TempDayItem;
                                }
                                else
                                {
                                    this.M_W3.Text = "Failed To Retrive Data";
                                }
                                break;
                            case 3:
                                if (dataBase.RetriveDayItem(CF.getYear(), i, out TempDayItem))
                                {
                                    this.Tu_W3.Text = i + ":<hr>" + TempDayItem;
                                }
                                else
                                {
                                    this.Tu_W3.Text = "Failed To Retrive Data";
                                }
                                break;
                            case 4:
                                if (dataBase.RetriveDayItem(CF.getYear(), i, out TempDayItem))
                                {
                                    this.W_W3.Text = i + ":<hr>" + TempDayItem;
                                }
                                else
                                {
                                    this.W_W3.Text = "Failed To Retrive Data";
                                }
                                break;
                            case 5:
                                if (dataBase.RetriveDayItem(CF.getYear(), i, out TempDayItem))
                                {
                                    this.Th_W3.Text = i + ":<hr>" + TempDayItem;
                                }
                                else
                                {
                                    this.Th_W3.Text = "Failed To Retrive Data";
                                }
                                break;
                            case 6:
                                if (dataBase.RetriveDayItem(CF.getYear(), i, out TempDayItem))
                                {
                                    this.F_W3.Text = i + ":<hr>" + TempDayItem;
                                }
                                else
                                {
                                    this.F_W3.Text = "Failed To Retrive Data";
                                }
                                break;
                            case 7:
                                if (dataBase.RetriveDayItem(CF.getYear(), i, out TempDayItem))
                                {
                                    this.Sa_W3.Text = i + ":<hr>" + TempDayItem;
                                }
                                else
                                {
                                    this.Sa_W3.Text = "Failed To Retrive Data";
                                }
                                curWeek++;
                                break;
                        }
                        break;

                    case 4:
                        switch (CF.getDayOfWeek(i))
                        {
                            case 1:
                                if (dataBase.RetriveDayItem(CF.getYear(), i, out TempDayItem))
                                {
                                    this.Su_W4.Text = i + ":<hr>" + TempDayItem;
                                }
                                else
                                {
                                    this.Su_W4.Text = "Failed To Retrive Data";
                                }
                                break;
                            case 2:
                                if (dataBase.RetriveDayItem(CF.getYear(), i, out TempDayItem))
                                {
                                    this.M_W4.Text = i + ":<hr>" + TempDayItem;
                                }
                                else
                                {
                                    this.M_W4.Text = "Failed To Retrive Data";
                                }
                                break;
                            case 3:
                                if (dataBase.RetriveDayItem(CF.getYear(), i, out TempDayItem))
                                {
                                    this.Tu_W4.Text = i + ":<hr>" + TempDayItem;
                                }
                                else
                                {
                                    this.Tu_W4.Text = "Failed To Retrive Data";
                                }
                                break;
                            case 4:
                                if (dataBase.RetriveDayItem(CF.getYear(), i, out TempDayItem))
                                {
                                    this.W_W4.Text = i + ":<hr>" + TempDayItem;
                                }
                                else
                                {
                                    this.W_W4.Text = "Failed To Retrive Data";
                                }
                                break;
                            case 5:
                                if (dataBase.RetriveDayItem(CF.getYear(), i, out TempDayItem))
                                {
                                    this.Th_W4.Text = i + ":<hr>" + TempDayItem;
                                }
                                else
                                {
                                    this.Th_W4.Text = "Failed To Retrive Data";
                                }
                                break;
                            case 6:
                                if (dataBase.RetriveDayItem(CF.getYear(), i, out TempDayItem))
                                {
                                    this.F_W4.Text = i + ":<hr>" + TempDayItem;
                                }
                                else
                                {
                                    this.F_W4.Text = "Failed To Retrive Data";
                                }
                                break;
                            case 7:
                                if (dataBase.RetriveDayItem(CF.getYear(), i, out TempDayItem))
                                {
                                    this.Sa_W4.Text = i + ":<hr>" + TempDayItem;
                                }
                                else
                                {
                                    this.Sa_W4.Text = "Failed To Retrive Data";
                                }
                                curWeek++;
                                break;
                        }
                        break;

                    case 5:
                        switch (CF.getDayOfWeek(i))
                        {
                            case 1:
                                if (dataBase.RetriveDayItem(CF.getYear(), i, out TempDayItem))
                                {
                                    this.Su_W5.Text = i + ":<hr>" + TempDayItem;
                                }
                                else
                                {
                                    this.Su_W5.Text = "Failed To Retrive Data";
                                }
                                break;
                            case 2:
                                if (dataBase.RetriveDayItem(CF.getYear(), i, out TempDayItem))
                                {
                                    this.M_W5.Text = i + ":<hr>" + TempDayItem;
                                }
                                else
                                {
                                    this.M_W5.Text = "Failed To Retrive Data";
                                }
                                break;
                            case 3:
                                if (dataBase.RetriveDayItem(CF.getYear(), i, out TempDayItem))
                                {
                                    this.Tu_W5.Text = i + ":<hr>" + TempDayItem;
                                }
                                else
                                {
                                    this.Tu_W5.Text = "Failed To Retrive Data";
                                }
                                break;
                            case 4:
                                if (dataBase.RetriveDayItem(CF.getYear(), i, out TempDayItem))
                                {
                                    this.W_W5.Text = i + ":<hr>" + TempDayItem;
                                }
                                else
                                {
                                    this.W_W5.Text = "Failed To Retrive Data";
                                }
                                break;
                            case 5:
                                if (dataBase.RetriveDayItem(CF.getYear(), i, out TempDayItem))
                                {
                                    this.Th_W5.Text = i + ":<hr>" + TempDayItem;
                                }
                                else
                                {
                                    this.Th_W5.Text = "Failed To Retrive Data";
                                }
                                break;
                            case 6:
                                if (dataBase.RetriveDayItem(CF.getYear(), i, out TempDayItem))
                                {
                                    this.F_W5.Text = i + ":<hr>" + TempDayItem;
                                }
                                else
                                {
                                    this.F_W5.Text = "Failed To Retrive Data";
                                }
                                break;
                            case 7:
                                if (dataBase.RetriveDayItem(CF.getYear(), i, out TempDayItem))
                                {
                                    this.Sa_W5.Text = i + ":<hr>" + TempDayItem;
                                }
                                else
                                {
                                    this.Sa_W5.Text = "Failed To Retrive Data";
                                }
                                curWeek++;
                                break;
                        }
                        break;
                        
                }//end week case
            }

            this.Construct();
        }//end updateContent

        protected void ChangeMonth(object sender, EventArgs e)
        {
            //use session to store month to display
        }
    }
}