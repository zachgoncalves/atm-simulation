using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ATM.Classes;

namespace ATM.Forms
{
    public partial class frmTransactionComplete : Form
    {
        public frmTransactionComplete()
        {
            InitializeComponent();
        }

        private void btnShowBalance_Click(object sender, EventArgs e)
        {
            pnlBalancesView.Visible = true;
            txtSavingsBalance.Text = GlobalData.customer.getRecordSavingsBalance().ToString();
            txtCheckingBalance.Text = GlobalData.customer.getRecordCheckingBalance().ToString();
        }

        private void btnNoNewTransaction_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thanks for being a MazeBank Customer!");
            GlobalData.ATMBank.writeOut(GlobalData.customer.generateRecord());
            GlobalData.ATMBank.CopyRemainingRecords();
            GlobalData.ATMBank.generateUpdatedFile();
            Application.Exit();
        }

        private void btnNewTransaction_Click(object sender, EventArgs e)
        {
            Form frmTransactionEntry = new frmTransactionEntry();
            frmTransactionEntry.Show();
            Close();
        }
    }
}
