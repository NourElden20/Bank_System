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
        }

        struct IndexData
        {
            public int Key;
            public int Position;
        }

        public string AccountID
        {
            get { return accountID; }
            set { accountID = value; }
        }

        public string PINCode
        {
            get { return pinCode; }
            set { pinCode = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string PhoneNumber
        {
            get { return phonenumber; }
            set { phonenumber = value; }
        }

        public double Balance
        {
            get { return balance; }
            set { balance = value; }
        }

        private clsClient ConvertRecordToClient(string Record, string Delim = "#//#")
        {
            string[] Fields = Record.Split(Delim.ToArray());

            clsClient Client = new clsClient();
            Client.AccountID = Fields[0];
            Client.PINCode = Fields[1];
            Client.Name = Fields[2];
            Client.PhoneNumber = Fields[3];
            Client.Balance = Convert.ToDouble(Fields[4]);


            return Client;
        }

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

        private SortedDictionary<int, int> LoadIndexFileIntoDic(string FileName)
        {
            StreamReader sr = new StreamReader(FileName);
            IndexData indexData = new IndexData();
            string Line = "";

            while ((Line = sr.ReadLine()) != null)
            {
                indexData = ConvertIndexRecordToKeyValuePair(Line);
                ClientsDict.Add(indexData.Key, indexData.Position);
            }

            sr.Close();
            return ClientsDict;
        }

        private IndexData ConvertIndexRecordToKeyValuePair(string Record, string Delim = "#//#")
        {
            IndexData indexData = new IndexData();
            string[] Fields = Record.Split(Delim.ToArray());
            indexData.Key = Convert.ToInt32(Fields[0]);
            indexData.Position = Convert.ToInt32(Fields[1]);

            return indexData;
        }

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

        private void UpdateIndexFile(SortedDictionary<int, int> Dict, string Delim = "#//#")
        {
            StreamWriter streamWriter = new StreamWriter(IndexFileName);//Will overwrite the file automatically

            foreach (KeyValuePair<int, int> item in Dict)
            {
                streamWriter.WriteLine(item.Key + Delim + item.Value);
            }
            streamWriter.Close();//Done!
        }

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

        }

        public void ShowAllClients()
        {
            throw new NotImplementedException();
        }

        public void AddNewClient(clsClient Client)
        {
            int Pos;
            int KeyValue;

            ClientsDict = LoadIndexFileIntoDic(IndexFileName);

            //ContainsKey Method Look for the Specified Key In the Dic
            if (!ClientsDict.ContainsKey(Convert.ToInt32(Client.accountID)))
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

        public bool FindClientByAccountID(string AccountID, out clsClient Client)
        {

            ClientsDict = LoadIndexFileIntoDic(IndexFileName);

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

        public bool DeleteClient(string AccountID)
        {
            clsClient Client = new clsClient();
            //ClientsDict = LoadIndexFileIntoDic(IndexFileName);

            if (FindClientByAccountID(AccountID, out Client))
            {
                // Prompt the user for confirmation
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this Clint", "Warning!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Yes)
                {
                    MarkForDelete(AccountID);
                    ClientsDict.Remove(Convert.ToInt32(AccountID));

                    // Update our list with Deleted Clients!
                    List<clsClient> ClientsList = LoadClientsDataFromFile(ClientsFileName);

                    //Delete Record From ClientsFile
                    SaveClientsDataToFile(ClientsFileName, ClientsList);

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
            else
            {
                //Not Founded!
                MessageBox.Show($"Client With Account Number: {AccountID}, is not Exists!", "Warning!", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
                return false;
            }
        }

        public bool UpdateClient(clsClient newClient)
        {
            clsClient Client;
            if (FindClientByAccountID(newClient.accountID, out Client))
            {
                // Prompt the user for confirmation
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to Update this Clint", "Warning!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Yes)
                {
                    Client = newClient;
                    List<clsClient> ClientsList = LoadClientsDataFromFile(ClientsFileName);
                    ClientsList = UpdateClientsList(ClientsList, Client);

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
                    return false;// User canceled deletion
                }
            }
            else
            {
                MessageBox.Show($"Client With Account Number: {AccountID}, is not Exists!", "Warning!", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
                return false;
            }
        }

    }
}
