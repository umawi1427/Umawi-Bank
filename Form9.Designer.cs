namespace Umawi_Bank
{
    partial class Form9
    {
        private System.ComponentModel.IContainer components = null;

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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lastname = new System.Windows.Forms.TextBox();
            this.firstname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.lastname);
            this.panel1.Controls.Add(this.firstname);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(878, 220);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1006, 894);
            this.panel1.TabIndex = 0;
            // 
            // lastname
            // 
            this.lastname.BackColor = System.Drawing.SystemColors.Control;
            this.lastname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lastname.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastname.ForeColor = System.Drawing.Color.Black;
            this.lastname.Location = new System.Drawing.Point(162, 598);
            this.lastname.Name = "lastname";
            this.lastname.ReadOnly = true;
            this.lastname.Size = new System.Drawing.Size(687, 109);
            this.lastname.TabIndex = 2;
            this.lastname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // firstname
            // 
            this.firstname.BackColor = System.Drawing.SystemColors.Control;
            this.firstname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.firstname.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstname.ForeColor = System.Drawing.Color.Black;
            this.firstname.Location = new System.Drawing.Point(162, 431);
            this.firstname.Name = "firstname";
            this.firstname.ReadOnly = true;
            this.firstname.Size = new System.Drawing.Size(687, 109);
            this.firstname.TabIndex = 1;
            this.firstname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(419, 190);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 147);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hi";
            // 
            // Form9
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(192F, 192F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(2688, 1336);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form9";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox firstname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox lastname;
    }
}