using Bank_System.Classes;
using ComponentFactory.Krypton.Toolkit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Bank_System
{
    public partial class WithdrawForm : KryptonForm
    {
        User user;
        public WithdrawForm()
        {
            InitializeComponent();
        }
        private int permission;
        public WithdrawForm(User user)
        {
            InitializeComponent();
            this.user = user;
        }

        clsClient Client = new clsClient();

        private void Withdraw_Button_Click(object sender, EventArgs e)
        {
            double WithdrawAmount;
            if (Withdraw_TextBox.Text == string.Empty)
            {
                MessageBox.Show($"Please enter your Withdraw amount First!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            WithdrawAmount = double.Parse(Withdraw_TextBox.Text);


            if(WithdrawAmount > Client.Balance)
            {
                MessageBox.Show($"your withdraw amount is Exceeds your balance!\r\nPlease enter a new amount!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Withdraw_TextBox.Text = string.Empty;
                return;
            }

            if (WithdrawAmount <= 0)
            {
                MessageBox.Show($"your withdraw amount is not Valid!\r\nyou can't withdraw 0$ OR Negative!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Withdraw_TextBox.Text = string.Empty;
                return;
            }


            DialogResult dialogResult = MessageBox.Show($"Your Going to withdraw {WithdrawAmount}$\r\n\nPress Yes For confirmation", "Warning!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (dialogResult == DialogResult.Yes)
            {
                Client.Balance -= WithdrawAmount;
                Client.UpdateClient(Client, dialogResult);
                Account_Balance_TextBox.Text = NewBalance_TextBox.Text = Client.Balance.ToString();
            }


        }

        private void TransactionMenu_Button_Click(object sender, EventArgs e)
        {
            TransactionsForm form = new TransactionsForm(user);
            this.Hide();
            form.ShowDialog();
            this.Close();
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

        private void ClearForm()
        {
            Account_Number_DetailsTextBox.Text = string.Empty;
            Account_Number_TextBox.Text = string.Empty;
            PINCode_TextBox.Text = string.Empty;
            Client_Name_TextBox.Text = string.Empty;
            Client_Phone_TextBox.Text = string.Empty;
            Account_Balance_TextBox.Text = string.Empty;
            Withdraw_TextBox.Text = string.Empty;
            NewBalance_TextBox.Text = string.Empty;
        }

        private void Clear_Button_Click(object sender, EventArgs e)
        {
            ClearForm();
        }
    }
}
