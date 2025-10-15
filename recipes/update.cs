using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace recipes
{
    public partial class update : Form
    {
        private readonly add_recipe _addRecipeControl;
        public update(add_recipe addRecipeControl)
        {

            InitializeComponent();
            _addRecipeControl = addRecipeControl;
        }

        private void update_Load(object sender, EventArgs e)
        {
            SQL.Connect();
        } 
        private void update_FormClosing(object sender, FormClosingEventArgs e)
        {
            SQL.Disconnect();
        }
        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtName.Text) || string.IsNullOrEmpty(txtIngredients.Text))
            {
                MessageBox.Show("Lütfen tüm alanları doldurun.", "Eksik Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string name = txtName.Text.Trim();
            string Ingredients = txtIngredients.Text.Trim();
            string userName = Session.userName;
            _addRecipeControl.AddRecipeToGrid(name, Ingredients);

            bool success = SQL.UpdateMyRecipe(userName,name, Ingredients);

            if (success)
            {
                MessageBox.Show("Tarifiniz başarıyla güncellendi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }
            else
            {
                MessageBox.Show("Tarifiniz güncellenirken bir hata oluştu.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.Hide();
            this.Close();
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txtIngredients.Text = "";
            txtName.Text = "";
        }

        private void btn_update_Click_1(object sender, EventArgs e)
        {  

            string name = txtName.Text.Trim();
            string ingredients = txtIngredients.Text.Trim();
            string userName = Session.userName;
            bool success = SQL.UpdateMyRecipe(userName,name, ingredients);

            if (success)
            {
                MessageBox.Show($"{name} güncellendi.");
                DataTable datatable = SQL.MyRecipes(userName);
                this.Hide();
                this.Close();

            }
            else
            {
                MessageBox.Show($"{name} adında bir tarif yok.");
                this.Hide();
                this.Close();
            }
        }

        private void btn_close_Click_1(object sender, EventArgs e)
        {

            this.Hide();
            this.Close();
        }
    }
}
