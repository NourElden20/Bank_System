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
    public partial class TransactionsForm : KryptonForm
    {
        public TransactionsForm()
        {
            InitializeComponent();
        }

        private void Transactions_Form_Load(object sender, EventArgs e)
        {

        }

        private void Deposit_Button_Click(object sender, EventArgs e)
        {
            DepositForm form = new DepositForm();
            this.Hide();
            form.ShowDialog();
            this.Close();
        }

        private void Withdraw_Button_Click(object sender, EventArgs e)
        {
            WithdrawForm form = new WithdrawForm();
            this.Hide();
            form.ShowDialog();
            this.Close();
        }

        private void ShowBalance_Button_Click(object sender, EventArgs e)
        {
            BalanceListForm form = new BalanceListForm();
            this.Hide();
            form.ShowDialog();
            this.Close();
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
