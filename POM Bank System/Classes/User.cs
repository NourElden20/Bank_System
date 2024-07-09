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

        public static int id ; 
        public string ID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Permission { get; set; }

        public User(string Username ,string Password, string Permission)
        {
            this.Username = Username;
            this.Password = Password;
            this.Permission = Permission;
        }
        public User(List<string> list)
        {
            this.ID         = list[0];
            this.Username   = list[1];
            this.Password   = list[2];
            this.Permission = list[3];
        }
        public User(User user)
        {
            Username =   user.Username;
            Password =   user.Password;
            Permission = user.Permission;
        }
        public User()
        {
            Username = string.Empty; 
            Password = string.Empty;
            Permission = string.Empty;
        }
       
    }
}
