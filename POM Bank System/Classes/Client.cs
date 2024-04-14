using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bank_System.Classes
{
    internal class clsClient
    {
        const string ClientsFileName = "Clients.txt";

        FileStream ClientsFile;
        StreamWriter MyStreamWriter;
        StreamReader MyStreamReader;


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
            string[] Fields = Record.Split(Delim.ToCharArray());

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
            string Record = Client.AccountID + Delim
               + Client.PINCode + Delim + Client.Name + Delim
                + Client.PhoneNumber + Delim + Client.Balance.ToString();

            return Record;
        }

        private List<clsClient> LoadClientsDataFromFile(string FileName)
        {
            ClientsFile = new FileStream(FileName, FileMode.Open, FileAccess.Read);
            MyStreamReader = new StreamReader(ClientsFile);

            List<clsClient> ClientsList = new List<clsClient>();
            clsClient Client = new clsClient();

            string Record = "";

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
                if (Client.AccountID != "*")
                {
                    string Record = ConvertClientDataToRecord(Client);

                    MyStreamWriter.WriteLine(Record);
                }
            }

            MyStreamWriter.Close();
            ClientsFile.Close();
        }

        private void MarkForDelete(string AccountID, string Delim = "#//#")
        {

            ClientsFile = new FileStream(ClientsFileName, FileMode.Open, FileAccess.ReadWrite);
            MyStreamWriter = new StreamWriter(ClientsFile);
            MyStreamReader = new StreamReader(ClientsFile);

            string Record = "";
            int Index = 0;

            while ((Record = MyStreamReader.ReadLine()) != null)
            {
                string[] Fields = Record.Split(Delim.ToCharArray());

                if (Fields[0] == AccountID)
                {
                    ClientsFile.Seek(Index, SeekOrigin.Begin);
                    MyStreamWriter.Write("*");
                    break;
                }
                Index += Record.Length + 2;
            }

            MyStreamWriter.Close();
            MyStreamReader.Close();
            ClientsFile.Close();
        }

        public void ShowAllClients()
        {
            throw new NotImplementedException();
        }

        public void AddNewClient(clsClient Client)
        {
            if (!ClientExistByAccountNumber(ClientsFileName, Client.AccountID))
            {
                ClientsFile = new FileStream(ClientsFileName, FileMode.Append, FileAccess.Write);
                MyStreamWriter = new StreamWriter(ClientsFile);

                string Record = ConvertClientDataToRecord(Client);

                MyStreamWriter.WriteLine(Record);

                MyStreamWriter.Close();
                ClientsFile.Close();
            }
            else
            {
                MessageBox.Show($"Client With Account Number: {Client.AccountID}, is Already Exists!", "Warning!", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
            }
        }

        public bool FindClientByAccountID(string AccountID, out clsClient Client)
        {
            List<clsClient> ClientsList = LoadClientsDataFromFile(ClientsFileName);

            foreach (clsClient C in ClientsList)
            {
                if (C.AccountID == AccountID)
                {
                    Client = C;
                    return true;
                }
            }

            Client = null;
            return false;
        }

        public bool FindClientByAccountID(string AccountID, List<clsClient> ClientsList, out clsClient Client)
        {
            foreach (clsClient C in ClientsList)
            {
                if (C.AccountID == AccountID)
                {
                    Client = C;
                    return true;
                }
            }

            Client = null;
            return false;
        }

        public bool ClientExistByAccountNumber(string FileName, string AccountID)
        {
            ClientsFile = new FileStream(FileName, FileMode.Open, FileAccess.Read);
            MyStreamReader = new StreamReader(ClientsFile);

            string Record;
            clsClient Client;

            while ((Record = MyStreamReader.ReadLine()) != null)
            {
                Client = ConvertRecordToClient(Record);
                if (AccountID == Client.AccountID)
                {
                    MyStreamReader.Close();
                    ClientsFile.Close();
                    return true; // Exist!
                }
            }

            MyStreamReader.Close();
            ClientsFile.Close();

            return false;// Not Exists!
        }

        public bool DeleteClient(string AccountID)
        {
            clsClient Client = new clsClient();

            if (FindClientByAccountID(AccountID, out Client))
            {
                // Prompt the user for confirmation
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this Clint", "Warning!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Yes)
                {
                    MarkForDelete(AccountID);

                    // Update our list with Deleted Clients!
                    List<clsClient> ClientsList = LoadClientsDataFromFile(ClientsFileName);

                    SaveClientsDataToFile(ClientsFileName, ClientsList);
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

        private List<clsClient> UpdateClientsList(List<clsClient> ClientsList, clsClient Client)
        {
            List<clsClient> UpdatedClientsList = new List<clsClient>();

            foreach (clsClient C in ClientsList)
            {
                if (C.AccountID != Client.AccountID)
                {
                    UpdatedClientsList.Add(C);
                }
                else
                {
                    UpdatedClientsList.Add(Client);
                }
            }

            return UpdatedClientsList;
        }

        public bool UpdateClient(clsClient newClientData)
        {
            clsClient Client;
            if (FindClientByAccountID(newClientData.accountID, out Client))
            {
                // Prompt the user for confirmation
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to Update this Clint", "Warning!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Yes)
                {

                    List<clsClient> ClientsList = LoadClientsDataFromFile(ClientsFileName);
                    ClientsList = UpdateClientsList(ClientsList, newClientData);

                    SaveClientsDataToFile(ClientsFileName, ClientsList);
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
