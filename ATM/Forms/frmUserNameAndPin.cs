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
    public partial class frmUserNameAndPin : Form
    {
        int loginAttempts = 1;
        public frmUserNameAndPin()
        {
            InitializeComponent();
        }

        private void btnVerifyAcc_Click(object sender, EventArgs e)
        {
            try
            {
                string customerName = txtVerifyName.Text;
                decimal customerPin = Convert.ToDecimal(txtVerifyPin.Text);
                if(loginAttempts <= 3)
                {
                    if (customerName.Equals(GlobalData.customer.getCustomerName()) && customerPin == Convert.ToInt32(GlobalData.customer.getCustomerPin()))
                    {
                        Form frmTransactionEntry = new frmTransactionEntry();
                        frmTransactionEntry.Show();
                        Close();
                    }
                    else
                    {
                        if (!customerName.Equals(GlobalData.customer.getCustomerName()))
                        {
                            MessageBox.Show("Please enter the correct name.", "Error");
                            txtVerifyName.Text = "";
                            customerName = "";
                            txtVerifyName.Focus();
                            loginAttempts++;
                        }
                        else if (!customerPin.Equals(GlobalData.customer.getCustomerPin()))
                        {
                            MessageBox.Show("Please enter the correct PIN number.", "Error");
                            txtVerifyPin.Text = "";
                            customerPin = 0;
                            txtVerifyPin.Focus();
                            loginAttempts++;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("You have reached the maximum login attempts.", "Account Locked");
                    Application.Exit();
                }

            }
            catch
            {
                MessageBox.Show("Please enter valid verification information.", "Error");
                txtVerifyPin.Text = "";
                txtVerifyName.Text = "";
                txtVerifyName.Focus();
            }
        }
    }
}
