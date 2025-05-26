using System;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace Umawi_Bank
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }
        private void buttonSend_Click(object sender, EventArgs e)
        {
            string connectionString = @"Server=tcp:umawibank.database.windows.net,1433;Initial Catalog=bank;Persist Security Info=False;User ID=umawi1427;Password=Hamza-1427;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
            string userId = Form1.LoggedInUserId;
            string userEmail = "";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT email FROM signup WHERE id = @id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", userId);
                try
                {
                    conn.Open();
                    object result = cmd.ExecuteScalar();
                    conn.Close();
                    userEmail = result != null ? result.ToString() : "Email not found";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                    return;
                }
            }
            string messageContent = textBoxMessage.Text;
            if (string.IsNullOrEmpty(messageContent))
            {
                MessageBox.Show("Please enter a message.");
                return;
            }
            DateTime sentDate = DateTime.Now;
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string insertQuery = @"INSERT INTO messages (senderid, senderemail, messagecontent, sentdate) 
                                       VALUES (@id, @mail, @content, @date)";
                SqlCommand cmd = new SqlCommand(insertQuery, conn);
                cmd.Parameters.AddWithValue("@id", userId);
                cmd.Parameters.AddWithValue("@mail", userEmail);
                cmd.Parameters.AddWithValue("@content", messageContent);
                cmd.Parameters.AddWithValue("@date", sentDate);
                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Message sent!");
                    textBoxMessage.Clear();
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error sending message: " + ex.Message);
                }
            }
        }
    }
}