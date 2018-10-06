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
        string recordName;
        int recordPin;
        decimal recordCheckingBalance;
        decimal recordSavingBalance;

        public Boolean customerMatch(string accNumber, string record)
        {
            record = record.Replace(",", "");
            record = record.Replace("$", "");
            string[] recordBreakdown = record.Split('*');

            if (recordBreakdown[0].Trim().Equals(accNumber))
            {
                customerAccNumber = accNumber;
                recordName = recordBreakdown[1].Trim();
                recordPin = Convert.ToInt32(recordBreakdown[2]);
                recordSavingBalance = Convert.ToDecimal(recordBreakdown[3]);
                recordCheckingBalance = Convert.ToDecimal(recordBreakdown[4]);
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
            return recordName;
        }
        public int getCustomerPin()
        {
            return recordPin;
        }
        public decimal getRecordSavingsBalance()
        {
            return recordSavingBalance;
        }
        public decimal getRecordCheckingBalance()
        {
            return recordCheckingBalance;
        }
        public void updateSavingsCheckings(decimal savingsBalance, decimal checkingBalance)
        {
            recordCheckingBalance = checkingBalance;
            recordSavingBalance = savingsBalance;
        }
    }
}
