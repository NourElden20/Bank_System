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
        User user;
        public ClientListForm(User user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void MainMenu_Button_Click(object sender, EventArgs e)
        {
            MainMenuForm form = new MainMenuForm(user);
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
