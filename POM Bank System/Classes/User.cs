using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Bank_System
{
    public class User 
    {
        const string Path = @"Users.txt";

        public static int id = 1;
        public static List<User> UsersList = new List<User>();

        public string ID = (id++).ToString();
        public string Username { get; set; }
        public string Password { get; set; }
        public string Permission { get; set; }

        public User(string Username ,string Password, string Permission)
        {
            this.Username = Username;
            this.Password = Password;
            this.Permission = Permission;
        }
        public User(User user)
        {
            Username =   user.Username;
            Password =   user.Password;
            Permission = user.Permission;
        }
        public User()
        {
            
        }
    }

    
    

}
