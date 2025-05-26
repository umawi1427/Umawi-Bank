using System;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
namespace Umawi_Bank
{
    public partial class Form16 : Form
    {
        private string userId;
        public Form16()
        {
            InitializeComponent();
            userId = Form1.LoggedInUserId;
            SetupDataGridView();
            LoadAccounts();
        }
        private DataGridView dgvAccounts;
        private void SetupDataGridView()
        {
            dgvAccounts = new DataGridView
            {
                Dock = DockStyle.Fill,
                AllowUserToAddRows = false,
                ReadOnly = true,
                AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill,
                RowTemplate = { Height = 100 },
                Font = new System.Drawing.Font("Segoe UI", 24),
                ColumnHeadersDefaultCellStyle = new DataGridViewCellStyle
                {
                    Font = new System.Drawing.Font("Segoe UI", 26, FontStyle.Bold),
                    Alignment = DataGridViewContentAlignment.MiddleCenter,
                    BackColor = Color.LightGray
                },
                DefaultCellStyle = new DataGridViewCellStyle
                {
                    Alignment = DataGridViewContentAlignment.MiddleLeft,
                    Padding = new Padding(10)
                }
            };
            dgvAccounts.Columns.Add("accountid", "Account ID");
            dgvAccounts.Columns.Add("accountname", "Account Name");
            dgvAccounts.Columns.Add("createdon", "Created On");
            DataGridViewButtonColumn btnColumn = new DataGridViewButtonColumn
            {
                Name = "createStatement",
                HeaderText = "Create Bank Statement",
                Text = "Create",
                UseColumnTextForButtonValue = true,
                Width = 400
            };
            dgvAccounts.Columns.Add(btnColumn);
            dgvAccounts.CellClick += DgvAccounts_CellClick;
            this.Controls.Add(dgvAccounts);
        }
        private void LoadAccounts()
        {
            string connectionString = @"Server=tcp:umawibank.database.windows.net,1433;Initial Catalog=bank;Persist Security Info=False;User ID=umawi1427;Password=Hamza-1427;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
            string query = "SELECT accountid, accountname, accountcreatedon FROM accounts WHERE userid = @userid";
            dgvAccounts.Rows.Clear();
            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@userid", userId);
                conn.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        dgvAccounts.Rows.Add(
                            reader["accountid"].ToString(),
                            reader["accountname"].ToString(),
                            Convert.ToDateTime(reader["accountcreatedon"]).ToShortDateString()
                        );
                    }
                }
            }
        }
        private void DgvAccounts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            if (dgvAccounts.Columns[e.ColumnIndex].Name == "createStatement")
            {
                string accountId = dgvAccounts.Rows[e.RowIndex].Cells["accountid"].Value.ToString();
                GenerateBankStatement(accountId);
            }
        }
        private void GenerateBankStatement(string accountId)
        {
            string connectionString = @"Server=tcp:umawibank.database.windows.net,1433;Initial Catalog=bank;Persist Security Info=False;User ID=umawi1427;Password=Hamza-1427;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
            string userQuery = "SELECT firstname, surname, email FROM signup WHERE id = @userid";
            string accountQuery = "SELECT accountname, accountid, currency, ISNULL(balance, 0.0) AS balance, accountcreatedon FROM accounts WHERE accountid = @accountid AND userid = @userid";
            string firstname = "", surname = "", email = "";
            string accountName = "", accId = "", currency = "";
            decimal balance = 0m;
            DateTime createdOn = DateTime.MinValue;
            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand userCmd = new SqlCommand(userQuery, conn))
            using (SqlCommand accCmd = new SqlCommand(accountQuery, conn))
            {
                userCmd.Parameters.AddWithValue("@userid", userId);
                accCmd.Parameters.AddWithValue("@userid", userId);
                accCmd.Parameters.AddWithValue("@accountid", accountId);
                conn.Open();
                using (SqlDataReader reader = userCmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        firstname = reader["firstname"].ToString();
                        surname = reader["surname"].ToString();
                        email = reader["email"].ToString();
                    }
                }
                using (SqlDataReader reader = accCmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        accountName = reader["accountname"].ToString();
                        accId = reader["accountid"].ToString();
                        currency = reader["currency"].ToString();
                        balance = Convert.ToDecimal(reader["balance"]);
                        createdOn = Convert.ToDateTime(reader["accountcreatedon"]);
                    }
                }
            }
            using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "PDF file|*.pdf", FileName = "BankStatement.pdf" })
            {
                if (sfd.ShowDialog() != DialogResult.OK)
                    return;
                Document doc = new Document(PageSize.A4);
                PdfWriter writer = PdfWriter.GetInstance(doc, new FileStream(sfd.FileName, FileMode.Create));
                doc.Open();
                var titleFont = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 18);
                var labelFont = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 12);
                var normalFont = FontFactory.GetFont(FontFactory.HELVETICA, 12);
                Paragraph title = new Paragraph("Bank Statement", titleFont)
                {
                    Alignment = Element.ALIGN_CENTER
                };
                doc.Add(title);
                doc.Add(new Paragraph(" "));
                PdfPTable userTable = new PdfPTable(2) { WidthPercentage = 80 };
                userTable.HorizontalAlignment = Element.ALIGN_CENTER;
                userTable.SetWidths(new float[] { 1f, 2f });
                userTable.AddCell(new PdfPCell(new Phrase("User Firstname:", labelFont)) { Border = 0 });
                userTable.AddCell(new PdfPCell(new Phrase(firstname, normalFont)) { Border = 0 });
                userTable.AddCell(new PdfPCell(new Phrase("User Surname:", labelFont)) { Border = 0 });
                userTable.AddCell(new PdfPCell(new Phrase(surname, normalFont)) { Border = 0 });
                userTable.AddCell(new PdfPCell(new Phrase("Email:", labelFont)) { Border = 0 });
                userTable.AddCell(new PdfPCell(new Phrase(email, normalFont)) { Border = 0 });
                doc.Add(userTable);
                doc.Add(new Paragraph(" "));
                PdfPTable accTable = new PdfPTable(2) { WidthPercentage = 80 };
                accTable.HorizontalAlignment = Element.ALIGN_CENTER;
                accTable.SetWidths(new float[] { 1f, 2f });
                accTable.AddCell(new PdfPCell(new Phrase("Account Name:", labelFont)) { Border = 0 });
                accTable.AddCell(new PdfPCell(new Phrase(accountName, normalFont)) { Border = 0 });
                accTable.AddCell(new PdfPCell(new Phrase("Account ID:", labelFont)) { Border = 0 });
                accTable.AddCell(new PdfPCell(new Phrase(accId, normalFont)) { Border = 0 });
                accTable.AddCell(new PdfPCell(new Phrase("Currency:", labelFont)) { Border = 0 });
                accTable.AddCell(new PdfPCell(new Phrase(currency, normalFont)) { Border = 0 });
                accTable.AddCell(new PdfPCell(new Phrase("Balance:", labelFont)) { Border = 0 });
                accTable.AddCell(new PdfPCell(new Phrase(balance.ToString("N2"), normalFont)) { Border = 0 });
                accTable.AddCell(new PdfPCell(new Phrase("Created On:", labelFont)) { Border = 0 });
                accTable.AddCell(new PdfPCell(new Phrase(createdOn.ToShortDateString(), normalFont)) { Border = 0 });
                doc.Add(accTable);
                doc.Add(new Paragraph(" "));
                Paragraph footer = new Paragraph("Bank Manager: HAMZAH KOURDIEH\n\nE-signature: Umawi Bank", normalFont)
                {
                    Alignment = Element.ALIGN_CENTER
                };
                doc.Add(footer);
                doc.Close();
                MessageBox.Show("Bank statement saved successfully.");
            }
        }
    }
}