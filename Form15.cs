using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
namespace Umawi_Bank
{
    public partial class Form15 : Form
    {
        private string userId;

        public Form15()
        {
            InitializeComponent();
            userId = Form1.LoggedInUserId;
            ShowTotalBalanceInUSD();
        }
        private void ShowTotalBalanceInUSD()
        {
            string connectionString = @"Server=tcp:umawibank.database.windows.net,1433;Initial Catalog=bank;Persist Security Info=False;User ID=umawi1427;Password=Hamza-1427;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
            string query = @"SELECT currency, ISNULL(balance, 0.0) AS balance FROM accounts WHERE userid = @userid";
            decimal totalUSD = 0m;
            var conversionRates = new System.Collections.Generic.Dictionary<string, decimal>(StringComparer.OrdinalIgnoreCase)
            {
                { "USD", 1m },
                { "EUR", 1.10m },
                { "TRY", 0.054m },
                { "SAR", 0.27m },
                { "GBP", 1.25m }
            };
            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@userid", userId);
                conn.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string currency = reader["currency"].ToString();
                        decimal balance = Convert.ToDecimal(reader["balance"]);

                        decimal rate = conversionRates[currency];
                        totalUSD += balance * rate;
                    }
                }
            }
            Label lblTotal = new Label();
            lblTotal.Text = $"Total Balance in USD: {totalUSD:N2}";
            lblTotal.Font = new Font("Segoe UI", 18, FontStyle.Bold);
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(30, 30);
            this.Controls.Add(lblTotal);
        }
    }
}
