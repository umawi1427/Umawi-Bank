using System.Windows.Forms;
namespace Umawi_Bank
{
    partial class Form4
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

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.loginButton = new System.Windows.Forms.Button();
            this.signupButton = new System.Windows.Forms.Button();
            this.about = new System.Windows.Forms.Button();
            this.contact = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // loginButton
            // 
            this.loginButton.BackColor = System.Drawing.Color.White;
            this.loginButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginButton.Location = new System.Drawing.Point(439, 1356);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(252, 97);
            this.loginButton.TabIndex = 1;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = false;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // signupButton
            // 
            this.signupButton.BackColor = System.Drawing.Color.White;
            this.signupButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signupButton.Location = new System.Drawing.Point(697, 1356);
            this.signupButton.Name = "signupButton";
            this.signupButton.Size = new System.Drawing.Size(289, 97);
            this.signupButton.TabIndex = 2;
            this.signupButton.Text = "Sign Up";
            this.signupButton.UseVisualStyleBackColor = false;
            this.signupButton.Click += new System.EventHandler(this.signupButton_Click);
            // 
            // about
            // 
            this.about.Font = new System.Drawing.Font("Tahoma", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.about.Location = new System.Drawing.Point(12, 1585);
            this.about.Name = "about";
            this.about.Size = new System.Drawing.Size(267, 84);
            this.about.TabIndex = 3;
            this.about.Text = "About Us";
            this.about.UseVisualStyleBackColor = true;
            this.about.Click += new System.EventHandler(this.about_Click);
            // 
            // contact
            // 
            this.contact.Font = new System.Drawing.Font("Tahoma", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contact.Location = new System.Drawing.Point(12, 1500);
            this.contact.Name = "contact";
            this.contact.Size = new System.Drawing.Size(267, 84);
            this.contact.TabIndex = 4;
            this.contact.Text = "Contact Us";
            this.contact.UseVisualStyleBackColor = true;
            this.contact.Click += new System.EventHandler(this.contact_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(192F, 192F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackgroundImageLayoutStore = System.Windows.Forms.ImageLayout.Stretch;
            this.BackgroundImageStore = global::Umawi_Bank.Properties.Resources.welcome;
            this.ClientSize = new System.Drawing.Size(2684, 1472);
            this.Controls.Add(this.contact);
            this.Controls.Add(this.about);
            this.Controls.Add(this.signupButton);
            this.Controls.Add(this.loginButton);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.IconOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("Form4.IconOptions.SvgImage")));
            this.MaximizeBox = false;
            this.Name = "Form4";
            this.Text = "Umawi Bank";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form4_Load);
            this.ResumeLayout(false);

        }
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Button signupButton;
        private Button about;
        private Button contact;
    }
}