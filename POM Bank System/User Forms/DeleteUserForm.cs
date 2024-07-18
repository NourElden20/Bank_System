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
        User user;
        public DeleteUserForm(User user)
        {
            InitializeComponent();
            this.user = user;
        }
      
        private void UsersMenu_Button_Click(object sender, EventArgs e)
        {
            UsersForm form = new UsersForm(user);
            this.Hide();
            form.ShowDialog();
            this.Close();
        }

        private void Delete_Button_Click(object sender, EventArgs e)
        {
            UserOperations U = new UserOperations();

            User ToDelete = U.FindUserByName(username_DetailsTextBox.Text);
            if (ToDelete != null)
            {              
                U.DeleteUser(ToDelete.ID);
            }
            else
            {
              MessageBox.Show("User not found", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }

        private void DeleteUserForm_Load(object sender, EventArgs e)
        {

        }
    }
}
