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
    public partial class UpdatedClientForm : KryptonForm
    {
        public UpdatedClientForm()
        {
            InitializeComponent();
        }

        clsClient Client = new clsClient();

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            GetClientNewData();
            if(!IsTextFieldsEmpty())
            {
                // Prompt the user for confirmation
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to Update this Clint", "Warning!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                Client.UpdateClient(Client, dialogResult);
                ClearForm();
            }

        }

        private void New_PINCode_TextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                New_Client_Name_TextBox.Focus();
            }
        }

        private void New_Client_Name_TextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                New_Client_Phone_TextBox.Focus();
            }
        }

        private void New_Client_Phone_TextBox_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void MainMenu_Button_Click(object sender, EventArgs e)
        {
            MainMenuForm form = new MainMenuForm();
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
            New_PINCode_TextBox.Text = string.Empty;
            New_Client_Name_TextBox.Text = string.Empty;
            New_Client_Phone_TextBox.Text = string.Empty;
            New_Account_Balance_TextBox.Text = string.Empty;
        }

        private void Enter_Button_Click(object sender, EventArgs e)
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

        private bool IsTextFieldsEmpty()
        {
            return (New_PINCode_TextBox.Text == string.Empty || New_Client_Name_TextBox.Text == string.Empty
                || New_Client_Phone_TextBox.Text == string.Empty || New_Account_Balance_TextBox.Text == string.Empty);
        }

        private void GetClientNewData()
        {
            if(IsTextFieldsEmpty())
            {

                MessageBox.Show($"Please enter Client Data Correctly!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;

            }

            Client.PINCode = New_PINCode_TextBox.Text;
            Client.Name = New_Client_Name_TextBox.Text;
            Client.PhoneNumber = New_Client_Phone_TextBox.Text;
            Client.Balance = Convert.ToDouble(New_Account_Balance_TextBox.Text);
        }

    }
}
