using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
namespace Umawi_Bank
{
    public partial class Form14 : Form
    {
        private string userId;

        public Form14()
        {
            InitializeComponent();
            userId = Form1.LoggedInUserId;
            LoadAccountInfo();
        }
        private void LoadAccountInfo()
        {
            string connectionString = @"Server=tcp:umawibank.database.windows.net,1433;Initial Catalog=bank;Persist Security Info=False;User ID=umawi1427;Password=Hamza-1427;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
            string query = @"SELECT accountid, accountname, currency, ISNULL(balance, 0.0) AS balance FROM accounts WHERE userid = @userid";
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
                            string accountName = reader["accountname"].ToString();
                            string currency = reader["currency"].ToString();
                            decimal balance = Convert.ToDecimal(reader["balance"]);
                            Panel panel = new Panel();
                            panel.Width = 2600;
                            panel.Height = 120;
                            panel.Left = 20;
                            panel.Top = yOffset;
                            panel.BorderStyle = BorderStyle.FixedSingle;
                            panel.BackColor = Color.AliceBlue;
                            Label lbl = new Label();
                            lbl.Text = $"Account Name: {accountName} | Account ID: {accountId} | Currency: {currency} | Balance: {balance:N2}";
                            lbl.Width = 2550;
                            lbl.Height = 100;
                            lbl.Location = new Point(20, 10);
                            lbl.Font = new Font("Segoe UI", 12, FontStyle.Regular);
                            panel.Controls.Add(lbl);
                            this.Controls.Add(panel);
                            yOffset += 140;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading accounts: " + ex.Message);
                }
            }
        }
    }
}