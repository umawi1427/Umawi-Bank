using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;
namespace Umawi_Bank
{
    public partial class Form19 : Form
    {
        string connectionString = @"Server=tcp:umawibank.database.windows.net,1433;Initial Catalog=bank;Persist Security Info=False;User ID=umawi1427;Password=Hamza-1427;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
        public Form19()
        {
            InitializeComponent();
            dgvAccounts.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular);
            dgvAccounts.RowTemplate.Height = 60;
            dgvAccounts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;

            LoadUserAccounts();
        }
        private void LoadUserAccounts()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(
                        "SELECT accountid, accountname FROM accounts WHERE userid = @userid", conn);
                    cmd.Parameters.AddWithValue("@userid", Form1.LoggedInUserId);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgvAccounts.DataSource = dt;
                    if (!dgvAccounts.Columns.Contains("GeneratePDF"))
                    {
                        DataGridViewButtonColumn btnCol = new DataGridViewButtonColumn();
                        btnCol.HeaderText = "Action";
                        btnCol.Name = "GeneratePDF";
                        btnCol.Text = "Generate PDF";
                        btnCol.UseColumnTextForButtonValue = true;
                        btnCol.Width = 250;
                        dgvAccounts.Columns.Add(btnCol);
                    }
                    dgvAccounts.Columns["accountid"].Width = 800;
                    dgvAccounts.Columns["accountname"].Width = 1100;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading accounts: " + ex.Message);
            }
        }
        private void dgvAccounts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvAccounts.Columns[e.ColumnIndex].Name == "GeneratePDF")
            {
                string accountId = dgvAccounts.Rows[e.RowIndex].Cells["accountid"].Value.ToString();
                string accountName = dgvAccounts.Rows[e.RowIndex].Cells["accountname"].Value.ToString();
                using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.Filter = "PDF files (*.pdf)|*.pdf";
                    saveFileDialog.FileName = $"TransactionHistory_{accountName}_{DateTime.Now:yyyyMMdd}.pdf";
                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        try
                        {
                            GeneratePdfFile(accountId, accountName, saveFileDialog.FileName);
                            MessageBox.Show("PDF saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error generating PDF: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }
        private void GeneratePdfFile(string accountId, string accountName, string savePath)
        {
            DataTable userInfo = new DataTable();
            DataTable transactions = new DataTable();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string userInfoQuery = @"SELECT s.id, s.firstname, s.surname, s.email, s.[phone number] 
                                         FROM signup s
                                         JOIN accounts a ON s.id = a.userid
                                         WHERE a.accountid = @accountId";
                using (SqlCommand cmd = new SqlCommand(userInfoQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@accountId", accountId);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(userInfo);
                }
                string transQuery = @"SELECT transactionid, transactiondate, amount, transactiontype 
                                      FROM transactions WHERE accountid = @accountId
                                      ORDER BY transactiondate DESC";
                using (SqlCommand cmd = new SqlCommand(transQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@accountId", accountId);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(transactions);
                }
            }
            if (userInfo.Rows.Count == 0)
                throw new Exception("User information not found for this account.");
            Document doc = new Document(PageSize.A4, 40, 40, 60, 60);
            PdfWriter.GetInstance(doc, new FileStream(savePath, FileMode.Create));
            doc.Open();
            var titleFont = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 18);
            var headerFont = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 14);
            var normalFont = FontFactory.GetFont(FontFactory.HELVETICA, 12);
            Paragraph title = new Paragraph($"Transaction History for Account: {accountName} ({accountId})", titleFont);
            title.Alignment = Element.ALIGN_CENTER;
            title.SpacingAfter = 20f;
            doc.Add(title);
            DataRow user = userInfo.Rows[0];
            PdfPTable userTable = new PdfPTable(2);
            userTable.WidthPercentage = 80;
            userTable.SetWidths(new float[] { 1, 2 });
            userTable.SpacingAfter = 20f;
            userTable.AddCell(new PdfPCell(new Phrase("User ID:", headerFont)) { Border = 0 });
            userTable.AddCell(new PdfPCell(new Phrase(user["id"].ToString(), normalFont)) { Border = 0 });
            userTable.AddCell(new PdfPCell(new Phrase("First Name:", headerFont)) { Border = 0 });
            userTable.AddCell(new PdfPCell(new Phrase(user["firstname"].ToString(), normalFont)) { Border = 0 });
            userTable.AddCell(new PdfPCell(new Phrase("Last Name:", headerFont)) { Border = 0 });
            userTable.AddCell(new PdfPCell(new Phrase(user["surname"].ToString(), normalFont)) { Border = 0 });
            userTable.AddCell(new PdfPCell(new Phrase("Email:", headerFont)) { Border = 0 });
            userTable.AddCell(new PdfPCell(new Phrase(user["email"].ToString(), normalFont)) { Border = 0 });
            userTable.AddCell(new PdfPCell(new Phrase("Phone Number:", headerFont)) { Border = 0 });
            userTable.AddCell(new PdfPCell(new Phrase(user["phone number"].ToString(), normalFont)) { Border = 0 });
            doc.Add(userTable);
            Paragraph transTitle = new Paragraph("Transactions", headerFont);
            transTitle.SpacingAfter = 10f;
            doc.Add(transTitle);
            PdfPTable transTable = new PdfPTable(4);
            transTable.WidthPercentage = 100;
            transTable.SetWidths(new float[] { 3, 3, 2, 2 });
            transTable.AddCell(new PdfPCell(new Phrase("Transaction ID", headerFont)) { BackgroundColor = BaseColor.LIGHT_GRAY });
            transTable.AddCell(new PdfPCell(new Phrase("Date", headerFont)) { BackgroundColor = BaseColor.LIGHT_GRAY });
            transTable.AddCell(new PdfPCell(new Phrase("Amount", headerFont)) { BackgroundColor = BaseColor.LIGHT_GRAY });
            transTable.AddCell(new PdfPCell(new Phrase("Type", headerFont)) { BackgroundColor = BaseColor.LIGHT_GRAY });
            foreach (DataRow row in transactions.Rows)
            {
                transTable.AddCell(new PdfPCell(new Phrase(row["transactionid"].ToString(), normalFont)));
                DateTime dt = Convert.ToDateTime(row["transactiondate"]);
                transTable.AddCell(new PdfPCell(new Phrase(dt.ToString("yyyy-MM-dd HH:mm:ss"), normalFont)));
                transTable.AddCell(new PdfPCell(new Phrase(string.Format("{0:0.00}", row["amount"]), normalFont)));
                transTable.AddCell(new PdfPCell(new Phrase(row["transactiontype"].ToString(), normalFont)));
            }
            doc.Add(transTable);
            Paragraph sig = new Paragraph("\n\nBank Manager HAMZAH KOURDIEH\nE-signature: umawi bank", normalFont);
            sig.Alignment = Element.ALIGN_CENTER;
            sig.SpacingBefore = 30f;
            doc.Add(sig);

            doc.Close();
        }
    }
}