using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATM.Classes
{
    class Customer
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
            while(endOfFile)
            {
                string[] recordArray = new string[currentFile.getNextRecord(ref bool endOfFile).Split()];
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
    }
}
