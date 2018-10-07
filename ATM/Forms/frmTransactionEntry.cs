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
    public partial class frmTransactionEntry : Form
    {
        int selectedTransaction = 0;
        decimal transactionAmount = 0;
        decimal checkingBalance = GlobalData.customer.getRecordCheckingBalance();
        decimal savingsBalance = GlobalData.customer.getRecordSavingsBalance();

        public frmTransactionEntry()
        {
            InitializeComponent();
        }

        public void lockUnusedControls(object control)
        {
            foreach (Control c in pnlTransactionList.Controls)
            {
                if (c == control) {
                    c.Enabled = true;
                } else
                {
                    c.Enabled = false;
                }
            }
        }

        private void transaction_Click(object sender, EventArgs e)
        {
            lockUnusedControls(sender);
            if (sender == btnSavingsDeposit)
            {
                selectedTransaction = 1;
            }
            if (sender == btnSavingsWithdraw)
            {
                selectedTransaction = 2;
            }
            if (sender == btnSavingsBalance)
            {
                selectedTransaction = 3;
            }
            if (sender == btnSavingsToChecking)
            {
                selectedTransaction = 4;
            }
            if (sender == btnCheckingDeposit)
            {
                selectedTransaction = 5;
            }
            if (sender == btnCheckingWithdraw)
            {
                selectedTransaction = 6;
            }
            if (sender == btnCheckingBalance)
            {
                selectedTransaction = 7;
            }
            if (sender == btnCheckingToSavings)
            {
                selectedTransaction = 8;
            }
            pnlValueInput.Enabled = true;
            txtTransactionAmount.Focus();
        }

        private void btnTransactionAmountOK_Click(object sender, EventArgs e)
        {
            try
            {
                transactionAmount = Convert.ToDecimal(txtTransactionAmount.Text);
                if(transactionAmount < 0)
                {
                    MessageBox.Show("Please enter a non-negative amount.", "Error");
                    txtTransactionAmount.Text = "";
                    txtTransactionAmount.Focus();
                }
                else
                {
                    pnlVerifyAmount.Visible = true;
                    txtTransactionInput.Text = transactionAmount.ToString();
                    btnTransactionGo.Enabled = true;
                    btnTransactionNo.Enabled = true;
                }
                
            }
            catch
            {
                MessageBox.Show("Please enter a valid integer amount.", "Error");
                txtTransactionAmount.Text = "";
                txtTransactionAmount.Focus();
            }
        }

        private void btnTransactionGo_Click(object sender, EventArgs e)
        {
            bool transactionHappened = false; 
            if (selectedTransaction == 1)
            {
                savingsBalance += transactionAmount;
                transactionHappened = true;
            }
            if (selectedTransaction == 2)
            {
                if(transactionAmount > 300)
                {
                    MessageBox.Show("Please enter a withdrawal amount less than 300.", "Error");
                    transactionAmount = 0;
                    txtTransactionAmount.Text = "";
                    txtTransactionAmount.Focus();
                }
                else
                {
                    if(transactionAmount > savingsBalance)
                    {
                        MessageBox.Show("You are withdrawing more money than you have in your account. Please widthdraw less.", "Overdraft Warning");
                        transactionAmount = 0;
                        txtTransactionAmount.Text = "";
                        txtTransactionAmount.Focus();
                    }
                    else
                    {
                        savingsBalance -= transactionAmount;
                        transactionHappened = true;
                    }
                }
            }
            if (selectedTransaction == 4)
            {
                if (transactionAmount > savingsBalance)
                {
                    MessageBox.Show("You are transfering more money than you have in your account. Please transfer less.", "Overdraft Warning");
                    transactionAmount = 0;
                    txtTransactionAmount.Text = "";
                    txtTransactionAmount.Focus();
                }
                else
                {
                    savingsBalance -= transactionAmount;
                    checkingBalance += transactionAmount;
                    transactionHappened = true;
                }
            }
            if (selectedTransaction == 5)
            {
                checkingBalance += transactionAmount;
                transactionHappened = true;
            }
            if (selectedTransaction == 6)
            {
                if (transactionAmount > 300)
                {
                    MessageBox.Show("Please enter a withdrawal amount less than 300.", "Error");
                    transactionAmount = 0;
                    txtTransactionAmount.Text = "";
                    txtTransactionAmount.Focus();
                }
                else
                {
                    if (transactionAmount > checkingBalance)
                    {
                        MessageBox.Show("You are withdrawing more money than you have in your account. Please widthdraw less.", "Overdraft Warning");
                        transactionAmount = 0;
                        txtTransactionAmount.Text = "";
                        txtTransactionAmount.Focus();
                    }
                    else
                    {
                        checkingBalance += transactionAmount;
                        transactionHappened = true;
                    }
                }
            }
            if (selectedTransaction == 8)
            {
                if (transactionAmount > savingsBalance)
                {
                    MessageBox.Show("You are transfering more money than you have in your account. Please transfer less.", "Overdraft Warning");
                    transactionAmount = 0;
                    txtTransactionAmount.Text = "";
                    txtTransactionAmount.Focus();
                }
                else
                {
                    checkingBalance -= transactionAmount;
                    savingsBalance += transactionAmount;
                    transactionHappened = true;
                }
            }
            if (transactionHappened)
            {
                GlobalData.customer.updateSavingsCheckings(savingsBalance, checkingBalance);
                Form frmTransactionComplete = new frmTransactionComplete();
                frmTransactionComplete.Show();
                Close();
            }

        }

        private void btnTransactionNo_Click(object sender, EventArgs e)
        {
            foreach (Control c in pnlTransactionList.Controls)
            {
                c.Enabled = true;
            }
            transactionAmount = 0;
            selectedTransaction = 0;
            pnlVerifyAmount.Visible = false;
            pnlValueInput.Enabled = false;
            btnTransactionGo.Enabled = false;
            btnTransactionNo.Enabled = false;
        }
    }
}
