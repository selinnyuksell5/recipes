using System;
using System.Data;
using System.Windows.Forms;

namespace recipes
{
    public partial class AddRecipe : Form
    {
        private readonly add_recipe _addRecipeControl;

        public AddRecipe(add_recipe addRecipeControl)
        {
            InitializeComponent();
            _addRecipeControl = addRecipeControl;
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtName.Text) || string.IsNullOrEmpty(txtIngredients.Text))
            {
                MessageBox.Show("Lütfen tüm alanları doldurun.", "Eksik Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string name = txtName.Text.Trim();
            string ingredients = txtIngredients.Text.Trim();
            string userName = Session.userName;


            _addRecipeControl.AddRecipeToGrid(name, ingredients);

            bool success = SQL.AddRecipes(name, ingredients, userName);

            if (success)
            {
                MessageBox.Show("Tarif başarıyla eklendi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Tarif eklenirken bir hata oluştu.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.Hide();
            this.Close();
        }

        private void AddRecipe_Load(object sender, EventArgs e)
        {
            SQL.Connect();
        }

        private void AddRecipe_FormClosing(object sender, FormClosingEventArgs e)
        {
            SQL.Disconnect();
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txtIngredients.Text = "";
            txtName.Text = "";
        }
    }
}
