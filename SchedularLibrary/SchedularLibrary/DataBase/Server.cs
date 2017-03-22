using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data.SqlClient;
using System.Globalization;
using System.Reflection;
using System.Diagnostics;

//Contians problems that must be fixed before push to master [MASTER]
//Contains problems that *SHOULD* be fixed before end of alpha phase [ALPHA]
//Contains problems that would be nice to resolve [TODO]
//Contains potential beta features [BETA] : fault talerance


namespace ExperimentalProc.DataBase
{
    public class Server
    {
        private string DataBaseConectionString = null;
        protected SqlConnection connection;
        public Server()
        {

            StreamReader config = new StreamReader(Path.GetDirectoryName(Uri.UnescapeDataString(new UriBuilder(Assembly.GetAssembly(typeof(Server)).CodeBase).Path)) + "/DataBaseConfig.txt");

            while (!config.EndOfStream)
            {//load config functions
                string[] line = config.ReadLine().Split(':');

                if (line[0] == "DataBase Conection String") { DataBaseConectionString = line[1]; }//database conection string

                //TODO add ADMIN config [ALPHA]
            }

            //DataBaseConectionString: Data Source=stusql;Initial Catalog=DanumCenter;Integrated Security=true;
            //config path: WebApp/Bin/DataBaseConfig.txt

            try
            {
                connection = new SqlConnection();
                connection.ConnectionString = DataBaseConectionString;
                Debug.WriteLine("Connection Made");
                Debug.WriteLine(DataBaseConectionString);
            }
            catch (SqlException excp)
            {
                Debug.WriteLine(DataBaseConectionString);
                Debug.WriteLine("Connection Failed: " + excp);
            }

        }

        //TODO: Alter this to work with new database [ALPHA]
        //generic insert into database statment
        public bool InsertRoomIntoDataBase(string Room_ID, string Room_Name)
        {

            SqlCommand cmd = new SqlCommand();
            //Convert Room Logic
            int Room_IDParse;
            if (int.TryParse(Room_ID, out Room_IDParse))
            {
                //Pre insert Room Logic Here:

            }
            else
            {
                Debug.WriteLine("Failed to Parse <STRING_ROOM_ID: " + Room_ID + "> too INT");
                return false;
            }


            //Convert Month Logic
            string Room_NameParse;
            if (Room_Name.Length <= 20)
            {
                //Pre insert Month Logic Here:
                Room_NameParse = Room_Name;
            }
            else
            {
                Debug.WriteLine("Failed to Parse <STRING_ROOM_NAME: " + Room_Name + "> too VARCHAR(20)");
                return false;
            }

            try
            {
                connection.Open();
                cmd.Connection = connection;
                cmd.CommandText = "INSERT INTO Rooms (Room_ID,Room_Name) VALUES(" + Room_IDParse + "," + "'" + Room_NameParse + "'" + "); ";//alter this to be an insert statment
                cmd.ExecuteNonQuery();
            }
            catch (SqlException excp)
            {
                Debug.WriteLine("Failed to run InsertIntoDataBase: " + excp);
                connection.Close();
                return false;
            }

            connection.Close();
            return true;
        }

        //TODO: Alter this to work with new database [ALPHA]
        //Generic insert Course item to database
        public bool InsertCourseIntoDataBase(string Class_ID, string Course, string Course_ID)
        {

            SqlCommand cmd = new SqlCommand();
            //Convert Room Logic
            int Class_IDParse;
            if (int.TryParse(Class_ID, out Class_IDParse))
            {
                //Pre insert Room Logic Here:

            }
            else
            {
                Debug.WriteLine("Failed to Parse <STRING_Class_ID: " + Class_ID + "> too INT");
                return false;
            }


            //Convert Month Logic
            string CourseParse;
            if (Course.Length <= 20)
            {
                //Pre insert Month Logic Here:
                CourseParse = Course;
            }
            else
            {
                Debug.WriteLine("Failed to Parse <STRING_Course: " + Course + "> too INT");
                return false;
            }
            //Convert Month Logic
            string Course_IDParse;
            if (Course_ID.Length <= 20)
            {
                //Pre insert Month Logic Here:
                Course_IDParse = Course;
            }
            else
            {
                Debug.WriteLine("Failed to Parse <STRING_MONTH: " + Course_ID + "> too INT");
                return false;
            }

            try
            {
                connection.Open();
                cmd.Connection = connection;
                cmd.CommandText = "INSERT INTO Classes(Class_ID,Class, Course) VALUES(" + (int)300 + "," + "'Gym'" + "," + "'15228'" + "); ";//alter this to insert passed params : CourseQueryString [ALPHA]
                cmd.ExecuteNonQuery();
            }
            catch (SqlException excp)
            {
                Debug.WriteLine("Failed to run InsertIntoDataBase: " + excp);
                connection.Close();
                return false;
            }

            connection.Close();
            return true;
        }

