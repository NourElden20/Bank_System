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
    public partial class UsersListForm : KryptonForm
    {
        public UsersListForm()
        {
            InitializeComponent();
        }

        private void UsersListForm_Load(object sender, EventArgs e)
        {
            foreach(var user in UserOperations.UsersList)
            userBindingSource.Add(user);
        }

       
        

        private void ManageUsersMenu_Button_Click(object sender, EventArgs e)
        {
            UsersForm form = new UsersForm();
            this.Hide();
            form.ShowDialog();
            this.Close();
        }
    }
}
