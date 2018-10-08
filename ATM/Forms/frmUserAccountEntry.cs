/* Temple University
 * Component Based Software Design (CIS 3309) 
 * Project 2: ATM
 * Form: frmUserAccountEntry
 * Written by: Zachary Goncalves
 */
using System;
using System.Windows.Forms;
using ATM.Classes;

namespace ATM.Forms
{
    public partial class frmUserAccountEntry : Form
    {
        public frmUserAccountEntry()
        {
            InitializeComponent();
        }

        private void btnAccStart_Click(object sender, EventArgs e)
        {
            try
            {
                int accNumber = Convert.ToInt32(txtAccNum.Text);
                if (accNumber.ToString().Length != 5)
                {
                    accNumber = 0;
                    txtAccNum.Text = "";
                    MessageBox.Show("Please enter an account number of 5 digits.", "Error");
                    txtAccNum.Focus();
                }
                else
                {
                    string strAccNumber = accNumber.ToString();
                    bool foundRecord = false;
                    string record = GlobalData.ATMBank.findCustomerRecord(strAccNumber, ref foundRecord);

                    if (foundRecord)
                    {
                        Form UserNamePinForm = new frmUserNameAndPin();
                        UserNamePinForm.Show();
                    }
                    else
                    {
                        MessageBox.Show("Please enter an account number that exists in our system.", "Error");
                        txtAccNum.Text = "";
                        accNumber = 0;
                        record = "";
                        txtAccNum.Focus();
                        GlobalData.ATMBank.rewindFiles();
                    }
                }
            }
            catch (Exception ex)
            {
                txtAccNum.Text = "";
                MessageBox.Show("Please enter a valid account number of 5 digits." + ex, "Error");
                txtAccNum.Focus();
            }
        }

    }
}