        //attempts to insert passed values into dataBase. returns false if failed
        public bool InsertUserIntoDataBase()
        {
            SqlCommand cmd = new SqlCommand();

            try
            {
                connection.Open();
                cmd.Connection = connection;
                cmd.CommandText = "INSERT INTO dbo.USER_REGISTRY(USER_NAME,USER_PASSWORD,USER_PRIVLAGE,USER_ONLINE) VALUES('testUser', '123test', '0', '0'); ";//alter this to insert passed params : CourseQueryString [ALPHA]
                cmd.ExecuteNonQuery();
            }
            catch (SqlException excp)
            {
                Debug.WriteLine("Failed to run InsertIntoDataBase: " + excp);
                connection.Close();
                return false;
            }

            connection.Close();
            return true;
        }


        //Check if user is registered with password
        public bool RetriveUserFromDataBase(string userName, string password)
        {
            bool pass = false;
            SqlCommand cmd = new SqlCommand("SELECT USER_NAME FROM dbo.USER_REGISTRY WHERE USER_NAME = '" + userName + "' AND USER_PASSWORD = '" + password + "';", connection);
            
            try
            {
                connection.Open();
               if(cmd.ExecuteScalar().ToString() == userName)
                {
                    pass = true;
                } else
                {
                    pass = false;
                }
            }
            catch (SqlException excp)
            {
                Debug.WriteLine("Failed to run InsertIntoDataBase: " + excp);
                connection.Close();
                return false;
            }

            connection.Close();

            return pass;
        }


