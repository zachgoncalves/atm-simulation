using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ATM.Classes
{
    public class GlobalData
    {
        // NOTE:
        //       Static methods of a class may be called without instantiating the class
        //              They called from the class itself
        //       Static objects or variables may be accessed without creating an instance of the class
        //              that contains them
        //       When you declare a class as static, all its members are automatically static

        //        private static string currentFilePath = "CurrentATMBankFile.txt";
        //        private static string updatedFilePath = "UpdatedATMBankFile.txt";

        // Application classes
        public static ATMBank ATMBank = new ATMBank();
        public static Customer customer = new Customer();
        //        public static currentFileClass currentFile = new currentFileClass(currentFilePath);
        //        public static updatedFileClass updatedFile = new updatedFileClass(updatedFilePath);

        // Creating instances of all the forms ...
        public static Form TransactionCompleteForm = new Forms.frmTransactionComplete();
        public static Form TransactionEntryForm = new Forms.frmTransactionEntry();
        // Only need these two (below) forms once so there is no need to instantiate them global and public.  We Instatiate them as we need them
        // public static Form PinIDEntryForm = new frmPinIDEntry();
        // public static Form SplashStartForm = new frmSplashStart();

        // For communication between forms ...
        public static string FormsCode = "";

    } // end Global Data Class

} // end namespace