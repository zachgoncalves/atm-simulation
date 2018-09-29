namespace ATM.Forms
{
    partial class frmTransactionComplete
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblTransactionComplete = new System.Windows.Forms.Label();
            this.lblNewTransaction = new System.Windows.Forms.Label();
            this.btnNoNewTransaction = new System.Windows.Forms.Button();
            this.btnNewTransaction = new System.Windows.Forms.Button();
            this.txtSavingsBalance = new System.Windows.Forms.TextBox();
            this.lblSavingsBalance = new System.Windows.Forms.Label();
            this.txtCheckingBalance = new System.Windows.Forms.TextBox();
            this.lblCheckingBalance = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblViewBalances = new System.Windows.Forms.Label();
            this.btnShowBalance = new System.Windows.Forms.Button();
            this.lblThanks = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ATM.Properties.Resources.logo_small;
            this.pictureBox1.Location = new System.Drawing.Point(31, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(303, 64);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // lblTransactionComplete
            // 
            this.lblTransactionComplete.AutoSize = true;
            this.lblTransactionComplete.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTransactionComplete.Location = new System.Drawing.Point(268, 121);
            this.lblTransactionComplete.Name = "lblTransactionComplete";
            this.lblTransactionComplete.Size = new System.Drawing.Size(274, 24);
            this.lblTransactionComplete.TabIndex = 4;
            this.lblTransactionComplete.Text = "TRANSACTION COMPLETE";
            // 
            // lblNewTransaction
            // 
            this.lblNewTransaction.AutoSize = true;
            this.lblNewTransaction.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewTransaction.Location = new System.Drawing.Point(58, 322);
            this.lblNewTransaction.Name = "lblNewTransaction";
            this.lblNewTransaction.Size = new System.Drawing.Size(338, 20);
            this.lblNewTransaction.TabIndex = 5;
            this.lblNewTransaction.Text = "Would you like to perform another transaction?";
            // 
            // btnNoNewTransaction
            // 
            this.btnNoNewTransaction.BackColor = System.Drawing.Color.DarkRed;
            this.btnNoNewTransaction.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnNoNewTransaction.Location = new System.Drawing.Point(591, 314);
            this.btnNoNewTransaction.Name = "btnNoNewTransaction";
            this.btnNoNewTransaction.Size = new System.Drawing.Size(134, 38);
            this.btnNoNewTransaction.TabIndex = 20;
            this.btnNoNewTransaction.Text = "No";
            this.btnNoNewTransaction.UseVisualStyleBackColor = false;
            // 
            // btnNewTransaction
            // 
            this.btnNewTransaction.BackColor = System.Drawing.Color.Green;
            this.btnNewTransaction.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnNewTransaction.Location = new System.Drawing.Point(425, 314);
            this.btnNewTransaction.Name = "btnNewTransaction";
            this.btnNewTransaction.Size = new System.Drawing.Size(134, 38);
            this.btnNewTransaction.TabIndex = 19;
            this.btnNewTransaction.Text = "Yes";
            this.btnNewTransaction.UseVisualStyleBackColor = false;
            // 
            // txtSavingsBalance
            // 
            this.txtSavingsBalance.Location = new System.Drawing.Point(213, 17);
            this.txtSavingsBalance.Name = "txtSavingsBalance";
            this.txtSavingsBalance.ReadOnly = true;
            this.txtSavingsBalance.Size = new System.Drawing.Size(100, 20);
            this.txtSavingsBalance.TabIndex = 22;
            // 
            // lblSavingsBalance
            // 
            this.lblSavingsBalance.AutoSize = true;
            this.lblSavingsBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSavingsBalance.Location = new System.Drawing.Point(126, 17);
            this.lblSavingsBalance.Name = "lblSavingsBalance";
            this.lblSavingsBalance.Size = new System.Drawing.Size(65, 20);
            this.lblSavingsBalance.TabIndex = 21;
            this.lblSavingsBalance.Text = "Savings";
            // 
            // txtCheckingBalance
            // 
            this.txtCheckingBalance.Location = new System.Drawing.Point(448, 17);
            this.txtCheckingBalance.Name = "txtCheckingBalance";
            this.txtCheckingBalance.ReadOnly = true;
            this.txtCheckingBalance.Size = new System.Drawing.Size(100, 20);
            this.txtCheckingBalance.TabIndex = 24;
            // 
            // lblCheckingBalance
            // 
            this.lblCheckingBalance.AutoSize = true;
            this.lblCheckingBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCheckingBalance.Location = new System.Drawing.Point(361, 17);
            this.lblCheckingBalance.Name = "lblCheckingBalance";
            this.lblCheckingBalance.Size = new System.Drawing.Size(75, 20);
            this.lblCheckingBalance.TabIndex = 23;
            this.lblCheckingBalance.Text = "Checking";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtCheckingBalance);
            this.panel1.Controls.Add(this.lblCheckingBalance);
            this.panel1.Controls.Add(this.lblSavingsBalance);
            this.panel1.Controls.Add(this.txtSavingsBalance);
            this.panel1.Location = new System.Drawing.Point(62, 234);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(663, 55);
            this.panel1.TabIndex = 25;
            this.panel1.Visible = false;
            // 
            // lblViewBalances
            // 
            this.lblViewBalances.AutoSize = true;
            this.lblViewBalances.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblViewBalances.Location = new System.Drawing.Point(60, 187);
            this.lblViewBalances.Name = "lblViewBalances";
            this.lblViewBalances.Size = new System.Drawing.Size(334, 20);
            this.lblViewBalances.TabIndex = 26;
            this.lblViewBalances.Text = "Would you like to view your account balances?";
            // 
            // btnShowBalance
            // 
            this.btnShowBalance.BackColor = System.Drawing.Color.Green;
            this.btnShowBalance.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnShowBalance.Location = new System.Drawing.Point(427, 179);
            this.btnShowBalance.Name = "btnShowBalance";
            this.btnShowBalance.Size = new System.Drawing.Size(134, 38);
            this.btnShowBalance.TabIndex = 27;
            this.btnShowBalance.Text = "Yes";
            this.btnShowBalance.UseVisualStyleBackColor = false;
            // 
            // lblThanks
            // 
            this.lblThanks.AutoSize = true;
            this.lblThanks.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThanks.Location = new System.Drawing.Point(298, 145);
            this.lblThanks.Name = "lblThanks";
            this.lblThanks.Size = new System.Drawing.Size(210, 17);
            this.lblThanks.TabIndex = 28;
            this.lblThanks.Text = "Thanks for choosing MazeBank!";
            // 
            // frmTransactionComplete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 431);
            this.Controls.Add(this.lblThanks);
            this.Controls.Add(this.btnShowBalance);
            this.Controls.Add(this.lblViewBalances);
            this.Controls.Add(this.btnNoNewTransaction);
            this.Controls.Add(this.btnNewTransaction);
            this.Controls.Add(this.lblNewTransaction);
            this.Controls.Add(this.lblTransactionComplete);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmTransactionComplete";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MazeBank - Transaction Complete";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblTransactionComplete;
        private System.Windows.Forms.Label lblNewTransaction;
        private System.Windows.Forms.Button btnNoNewTransaction;
        private System.Windows.Forms.Button btnNewTransaction;
        private System.Windows.Forms.TextBox txtSavingsBalance;
        private System.Windows.Forms.Label lblSavingsBalance;
        private System.Windows.Forms.TextBox txtCheckingBalance;
        private System.Windows.Forms.Label lblCheckingBalance;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblViewBalances;
        private System.Windows.Forms.Button btnShowBalance;
        private System.Windows.Forms.Label lblThanks;
    }
}