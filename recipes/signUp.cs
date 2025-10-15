using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace recipes
{
    public partial class signUp : Form
    {
        private SQL sqlManager;

        public signUp()
        {
            InitializeComponent();
            sqlManager = new SQL();

        }

        private void signUp_Load(object sender, EventArgs e)
        {
            passwordtb.UseSystemPasswordChar = true;
            rpasswordtb.UseSystemPasswordChar = true;
           SQL.Connect();
        }
        private void signUp_FormClosing(object sender, EventArgs e)
        {
            SQL.Disconnect();
        }


        private void btn_signUp_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(userNametb.Text) || string.IsNullOrEmpty(passwordtb.Text))
            {
                MessageBox.Show("Lütfen tüm alanları doldurun.", "Eksik Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (passwordtb.Text != rpasswordtb.Text)
            {
                MessageBox.Show("Lütfen şifre tekrarını doğru yazınız.", "Şifre Hatası", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                userNametb.Text = "";
                passwordtb.Text = "";
                rpasswordtb.Text = "";
                return;
            }

            string userName = userNametb.Text.Trim();
            string password = passwordtb.Text.Trim();

            bool success = SQL.SignUp(userName, password);

            if (success)
            {
                this.Hide();
                login loginForm = new login();
                loginForm.ShowDialog();
                this.Close();
            }
        }


        private void btn_password_Click(object sender, EventArgs e)
        {

            if (passwordtb.UseSystemPasswordChar == true)
            {
                passwordtb.UseSystemPasswordChar = false;
            }
            else
            {
                passwordtb.UseSystemPasswordChar = true;
            }
        }

        private void btn_rpassword_Click(object sender, EventArgs e)
        {

            if (rpasswordtb.UseSystemPasswordChar == true)
            {
                rpasswordtb.UseSystemPasswordChar = false;
            }
            else
            {
                rpasswordtb.UseSystemPasswordChar = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            login login2 = new login();
            login2.ShowDialog();
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();   
        }
    }
}
