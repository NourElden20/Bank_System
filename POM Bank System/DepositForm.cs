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
    public partial class DepositForm : KryptonForm
    {
        public DepositForm()
        {
            InitializeComponent();
        }

        private void TransactionMenu_Button_Click(object sender, EventArgs e)
        {
            TransactionsForm form = new TransactionsForm();
            this.Hide();
            form.ShowDialog();
            this.Close();
        }
    }
}
