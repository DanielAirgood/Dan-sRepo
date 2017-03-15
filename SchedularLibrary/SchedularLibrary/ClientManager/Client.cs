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

        public Client(string SessionID)
        {
            this.SessionID = SessionID;
        }

        public string getSessionID()
        {
            return SessionID;
        }
    }
}
