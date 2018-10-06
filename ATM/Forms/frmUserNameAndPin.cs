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
        public frmUserNameAndPin()
        {
            InitializeComponent();
        }

        private void btnVerifyAcc_Click(object sender, EventArgs e)
        {
            // TODO: 
            //  - Verify Pin and Name with inputted account number
            //  - Count number of failed entries (and kick user out / reload to form 1)
            // txtVerifyName, txtVerifyPin
            //  - Output error message for user (was it name or pin)

            try
            {
                string customerName = txtVerifyName.Text;
                decimal customerPin = Convert.ToDecimal(txtVerifyPin.Text);
                if (customerName.Equals(GlobalData.customer.getCustomerName()) && customerPin == Convert.ToInt32(GlobalData.customer.getCustomerPin()))
                {
                    Form frmTransactionEntry = new frmTransactionEntry();
                    frmTransactionEntry.Show();
                }
                else
                {
                    if(!customerName.Equals(GlobalData.customer.getCustomerName()))
                    {
                        MessageBox.Show("Please enter the correct name.", "Error");
                        txtVerifyName.Text = "";
                        customerName = "";
                        txtVerifyName.Focus();
                    }
                    else
                    {
                        MessageBox.Show("Please enter the correct PIN number.", "Error");
                        txtVerifyPin.Text = "";
                        customerPin = 0;
                        txtVerifyPin.Focus();
                    }
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
