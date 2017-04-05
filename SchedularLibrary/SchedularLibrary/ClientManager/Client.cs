using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExperimentalProc.ClientManager
{
    public class Client
    {
        protected string SessionID;
        protected int UserID;

        public string User;

        public Client(string SessionID)
        {
            this.SessionID = SessionID;
            
        }

        public void Finish(string User)
        {
            this.User = User;
            using (DataBase.Server serv = new DataBase.Server())
            {
                if(serv.RetriveUserID(this.User, out this.UserID))
                {
                    //if UserID found
                }
            }
        }

        public string getSessionID()
        {
            return SessionID;
        }

        public void Dispose()
        {
            using (DataBase.Server serv = new DataBase.Server())
            {
                

                if (serv.UpdateUserSession(this.UserID))
                {
                    //if UpdateUserSession pass
                }
            }
        }
    }
}
