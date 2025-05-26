namespace Umawi_Bank
{
    partial class Form6
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ComboBox countryCodeComboBox;
        private System.Windows.Forms.TextBox textEmail;
        private System.Windows.Forms.TextBox textPhone;
        private System.Windows.Forms.TextBox textPassword;
        private System.Windows.Forms.Button buttonSave;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.countryCodeComboBox = new System.Windows.Forms.ComboBox();
            this.textEmail = new System.Windows.Forms.TextBox();
            this.textPhone = new System.Windows.Forms.TextBox();
            this.textPassword = new System.Windows.Forms.TextBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.emaillabel = new System.Windows.Forms.Label();
            this.phonenumberlabel = new System.Windows.Forms.Label();
            this.passwordlabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // countryCodeComboBox
            // 
            this.countryCodeComboBox.FormattingEnabled = true;
            this.countryCodeComboBox.Location = new System.Drawing.Point(464, 144);
            this.countryCodeComboBox.Name = "countryCodeComboBox";
            this.countryCodeComboBox.Size = new System.Drawing.Size(161, 59);
            this.countryCodeComboBox.TabIndex = 0;
            // 
            // textEmail
            // 
            this.textEmail.Location = new System.Drawing.Point(464, 53);
            this.textEmail.Name = "textEmail";
            this.textEmail.Size = new System.Drawing.Size(478, 56);
            this.textEmail.TabIndex = 1;
            // 
            // textPhone
            // 
            this.textPhone.Location = new System.Drawing.Point(631, 144);
            this.textPhone.Name = "textPhone";
            this.textPhone.Size = new System.Drawing.Size(311, 56);
            this.textPhone.TabIndex = 2;
            // 
            // textPassword
            // 
            this.textPassword.Location = new System.Drawing.Point(464, 243);
            this.textPassword.Name = "textPassword";
            this.textPassword.Size = new System.Drawing.Size(478, 56);
            this.textPassword.TabIndex = 3;
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(744, 344);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(198, 56);
            this.buttonSave.TabIndex = 4;
            this.buttonSave.Text = "Save Changes";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // emaillabel
            // 
            this.emaillabel.AutoSize = true;
            this.emaillabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emaillabel.Location = new System.Drawing.Point(91, 58);
            this.emaillabel.Name = "emaillabel";
            this.emaillabel.Size = new System.Drawing.Size(126, 51);
            this.emaillabel.TabIndex = 5;
            this.emaillabel.Text = "email";
            // 
            // phonenumberlabel
            // 
            this.phonenumberlabel.AutoSize = true;
            this.phonenumberlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phonenumberlabel.Location = new System.Drawing.Point(91, 144);
            this.phonenumberlabel.Name = "phonenumberlabel";
            this.phonenumberlabel.Size = new System.Drawing.Size(299, 51);
            this.phonenumberlabel.TabIndex = 6;
            this.phonenumberlabel.Text = "pohne number";
            // 
            // passwordlabel
            // 
            this.passwordlabel.AutoSize = true;
            this.passwordlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordlabel.Location = new System.Drawing.Point(91, 243);
            this.passwordlabel.Name = "passwordlabel";
            this.passwordlabel.Size = new System.Drawing.Size(207, 51);
            this.passwordlabel.TabIndex = 7;
            this.passwordlabel.Text = "password";
            this.passwordlabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(25F, 51F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1226, 794);
            this.Controls.Add(this.passwordlabel);
            this.Controls.Add(this.phonenumberlabel);
            this.Controls.Add(this.emaillabel);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.textPassword);
            this.Controls.Add(this.textPhone);
            this.Controls.Add(this.textEmail);
            this.Controls.Add(this.countryCodeComboBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form6";
            this.Text = "Edit Profile";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label emaillabel;
        private System.Windows.Forms.Label phonenumberlabel;
        private System.Windows.Forms.Label passwordlabel;
    }
}