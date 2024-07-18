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
        User user;
        public TransactionsForm(User user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void Transactions_Form_Load(object sender, EventArgs e)
        {

        }

        private void Deposit_Button_Click(object sender, EventArgs e)
        {
            DepositForm form = new DepositForm(user);
            this.Hide();
            form.ShowDialog();
            this.Close();
        }

        private void Withdraw_Button_Click(object sender, EventArgs e)
        {
            WithdrawForm form = new WithdrawForm(user);
            this.Hide();
            form.ShowDialog();
            this.Close();
        }

        private void ShowBalance_Button_Click(object sender, EventArgs e)
        {
            BalanceListForm form = new BalanceListForm(user);
            this.Hide();
            form.ShowDialog();
            this.Close();
        }

        private void MainMenu_Button_Click(object sender, EventArgs e)
        {
            MainMenuForm form = new MainMenuForm(user);
            this.Hide();
            form.ShowDialog();
            this.Close();
        }
    }
}
