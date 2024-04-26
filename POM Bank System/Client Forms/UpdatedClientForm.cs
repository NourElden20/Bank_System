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
    public partial class UpdatedClientForm : KryptonForm
    {
        public UpdatedClientForm()
        {
            InitializeComponent();
        }

        private void MainMenu_Button_Click(object sender, EventArgs e)
        {
            MainMenuForm form = new MainMenuForm();
            this.Hide();
            form.ShowDialog();
            this.Close();
        }
    }
}
