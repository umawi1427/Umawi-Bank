using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
namespace Umawi_Bank
{
    public partial class Form12 : Form
    {
        private string userId;
        public Form12()
        {
            InitializeComponent();
            userId = Form1.LoggedInUserId;
            LoadAccounts();
        }
        private void LoadAccounts()
        {
            string connectionString = @"Server=tcp:umawibank.database.windows.net,1433;Initial Catalog=bank;Persist Security Info=False;User ID=umawi1427;Password=Hamza-1427;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
            string query = "SELECT accountid, accountname FROM accounts WHERE userid = @userid";
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
                            Panel panel = new Panel();
                            panel.Width = 2600;
                            panel.Height = 100;
                            panel.Left = 20;
                            panel.Top = yOffset;
                            panel.BorderStyle = BorderStyle.FixedSingle;
                            panel.BackColor = Color.MistyRose;
                            Label lbl = new Label();
                            lbl.Text = $"Account Name: {accountName} | Account ID: {accountId}";
                            lbl.Width = 2300;
                            lbl.Height = 60;
                            lbl.Location = new Point(20, 20);
                            lbl.Font = new Font("Segoe UI", 12, FontStyle.Bold);
                            Button btnDelete = new Button();
                            btnDelete.Text = "Delete";
                            btnDelete.Width = 150;
                            btnDelete.Height = 40;
                            btnDelete.Location = new Point(2400, 30);
                            btnDelete.Font = new Font("Segoe UI", 10);
                            btnDelete.Tag = accountId;
                            btnDelete.Click += BtnDelete_Click;
                            panel.Controls.Add(lbl);
                            panel.Controls.Add(btnDelete);
                            this.Controls.Add(panel);
                            yOffset += 120;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading accounts: " + ex.Message);
                }
            }
        }
        private void BtnDelete_Click(object sender, EventArgs e)
        {
            string accountId = (string)((Button)sender).Tag;
            var confirm = MessageBox.Show("Are you sure you want to delete this account and its transactions?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirm == DialogResult.Yes)
            {
            string connectionString = @"Server=tcp:umawibank.database.windows.net,1433;Initial Catalog=bank;Persist Security Info=False;User ID=umawi1427;Password=Hamza-1427;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlTransaction transaction = conn.BeginTransaction();
                    try
                    {
                        SqlCommand deleteTransactions = new SqlCommand("DELETE FROM transactions WHERE accountid = @accountid", conn, transaction);
                        deleteTransactions.Parameters.AddWithValue("@accountid", accountId);
                        deleteTransactions.ExecuteNonQuery();
                        SqlCommand deleteAccount = new SqlCommand("DELETE FROM accounts WHERE accountid = @accountid", conn, transaction);
                        deleteAccount.Parameters.AddWithValue("@accountid", accountId);
                        deleteAccount.ExecuteNonQuery();
                        transaction.Commit();
                        MessageBox.Show("Account and its transactions deleted successfully.");
                        this.Controls.Clear();
                        InitializeComponent();
                        LoadAccounts();
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        MessageBox.Show("Error deleting account: " + ex.Message);
                    }
                }
            }
        }
    }
}