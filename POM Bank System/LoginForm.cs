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
    public partial class Login_Form : KryptonForm
    {
        public Login_Form()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        
        private void Login_Button_Click(object sender, EventArgs e)
        {
            UserOperations U = new UserOperations();

            string username = Username_TextBox.Text;
            string password = Password_TextBox.Text;

            User user = U.FindUserByName(username);

            if (user != null)
            {
                MainMenuForm form = new MainMenuForm(user);
                this.Hide();
                form.ShowDialog();
                this.Close();
                return;
            }
            else
            {
                MessageBox.Show("Invalid username or password!", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void Check_ShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (Check_ShowPass.Checked == false)
            {
                Password_TextBox.UseSystemPasswordChar = true;
                Password_TextBox.UseSystemPasswordChar = true;
            }
            else
            {
                Password_TextBox.UseSystemPasswordChar = false;
                Password_TextBox.UseSystemPasswordChar = false;
            }
        }
    }
}
