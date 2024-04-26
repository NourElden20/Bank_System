using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
namespace Bank_System
{
    public partial class MainMenuForm : KryptonForm
    {
        public MainMenuForm()
        {
            InitializeComponent();
        }

        private void MainMenuForm_Load(object sender, EventArgs e)
        {

        }

        private void Logout_Button_Click(object sender, EventArgs e)
        {
            Login_Form loginForm = new Login_Form();
            this.Hide();
            loginForm.ShowDialog();
            this.Close();
        }

        private void ManageUsers_Button_Click(object sender, EventArgs e)
        {
            UsersForm form = new UsersForm();
            this.Hide();
            form.ShowDialog();
            this.Close();
        }

        private void AddNewClient_Button_Click(object sender, EventArgs e)
        {
            NewClientForm form = new NewClientForm();
            this.Hide();
            form.ShowDialog();
            this.Close();
        }

        private void DeleteClient_Button_Click(object sender, EventArgs e)
        {
            DeleteClientForm form = new DeleteClientForm();
            this.Hide();
            form.ShowDialog();
            this.Close();
        }

        private void UpdateClientInfo_Button_Click(object sender, EventArgs e)
        {
            UpdatedClientForm form = new UpdatedClientForm();
            this.Hide();
            form.ShowDialog();
            this.Close();
        }

        private void ShowClientList_Button_Click(object sender, EventArgs e)
        {
            ClientListForm form = new ClientListForm();
            this.Hide();
            form.ShowDialog();
            this.Close();
        }

        private void FindClient_Button_Click(object sender, EventArgs e)
        {
            FindClientForm form = new FindClientForm();
            this.Hide();
            form.ShowDialog();
            this.Close();
        }

        private void Transactions_Button_Click(object sender, EventArgs e)
        {
            TransactionsForm form = new TransactionsForm();
            this.Hide();
            form.ShowDialog();
            this.Close();
        }
    }
}
