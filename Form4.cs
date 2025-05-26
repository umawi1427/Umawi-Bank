using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Umawi_Bank
{
    public partial class Form4 : DevExpress.XtraEditors.XtraForm
    {
        public Form4()
        {
            InitializeComponent();
        }
        private void loginButton_Click(object sender, EventArgs e)
        {
            Form1 loginForm = new Form1();
            this.Hide();
            loginForm.ShowDialog();
            this.Close();
        }
        private void signupButton_Click(object sender, EventArgs e)
        {
            Form2 signupForm = new Form2();
            this.Hide();
            signupForm.ShowDialog();
            this.Close();
        }
        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void contact_Click(object sender, EventArgs e)
        {
           MessageBox.Show("For any inquiries, please contact us at:\n\nEmail:umawi1427@gmail.com\n\nPhone: +905398791427\n\nWe are here to assist you!");
        }

        private void about_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Umawi Bank is a trusted financial institution committed to delivering secure, innovative, and customer-focused banking solutions. Founded with the vision of empowering individuals and businesses, Umawi Bank combines modern technology with personalized service to meet the evolving needs of our clients.\r\n\r\nOur mission is to provide accessible and reliable banking services that promote financial growth and stability. Whether it’s savings, loans, or investment solutions, we strive to offer exceptional support and value through every stage of our customers’ financial journey.\r\n\r\nAt Umawi Bank, we believe in transparency, integrity, and excellence. Our dedicated team works around the clock to ensure your financial transactions are fast, safe, and seamless.\r\n\r\nUmawi Bank – Your Future, Our Priority.");
        }
    }
}