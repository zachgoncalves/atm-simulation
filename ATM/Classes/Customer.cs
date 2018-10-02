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
        string recordPin;
        decimal recordCheckingBalance;
        decimal recordSavingBalance;

        public Boolean customerMatch(string accNumber, string accountsInFile)
        {
            bool endOfFile = false;
            while (endOfFile)
            {
                string[] recordArray = GlobalData.currentFile.getNextRecord(ref endOfFile).Split('*');
                accountsInFile = recordArray[0];
                if(accountsInFile.Equals(accNumber))
                {
                    customerAccNumber = accNumber;
                    break;
                } else if (endOfFile == true)
                {
                    return false;
                }
            }
            return true;
        }
        public string setRecordName(string customerName)
        {
            return recordName = customerName;
        }
        public string setRecordPin(string customerPin)
        {
            return recordPin = customerPin;
        }
    }
}
