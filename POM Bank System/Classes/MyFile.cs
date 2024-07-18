using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Bank_System.Classes
{
    


    static class MyFile
    {
        readonly private static string IndexFileName = @"UsersIndex.txt";
        readonly public static string UsersFileName = @"Users.txt";
        public static SortedDictionary<int, int> LoadIndexFileIntoDic(string FileName)
        {
            StreamReader sr = new StreamReader(FileName);
            IndexData indexData = new IndexData();
            UserOperations.UsersDic.Clear();
            string Line = "";

            while ((Line = sr.ReadLine()) != null)
            {
                indexData = ConvertIndexRecordToKeyValuePair(Line);
                UserOperations.UsersDic.Add(indexData.Key, indexData.Position);
            }

            sr.Close();
            return UserOperations.UsersDic;
        }

        /// <summary>
        /// Converts a delimited string record into an <see cref="IndexData"/> object.
        /// </summary>
        /// <param name="Record">The delimited string record representing the index data.</param>
        /// <param name="Delim">
        /// The delimiter used to separate fields in the record. 
        /// The default value is "#//#".
        /// </param>
        /// <returns>
        /// An <see cref="IndexData"/> object populated with the key and position from the record.
        /// </returns>
        public static IndexData ConvertIndexRecordToKeyValuePair(string Record, string Delim = "#//#")
        {
            IndexData indexData = new IndexData();
            string[] Fields = Record.Split(Delim.ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            indexData.Key = Convert.ToInt32(Fields[0]);
            indexData.Position = Convert.ToInt32(Fields[1]);

            return indexData;
        }

        /// <summary>
        /// Adds a key and position to the index file.
        /// </summary>
        /// <param name="Key">The key to be added to the index file.</param>
        /// <param name="Pos">The position associated with the key to be added to the index file.</param>
        /// <param name="Delim">
        /// The delimiter used to separate the key and position in the index file. 
        /// The default value is "#//#".
        /// </param>
        public static void AddToIndexFile(int Key, int Pos, string Delim = "#//#")
        {
            
            if (File.Exists(IndexFileName))
            {
                FileStream IndexFile = new FileStream(IndexFileName, FileMode.Append, FileAccess.Write);
                StreamWriter MyStreamWriter = new StreamWriter(IndexFile);

                MyStreamWriter.WriteLine(Key + Delim + Pos);

                MyStreamWriter.Close();
                IndexFile.Close();
            }
            else
            {
                MessageBox.Show("The Index File Not Available!");
            }

        }

        /// <summary>
        /// Updates the index file with the contents of a sorted dictionary.
        /// </summary>
        /// <param name="Dict">
        /// The <see cref="SortedDictionary{TKey, TValue}"/> containing the key-value pairs to be written to the index file.
        /// </param>
        /// <param name="Delim">
        /// The delimiter used to separate the key and value in the index file. 
        /// The default value is "#//#".
        /// </param>
        public static void UpdateIndexFile(SortedDictionary<int, int> Dict, string Delim = "#//#")
        {
            StreamWriter streamWriter = new StreamWriter(IndexFileName);//Will overwrite the file automatically

            foreach (KeyValuePair<int, int> item in Dict)
            {
                streamWriter.WriteLine(item.Key + Delim + item.Value);
            }
            streamWriter.Close();//Done!
        }

        public static void MarkForDelete(string key)
        {

            using (FileStream UsersFile = new FileStream(UsersFileName, FileMode.Open, FileAccess.ReadWrite))
            {
                using (StreamWriter MyStreamWriter = new StreamWriter(UsersFile))
                {

                    int Position = UserOperations.UsersDic[Convert.ToInt32(key)];

                    UsersFile.Seek(Position, SeekOrigin.Begin);
                    MyStreamWriter.Write("*");

                }
            }
        }


        /// <summary>
        /// Updates the specified user in the list of users if it exists.
        /// </summary>
        /// <param name="userlist">The list of clients to update.</param>
        /// <param name="user">The user containing updated information.</param>
        /// <returns>The updated list of users.</returns>
        public static List<User> UpdateUsersList(List<User> userlist, User user)
        {
            for (int i = 0; i < userlist.Count; i++)
            {
                if (user.ID == userlist[i].ID)
                {
                    userlist[i] = user;//Updated!
                    break;// No need Keep iterating on the List
                }
            }

            return userlist;
        }

        /// <summary>
        /// Updates the dictionary of Users data positions based on the current users file.
        /// </summary>
        public static void UpdateDictionary(SortedDictionary<int,int> Dic)
        {
            Dic.Clear();
            FileStream UsersFile = new FileStream(UsersFileName, FileMode.Open, FileAccess.Read);
            StreamReader MyStreamReader = new StreamReader(UsersFile);

            string Line;
            User user;

            IndexData Index_Data = new IndexData();

            Index_Data.Position = 0;
            while ((Line = MyStreamReader.ReadLine()) != null)
            {
                user = ConvertRecordToUser(Line);

                Index_Data.Key = Convert.ToInt32(user.ID);

                Dic.Add(Index_Data.Key, Index_Data.Position);

                Index_Data.Position += Line.Length + 2;
            }

            MyStreamReader.Close();
            UsersFile.Close();
        }

        public static User ConvertRecordToUser(string Record, string Delim = "#//#")
        {
            string[] Fields = Record.Split(Delim.ToCharArray(), StringSplitOptions.RemoveEmptyEntries);

            User user = new User()
            {
                ID = Fields[0],
                Username = Fields[1],
                Password = Fields[2],
                Permission = Fields[3]
            };

            return user;
        }
        public static List<User> ShowAllUsers()
        {
            return LoadUsersDataFromFile(UsersFileName);
        }

        /// <summary>
        /// Loads client data from a file into a list of <see cref="clsClient"/> objects.
        /// </summary>
        /// <param name="FileName">The name of the file containing client data.</param>
        /// <returns>
        /// A list of <see cref="clsClient"/> objects populated with data from the file.
        /// </returns>
        public static List<User> LoadUsersDataFromFile(string FileName)
        {
            FileStream UsersFile = new FileStream(FileName, FileMode.Open, FileAccess.Read);
            StreamReader MyStreamReader = new StreamReader(UsersFile);

            List<User> UsersList = new List<User>();
            User user;

            string Record;

            while ((Record = MyStreamReader.ReadLine()) != null)
            {
                user = ConvertRecordToUser(Record);
                UsersList.Add(user);
            }

            MyStreamReader.Close();
            UsersFile.Close();
            return UsersList;
        }
        /// <summary>
        /// Saves client data from a list of <see cref="clsClient"/> objects to a file.
        /// </summary>
        /// <param name="FileName">The name of the file to save the client data.</param>
        /// <param name="ClientsList">
        /// The list of <see cref="clsClient"/> objects containing the client data to be saved.
        /// </param>
        public static void SaveUsersDataToFile(string FileName, List<User> UsersList)
        {
            FileStream ClientsFile = new FileStream(FileName, FileMode.Truncate, FileAccess.Write);
            StreamWriter MyStreamWriter = new StreamWriter(ClientsFile);

            foreach (User user in UsersList)
            {
                if (user.ID != "*")// if true then it's not deleted
                {
                    string Record = ConvertUsersDataToRecord(user);

                    MyStreamWriter.WriteLine(Record);
                }
            }

            MyStreamWriter.Close();
            ClientsFile.Close();
        }
        public static string ConvertUsersDataToRecord(User user, string Delim = "#//#")
        {
            string Record =
                user.ID + Delim +
                user.Username + Delim +
                user.Password + Delim +
                user.Permission;

            return Record;
        }
        public struct IndexData
        {
            public int Key;
            public int Position;
        }
    }
}
