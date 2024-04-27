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
using Bank_System.Classes;

namespace Bank_System
{
    public partial class BalanceListForm : KryptonForm
    {
        public BalanceListForm()
        {
            InitializeComponent();
        }

        private void BalanceListForm_Load(object sender, EventArgs e)
        {
            clsClient Client = new clsClient();
            List<clsClient> ClientsList = Client.ShowAllClients();

            double TotalBalances = 0;
            int NumberOfClients = ClientsList.Count;

            foreach (clsClient client in ClientsList)
            {
                clsClientBindingSource.Add(client);
                TotalBalances += client.Balance;

            }

            TotalBalance_Label.Text = $"Total Balances: {TotalBalances}$";
            NOClient_Label.Text = $"Number of Clients: {NumberOfClients}";
        }

        private void TransactionsMenu_Button_Click(object sender, EventArgs e)
        {
            TransactionsForm form = new TransactionsForm();
            this.Hide();
            form.ShowDialog();
            this.Close();
        }
    }
}
