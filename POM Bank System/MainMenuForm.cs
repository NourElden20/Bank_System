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
    public partial class MainMenuForm : KryptonForm
    {

        private void MainMenuForm_Load(object sender, EventArgs e)
        {

        }

        private int user;
        public MainMenuForm(int userId)
        {
            InitializeComponent();
            user = userId;

            if (UserOperations.FillWithID(user).Permission.Equals("Low-Level"))
            {
                ManageUsers_Button.Visible = false;
                DeleteClient_Button.Visible = false;
                AddNewClient_Button.Location = new Point(159, 143);
                Logout_Button.Location = new Point(141, 453);
                return;
            }
            if (UserOperations.FillWithID(user).Permission.Equals("Mid-Level"))
            {
                ManageUsers_Button.Visible = false;
                Logout_Button.Location = new Point(141, 453);
                return;
            }
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
            UsersForm form = new UsersForm(user);
            this.Hide();
            form.ShowDialog();
            this.Close();
        }

        private void AddNewClient_Button_Click(object sender, EventArgs e)
        {
            NewClientForm form = new NewClientForm(user);
            this.Hide();
            form.ShowDialog();
            this.Close();
        }

        private void DeleteClient_Button_Click(object sender, EventArgs e)
        {
            DeleteClientForm form = new DeleteClientForm(user);
            this.Hide();
            form.ShowDialog();
            this.Close();
        }

        private void UpdateClientInfo_Button_Click(object sender, EventArgs e)
        {
            UpdatedClientForm form = new UpdatedClientForm(user);
            this.Hide();
            form.ShowDialog();
            this.Close();
        }

        private void ShowClientList_Button_Click(object sender, EventArgs e)
        {
            ClientListForm form = new ClientListForm(user);
            this.Hide();
            form.ShowDialog();
            this.Close();
        }

        private void FindClient_Button_Click(object sender, EventArgs e)
        {
            FindClientForm form = new FindClientForm(user);
            this.Hide();
            form.ShowDialog();
            this.Close();
        }

        private void Transactions_Button_Click(object sender, EventArgs e)
        {
            TransactionsForm form = new TransactionsForm(user);
            this.Hide();
            form.ShowDialog();
            this.Close();
        }
    }
}
