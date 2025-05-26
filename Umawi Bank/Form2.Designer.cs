using System.Windows.Forms;
namespace Umawi_Bank
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.birthcountryComboBox = new System.Windows.Forms.ComboBox();
            this.countryCodeComboBox = new System.Windows.Forms.ComboBox();
            this.phonenumber = new System.Windows.Forms.TextBox();
            this.phonenumberlabel = new System.Windows.Forms.Label();
            this.birthcountrylabel = new System.Windows.Forms.Label();
            this.birthdatePicker = new System.Windows.Forms.DateTimePicker();
            this.birthdatelabel = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.TextBox();
            this.emaillabel = new System.Windows.Forms.Label();
            this.surname = new System.Windows.Forms.TextBox();
            this.surnamelabel = new System.Windows.Forms.Label();
            this.firstname = new System.Windows.Forms.TextBox();
            this.firstnamelabel = new System.Windows.Forms.Label();
            this.hidepassword = new System.Windows.Forms.CheckBox();
            this.loginnavigator = new System.Windows.Forms.Button();
            this.signupbutton = new System.Windows.Forms.Button();
            this.password = new System.Windows.Forms.TextBox();
            this.idnumber = new System.Windows.Forms.TextBox();
            this.passwordlabel = new System.Windows.Forms.Label();
            this.idnumberlabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // birthcountryComboBox
            // 
            this.birthcountryComboBox.Font = new System.Drawing.Font("Tahoma", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.birthcountryComboBox.FormattingEnabled = true;
            this.birthcountryComboBox.Location = new System.Drawing.Point(734, 868);
            this.birthcountryComboBox.Name = "birthcountryComboBox";
            this.birthcountryComboBox.Size = new System.Drawing.Size(400, 60);
            this.birthcountryComboBox.TabIndex = 2;
            // 
            // countryCodeComboBox
            // 
            this.countryCodeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.countryCodeComboBox.Font = new System.Drawing.Font("Tahoma", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countryCodeComboBox.FormattingEnabled = true;
            this.countryCodeComboBox.Location = new System.Drawing.Point(734, 996);
            this.countryCodeComboBox.Name = "countryCodeComboBox";
            this.countryCodeComboBox.Size = new System.Drawing.Size(163, 60);
            this.countryCodeComboBox.TabIndex = 19;
            // 
            // phonenumber
            // 
            this.phonenumber.Font = new System.Drawing.Font("Tahoma", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phonenumber.Location = new System.Drawing.Point(903, 996);
            this.phonenumber.Name = "phonenumber";
            this.phonenumber.Size = new System.Drawing.Size(231, 59);
            this.phonenumber.TabIndex = 20;
            // 
            // phonenumberlabel
            // 
            this.phonenumberlabel.AutoSize = true;
            this.phonenumberlabel.BackColor = System.Drawing.Color.Transparent;
            this.phonenumberlabel.Font = new System.Drawing.Font("Tahoma", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phonenumberlabel.Location = new System.Drawing.Point(208, 996);
            this.phonenumberlabel.Name = "phonenumberlabel";
            this.phonenumberlabel.Size = new System.Drawing.Size(305, 52);
            this.phonenumberlabel.TabIndex = 18;
            this.phonenumberlabel.Text = "Phone Number";
            // 
            // birthcountrylabel
            // 
            this.birthcountrylabel.AutoSize = true;
            this.birthcountrylabel.BackColor = System.Drawing.Color.Transparent;
            this.birthcountrylabel.Font = new System.Drawing.Font("Tahoma", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.birthcountrylabel.Location = new System.Drawing.Point(204, 868);
            this.birthcountrylabel.Name = "birthcountrylabel";
            this.birthcountrylabel.Size = new System.Drawing.Size(272, 52);
            this.birthcountrylabel.TabIndex = 16;
            this.birthcountrylabel.Text = "Birth Country";
            // 
            // birthdatePicker
            // 
            this.birthdatePicker.Font = new System.Drawing.Font("Tahoma", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.birthdatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.birthdatePicker.Location = new System.Drawing.Point(734, 734);
            this.birthdatePicker.Name = "birthdatePicker";
            this.birthdatePicker.Size = new System.Drawing.Size(400, 59);
            this.birthdatePicker.TabIndex = 15;
            // 
            // birthdatelabel
            // 
            this.birthdatelabel.AutoSize = true;
            this.birthdatelabel.BackColor = System.Drawing.Color.Transparent;
            this.birthdatelabel.Font = new System.Drawing.Font("Tahoma", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.birthdatelabel.Location = new System.Drawing.Point(200, 734);
            this.birthdatelabel.Name = "birthdatelabel";
            this.birthdatelabel.Size = new System.Drawing.Size(213, 52);
            this.birthdatelabel.TabIndex = 14;
            this.birthdatelabel.Text = "Birth Date";
            // 
            // email
            // 
            this.email.Font = new System.Drawing.Font("Tahoma", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email.Location = new System.Drawing.Point(734, 600);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(400, 59);
            this.email.TabIndex = 13;
            // 
            // emaillabel
            // 
            this.emaillabel.AutoSize = true;
            this.emaillabel.BackColor = System.Drawing.Color.Transparent;
            this.emaillabel.Font = new System.Drawing.Font("Tahoma", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emaillabel.Location = new System.Drawing.Point(200, 600);
            this.emaillabel.Name = "emaillabel";
            this.emaillabel.Size = new System.Drawing.Size(125, 52);
            this.emaillabel.TabIndex = 12;
            this.emaillabel.Text = "Email";
            // 
            // surname
            // 
            this.surname.Font = new System.Drawing.Font("Tahoma", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.surname.Location = new System.Drawing.Point(734, 482);
            this.surname.Name = "surname";
            this.surname.Size = new System.Drawing.Size(400, 59);
            this.surname.TabIndex = 11;
            // 
            // surnamelabel
            // 
            this.surnamelabel.AutoSize = true;
            this.surnamelabel.BackColor = System.Drawing.Color.Transparent;
            this.surnamelabel.Font = new System.Drawing.Font("Tahoma", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.surnamelabel.Location = new System.Drawing.Point(200, 482);
            this.surnamelabel.Name = "surnamelabel";
            this.surnamelabel.Size = new System.Drawing.Size(192, 52);
            this.surnamelabel.TabIndex = 10;
            this.surnamelabel.Text = "Surname";
            // 
            // firstname
            // 
            this.firstname.Font = new System.Drawing.Font("Tahoma", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstname.Location = new System.Drawing.Point(734, 367);
            this.firstname.Name = "firstname";
            this.firstname.Size = new System.Drawing.Size(400, 59);
            this.firstname.TabIndex = 9;
            // 
            // firstnamelabel
            // 
            this.firstnamelabel.AutoSize = true;
            this.firstnamelabel.BackColor = System.Drawing.Color.Transparent;
            this.firstnamelabel.Font = new System.Drawing.Font("Tahoma", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstnamelabel.Location = new System.Drawing.Point(200, 367);
            this.firstnamelabel.Name = "firstnamelabel";
            this.firstnamelabel.Size = new System.Drawing.Size(227, 52);
            this.firstnamelabel.TabIndex = 8;
            this.firstnamelabel.Text = "First Name";
            // 
            // hidepassword
            // 
            this.hidepassword.AutoSize = true;
            this.hidepassword.Location = new System.Drawing.Point(1100, 1144);
            this.hidepassword.Name = "hidepassword";
            this.hidepassword.Size = new System.Drawing.Size(28, 27);
            this.hidepassword.TabIndex = 7;
            this.hidepassword.UseVisualStyleBackColor = true;
            // 
            // loginnavigator
            // 
            this.loginnavigator.BackColor = System.Drawing.Color.Transparent;
            this.loginnavigator.Font = new System.Drawing.Font("Tahoma", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginnavigator.Location = new System.Drawing.Point(213, 1266);
            this.loginnavigator.Name = "loginnavigator";
            this.loginnavigator.Size = new System.Drawing.Size(667, 85);
            this.loginnavigator.TabIndex = 6;
            this.loginnavigator.Text = "already have account log in";
            this.loginnavigator.UseVisualStyleBackColor = false;
            this.loginnavigator.Click += new System.EventHandler(this.loginnavigator_Click);
            // 
            // signupbutton
            // 
            this.signupbutton.BackColor = System.Drawing.Color.Transparent;
            this.signupbutton.Font = new System.Drawing.Font("Tahoma", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signupbutton.Location = new System.Drawing.Point(936, 1272);
            this.signupbutton.Name = "signupbutton";
            this.signupbutton.Size = new System.Drawing.Size(198, 79);
            this.signupbutton.TabIndex = 5;
            this.signupbutton.Text = "sign up";
            this.signupbutton.UseVisualStyleBackColor = false;
            // 
            // password
            // 
            this.password.Font = new System.Drawing.Font("Tahoma", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password.Location = new System.Drawing.Point(734, 1127);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(400, 59);
            this.password.TabIndex = 3;
            this.password.UseSystemPasswordChar = true;
            // 
            // idnumber
            // 
            this.idnumber.Font = new System.Drawing.Font("Tahoma", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idnumber.Location = new System.Drawing.Point(734, 243);
            this.idnumber.Name = "idnumber";
            this.idnumber.Size = new System.Drawing.Size(400, 59);
            this.idnumber.TabIndex = 2;
            // 
            // passwordlabel
            // 
            this.passwordlabel.AutoSize = true;
            this.passwordlabel.BackColor = System.Drawing.Color.Transparent;
            this.passwordlabel.Font = new System.Drawing.Font("Tahoma", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordlabel.Location = new System.Drawing.Point(211, 1127);
            this.passwordlabel.Name = "passwordlabel";
            this.passwordlabel.Size = new System.Drawing.Size(202, 52);
            this.passwordlabel.TabIndex = 1;
            this.passwordlabel.Text = "Password";
            // 
            // idnumberlabel
            // 
            this.idnumberlabel.AutoSize = true;
            this.idnumberlabel.BackColor = System.Drawing.Color.Transparent;
            this.idnumberlabel.Font = new System.Drawing.Font("Tahoma", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idnumberlabel.Location = new System.Drawing.Point(200, 246);
            this.idnumberlabel.Name = "idnumberlabel";
            this.idnumberlabel.Size = new System.Drawing.Size(232, 52);
            this.idnumberlabel.TabIndex = 0;
            this.idnumberlabel.Text = "ID Number";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(192F, 192F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackgroundImageLayoutStore = System.Windows.Forms.ImageLayout.Stretch;
            this.BackgroundImageStore = global::Umawi_Bank.Properties.Resources.signup;
            this.ClientSize = new System.Drawing.Size(2684, 1472);
            this.Controls.Add(this.signupbutton);
            this.Controls.Add(this.loginnavigator);
            this.Controls.Add(this.hidepassword);
            this.Controls.Add(this.phonenumber);
            this.Controls.Add(this.countryCodeComboBox);
            this.Controls.Add(this.birthcountryComboBox);
            this.Controls.Add(this.password);
            this.Controls.Add(this.passwordlabel);
            this.Controls.Add(this.phonenumberlabel);
            this.Controls.Add(this.idnumberlabel);
            this.Controls.Add(this.idnumber);
            this.Controls.Add(this.firstnamelabel);
            this.Controls.Add(this.birthcountrylabel);
            this.Controls.Add(this.firstname);
            this.Controls.Add(this.birthdatePicker);
            this.Controls.Add(this.surnamelabel);
            this.Controls.Add(this.birthdatelabel);
            this.Controls.Add(this.surname);
            this.Controls.Add(this.email);
            this.Controls.Add(this.emaillabel);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.IconOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("Form2.IconOptions.SvgImage")));
            this.MaximizeBox = false;
            this.Name = "Form2";
            this.Text = "Sign Up";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private Label firstnamelabel;
        private CheckBox hidepassword;
        private Button loginnavigator;
        private Button signupbutton;
        private TextBox password;
        private TextBox idnumber;
        private Label passwordlabel;
        private Label idnumberlabel;
        private TextBox firstname;
        private TextBox email;
        private Label emaillabel;
        private TextBox surname;
        private Label surnamelabel;
        private TextBox phonenumber;
        private Label phonenumberlabel;
        private Label birthcountrylabel;
        private DateTimePicker birthdatePicker;
        private Label birthdatelabel;
        private ComboBox countryCodeComboBox;
        private ComboBox birthcountryComboBox;
    }
}