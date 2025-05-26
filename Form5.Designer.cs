using System.Windows.Forms;
namespace Umawi_Bank
{
    partial class Form5
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox textId;
        private System.Windows.Forms.TextBox textFirstName;
        private System.Windows.Forms.TextBox textSurname;
        private System.Windows.Forms.TextBox textPassword;
        private System.Windows.Forms.TextBox textBirthdate;
        private System.Windows.Forms.TextBox textBirthplace;
        private System.Windows.Forms.TextBox textPhone;
        private System.Windows.Forms.TextBox textEmail;
        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.Label labelFirstName;
        private System.Windows.Forms.Label labelSurname;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Label labelBirthdate;
        private System.Windows.Forms.Label labelBirthplace;
        private System.Windows.Forms.Label labelPhone;
        private System.Windows.Forms.Label labelEmail;

        /// <summary>
        /// Required designer variable.
        /// </summary>
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
            this.textId = new System.Windows.Forms.TextBox();
            this.textFirstName = new System.Windows.Forms.TextBox();
            this.textSurname = new System.Windows.Forms.TextBox();
            this.textPassword = new System.Windows.Forms.TextBox();
            this.textBirthdate = new System.Windows.Forms.TextBox();
            this.textBirthplace = new System.Windows.Forms.TextBox();
            this.textPhone = new System.Windows.Forms.TextBox();
            this.textEmail = new System.Windows.Forms.TextBox();
            this.labelId = new System.Windows.Forms.Label();
            this.labelFirstName = new System.Windows.Forms.Label();
            this.labelSurname = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.labelBirthdate = new System.Windows.Forms.Label();
            this.labelBirthplace = new System.Windows.Forms.Label();
            this.labelPhone = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textId
            // 
            this.textId.Location = new System.Drawing.Point(345, 45);
            this.textId.Name = "textId";
            this.textId.ReadOnly = true;
            this.textId.Size = new System.Drawing.Size(658, 56);
            this.textId.TabIndex = 0;
            // 
            // textFirstName
            // 
            this.textFirstName.Location = new System.Drawing.Point(345, 121);
            this.textFirstName.Name = "textFirstName";
            this.textFirstName.ReadOnly = true;
            this.textFirstName.Size = new System.Drawing.Size(658, 56);
            this.textFirstName.TabIndex = 1;
            // 
            // textSurname
            // 
            this.textSurname.Location = new System.Drawing.Point(345, 204);
            this.textSurname.Name = "textSurname";
            this.textSurname.ReadOnly = true;
            this.textSurname.Size = new System.Drawing.Size(658, 56);
            this.textSurname.TabIndex = 2;
            // 
            // textPassword
            // 
            this.textPassword.Location = new System.Drawing.Point(345, 298);
            this.textPassword.Name = "textPassword";
            this.textPassword.ReadOnly = true;
            this.textPassword.Size = new System.Drawing.Size(658, 56);
            this.textPassword.TabIndex = 3;
            // 
            // textBirthdate
            // 
            this.textBirthdate.Location = new System.Drawing.Point(345, 386);
            this.textBirthdate.Name = "textBirthdate";
            this.textBirthdate.ReadOnly = true;
            this.textBirthdate.Size = new System.Drawing.Size(658, 56);
            this.textBirthdate.TabIndex = 4;
            // 
            // textBirthplace
            // 
            this.textBirthplace.Location = new System.Drawing.Point(345, 466);
            this.textBirthplace.Name = "textBirthplace";
            this.textBirthplace.ReadOnly = true;
            this.textBirthplace.Size = new System.Drawing.Size(658, 56);
            this.textBirthplace.TabIndex = 5;
            // 
            // textPhone
            // 
            this.textPhone.Location = new System.Drawing.Point(345, 547);
            this.textPhone.Name = "textPhone";
            this.textPhone.ReadOnly = true;
            this.textPhone.Size = new System.Drawing.Size(658, 56);
            this.textPhone.TabIndex = 6;
            // 
            // textEmail
            // 
            this.textEmail.Location = new System.Drawing.Point(345, 632);
            this.textEmail.Name = "textEmail";
            this.textEmail.ReadOnly = true;
            this.textEmail.Size = new System.Drawing.Size(658, 56);
            this.textEmail.TabIndex = 7;
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.Location = new System.Drawing.Point(30, 45);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(77, 51);
            this.labelId.TabIndex = 8;
            this.labelId.Text = "ID:";
            // 
            // labelFirstName
            // 
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.Location = new System.Drawing.Point(30, 121);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(244, 51);
            this.labelFirstName.TabIndex = 9;
            this.labelFirstName.Text = "First Name:";
            // 
            // labelSurname
            // 
            this.labelSurname.AutoSize = true;
            this.labelSurname.Location = new System.Drawing.Point(28, 209);
            this.labelSurname.Name = "labelSurname";
            this.labelSurname.Size = new System.Drawing.Size(209, 51);
            this.labelSurname.TabIndex = 10;
            this.labelSurname.Text = "Surname:";
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Location = new System.Drawing.Point(27, 298);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(224, 51);
            this.labelPassword.TabIndex = 11;
            this.labelPassword.Text = "Password:";
            // 
            // labelBirthdate
            // 
            this.labelBirthdate.AutoSize = true;
            this.labelBirthdate.Location = new System.Drawing.Point(30, 389);
            this.labelBirthdate.Name = "labelBirthdate";
            this.labelBirthdate.Size = new System.Drawing.Size(207, 51);
            this.labelBirthdate.TabIndex = 12;
            this.labelBirthdate.Text = "Birthdate:";
            // 
            // labelBirthplace
            // 
            this.labelBirthplace.AutoSize = true;
            this.labelBirthplace.Location = new System.Drawing.Point(27, 471);
            this.labelBirthplace.Name = "labelBirthplace";
            this.labelBirthplace.Size = new System.Drawing.Size(227, 51);
            this.labelBirthplace.TabIndex = 13;
            this.labelBirthplace.Text = "Birthplace:";
            // 
            // labelPhone
            // 
            this.labelPhone.AutoSize = true;
            this.labelPhone.Location = new System.Drawing.Point(30, 550);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(159, 51);
            this.labelPhone.TabIndex = 14;
            this.labelPhone.Text = "Phone:";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(30, 635);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(143, 51);
            this.labelEmail.TabIndex = 15;
            this.labelEmail.Text = "Email:";
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(25F, 51F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(2688, 752);
            this.Controls.Add(this.textId);
            this.Controls.Add(this.textFirstName);
            this.Controls.Add(this.textSurname);
            this.Controls.Add(this.textPassword);
            this.Controls.Add(this.textBirthdate);
            this.Controls.Add(this.textBirthplace);
            this.Controls.Add(this.textPhone);
            this.Controls.Add(this.textEmail);
            this.Controls.Add(this.labelId);
            this.Controls.Add(this.labelFirstName);
            this.Controls.Add(this.labelSurname);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.labelBirthdate);
            this.Controls.Add(this.labelBirthplace);
            this.Controls.Add(this.labelPhone);
            this.Controls.Add(this.labelEmail);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form5";
            this.ShowIcon = false;
            this.Text = "User Profile";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}