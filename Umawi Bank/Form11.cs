using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Drawing;
namespace Umawi_Bank
{
    public partial class Form11 : Form
    {
        private string userId;
        public Form11()
        {
            InitializeComponent();
            userId = Form1.LoggedInUserId;
            LoadAccountData();
        }
        private void LoadAccountData()
        {
            string connectionString = @"Server=tcp:umawibank.database.windows.net,1433;Initial Catalog=bank;Persist Security Info=False;User ID=umawi1427;Password=Hamza-1427;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
            string query = @"SELECT accountid, accountname, currency, ISNULL(balance, 0.0) AS balance, accountcreatedon FROM accounts WHERE userid = @userid";
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
                            string currency = reader["currency"].ToString();
                            decimal balance = Convert.ToDecimal(reader["balance"]);
                            DateTime createdOn = Convert.ToDateTime(reader["accountcreatedon"]);
                            Panel panel = new Panel();
                            panel.Width = 2600;
                            panel.Height = 100;
                            panel.Left = 20;
                            panel.Top = yOffset;
                            panel.BorderStyle = BorderStyle.FixedSingle;
                            panel.BackColor = Color.WhiteSmoke;
                            Label lbl = new Label();
                            lbl.Text = $"Account ID: {accountId}    |    Name: {name}    |    Currency: {currency}    |    Balance: {balance}    |    Created On: {createdOn:yyyy-MM-dd}";
                            lbl.Width = 2500;
                            lbl.Height = 60;
                            lbl.Font = new Font("Segoe UI", 12, FontStyle.Bold);
                            lbl.Location = new Point(20, 20);
                            panel.Controls.Add(lbl);
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