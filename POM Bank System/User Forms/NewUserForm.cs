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
    public partial class NewUserForm : KryptonForm
    {
        public NewUserForm()
        {
            InitializeComponent();
        }
        User user = new User();

        private void no_radioButton_CheckedChanged(object sender, EventArgs e)
        {
            GrpBox_UserLevel.Visible = true;
            

        }

        private void yes_radioButton_CheckedChanged(object sender, EventArgs e)// User is Admin
        {
            GrpBox_UserLevel.Visible = false;
            
        }

        private void UsersMenu_Button_Click(object sender, EventArgs e)
        {
            UsersForm form = new UsersForm();
            this.Hide();
            form.ShowDialog();
            this.Close();
        }

        private void Add_Button_Click(object sender, EventArgs e)
        {
            user.Username = username_TextBox.Text;
            user.Password = Password_TextBox.Text;
            string confirmPassword = confirm_password_TextBox.Text;
            if (user.Password != confirmPassword)
            {
                MessageBox.Show("The passwords you entered don't match", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (user.Password.Length < 8)
            {
                MessageBox.Show("Password must be at least 8 characters long.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (yes_radioButton.Checked) user.Permission = "Admin";
            else
            {
                if (RBtn_MidLevel.Checked) user.Permission = "Mid-Level";
                if (RBtn_LowLevel.Checked) user.Permission = "Low-Level";
            }
            UserOperations.AddUser(user);
        }
        private bool CheckIFFieldsEmpty()
        {
            if(username_TextBox.Text == string.Empty || Password_TextBox.Text == string.Empty || confirm_password_TextBox.Text == string.Empty)
            {
                MessageBox.Show("Fill the fields","Error!",MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                return true;
            }
            return false;
        }
    }
}