        /*
         Attempts a brute force insert of all data considered valid by target parameters.
         Does not check against data inside database.
         If a target parameters are not valid within given context, function will imediantly terminate and no data will be inserted into database [returns false].
             
             Parmeters(implicit):
             Target Database: Defined by [DataBase Connetion String] in [WebApp/Bin/DataBaseConfig.txt]

             Parmeters(defined):
             year(string): target year for upload into database. used by (Calander Logic) and [Calandar/CalanderFormater.cs]
             month(string): target month to upload target data. if left as (null) or (0) all months will be targeted
             week(string): target day of week to upload target data. if left as (null) or (0) all weeks will be targeted
             day(string): target day of target month(s) to upload target data. if left as (null) or (0) all days will be targeted
             room(string): roomID of target data to upload into database
             course(string): courseID of target data to upload into database
             startTime(string): time of day following 12 Clock formated to fit "XX:XX" as a 5 character string, defines begining target time of day for upload into dataBase
             endTime(string): time of day following 12 Clock formated to fit "XX:XX" as a 5 character string, defines ending target time of day for upload into dataBase
             */
        public bool InsertSchedualItem(string year, string[] month, string[] week, string[] day, string room, string course, string startTime, string endTime)
        {

            //Convert Year Logic
            int yearParse;
            if (int.TryParse(year, out yearParse))
            {
                //Pre insert Year Logic Here:

            }
            else
            {
                Debug.WriteLine("Failed to Parse <STRING_YEAR: " + year + "> too INT");
                return false;
            }


            //Convert Month Logic
            int[] monthParse = new int[month.Length];
            for (int i = 0; i < month.Length; i++)
            {

                if (int.TryParse(month[i], out monthParse[i]))
                {
                    //Pre insert Month Logic Here:

                }
                else
                {
                    Debug.WriteLine("Failed to Parse <STRING_MONTH: " + month[i] + "> too INT");
                    return false;
                }
            }


            //Convert Week Logic
            int[] weekParse = new int[week.Length];
            for (int i = 0; i < week.Length; i++)
            {
                if (int.TryParse(week[i], out weekParse[i]))
                {
                    //Pre insert Day Logic Here:

                }
                else
                {
                    Debug.WriteLine("Failed to Parse <STRING_WEEK: " + week[i] + "> too INT");
                    return false;
                }
            }


            //Convert Day Logic
            int[] dayParse = new int[day.Length];
            for (int i = 0; i < day.Length; i++)
            {
                if (int.TryParse(day[i], out dayParse[i]))
                {
                    //Pre insert Day Logic Here:

                }
                else
                {
                    Debug.WriteLine("Failed to Parse <STRING_DAY: " + day[i] + "> too INT");
                    return false;
                }
            }


            //Convert Room Logic
            int roomParse;
            if (int.TryParse(room, out roomParse))
            {
                //Pre insert Room Logic Here:

            }
            else if (room == null)//Dan: roomID shouldn't be optional either, need to fix before push to master [MASTER] not-note: meh...
            {
                roomParse = 0;
            }
            else
            {
                Debug.WriteLine("Failed to Parse <STRING_ROOM: " + room + "> too INT");
                return false;
            }


            //Convert Course Logic
            int courseParse;
            if (int.TryParse(course, out courseParse))
            {
                //Pre insert Course Logic Here:

            }
            else if (course == null)//Dan: hold up... the course ID shouldn't be optional. this needs fixed before we can update master [MASTER]
            {
                courseParse = 0;
            }
            else
            {
                Debug.WriteLine("Failed to Parse <STRING_COURSE: " + course + "> too INT");
                return false;
            }

            TimeItem startTimeParse;
            try
            {
                startTimeParse = new TimeItem(startTime);
            }
            catch (FormatException excpt)
            {
                Debug.WriteLine("Failed to Parse <STRING_START_TIME: " + startTime + "> too TIMEITEM \n" + excpt);
                return false;
            }

            TimeItem endTimeParse;
            try
            {
                endTimeParse = new TimeItem(endTime);
            }
            catch (FormatException excpt)
            {
                Debug.WriteLine("Failed to Parse <STRING_END_TIME: " + endTime + "> too TIMEITEM \n" + excpt);
                return false;
            }


            //Dan : Calandar logic
            Calandar.CalanderFormater CF = new Calandar.CalanderFormater(yearParse);


            SqlCommand cmd = new SqlCommand();//holds information for interacting with database
            //GregorianCalendar GC = new GregorianCalendar();//deadcode: replaced with CalanderFormater

            //Dan : find valid days logic
            for (int curDay = 1; curDay <= CF.GetDaysAmount(); curDay++)//begin for days in year
            {
                bool isValid = true;

                if (monthParse.Length != 0)//if month specified
                {
                    for (int i = 0; i < monthParse.Length; i++)
                    {
                        if (CF.getMonthByDay(curDay).getMonthID() == monthParse[i])//looks to see if current day is in specified month
                        {
                            isValid = true;//makes invalid if it is
                            break;
                        }
                        else
                        {
                            isValid = false;
                        }
                    }

                }//end if month specified

                if (weekParse.Length != 0 && isValid)//if week specified
                {
                    for (int i = 0; i < weekParse.Length; i++)
                    {
                        if (CF.getDayOfWeek(curDay) == weekParse[i])//looks to see if current day is specified day of week
                        {
                            isValid = true;
                            break;
                        }
                        else
                        {
                            isValid = false;
                        }
                    }
                }//end if week specified

                if (dayParse.Length != 0 && isValid)//if day specified
                {
                    for (int i = 0; i < dayParse.Length; i++)
                    {
                        if (CF.getMonthByDay(curDay).getDayByMonth(dayParse[i]).getDayID() == curDay)//looks to see if current day is specified days into month
                        {
                            isValid = true;
                            break;
                        }
                        else
                        {
                            isValid = false;
                        }
                    }
                }//end if day specified
                
                if (isValid)//if valid day
                {
                    string[] badrows;
                    string[] colDats = { null, null, null, null, null, null, CF[curDay - 1].getDayID().ToString(), null, null };
                    if (!IsConflict("SELECT * FROM dbo.CALANDER_LIST WHERE LIST_YEAR IN (" + yearParse + ") AND ROOM_ID IN (" + roomParse + ");", colDats, out badrows))//checks for conflicting days of year
                    {

                        colDats = new string[] { null, null, null, null, null, null, null, startTimeParse.ToString(), endTimeParse.ToString() };//checks for conflicting rooms in days of year

                        string[] rowGet;
                        for (int i = 0; i < badrows.Length; i++)
                        {
                            if (IsConflictSingleRow("SELECT * FROM dbo.CALANDER_LIST WHERE LIST_ID IN (" + badrows[i] + ");", colDats, out rowGet))
                            {
                                TimeItem gotStart = new TimeItem(rowGet[7]);
                                TimeItem gotend = new TimeItem(rowGet[8]);

                                if ((gotStart <= startTimeParse) && (gotend >= startTimeParse) || (gotend >= endTimeParse) && (gotStart <= endTimeParse))//check for time conflict
                                {
                                    isValid = false;
                                }
                            }else
                            {
                                //TODO: check for fail to read on single row : fault talerance [BETA]
                            }

                        }//end for each conflict
                        
                    }//end if Conflict

                    if (isValid)
                    {
                        cmd.CommandText += "INSERT INTO dbo.CALANDER_LIST(CLASS_ID,ROOM_ID,LIST_YEAR,LIST_MONTH,LIST_WEEK,LIST_DAY,START_TIME,END_TIME) VALUES(" + courseParse + "," + roomParse + "," + yearParse + "," + CF.getMonthByDay(curDay).getMonthID() + "," + CF.getDayOfWeek(curDay) + "," + curDay + ", '" + startTimeParse.ToString() + "', '" + endTimeParse.ToString() + "');\n";
                    }
                }//end if valid day

            }//end for days in year



            try
            {
                Debug.WriteLine(cmd.CommandText);
                connection.Open();
                //SqlCommand cmd = new SqlCommand();//moved to : find valid days logic
                cmd.Connection = connection;
                //cmd.CommandText = null;//moved to : find valid days logic
                cmd.ExecuteNonQuery();
                connection.Close();
            }
            catch (SqlException excp)
            {
                Debug.WriteLine("Failed to run InsertIntoDataBase: " + excp);
                connection.Close();
                return false;
            }

            return true;
        }//end InsertSchedualItem

       
        /*
         * (bool) IsConflict(string selectQuery, string[] collumDats, out string[] badRows)
         * takes a query string that selects a table and compares it too a string array containg a set of row data for that table
         * 
         *      Parameters(implicit):
         *      Target Database: Defined by [DataBase Connetion String] in [WebApp/Bin/DataBaseConfig.txt]
         * 
         *      Parameters(defined):
         *      selectQuery(string): a SQL select statment that must reuturn the primary key as the first element and all data must be returned
         *              as the same element index as the value it is to be compared too in [collumDats]
         *      collumDats(string[]): an array of string values that represent a row of data to compare against, any element index with its value as (null)
         *              will not be checked for conflicts
         *      
         *      Parameters(return):
         *      this method(bool): returns true if no conflicts detected, false if there are
         *      badRows(string[]): creates a string array whose length is the number of rows with conflicting data and each element is the primary key of each row that had conflicting data
         */
        private bool IsConflict(string selectQuery, string[] collumDats, out string[] badRows)
        {

            SqlCommand cmd = new SqlCommand(selectQuery, connection);
            List<string> tempBadRows = new List<string>();


            try
            {
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())//runs for each row
                {
                    for (int i = 0; i < collumDats.Length; i++)//runs for each given collumn
                    {
                        if (!(string.IsNullOrEmpty(collumDats[i]) || collumDats[i].Equals("0")))
                        {
                            if (collumDats[i] == reader.GetValue(i).ToString())
                                tempBadRows.Add(reader.GetValue(0).ToString());

                            break;
                        }
                    }//end for collumn
                }//end while row
                reader.Close();
                connection.Close();
            }
            catch (SqlException excp)//currently dosen't warn do anything alert user if function didn't execute, or only partially execute probably want to fix that [TODO]
            {
                Debug.WriteLine("Failed on dataReader: " + excp);

                connection.Close();

            }

            if (tempBadRows.Count == 0)
            {
                badRows = null;
                return true;
            }
            else
            {
                badRows = tempBadRows.ToArray();
                return false;
            }

        }

        
        //functions like IsCOnflict but for single row, and returns all data in row as string array
        private bool IsConflictSingleRow(string selectQuery, string[] collumDats, out string[] rowDats)
        {
            rowDats = new string[collumDats.Length];

            SqlCommand cmd = new SqlCommand(selectQuery, connection);

            try
            {
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                
                reader.Read();

                for (int i = 0; i < collumDats.Length; i++)//runs for each given collumn
                {
                    if (!(string.IsNullOrEmpty(collumDats[i]) || collumDats[i].Equals("0")))
                    {

                        rowDats[i] = reader.GetValue(i).ToString();

                    }
                }//end for collumn

                reader.Close();
                connection.Close();
            }
            catch (SqlException excp)
            {
                Debug.WriteLine("Failed on dataReader: " + excp);

                connection.Close();

                return false;

            }

            return true;
        }



    }
}
