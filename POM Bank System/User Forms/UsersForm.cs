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
    public partial class UsersForm : KryptonForm
    {
        User user;
        public UsersForm(User user)
        {
            InitializeComponent();
         this.user = user;
                
        }
        
        private void AddNewUser_Button_Click(object sender, EventArgs e)
        {
            NewUserForm form = new NewUserForm(user);
            this.Hide();
            form.ShowDialog();
            this.Close();

        }

        private void MainMenu_Button_Click(object sender, EventArgs e)
        {
            MainMenuForm form = new MainMenuForm(user);
            this.Hide();
            form.ShowDialog();
            this.Close();
        }

        private void ListUsers_Button_Click(object sender, EventArgs e)
        {
            UsersListForm form = new UsersListForm(user);
            this.Hide();
            form.ShowDialog();
            this.Close();
        }

        private void DeleteUser_Button_Click(object sender, EventArgs e)
        {
            DeleteUserForm form = new DeleteUserForm(user);
            this.Hide();
            form.ShowDialog();
            this.Close();
        }

        private void UsersForm_Load(object sender, EventArgs e)
        {

        }
    }
}

