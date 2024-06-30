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
    public partial class ClientListForm : KryptonForm
    {
        private int permission;
        public ClientListForm(int per)
        {
            InitializeComponent();
            permission = per;
        }

        private void MainMenu_Button_Click(object sender, EventArgs e)
        {
            MainMenuForm form = new MainMenuForm(permission);
            this.Hide();
            form.ShowDialog();
            this.Close();
        }

        private void ClientListForm_Load(object sender, EventArgs e)
        {
            clsClient Client = new clsClient();

            List<clsClient> ClientsList = Client.ShowAllClients();

            foreach (clsClient client in ClientsList)
            {
                clsClientBindingSource.Add(client);
            }
        }
    }
}
