using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bank_System.Classes
{
    public class UserOperations
    {
        public const string Path = @"Users.txt";
        public static List<User> UsersList = new List<User>();

        public static void AddUser(User user)
        {
            MyFile.AddRecord(user, Path);
            UsersList.Add(user);
            MessageBox.Show("User Added Successfully!","Event!",MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public static void RemoveUser(User user)
        {
            MyFile.DeleteRecord(user, Path);
            UsersList.Add(user);
            MessageBox.Show("User Removed Successfully!", "Event!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public static void UpdateUser(User user)
        {
            MyFile.UpdateRecord(user, Path);
            UsersList.Add(user);
            MessageBox.Show("User Updated Successfully!", "Event!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public static void ShowUsers(TextBox Holder)
        {
            MyFile.LoadFile(Path, Holder);
        }
        public static void LoadUsersFromFile(TextBox Holder)
        {
            MyFile.LoadUsersFromFileToList();
        }
    }
}
