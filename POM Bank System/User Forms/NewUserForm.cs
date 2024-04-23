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
    public partial class NewUserForm : KryptonForm
    {
        public NewUserForm()
        {
            InitializeComponent();
        }

        private void no_radioButton_CheckedChanged(object sender, EventArgs e)
        {
            GrpBox_UserLevel.Visible = true;
        }

        private void yes_radioButton_CheckedChanged(object sender, EventArgs e)
        {
            GrpBox_UserLevel.Visible = false;
        }
    }
}
