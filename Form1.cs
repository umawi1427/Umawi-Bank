using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
namespace Umawi_Bank
{
    public partial class Form1 : DevExpress.XtraEditors.XtraForm
    {
        public static string LoggedInUserId;
        SqlConnection conn = new SqlConnection(@"Server=tcp:umawibank.database.windows.net,1433;Initial Catalog=bank;Persist Security Info=False;User ID=umawi1427;Password=Hamza-1427;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
        public Form1()
        {
            InitializeComponent();
            button2.Click += new EventHandler(loginButton_Click);
            button3.Click += new EventHandler(openSignupForm);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            button1.Click += (s, args) =>
            {
                Form3 resetForm = new Form3();
                resetForm.ShowDialog();
            };
        }
        private void loginButton_Click(object sender, EventArgs e)
        {
            string id = textBox1.Text;
            string password = textBox2.Text;

            if (string.IsNullOrEmpty(id) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter both ID and password.", "Login Error");
                return;
            }
            string query = "SELECT COUNT(*) FROM signup WHERE id = @id AND password = @password";
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@password", password);
                try
                {
                    conn.Open();
                    int userExists = (int)cmd.ExecuteScalar();
                    conn.Close();

                    if (userExists > 0)
                    {
                        LoggedInUserId = id;
                        RibbonForm1 mainForm = new RibbonForm1();
                        this.Hide();
                        mainForm.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Invalid ID or password.", "Login Error");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message, "Database Error");
                }
            }
        }
        private void openSignupForm(object sender, EventArgs e)
        {
            Form2 signupForm = new Form2();
            this.Hide();
            signupForm.ShowDialog();
            this.Close();
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            textBox2.UseSystemPasswordChar = !checkBox1.Checked;
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}