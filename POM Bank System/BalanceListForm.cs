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
    public partial class BalanceListForm : KryptonForm
    {
        public BalanceListForm()
        {
            InitializeComponent();
        }

        private void BalanceListForm_Load(object sender, EventArgs e)
        {

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
