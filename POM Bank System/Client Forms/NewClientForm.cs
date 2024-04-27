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
    public partial class NewClientForm : KryptonForm
    {
        public NewClientForm()
        {
            InitializeComponent();
        }

        private void Account_Number_TextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                PINCode_TextBox.Focus();
            }
        }

        private void PINCode_TextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Client_Name_TextBox.Focus();
            }
        }

        private void Client_Name_TextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Client_Phone_TextBox.Focus();
            }
        }

        private void Client_Phone_TextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Account_Balance_TextBox.Focus();
            }
        }


        private void ClearForm()
        {
            Account_Number_TextBox.Text = string.Empty;
            PINCode_TextBox.Text = string.Empty;
            Client_Name_TextBox.Text = string.Empty;
            Client_Phone_TextBox.Text = string.Empty;
            Account_Balance_TextBox.Text = string.Empty;
        }

        private void MainMenu_Button_Click(object sender, EventArgs e)
        {
            MainMenuForm form = new MainMenuForm();
            this.Hide();
            form.ShowDialog();
            this.Close();
        }

        private bool IsTextFieldsEmpty()
        {
            return (Account_Number_TextBox.Text == string.Empty || PINCode_TextBox.Text == string.Empty
                || Client_Name_TextBox.Text == string.Empty || Client_Phone_TextBox.Text == string.Empty
                || Account_Balance_TextBox.Text == string.Empty);
        }

        private clsClient GetClientData()
        {
            if (IsTextFieldsEmpty())
            {
                MessageBox.Show($"Please enter Client Data Correctly!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null;
            }

            clsClient Client = new clsClient();
            Client.AccountID = Account_Number_TextBox.Text;
            Client.PINCode = PINCode_TextBox.Text;
            Client.Name = Client_Name_TextBox.Text;
            Client.PhoneNumber = Client_Phone_TextBox.Text;
            Client.Balance = Convert.ToDouble(Account_Balance_TextBox.Text);

            return Client;
        }

        private void Add_Button_Click(object sender, EventArgs e)
        {
            clsClient Client = GetClientData();

            if (Client != null)
                Client.AddNewClient(Client);
            
            ClearForm();

        }
    }
}
