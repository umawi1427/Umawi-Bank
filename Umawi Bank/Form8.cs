using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace Umawi_Bank
{
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }
        private void Form8_Load(object sender, EventArgs e)
        {
            string connectionString = @"Server=tcp:umawibank.database.windows.net,1433;Initial Catalog=bank;Persist Security Info=False;User ID=umawi1427;Password=Hamza-1427;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
            string query = "SELECT senderemail AS Email, senderid AS ID, sentdate AS Date, messagecontent AS Message FROM messages";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable messagesTable = new DataTable();
                try
                {
                    conn.Open();
                    adapter.Fill(messagesTable);
                    conn.Close();
                    tableLayoutPanelMessages.Controls.Clear();
                    tableLayoutPanelMessages.ColumnCount = 4;
                    tableLayoutPanelMessages.ColumnStyles.Clear();
                    tableLayoutPanelMessages.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25f));
                    tableLayoutPanelMessages.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15f));
                    tableLayoutPanelMessages.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20f));
                    tableLayoutPanelMessages.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40f));
                    foreach (DataRow row in messagesTable.Rows)
                    {
                        Label emailLabel = new Label { Text = row["Email"].ToString(), AutoSize = true };
                        Label idLabel = new Label { Text = row["ID"].ToString(), AutoSize = true };
                        Label dateLabel = new Label { Text = row["Date"].ToString(), AutoSize = true };
                        Label messageLabel = new Label { Text = row["Message"].ToString(), AutoSize = true };
                        tableLayoutPanelMessages.RowCount++;
                        tableLayoutPanelMessages.RowStyles.Add(new RowStyle(SizeType.AutoSize));
                        tableLayoutPanelMessages.Controls.Add(emailLabel, 0, tableLayoutPanelMessages.RowCount - 1);
                        tableLayoutPanelMessages.Controls.Add(idLabel, 1, tableLayoutPanelMessages.RowCount - 1);
                        tableLayoutPanelMessages.Controls.Add(dateLabel, 2, tableLayoutPanelMessages.RowCount - 1);
                        tableLayoutPanelMessages.Controls.Add(messageLabel, 3, tableLayoutPanelMessages.RowCount - 1);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading messages: " + ex.Message);
                }
            }
        }
    }
}