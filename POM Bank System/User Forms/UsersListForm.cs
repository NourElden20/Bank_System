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
        User user;
        public UsersListForm(User user)
        {
            InitializeComponent();
            this.user = user;
           
        }

        private void UsersListForm_Load(object sender, EventArgs e)
        {
           
            List<User> Users = MyFile.ShowAllUsers();
            foreach (var Entry in Users)
            {
                userBindingSource.Add(Entry);
            }
        }




            private void ManageUsersMenu_Button_Click(object sender, EventArgs e)
        {
            UsersForm form = new UsersForm(user);
            this.Hide();
            form.ShowDialog();
            this.Close();
        }
    }
}
