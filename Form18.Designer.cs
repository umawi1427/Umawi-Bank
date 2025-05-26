namespace Umawi_Bank
{
    partial class Form18
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.ComboBox cboSenderAccount;
        private System.Windows.Forms.ComboBox cboReceiverAccount;
        private System.Windows.Forms.NumericUpDown numericAmount;
        private System.Windows.Forms.Button btnTransfer;
        private System.Windows.Forms.Label lblSenderAccount;
        private System.Windows.Forms.Label lblReceiverAccount;
        private System.Windows.Forms.Label lblAmount;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.cboSenderAccount = new System.Windows.Forms.ComboBox();
            this.cboReceiverAccount = new System.Windows.Forms.ComboBox();
            this.numericAmount = new System.Windows.Forms.NumericUpDown();
            this.btnTransfer = new System.Windows.Forms.Button();
            this.lblSenderAccount = new System.Windows.Forms.Label();
            this.lblReceiverAccount = new System.Windows.Forms.Label();
            this.lblAmount = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericAmount)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSenderAccount
            // 
            this.lblSenderAccount.AutoSize = true;
            this.lblSenderAccount.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.lblSenderAccount.Location = new System.Drawing.Point(100, 100);
            this.lblSenderAccount.Name = "lblSenderAccount";
            this.lblSenderAccount.Size = new System.Drawing.Size(176, 32);
            this.lblSenderAccount.TabIndex = 4;
            this.lblSenderAccount.Text = "Sender Account:";
            // 
            // cboSenderAccount
            // 
            this.cboSenderAccount.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSenderAccount.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.cboSenderAccount.FormattingEnabled = true;
            this.cboSenderAccount.Location = new System.Drawing.Point(300, 97);
            this.cboSenderAccount.Name = "cboSenderAccount";
            this.cboSenderAccount.Size = new System.Drawing.Size(600, 39);
            this.cboSenderAccount.TabIndex = 0;
            // 
            // lblReceiverAccount
            // 
            this.lblReceiverAccount.AutoSize = true;
            this.lblReceiverAccount.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.lblReceiverAccount.Location = new System.Drawing.Point(100, 180);
            this.lblReceiverAccount.Name = "lblReceiverAccount";
            this.lblReceiverAccount.Size = new System.Drawing.Size(191, 32);
            this.lblReceiverAccount.TabIndex = 5;
            this.lblReceiverAccount.Text = "Receiver Account:";
            // 
            // cboReceiverAccount
            // 
            this.cboReceiverAccount.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboReceiverAccount.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.cboReceiverAccount.FormattingEnabled = true;
            this.cboReceiverAccount.Location = new System.Drawing.Point(300, 177);
            this.cboReceiverAccount.Name = "cboReceiverAccount";
            this.cboReceiverAccount.Size = new System.Drawing.Size(600, 39);
            this.cboReceiverAccount.TabIndex = 1;
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.lblAmount.Location = new System.Drawing.Point(100, 260);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(98, 32);
            this.lblAmount.TabIndex = 6;
            this.lblAmount.Text = "Amount:";
            // 
            // numericAmount
            // 
            this.numericAmount.DecimalPlaces = 2;
            this.numericAmount.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.numericAmount.Location = new System.Drawing.Point(300, 257);
            this.numericAmount.Maximum = new decimal(new int[] {
            1000000, 0, 0, 0});
            this.numericAmount.Name = "numericAmount";
            this.numericAmount.Size = new System.Drawing.Size(300, 39);
            this.numericAmount.TabIndex = 2;
            this.numericAmount.ThousandsSeparator = true;
            // 
            // btnTransfer
            // 
            this.btnTransfer.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.btnTransfer.Location = new System.Drawing.Point(300, 340);
            this.btnTransfer.Name = "btnTransfer";
            this.btnTransfer.Size = new System.Drawing.Size(300, 50);
            this.btnTransfer.TabIndex = 3;
            this.btnTransfer.Text = "Transfer Money";
            this.btnTransfer.UseVisualStyleBackColor = true;
            this.btnTransfer.Click += new System.EventHandler(this.btnTransfer_Click);
            // 
            // Form18
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 600);
            this.Controls.Add(this.btnTransfer);
            this.Controls.Add(this.numericAmount);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.cboReceiverAccount);
            this.Controls.Add(this.lblReceiverAccount);
            this.Controls.Add(this.cboSenderAccount);
            this.Controls.Add(this.lblSenderAccount);
            this.Name = "Form18";
            this.Text = "Transfer Between Your Accounts";
            ((System.ComponentModel.ISupportInitialize)(this.numericAmount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
    }
}