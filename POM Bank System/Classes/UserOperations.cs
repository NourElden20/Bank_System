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
        readonly private static string IndexFileName = @"UsersIndex.txt";
        readonly private static string UsersFileName = @"Users.txt";
        public static List<User> UsersList = new List<User>();

        public static SortedDictionary<int, int> UsersDic = new SortedDictionary<int, int>();

        /// <summary>
        /// Adds a new User to the Users data file and updates the index.
        /// </summary>
        /// <param name="user">The user to be added.</param>
        public void AddNewUser(User user)
        {
            int Pos;
            int KeyValue;

            UsersDic = MyFile.LoadIndexFileIntoDic(IndexFileName);

            //ContainsKey Method Look for the Specified Key In the Dic
            if (!UsersDic.ContainsKey(Convert.ToInt32(user.ID)))
            {
                //Founded!
                using (FileStream UsersFile = new FileStream(UsersFileName, FileMode.Open, FileAccess.Write))
                {
                    using (StreamWriter MyStreamWriter = new StreamWriter(UsersFile))
                    {

                        UsersFile.Seek(0, SeekOrigin.End);//to go to the end of file

                        Pos = Convert.ToInt32(UsersFile.Position);// Address of the record
                        KeyValue = Convert.ToInt32(user.ID);// Primary key 

                        string Record = MyFile.ConvertUsersDataToRecord(user);// Convert Client Object to Record
                        MyStreamWriter.WriteLine(Record);// Save Record in Client File

                        UsersDic.Add(KeyValue, Pos);// Add Index of the record to Dic

                    }
                }

                MyFile.AddToIndexFile(KeyValue, Pos);// Update the Index File With the new Record

                MessageBox.Show($"Client {user.ID} Added successfully!", "User Added!", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
            else
            {
                //Not Found!
                MessageBox.Show($"Client With Account Number: {user.ID}, is Already Exists!", "Warning!", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
            }
        }

        /// <summary>
        /// Finds a user by their ID in the users data file.
        /// </summary>
        /// <param name="ID">The ID of the user to find.</param>
        /// <param name="user">The user object if found, otherwise null.</param>
        /// <returns>True if the user is found, otherwise false.</returns>
        public bool FindUserByID(string ID, out User user)
        {

            if (BinarySearch(UsersDic.Keys.ToArray(), Convert.ToInt32(ID)))
            {
                //Founded!
                using (FileStream UsersFile = new FileStream(UsersFileName, FileMode.Open, FileAccess.Read))
                {
                    using (StreamReader MyStreamReader = new StreamReader(UsersFile))
                    {

                        UsersFile.Seek(UsersDic[Convert.ToInt32(ID)], SeekOrigin.Begin);// Seek to the Record 

                        string Line = MyStreamReader.ReadLine();

                        user = MyFile.ConvertRecordToUser(Line);

                    }
                } 

                return true;

            }


            //Not Founded!
            user = null;
            return false;
        }
        /// <summary>
        /// Finds a user by their Name in the users data file.
        /// </summary>
        /// <param name="name">The Name of the user to find.</param>
        /// <returns>User object if the user is found, otherwise Null.</returns>
        public User FindUserByName(string name)
        {
            UsersList = MyFile.LoadUsersDataFromFile(UsersFileName);
            User user = LinearSearch(UsersList, name);
            if (user != null)
            {
                return user;
            }
            return null;
        }

        /// <summary>
        /// Deletes a user by their ID from the users data file and updates the index.
        /// </summary>
        /// <param name="ID">The ID of the user to delete.</param>
        /// <returns>True if the user is successfully deleted, otherwise false.</returns>
        public bool DeleteUser(string ID)
        {
            User user = new User();
            UsersDic = MyFile.LoadIndexFileIntoDic(IndexFileName);

            // Prompt the user for confirmation
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this User", "Warning!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                MyFile.MarkForDelete(ID);
                UsersDic.Remove(Convert.ToInt32(ID));

                // Update our list with Deleted Clients!
                List<User> UsersList = MyFile.LoadUsersDataFromFile(UsersFileName);

                //Delete Record From ClientsFile
                MyFile.SaveUsersDataToFile(UsersFileName, UsersList);

                //Update the dictionary for the changes in the length of records!
                MyFile.UpdateDictionary(UsersDic);

                //Delete the Record Key from Index FiLE
                MyFile.UpdateIndexFile(UsersDic);

                MessageBox.Show($"User With ID Number: {ID}, has been deleted Successfully!", "User has been Deleted!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            else
            {
                return false;// User canceled deletion
            }
        }

        /// <summary>
        /// Updates a User's information in the users data file and updates the index.
        /// </summary>
        /// <param name="newUser">The user with updated information.</param>
        /// <param name="dialogResult">The result of the confirmation dialog.</param>
        /// <returns>True if the user is successfully updated, otherwise false.</returns>
        public bool UpdateUser(User newUser, DialogResult dialogResult)
        {

            if (dialogResult == DialogResult.Yes)
            {
                List<User> UsersList = MyFile.LoadUsersDataFromFile(UsersFileName);
                UsersList = MyFile.UpdateUsersList(UsersList, newUser);

                MyFile.SaveUsersDataToFile(UsersFileName, UsersList);

                /*
                We must Update the index File because updating record mean there may be
                change in the record length which Will Sabotage the index File and will give me Wrong Data!
                1) we need to update the dictionary 
                2) Rewrite the Dictionary in the index file
                */

                MyFile.UpdateDictionary(UsersDic);
                MyFile.UpdateIndexFile(UsersDic);

                MessageBox.Show($"User With ID Number: {newUser.ID}, has been Updated Successfully!", "User has been Updated!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            else
            {
                return false;
            }
        }


        /// <summary>
        /// Performs a binary search on a sorted array of integers to find a specified key.
        /// </summary>
        /// <param name="SearchArray">The sorted array of integers to search.</param>
        /// <param name="Key">The key to search for in the array.</param>
        /// <returns>
        /// <c>true</c> if the key is found in the array; otherwise, <c>false</c>.
        /// </returns>
        private bool BinarySearch(int[] SearchArray, int Key)
        {
            int Low = 0;
            int High = SearchArray.Length - 1;
            int Mid = (Low + High) / 2;

            while (Low <= High)
            {
                Mid = (Low + High) / 2;
                if (Key < SearchArray[Mid])
                    High = Mid - 1;
                else if (Key > SearchArray[Mid])
                    Low = Mid + 1;
                else
                    return true; //Founded!
            }
            return false;//Not Founded!
        }

        private User LinearSearch(List<User> users, string key)
        {
            foreach (var user in users)
            {
                if(user.Username == key)
                    return user;
            }
            return null;
        }
        
    }
}
