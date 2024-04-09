using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_System
{
    interface IUser
    {
        void ShowClientList();
        void AddNewClient();
        void DeleteClient();
        void FindClient();
        void UpdateClientInfo();
    }
}
