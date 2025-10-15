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
using System.Data.SqlClient;

namespace recipes
{

    public partial class login : Form
    {
        private int UserId;

        public login()
        {
            InitializeComponent();
           
        }
        


        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void login_Load(object sender, EventArgs e)
        {
            SQL.Connect();
            passwordtb.UseSystemPasswordChar = true;
        }

        private void btn_signUp_Click(object sender, EventArgs e)
        {
            this.Hide();
            signUp signUpForm = new signUp();
            signUpForm.ShowDialog();
            this.Close();
            

        }

        private void btn_password_Click(object sender, EventArgs e)
        {
            if(passwordtb.UseSystemPasswordChar == true) { 
                passwordtb.UseSystemPasswordChar = false;}
            else
            {
                passwordtb.UseSystemPasswordChar = true;
            }
        }

        private void btn_signIn_Click(object sender, EventArgs e)
        {
            string userName = userNametb.Text;
            if (string.IsNullOrEmpty(userName) || string.IsNullOrEmpty(passwordtb.Text))
            {
                MessageBox.Show("Lütfen tüm alanları doldurun.", "Eksik Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            
            bool success = SQL.LogIn(userNametb.Text.Trim(), passwordtb.Text.Trim());
            if (success)
            {
                MessageBox.Show("Giriş başarılı.", "Giriş", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Session.userName= userName;
                this.Hide();
                home homeForm = new home(UserId);
                homeForm.ShowDialog();
                this.Close();
                
            }
            
            else
            {
                MessageBox.Show("Giriş başarısız. Kullanıcı adı veya şifre yanlış.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
        }

        

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
        }
    }
}
