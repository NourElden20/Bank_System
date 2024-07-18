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
    public partial class FindClientForm : KryptonForm
    {
        User user;
        public FindClientForm(User user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void MainMenu_Button_Click(object sender, EventArgs e)
        {
            MainMenuForm form = new MainMenuForm(user);
            this.Hide();
            form.ShowDialog();
            this.Close();
        }

        private void Find_Button_Click(object sender, EventArgs e)
        {
            string AccountId;

            if (Account_Number_TextBox.Text != string.Empty)
                AccountId = Account_Number_TextBox.Text;
            else
            {
                MessageBox.Show($"Please enter Account Number First!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            clsClient Client = new clsClient();

            if(Client.FindClientByAccountID(AccountId, out Client))
            {
                MessageBox.Show($"Client with Account Number: {AccountId} is founded!", "Founded!", MessageBoxButtons.OK);

                Account_Number_DetailsTextBox.Text = Client.AccountID;
                PINCode_TextBox.Text = Client.PINCode;
                Client_Name_TextBox.Text = Client.Name;
                Client_Phone_TextBox.Text = Client.PhoneNumber;
                Account_Balance_TextBox.Text = Client.Balance.ToString();
                return;
            }

            //Not Founded!
            MessageBox.Show($"Client with Account Number: {AccountId} is Not founded!", "Client doesn't exists", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void FindClientForm_Load(object sender, EventArgs e)
        {

        }
    }
}
