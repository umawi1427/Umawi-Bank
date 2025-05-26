using System;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace Umawi_Bank
{
    public partial class Form18 : Form
    {
        string connectionString = @"Server=tcp:umawibank.database.windows.net,1433;Initial Catalog=bank;Persist Security Info=False;User ID=umawi1427;Password=Hamza-1427;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
        public Form18()
        {
            InitializeComponent();
            LoadUserAccounts();
        }
        private void LoadUserAccounts()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(
                    "SELECT accountid, accountname, currency FROM accounts WHERE userid = @userid", conn);
                cmd.Parameters.AddWithValue("@userid", Form1.LoggedInUserId);

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string accountInfo = $"{reader["accountid"]} - {reader["accountname"]} ({reader["currency"]})";
                    cboSenderAccount.Items.Add(accountInfo);
                    cboReceiverAccount.Items.Add(accountInfo);
                }
            }
        }
        private void btnTransfer_Click(object sender, EventArgs e)
        {
            if (cboSenderAccount.SelectedItem == null || cboReceiverAccount.SelectedItem == null)
            {
                MessageBox.Show("Please select both sender and receiver accounts.");
                return;
            }
            string senderInfo = cboSenderAccount.SelectedItem.ToString();
            string receiverInfo = cboReceiverAccount.SelectedItem.ToString();
            decimal amount = numericAmount.Value;
            string senderAccountId = senderInfo.Split('-')[0].Trim();
            string receiverAccountId = receiverInfo.Split('-')[0].Trim();
            string senderCurrency = GetCurrencyFromText(senderInfo);
            string receiverCurrency = GetCurrencyFromText(receiverInfo);
            decimal convertedAmount = amount;
            decimal exchangeRate = 1.0m;
            if (senderCurrency != receiverCurrency)
            {
                exchangeRate = GetExchangeRate(senderCurrency, receiverCurrency);
                convertedAmount = amount * exchangeRate;
            }

            ExecuteTransfer(senderAccountId, receiverAccountId, amount, convertedAmount);
        }
        private string GetCurrencyFromText(string text)
        {
            int start = text.IndexOf('(') + 1;
            int end = text.IndexOf(')');
            return text.Substring(start, end - start);
        }
        private decimal GetExchangeRate(string from, string to)
        {
            var ratesToTRY = new System.Collections.Generic.Dictionary<string, decimal>
            {
                { "EUR", 43.565m },
                { "USD", 38.746m },
                { "SAR", 4.91m },
                { "GBP", 50.231m },
                { "TRY", 1m }
            };
            decimal fromRate = ratesToTRY.ContainsKey(from) ? ratesToTRY[from] : 1m;
            decimal toRate = ratesToTRY.ContainsKey(to) ? ratesToTRY[to] : 1m;

            return fromRate / toRate;
        }
        private void ExecuteTransfer(string senderAccountId, string receiverAccountId, decimal originalAmount, decimal convertedAmount)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlTransaction transaction = conn.BeginTransaction();
                try
                {
                    decimal senderBalance = GetAccountBalance(senderAccountId, conn, transaction);
                    if (senderBalance < originalAmount)
                    {
                        MessageBox.Show("Insufficient balance in sender account.");
                        return;
                    }
                    UpdateAccountBalance(senderAccountId, -originalAmount, conn, transaction);
                    UpdateAccountBalance(receiverAccountId, convertedAmount, conn, transaction);
                    LogTransaction(senderAccountId, -originalAmount, conn, transaction);
                    LogTransaction(receiverAccountId, convertedAmount, conn, transaction);
                    transaction.Commit();
                    MessageBox.Show("Transfer completed successfully.");
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show("Transfer failed: " + ex.Message);
                }
            }
        }
        private decimal GetAccountBalance(string accountId, SqlConnection conn, SqlTransaction transaction)
        {
            SqlCommand cmd = new SqlCommand(
                "SELECT balance FROM accounts WHERE accountid = @accountid", conn, transaction);
            cmd.Parameters.AddWithValue("@accountid", accountId);
            object result = cmd.ExecuteScalar();
            if (result == null || result == DBNull.Value)
                throw new Exception("Account not found or balance not available.");

            return Convert.ToDecimal(result);
        }
        private void UpdateAccountBalance(string accountId, decimal amount, SqlConnection conn, SqlTransaction transaction)
        {
            SqlCommand cmd = new SqlCommand(
                "UPDATE accounts SET balance = balance + @amount WHERE accountid = @accountid", conn, transaction);
            cmd.Parameters.AddWithValue("@amount", amount);
            cmd.Parameters.AddWithValue("@accountid", accountId);
            cmd.ExecuteNonQuery();
        }
        private void LogTransaction(string accountId, decimal amount, SqlConnection conn, SqlTransaction transaction)
        {
            string transactionId = Guid.NewGuid().ToString();
            SqlCommand cmd = new SqlCommand(
                "INSERT INTO transactions (transactionid, accountid, transactiondate, amount, transactiontype) " +
                "VALUES (@transactionid, @accountid, @transactiondate, @amount, @transactiontype)", conn, transaction);
            cmd.Parameters.AddWithValue("@transactionid", transactionId);
            cmd.Parameters.AddWithValue("@accountid", accountId);
            cmd.Parameters.AddWithValue("@transactiondate", DateTime.Now);
            cmd.Parameters.AddWithValue("@amount", amount);
            cmd.Parameters.AddWithValue("@transactiontype", amount > 0 ? "Credit" : "Debit");
            cmd.ExecuteNonQuery();
        }
    }
}