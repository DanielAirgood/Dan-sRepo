using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Diagnostics;

namespace ExperimentalProc.ClientManager
{
    public class Manager
    {
        List<Client> ActiveUsers;

        public Manager()
        {
            ActiveUsers = new List<Client>();
        }

        public Client RetriveClient(string sessionID)
        {
            return ActiveUsers.Find(x => x.getSessionID() == sessionID);//TODO: alter this to use index
        }

        public void AddUser(string sessionID)
        {
            //Debug.WriteLine("User added" + sessionID);

            ActiveUsers.Add(new Client(sessionID));
        }

        public void RemoveUser(string sessionID)
        {
            ActiveUsers.Remove(RetriveClient(sessionID));
        }
        //TODO: overload this to remove client by object referance


        //Index overload
        public Client this[int index]
        {
            get
            {
                return ActiveUsers[index];
            }

        }
    }
}
