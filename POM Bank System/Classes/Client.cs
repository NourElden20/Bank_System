using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bank_System.Classes
{
    public class clsClient
    {
        const string ClientsFileName = "Clients.txt";
        const string IndexFileName = "Index.txt";

        FileStream ClientsFile;
        StreamWriter MyStreamWriter;
        StreamReader MyStreamReader;

        SortedDictionary<int, int> ClientsDict = new SortedDictionary<int, int>();

        string accountID;
        string pinCode;
        string name;
        string phonenumber;
        double balance;


        public clsClient()
        {
            accountID = "";
            pinCode = "";
            name = "";
            phonenumber = "";
            balance = 0.0;

            //Load index at the start of the program 
            ClientsDict = LoadIndexFileIntoDic(IndexFileName);
        }

        struct IndexData
        {
            public int Key;
            public int Position;
        }

        public string AccountID { get; set; }
      
        public string PINCode { get; set; }
       

        public string Name { get; set; }
       

        public string PhoneNumber { get; set; }
       
        public double Balance { get;set; }
        

        /// <summary>
        /// Converts a delimited string record into a <see cref="clsClient"/> object.
        /// </summary>
        /// <param name="Record">The delimited string record representing the client data.</param>
        /// <param name="Delim">
        /// The delimiter used to separate fields in the record. 
        /// The default value is "#//#".
        /// </param>
        /// <returns>
        /// A <see cref="clsClient"/> object populated with data from the record.
        /// </returns>
        private clsClient ConvertRecordToClient(string Record, string Delim = "#//#")
        {
            string[] Fields = Record.Split(Delim.ToCharArray(), StringSplitOptions.RemoveEmptyEntries);

            clsClient Client = new clsClient()
            {
                AccountID = Fields[0],
                PINCode = Fields[1],
                Name = Fields[2],
                PhoneNumber = Fields[3],
                Balance = Convert.ToDouble(Fields[4])
            };

            return Client;
        }

        /// <summary>
        /// Converts a <see cref="clsClient"/> object into a delimited string record.
        /// </summary>
        /// <param name="Client">The <see cref="clsClient"/> object containing the client data to be converted.</param>
        /// <param name="Delim">
        /// The delimiter used to separate fields in the resulting record.
        /// The default value is "#//#".
        /// </param>
        /// <returns>
        /// A delimited string record representing the client data.
        /// </returns>
        private string ConvertClientDataToRecord(clsClient Client, string Delim = "#//#")
        {
            string Record = 
                Client.AccountID + Delim +
                Client.PINCode + Delim +
                Client.Name + Delim +
                Client.PhoneNumber + Delim +
                Client.Balance.ToString();

            return Record;
        }

        /// <summary>
        /// Loads an index file into a sorted dictionary.
        /// </summary>
        /// <param name="FileName">The name of the index file to be loaded.</param>
        /// <returns>
        /// A <see cref="SortedDictionary{TKey, TValue}"/> containing the key-value pairs from the index file.
        /// The key is the index key, and the value is the position.
        /// </returns>
        private SortedDictionary<int, int> LoadIndexFileIntoDic(string FileName)
        {
            StreamReader sr = new StreamReader(FileName);
            IndexData indexData = new IndexData();
            ClientsDict.Clear();
            string Line = "";

            while ((Line = sr.ReadLine()) != null)
            {
                indexData = ConvertIndexRecordToKeyValuePair(Line);
                ClientsDict.Add(indexData.Key, indexData.Position);
            }

            sr.Close();
            return ClientsDict;
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
        private IndexData ConvertIndexRecordToKeyValuePair(string Record, string Delim = "#//#")
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
        private void AddToIndexFile(int Key, int Pos, string Delim = "#//#")
        {
            if (File.Exists(IndexFileName))
            {
                FileStream IndexFile = new FileStream(IndexFileName, FileMode.Append, FileAccess.Write);
                MyStreamWriter = new StreamWriter(IndexFile);

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
        private void UpdateIndexFile(SortedDictionary<int, int> Dict, string Delim = "#//#")
        {
            StreamWriter streamWriter = new StreamWriter(IndexFileName);//Will overwrite the file automatically

            foreach (KeyValuePair<int, int> item in Dict)
            {
                streamWriter.WriteLine(item.Key + Delim + item.Value);
            }
            streamWriter.Close();//Done!
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

        /// <summary>
        /// Loads client data from a file into a list of <see cref="clsClient"/> objects.
        /// </summary>
        /// <param name="FileName">The name of the file containing client data.</param>
        /// <returns>
        /// A list of <see cref="clsClient"/> objects populated with data from the file.
        /// </returns>
        private List<clsClient> LoadClientsDataFromFile(string FileName)
        {
            ClientsFile = new FileStream(FileName, FileMode.Open, FileAccess.Read);
            MyStreamReader = new StreamReader(ClientsFile);

            List<clsClient> ClientsList = new List<clsClient>();
            clsClient Client;

            string Record;

            while ((Record = MyStreamReader.ReadLine()) != null)
            {
                Client = ConvertRecordToClient(Record);
                ClientsList.Add(Client);
            }

            MyStreamReader.Close();
            ClientsFile.Close();

            return ClientsList;
        }

        /// <summary>
        /// Saves client data from a list of <see cref="clsClient"/> objects to a file.
        /// </summary>
        /// <param name="FileName">The name of the file to save the client data.</param>
        /// <param name="ClientsList">
        /// The list of <see cref="clsClient"/> objects containing the client data to be saved.
        /// </param>
        private void SaveClientsDataToFile(string FileName, List<clsClient> ClientsList)
        {
            ClientsFile = new FileStream(FileName, FileMode.Truncate, FileAccess.Write);
            MyStreamWriter = new StreamWriter(ClientsFile);

            foreach (clsClient Client in ClientsList)
            {
                if (Client.AccountID != "*")// if true then it's not deleted
                {
                    string Record = ConvertClientDataToRecord(Client);

                    MyStreamWriter.WriteLine(Record);
                }
            }

            MyStreamWriter.Close();
            ClientsFile.Close();
        }

        /// <summary>
        /// Marks a client record for deletion in the clients file.
        /// </summary>
        /// <param name="AccountID">The account ID of the client to mark for deletion.</param>
        private void MarkForDelete(string AccountID)
        {

            ClientsFile = new FileStream(ClientsFileName, FileMode.Open, FileAccess.ReadWrite);
            MyStreamWriter = new StreamWriter(ClientsFile);

            int Position = ClientsDict[Convert.ToInt32(AccountID)];

            ClientsFile.Seek(Position, SeekOrigin.Begin);
            MyStreamWriter.Write("*");

            MyStreamWriter.Close();
            ClientsFile.Close();
        }

        /// <summary>
        /// Updates the specified client in the list of clients if it exists.
        /// </summary>
        /// <param name="ClientsList">The list of clients to update.</param>
        /// <param name="Client">The client containing updated information.</param>
        /// <returns>The updated list of clients.</returns>
        private List<clsClient> UpdateClientsList(List<clsClient> ClientsList, clsClient Client)
        {

            for (int i = 0; i < ClientsList.Count; i++)
            {
                if (Client.AccountID == ClientsList[i].AccountID)
                {
                    ClientsList[i] = Client;//Updated!
                    break;// No need Keep iterating on the List
                }
            }

            return ClientsList;
        }

        /// <summary>
        /// Updates the dictionary of client data positions based on the current client file.
        /// </summary>
        private void UpdateDictionary()
        {
            ClientsDict.Clear();
            ClientsFile = new FileStream(ClientsFileName, FileMode.Open, FileAccess.Read);
            MyStreamReader = new StreamReader(ClientsFile);

            string Line;
            clsClient Client;

            IndexData Index_Data = new IndexData();

            Index_Data.Position = 0;
            while ((Line = MyStreamReader.ReadLine()) != null)
            {
                Client = ConvertRecordToClient(Line);

                Index_Data.Key = Convert.ToInt32(Client.AccountID);

                ClientsDict.Add(Index_Data.Key, Index_Data.Position);

                Index_Data.Position += Line.Length + 2;
            }

            MyStreamReader.Close();
            ClientsFile.Close();
        }

        /// <summary>
        /// Retrieves a list of all clients from the client data file.
        /// </summary>
        /// <returns>A list of all clients.</returns>
        public List<clsClient> ShowAllClients()
        {
            return LoadClientsDataFromFile(ClientsFileName); 
        }

        /// <summary>
        /// Adds a new client to the client data file and updates the index.
        /// </summary>
        /// <param name="Client">The client to be added.</param>
        public void AddNewClient(clsClient Client)
        {
            int Pos;
            int KeyValue;

            ClientsDict = LoadIndexFileIntoDic(IndexFileName);

            //ContainsKey Method Look for the Specified Key In the Dic
            int key = int.Parse(Client.AccountID);
            if (!ClientsDict.ContainsKey(key))
            {
                //Founded!
                ClientsFile = new FileStream(ClientsFileName, FileMode.Open, FileAccess.Write);
                MyStreamWriter = new StreamWriter(ClientsFile);

                ClientsFile.Seek(0, SeekOrigin.End);//to go to the end of file

                Pos = Convert.ToInt32(ClientsFile.Position);// Address of the record
                KeyValue = Convert.ToInt32(Client.AccountID);// Primary key 

                string Record = ConvertClientDataToRecord(Client);// Convert Client Object to Record
                MyStreamWriter.WriteLine(Record);// Save Record in Client File

                ClientsDict.Add(KeyValue, Pos);// Add Index of the record to Dic

                MyStreamWriter.Close();
                ClientsFile.Close();

                AddToIndexFile(KeyValue, Pos);// Update the Index File With the new Record

                MessageBox.Show($"Client {Client.AccountID} Added successfully!", "Client Added!", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
            else
            {
                //Not Found!
                MessageBox.Show($"Client With Account Number: {Client.AccountID}, is Already Exists!", "Warning!", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
            }
        }

        /// <summary>
        /// Finds a client by their AccountID in the client data file.
        /// </summary>
        /// <param name="AccountID">The AccountID of the client to find.</param>
        /// <param name="Client">The client object if found, otherwise null.</param>
        /// <returns>True if the client is found, otherwise false.</returns>
        public bool FindClientByAccountID(string AccountID, out clsClient Client)
        {

            if (BinarySearch(ClientsDict.Keys.ToArray(), Convert.ToInt32(AccountID)))
            {
                //Founded!
                ClientsFile = new FileStream(ClientsFileName, FileMode.Open, FileAccess.Read);
                MyStreamReader = new StreamReader(ClientsFile);

                ClientsFile.Seek(ClientsDict[Convert.ToInt32(AccountID)], SeekOrigin.Begin);// Seek to the Record 

                string Line = MyStreamReader.ReadLine();

                Client = ConvertRecordToClient(Line);

                MyStreamReader.Close();
                ClientsFile.Close();

                return true;

            }

            //Not Founded!
            Client = null;
            return false;
        }

        /// <summary>
        /// Deletes a client by their AccountID from the client data file and updates the index.
        /// </summary>
        /// <param name="AccountID">The AccountID of the client to delete.</param>
        /// <returns>True if the client is successfully deleted, otherwise false.</returns>
        public bool DeleteClient(string AccountID)
        {
            clsClient Client = new clsClient();
            ClientsDict = LoadIndexFileIntoDic(IndexFileName);

            // Prompt the user for confirmation
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this Client", "Warning!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                MarkForDelete(AccountID);
                ClientsDict.Remove(Convert.ToInt32(AccountID));

                // Update our list with Deleted Clients!
                List<clsClient> ClientsList = LoadClientsDataFromFile(ClientsFileName);

                //Delete Record From ClientsFile
                SaveClientsDataToFile(ClientsFileName, ClientsList);

                //Update the dictionary for the canges in the length of records!
                UpdateDictionary();

                //Delete the Record Key from Index FiLE
                UpdateIndexFile(ClientsDict);

                MessageBox.Show($"Client With Account Number: {AccountID}, has been deleted Successfully!", "Client has been Deleted!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            else
            {
                return false;// User canceled deletion
            }
        }

        /// <summary>
        /// Updates a client's information in the client data file and updates the index.
        /// </summary>
        /// <param name="newClient">The client with updated information.</param>
        /// <param name="dialogResult">The result of the confirmation dialog.</param>
        /// <returns>True if the client is successfully updated, otherwise false.</returns>
        public bool UpdateClient(clsClient newClient, DialogResult dialogResult)
        {
            
            if (dialogResult == DialogResult.Yes)
            {
                List<clsClient> ClientsList = LoadClientsDataFromFile(ClientsFileName);
                ClientsList = UpdateClientsList(ClientsList, newClient);

                SaveClientsDataToFile(ClientsFileName, ClientsList);

                /*
                We must Update the index File because updating record mean there may be
                change in the record length which Will Sabotage the index File and will give me Wrong Data!
                1) we need to update the dictionary 
                2) Rewrite the Dictionary in the index file
                */

                UpdateDictionary();
                UpdateIndexFile(ClientsDict);

                MessageBox.Show($"Client With Account Number: {AccountID}, has been Updated Successfully!", "Client has been Updated!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
