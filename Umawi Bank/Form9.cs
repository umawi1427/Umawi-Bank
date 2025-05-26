using System;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace Umawi_Bank
{
    public partial class Form9 : Form
    {
        public Form9()
        {
        InitializeComponent();
        string userId = Form1.LoggedInUserId;
        LoadUserData(userId);
        }
        private void LoadUserData(string userId)
        {
        SqlConnection conn = new SqlConnection(@"Server=tcp:umawibank.database.windows.net,1433;Initial Catalog=bank;Persist Security Info=False;User ID=umawi1427;Password=Hamza-1427;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
            try
            {
                conn.Open();
                string query = "SELECT * FROM signup WHERE id = @id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", userId);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    firstname.Text = reader["firstname"].ToString();
                    lastname.Text = reader["surname"].ToString();
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
    }
}