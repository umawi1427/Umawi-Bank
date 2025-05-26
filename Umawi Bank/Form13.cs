using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
namespace Umawi_Bank
{
    public partial class Form13 : Form
    {
        private string userId;
        public Form13()
        {
            InitializeComponent();
            userId = Form1.LoggedInUserId;
            LoadAccountData();
        }
        private void LoadAccountData()
        {
            string connectionString = @"Server=tcp:umawibank.database.windows.net,1433;Initial Catalog=bank;Persist Security Info=False;User ID=umawi1427;Password=Hamza-1427;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
            string query = @"SELECT accountid, accountname FROM accounts WHERE userid = @userid";
            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@userid", userId);
                try
                {
                    conn.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        int yOffset = 20;
                        while (reader.Read())
                        {
                            string accountId = reader["accountid"].ToString();
                            string name = reader["accountname"].ToString();
                            Panel panel = new Panel();
                            panel.Width = 2600;
                            panel.Height = 100;
                            panel.Left = 20;
                            panel.Top = yOffset;
                            panel.BorderStyle = BorderStyle.FixedSingle;
                            panel.BackColor = Color.WhiteSmoke;
                            Label lbl = new Label();
                            lbl.Text = $"Account Name: {name} | Account ID: {accountId}";
                            lbl.Width = 2300;
                            lbl.Height = 60;
                            lbl.Location = new Point(20, 20);
                            lbl.Font = new Font("Segoe UI", 12, FontStyle.Bold);
                            Button btnCopy = new Button();
                            btnCopy.Text = "Copy";
                            btnCopy.Width = 150;
                            btnCopy.Height = 40;
                            btnCopy.Location = new Point(2400, 30);
                            btnCopy.Tag = lbl.Text;
                            btnCopy.Font = new Font("Segoe UI", 8);
                            btnCopy.Click += (s, e) =>
                            {
                                string textToCopy = (string)((Button)s).Tag;
                                Clipboard.SetText(textToCopy);
                                MessageBox.Show("Copied to clipboard.");
                            };
                            panel.Controls.Add(lbl);
                            panel.Controls.Add(btnCopy);
                            this.Controls.Add(panel);
                            yOffset += 120;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
    }
}