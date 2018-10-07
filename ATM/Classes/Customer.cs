using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATM.Classes
{
    public class Customer
    {
        string customer;
        string customerAccNumber;
        string customerName;
        int customerPin;
        decimal customerCheckingBalance;
        decimal customerSavingBalance;

        public Boolean customerMatch(string accNumber, string record)
        {
            record = record.Replace(",", "");
            record = record.Replace("$", "");
            string[] recordBreakdown = record.Split('*');

            if (recordBreakdown[0].Trim().Equals(accNumber))
            {
                customerAccNumber = accNumber;
                customerName = recordBreakdown[1].Trim();
                customerPin = Convert.ToInt32(recordBreakdown[2]);
                customerSavingBalance = Convert.ToDecimal(recordBreakdown[3]);
                customerCheckingBalance = Convert.ToDecimal(recordBreakdown[4]);
                MessageBox.Show(recordBreakdown[0] + " :Acc Num: " + accNumber);
                return true;
            }
            else
            {
                return false;
            }   
        }
        public string getCustomerName()
        {
            return customerName;
        }
        public int getCustomerPin()
        {
            return customerPin;
        }
        public decimal getRecordSavingsBalance()
        {
            return customerSavingBalance;
        }
        public decimal getRecordCheckingBalance()
        {
            return customerCheckingBalance;
        }
        public void updateSavingsCheckings(decimal savingsBalance, decimal checkingBalance)
        {
            customerCheckingBalance = checkingBalance;
            customerSavingBalance = savingsBalance;
        }
        public string generateRecord()
        {
            customer = customerAccNumber + " * " + customerName + " * " + customerPin + " * " + customerSavingBalance.ToString("C") + " * " + customerCheckingBalance.ToString("C");
            return customer;
        }
    }
}
