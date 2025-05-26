using System;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace Umawi_Bank
{
    public partial class Form17 : Form
    {
        string connectionString = @"Server=tcp:umawibank.database.windows.net,1433;Initial Catalog=bank;Persist Security Info=False;User ID=umawi1427;Password=Hamza-1427;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
        public Form17()
        {
            InitializeComponent();
            LoadSenderAccounts();
        }
        private void LoadSenderAccounts()
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
                    string display = $"{reader["accountid"]} - {reader["accountname"]} ({reader["currency"]})";
                    cboSenderAccount.Items.Add(display);
                }
            }
        }
        private void btnSendMoney_Click(object sender, EventArgs e)
        {
            string recipientFirstName = txtFirstName.Text.Trim();
            string recipientLastName = txtLastName.Text.Trim();
            string recipientAccountId = txtRecipientAccountId.Text.Trim();
            decimal amount;
            if (!decimal.TryParse(txtAmount.Text, out amount) || amount <= 0)
            {
                MessageBox.Show("Please enter a valid amount.");
                return;
            }

            if (cboSenderAccount.SelectedItem == null)
            {
                MessageBox.Show("Please select a sender account.");
                return;
            }
            string selectedSenderInfo = cboSenderAccount.SelectedItem.ToString();
            string senderAccountId = selectedSenderInfo.Split('-')[0].Trim();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlTransaction sqlTran = conn.BeginTransaction();
                try
                {
                    SqlCommand cmdSenderAccount = new SqlCommand(
                        "SELECT balance, currency FROM accounts WHERE accountid = @accountid AND userid = @userid", conn, sqlTran);
                    cmdSenderAccount.Parameters.AddWithValue("@accountid", senderAccountId);
                    cmdSenderAccount.Parameters.AddWithValue("@userid", Form1.LoggedInUserId);
                    SqlDataReader readerSender = cmdSenderAccount.ExecuteReader();
                    if (!readerSender.Read())
                    {
                        MessageBox.Show("Sender account not found.");
                        readerSender.Close();
                        sqlTran.Rollback();
                        return;
                    }
                    decimal senderBalance = readerSender.GetDecimal(0);
                    string senderCurrency = readerSender.GetString(1);
                    readerSender.Close();
                    SqlCommand cmdRecipient = new SqlCommand(
                        @"SELECT a.accountid, a.currency FROM accounts a
                          JOIN signup s ON a.userid = s.id
                          WHERE a.accountid = @recipientId AND s.firstname = @fname AND s.surname = @lname", conn, sqlTran);
                    cmdRecipient.Parameters.AddWithValue("@recipientId", recipientAccountId);
                    cmdRecipient.Parameters.AddWithValue("@fname", recipientFirstName);
                    cmdRecipient.Parameters.AddWithValue("@lname", recipientLastName);
                    SqlDataReader readerRecipient = cmdRecipient.ExecuteReader();
                    if (!readerRecipient.Read())
                    {
                        MessageBox.Show("Recipient account not found or name mismatch.");
                        readerRecipient.Close();
                        sqlTran.Rollback();
                        return;
                    }
                    string recipientCurrency = readerRecipient.GetString(1);
                    readerRecipient.Close();
                    if (senderCurrency != recipientCurrency)
                    {
                        MessageBox.Show("Currency mismatch between accounts.");
                        sqlTran.Rollback();
                        return;
                    }
                    if (senderBalance < amount)
                    {
                        MessageBox.Show("Insufficient balance.");
                        sqlTran.Rollback();
                        return;
                    }
                    SqlCommand cmdDebit = new SqlCommand(
                        "UPDATE accounts SET balance = balance - @amount WHERE accountid = @accountid", conn, sqlTran);
                    cmdDebit.Parameters.AddWithValue("@amount", amount);
                    cmdDebit.Parameters.AddWithValue("@accountid", senderAccountId);
                    cmdDebit.ExecuteNonQuery();
                    SqlCommand cmdCredit = new SqlCommand(
                        "UPDATE accounts SET balance = balance + @amount WHERE accountid = @recipientid", conn, sqlTran);
                    cmdCredit.Parameters.AddWithValue("@amount", amount);
                    cmdCredit.Parameters.AddWithValue("@recipientid", recipientAccountId);
                    cmdCredit.ExecuteNonQuery();
                    string transactionIdSender = Guid.NewGuid().ToString();
                    string transactionIdRecipient = Guid.NewGuid().ToString();
                    DateTime now = DateTime.Now;
                    SqlCommand cmdTransSender = new SqlCommand(
                        @"INSERT INTO transactions (transactionid, accountid, transactiondate, amount, transactiontype)
                          VALUES (@tid, @accid, @date, @amount, 'Debit')", conn, sqlTran);
                    cmdTransSender.Parameters.AddWithValue("@tid", transactionIdSender);
                    cmdTransSender.Parameters.AddWithValue("@accid", senderAccountId);
                    cmdTransSender.Parameters.AddWithValue("@date", now);
                    cmdTransSender.Parameters.AddWithValue("@amount", amount);
                    cmdTransSender.ExecuteNonQuery();
                    SqlCommand cmdTransRecipient = new SqlCommand(
                        @"INSERT INTO transactions (transactionid, accountid, transactiondate, amount, transactiontype)
                          VALUES (@tid, @accid, @date, @amount, 'Credit')", conn, sqlTran);
                    cmdTransRecipient.Parameters.AddWithValue("@tid", transactionIdRecipient);
                    cmdTransRecipient.Parameters.AddWithValue("@accid", recipientAccountId);
                    cmdTransRecipient.Parameters.AddWithValue("@date", now);
                    cmdTransRecipient.Parameters.AddWithValue("@amount", amount);
                    cmdTransRecipient.ExecuteNonQuery();
                    sqlTran.Commit();
                    MessageBox.Show("Transfer successful!");
                }
                catch (Exception ex)
                {
                    sqlTran.Rollback();
                    MessageBox.Show("Transfer failed: " + ex.Message);
                }
            }
        }
    }
}