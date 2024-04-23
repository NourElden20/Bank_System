using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Bank_System
{
    public abstract class User 
    {
        public static int id = 1;

        public string Username { get; set; }
        public string Password { get; set; }
        public string Permission { get; set; }


    }

    
    

}
