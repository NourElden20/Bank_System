using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Bank_System.Classes
{
    public class UserOperations
    {
        public const string Path = @"Users.txt";
        public static List<User> UsersList = new List<User>();

        public static void AddUser(User user)
        {
            user.ID = (++User.id).ToString();
            MyFile.AddRecord(user, Path);
            UsersList.Add(user);
            MessageBox.Show("User Added Successfully!","Event!",MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public static void RemoveUser(User user)
        {
            MyFile.DeleteRecord(user, Path);
            UsersList.Remove(user);

             MessageBox.Show("User Removed Successfully!", "Event!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public static void UpdateUser(User user,User Newuser)
        {
            MyFile.UpdateRecord(user, Path);
            foreach (var u in UsersList)
            {
                if (u.ID == user.ID)
                {
                     user.ID         = Newuser.ID;
                     user.Username   = Newuser.Username;
                    user.Password    = Newuser.Password;
                    user.Permission  = Newuser.Permission;
                }
            }
            MessageBox.Show("User Updated Successfully!", "Event!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public static void ShowUsers(TextBox Holder)
        {
            MyFile.LoadFile(Path, Holder);
        }
        public static int FindUsers(string Username,string Password)
        {
            foreach (var user in UsersList)
            {
                if(Username == user.Username && Password == user.Password)
                {
                    return int.Parse(user.ID);
                }
            }
            return -1;
        }
        public static void LoadUsersFromFile()
        {
            MyFile.LoadUsersFromFileToList();
        }
        public static User FillWithID(int id)
        {
            foreach (var user in UsersList)
            {
                if (user.ID == id.ToString())
                {
                    return user;
                }
            }
           return null;
        }
    }
}
