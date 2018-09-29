﻿namespace ATM.Forms
{
    partial class frmUserNameAndPin
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
            this.lblVerifyAcc = new System.Windows.Forms.Label();
            this.lblVerifyDesc = new System.Windows.Forms.Label();
            this.lblVerifyName = new System.Windows.Forms.Label();
            this.lblVerifyPin = new System.Windows.Forms.Label();
            this.txtVerifyPin = new System.Windows.Forms.TextBox();
            this.txtVerifyName = new System.Windows.Forms.TextBox();
            this.btnVerifyAcc = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblVerifyAcc
            // 
            this.lblVerifyAcc.AutoSize = true;
            this.lblVerifyAcc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVerifyAcc.Location = new System.Drawing.Point(148, 128);
            this.lblVerifyAcc.Name = "lblVerifyAcc";
            this.lblVerifyAcc.Size = new System.Drawing.Size(258, 24);
            this.lblVerifyAcc.TabIndex = 2;
            this.lblVerifyAcc.Text = "ACCOUNT VERIFICATION";
            // 
            // lblVerifyDesc
            // 
            this.lblVerifyDesc.AutoSize = true;
            this.lblVerifyDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVerifyDesc.Location = new System.Drawing.Point(148, 161);
            this.lblVerifyDesc.Name = "lblVerifyDesc";
            this.lblVerifyDesc.Size = new System.Drawing.Size(364, 20);
            this.lblVerifyDesc.TabIndex = 3;
            this.lblVerifyDesc.Text = "Enter your name and pin number, then press okay.";
            // 
            // lblVerifyName
            // 
            this.lblVerifyName.AutoSize = true;
            this.lblVerifyName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVerifyName.Location = new System.Drawing.Point(148, 216);
            this.lblVerifyName.Name = "lblVerifyName";
            this.lblVerifyName.Size = new System.Drawing.Size(51, 20);
            this.lblVerifyName.TabIndex = 4;
            this.lblVerifyName.Text = "Name";
            // 
            // lblVerifyPin
            // 
            this.lblVerifyPin.AutoSize = true;
            this.lblVerifyPin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVerifyPin.Location = new System.Drawing.Point(148, 250);
            this.lblVerifyPin.Name = "lblVerifyPin";
            this.lblVerifyPin.Size = new System.Drawing.Size(162, 20);
            this.lblVerifyPin.TabIndex = 5;
            this.lblVerifyPin.Text = "Pin Number (4 Digits):";
            // 
            // txtVerifyPin
            // 
            this.txtVerifyPin.Location = new System.Drawing.Point(339, 249);
            this.txtVerifyPin.Name = "txtVerifyPin";
            this.txtVerifyPin.Size = new System.Drawing.Size(100, 20);
            this.txtVerifyPin.TabIndex = 6;
            // 
            // txtVerifyName
            // 
            this.txtVerifyName.Location = new System.Drawing.Point(339, 216);
            this.txtVerifyName.Name = "txtVerifyName";
            this.txtVerifyName.Size = new System.Drawing.Size(100, 20);
            this.txtVerifyName.TabIndex = 7;
            // 
            // btnVerifyAcc
            // 
            this.btnVerifyAcc.BackColor = System.Drawing.Color.Green;
            this.btnVerifyAcc.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnVerifyAcc.Location = new System.Drawing.Point(339, 293);
            this.btnVerifyAcc.Name = "btnVerifyAcc";
            this.btnVerifyAcc.Size = new System.Drawing.Size(82, 31);
            this.btnVerifyAcc.TabIndex = 8;
            this.btnVerifyAcc.Text = "Okay";
            this.btnVerifyAcc.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ATM.Properties.Resources.logo_small;
            this.pictureBox1.Location = new System.Drawing.Point(31, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(303, 64);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // frmUserNameAndPin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 373);
            this.Controls.Add(this.btnVerifyAcc);
            this.Controls.Add(this.txtVerifyName);
            this.Controls.Add(this.txtVerifyPin);
            this.Controls.Add(this.lblVerifyPin);
            this.Controls.Add(this.lblVerifyName);
            this.Controls.Add(this.lblVerifyDesc);
            this.Controls.Add(this.lblVerifyAcc);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmUserNameAndPin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MazeBank - Verify it\'s you";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblVerifyAcc;
        private System.Windows.Forms.Label lblVerifyDesc;
        private System.Windows.Forms.Label lblVerifyName;
        private System.Windows.Forms.Label lblVerifyPin;
        private System.Windows.Forms.TextBox txtVerifyPin;
        private System.Windows.Forms.TextBox txtVerifyName;
        private System.Windows.Forms.Button btnVerifyAcc;
    }
}