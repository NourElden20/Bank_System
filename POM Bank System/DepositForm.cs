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
    public partial class DepositForm : KryptonForm
    {
        
        User user;
        public DepositForm(User user)
        {
            InitializeComponent();
            this.user = user;
        }

        clsClient Client = new clsClient();
        private void TransactionMenu_Button_Click(object sender, EventArgs e)
        {
            TransactionsForm form = new TransactionsForm(user);
            this.Hide();
            form.ShowDialog();
            this.Close();
        }

        private void DepositForm_Load(object sender, EventArgs e)
        {

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

        private void Deposit_Button_Click(object sender, EventArgs e)
        {
            double DepositAmount;
            if(Deposit_TextBox.Text == string.Empty)
            {
                MessageBox.Show($"Please enter your Deposit amount First!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DepositAmount = double.Parse(Deposit_TextBox.Text);

            if(DepositAmount <= 0)
            {
                MessageBox.Show($"your Deposit amount is not Valid!\r\nyou can't deposit 0$ OR Negative!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Deposit_TextBox.Text = string.Empty;
                return;
            }

            
            DialogResult dialogResult = MessageBox.Show($"Your Going to Deposit {DepositAmount}$\r\n\nPress Yes For confirmation", "Warning!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (dialogResult == DialogResult.Yes)
            {
                Client.Balance += DepositAmount;
                Account_Balance_TextBox.Text = NewBalance_TextBox.Text = Client.Balance.ToString();
            }

            Client.UpdateClient(Client, dialogResult);
        }

        private void ClearForm()
        {
            Account_Number_DetailsTextBox.Text = string.Empty;
            Account_Number_TextBox.Text = string.Empty;
            PINCode_TextBox.Text = string.Empty;
            Client_Name_TextBox.Text = string.Empty;
            Client_Phone_TextBox.Text = string.Empty;
            Account_Balance_TextBox.Text = string.Empty;
            Deposit_TextBox.Text = string.Empty;
            NewBalance_TextBox.Text = string.Empty;
        }

        private void Clear_Button_Click(object sender, EventArgs e)
        {
            ClearForm();
        }
    }
}
