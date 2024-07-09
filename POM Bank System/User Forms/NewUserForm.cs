using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
            string usernamePattern = @"^[a-zA-Z0-9]+@(gmail|yahoo|outlook)\.com$";
            string passwordPattern = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[@$!%*?&_\-])[A-Za-z\d@$!%*?&_\-]{8,}$";

            user.Username = username_TextBox.Text;
            user.Password = Password_TextBox.Text;
            string confirmPassword = confirm_password_TextBox.Text;

            if (!Regex.IsMatch(user.Username, usernamePattern))
            {
                MessageBox.Show("Username must be alphanumeric, and in the format 'name@domain.com' where domain is gmail, yahoo, or outlook.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!Regex.IsMatch(user.Password, passwordPattern))
            {
                MessageBox.Show("Password must be at least 8 characters long and contain at least one uppercase letter, one lowercase letter, one digit, and one special character.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (user.Password != confirmPassword)
            {
                MessageBox.Show("The passwords you entered don't match.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (yes_radioButton.Checked) user.Permission = "Admin";
            else
            {
                if (RBtn_MidLevel.Checked)
                {
                    user.Permission = "Mid-Level";
                }
                else if (RBtn_LowLevel.Checked)
                {
                    user.Permission = "Low-Level";
                }
                else
                {
                    MessageBox.Show("Please select a permission level.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
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
