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
    public partial class DeleteUserForm : KryptonForm
    {
        public DeleteUserForm()
        {
            InitializeComponent();
        }
      
        private void UsersMenu_Button_Click(object sender, EventArgs e)
        {
            UsersForm form = new UsersForm();
            this.Hide();
            form.ShowDialog();
            this.Close();
        }

        private void Delete_Button_Click(object sender, EventArgs e)
        {
            var id = UserOperations.FindUsers(username_DetailsTextBox.Text, password_TextBox.Text);
            if (id != -1)
            {
                User user = UserOperations.FillWithID(id);
                UserOperations.RemoveUser(user);
            }
            else
            {
              MessageBox.Show("User not found", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }
    }
}
