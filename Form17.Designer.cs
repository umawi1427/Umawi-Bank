namespace Umawi_Bank
{
    partial class Form17
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtRecipientAccountId = new System.Windows.Forms.TextBox();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.cboSenderAccount = new System.Windows.Forms.ComboBox();
            this.lblSenderAccount = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblAccountId = new System.Windows.Forms.Label();
            this.lblAmount = new System.Windows.Forms.Label();
            this.btnSendMoney = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cboSenderAccount
            // 
            this.cboSenderAccount.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSenderAccount.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.cboSenderAccount.FormattingEnabled = true;
            this.cboSenderAccount.Location = new System.Drawing.Point(300, 50);
            this.cboSenderAccount.Size = new System.Drawing.Size(600, 45);
            this.cboSenderAccount.TabIndex = 0;
            // 
            // txtFirstName
            this.txtFirstName.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.txtFirstName.Location = new System.Drawing.Point(300, 120);
            this.txtFirstName.Size = new System.Drawing.Size(600, 43);
            // 
            // txtLastName
            this.txtLastName.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.txtLastName.Location = new System.Drawing.Point(300, 190);
            this.txtLastName.Size = new System.Drawing.Size(600, 43);
            // 
            // txtRecipientAccountId
            this.txtRecipientAccountId.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.txtRecipientAccountId.Location = new System.Drawing.Point(300, 260);
            this.txtRecipientAccountId.Size = new System.Drawing.Size(600, 43);
            // 
            // txtAmount
            this.txtAmount.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.txtAmount.Location = new System.Drawing.Point(300, 330);
            this.txtAmount.Size = new System.Drawing.Size(600, 43);
            // 
            // Labels
            this.lblSenderAccount.AutoSize = true;
            this.lblSenderAccount.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.lblSenderAccount.Location = new System.Drawing.Point(50, 50);
            this.lblSenderAccount.Text = "Sender Account:";
            //
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.lblFirstName.Location = new System.Drawing.Point(50, 120);
            this.lblFirstName.Text = "First Name:";
            //
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.lblLastName.Location = new System.Drawing.Point(50, 190);
            this.lblLastName.Text = "Last Name:";
            //
            this.lblAccountId.AutoSize = true;
            this.lblAccountId.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.lblAccountId.Location = new System.Drawing.Point(50, 260);
            this.lblAccountId.Text = "Recipient Acc ID:";
            //
            this.lblAmount.AutoSize = true;
            this.lblAmount.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.lblAmount.Location = new System.Drawing.Point(50, 330);
            this.lblAmount.Text = "Amount:";
            //
            // btnSendMoney
            this.btnSendMoney.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.btnSendMoney.Location = new System.Drawing.Point(300, 400);
            this.btnSendMoney.Size = new System.Drawing.Size(600, 50);
            this.btnSendMoney.Text = "Send Money";
            this.btnSendMoney.Click += new System.EventHandler(this.btnSendMoney_Click);
            // 
            // Form17
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 500);
            this.Controls.Add(this.cboSenderAccount);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtRecipientAccountId);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.lblSenderAccount);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblAccountId);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.btnSendMoney);
            this.Name = "Form17";
            this.Text = "Money Transfer";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtRecipientAccountId;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.ComboBox cboSenderAccount;
        private System.Windows.Forms.Label lblSenderAccount;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblAccountId;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Button btnSendMoney;
    }
}