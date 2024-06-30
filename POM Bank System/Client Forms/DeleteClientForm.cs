using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bank_System.Classes;
using ComponentFactory.Krypton.Toolkit;


namespace Bank_System
{
    public partial class DeleteClientForm : KryptonForm
    {
        private int permission;
        public DeleteClientForm(int per)
        {
            InitializeComponent();
            permission = per;
        }

        clsClient Client = new clsClient();

        private void MainMenu_Button_Click(object sender, EventArgs e)
        {
            MainMenuForm form = new MainMenuForm(permission);
            this.Hide();
            form.ShowDialog();
            this.Close();
        }

        private void ClearForm()
        {
            Account_Number_DetailsTextBox.Text = string.Empty;
            Account_Number_TextBox.Text = string.Empty;
            PINCode_TextBox.Text = string.Empty;
            Client_Name_TextBox.Text = string.Empty;
            Client_Phone_TextBox.Text = string.Empty;
            Account_Balance_TextBox.Text = string.Empty;
            Delete_Button.Enabled = false;
        }

        private void Enter_AccNumber_Button_Click(object sender, EventArgs e)
        {
            string AccountId;

            if (Account_Number_TextBox.Text != string.Empty)
                AccountId = Account_Number_TextBox.Text;
            else
            {
                MessageBox.Show($"Please enter Account Number First!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            clsClient client = new clsClient();

            if (Client.FindClientByAccountID(AccountId, out client))
            {
                MessageBox.Show($"Client with Account Number: {AccountId} is founded!", "Founded!", MessageBoxButtons.OK);

                Client = client;

                Account_Number_DetailsTextBox.Text = Client.AccountID;
                PINCode_TextBox.Text = Client.PINCode;
                Client_Name_TextBox.Text = Client.Name;
                Client_Phone_TextBox.Text = Client.PhoneNumber;
                Account_Balance_TextBox.Text = Client.Balance.ToString();
                return;
            }

            //Not Founded!
            MessageBox.Show($"Client With Account Number: {AccountId}, is not Exists!", "Warning!", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
        }

        private void Delete_Button_Click(object sender, EventArgs e)
        {

            string AccountNumber;

            if (Account_Number_DetailsTextBox.Text != string.Empty)
            {
                AccountNumber = Account_Number_DetailsTextBox.Text;
                Client.DeleteClient(AccountNumber);
                ClearForm();
            }
            else
                MessageBox.Show($"Please eneter Client Id First to delete him", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
