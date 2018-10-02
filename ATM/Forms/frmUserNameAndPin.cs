using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        }
    }
}
