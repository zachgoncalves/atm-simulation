﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ATM.Classes
{
    public class GlobalData
    {
        private static string currentFilePath = "CurrentATMBankFile.txt";
        private static string updatedFilePath = "UpdatedATMBankFile.txt";

        // Application classes
        public static ATMBank ATMBank = new ATMBank();
        public static Customer customer = new Customer();
        public static currentFile currentFile = new currentFile(currentFilePath);
        public static updatedFile updatedFile = new updatedFile(updatedFilePath);

        // Creating instances of all the forms ...
        public static Form TransactionCompleteForm = new Forms.frmTransactionComplete();
        public static Form TransactionEntryForm = new Forms.frmTransactionEntry();

        // For communication between forms ...
        public static string FormsCode = "";

    } // end Global Data Class

} // end namespace