using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_System.Classes
{
    public class Admin : User,IAdmin
    {
        const string Path = @"Users.txt";
       
        //User operations
        public void AddNewUser()
        {
            throw new NotImplementedException();
        }
     
        public void DeleteUser()
        {
            throw new NotImplementedException();
        }

        public void FindUser()
        {
            throw new NotImplementedException();
        }

        public void ListUsers()
        {

        }


        //Client operations

        public void AddNewClient()
        {
            throw new NotImplementedException();
        }

        public void DeleteClient()
        {
            throw new NotImplementedException();
        }
        public void FindClient()
        {
            throw new NotImplementedException();
        }

        public void ShowClientList()
        {
            throw new NotImplementedException();
        }

        public void UpdateClientInfo()
        {
            throw new NotImplementedException();
        }
    }

}
