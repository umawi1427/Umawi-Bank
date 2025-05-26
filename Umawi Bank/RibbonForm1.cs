using DevExpress.Utils;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
namespace Umawi_Bank
{
    public partial class RibbonForm1 : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private string userId;
        public RibbonForm1()
        {
            InitializeComponent();
            this.Load += RibbonForm1_Load;
            DevExpress.Skins.SkinManager.EnableFormSkins();
            DevExpress.LookAndFeel.UserLookAndFeel.Default.SkinName = "Office 2019 Colorful";
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow;
            ribbon.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2019;
            ribbon.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            ribbon.ShowToolbarCustomizeItem = false;
            ribbon.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden;
        }
        private void RibbonForm1_Load(object sender, EventArgs e)
        {
            Form9 form9 = new Form9();
            form9.MdiParent = this;
            form9.ForeColor = Color.Black;
            form9.Show();
        }
        private void profileinformation_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form5 info = new Form5();
            info.MdiParent = this;
            info.ForeColor = Color.Black;
            info.Show();
        }
        private void editprofile_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form6 edit = new Form6();
            edit.MdiParent = this;
            edit.ForeColor = Color.Black;
            edit.Show();
        }
        private void deletemybankaccount_ItemClick(object sender, ItemClickEventArgs e)
        {
            var confirmResult = MessageBox.Show("Are you sure you want to delete your account? This action cannot be undone.", "Confirm Delete", MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                userId = Form1.LoggedInUserId;
                DeleteUserAccount(userId);
            }
        }
        private void DeleteUserAccount(string userId)
        {
            if (string.IsNullOrEmpty(userId))
            {
                MessageBox.Show("Error: No user is logged in.");
                return;
            }
            SqlConnection conn = new SqlConnection(@"Server=tcp:umawibank.database.windows.net,1433;Initial Catalog=bank;Persist Security Info=False;User ID=umawi1427;Password=Hamza-1427;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
            try
            {
                conn.Open();
                string deleteTransactions = @"
            DELETE FROM transactions 
            WHERE accountid IN (SELECT accountid FROM accounts WHERE userid = @id)";
                SqlCommand cmdTransactions = new SqlCommand(deleteTransactions, conn);
                cmdTransactions.Parameters.AddWithValue("@id", userId);
                cmdTransactions.ExecuteNonQuery();
                string deleteMessages = @"
            DELETE FROM messages 
            WHERE senderid = @id";
                SqlCommand cmdMessages = new SqlCommand(deleteMessages, conn);
                cmdMessages.Parameters.AddWithValue("@id", userId);
                cmdMessages.ExecuteNonQuery();
                string deleteAccounts = @"
            DELETE FROM accounts 
            WHERE userid = @id";
                SqlCommand cmdAccounts = new SqlCommand(deleteAccounts, conn);
                cmdAccounts.Parameters.AddWithValue("@id", userId);
                cmdAccounts.ExecuteNonQuery();
                string deleteSignup = @"
            DELETE FROM signup 
            WHERE id = @id";
                SqlCommand cmdSignup = new SqlCommand(deleteSignup, conn);
                cmdSignup.Parameters.AddWithValue("@id", userId);
                int rowsAffected = cmdSignup.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Your account and all related data have been successfully deleted.");
                    this.Close();
                    Form1.LoggedInUserId = null;
                    Form4 loginForm = new Form4();
                    loginForm.ShowDialog();
                    Application.Exit();
                }
                else
                {
                    MessageBox.Show("Error: Account deletion failed.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
        private void logoutbutton_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form1.LoggedInUserId = null;
            Form4 loginForm = new Form4();
            this.Hide();
            loginForm.ShowDialog();
            this.Close();
        }
        private void sendmessage_ItemClick(object sender, ItemClickEventArgs e)
        {
            string userId = Form1.LoggedInUserId;
            if (userId == "36653349548")
            {
                Form8 form8 = new Form8();
                form8.MdiParent = this;
                form8.Show();
            }
            else
            {
                Form7 form7 = new Form7();
                form7.ShowDialog();
            }
        }
        private void createaccount_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form10 form10 = new Form10();
            form10.MdiParent = this;
            form10.ForeColor = Color.Black;
            form10.Show();
        }
        private void viewaccounts_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form11 form11 = new Form11();
            form11.MdiParent = this;
            form11.ForeColor = Color.Black;
            form11.Show();
        }
        private void deleteaccount_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form12 form12 = new Form12();
            form12.MdiParent = this;
            form12.ForeColor = Color.Black;
            form12.Show();
        }
        private void copyaccountinformation_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form13 form13 = new Form13();
            form13.MdiParent = this;
            form13.ForeColor = Color.Black;
            form13.Show();
        }
        private void individual_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form14 form14 = new Form14();
            form14.MdiParent = this;
            form14.ForeColor = Color.Black;
            form14.Show();
        }
        private void general_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form15 form15 = new Form15();
            form15.MdiParent = this;
            form15.ForeColor = Color.Black;
            form15.Show();
        }
        private void bankstatement_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form16 form16 = new Form16();
            form16.MdiParent = this;
            form16.ForeColor = Color.Black;
            form16.Show();
        }
        private void transfermoney_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form17 form17 = new Form17();
            form17.MdiParent = this;
            form17.ForeColor = Color.Black;
            form17.Show();
        }
        private void buyforeigncurrency_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form18 form18 = new Form18();
            form18.MdiParent = this;
            form18.ForeColor = Color.Black;
            form18.Show();
        }
        private void transactionhistory_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form19 form19 = new Form19();
            form19.MdiParent = this;
            form19.ForeColor = Color.Black;
            form19.Show();
        }
    }
}