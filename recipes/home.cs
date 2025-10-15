using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;
using System.Data;
using System.Linq;
using System.Drawing;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.ComponentModel;

namespace recipes
{
    public partial class home : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=SELIN\\SQLEXPRESS;Initial Catalog=recipes;Integrated Security=True");
        private SQL sqlManager;
        private static readonly string appId = "ddf763e3";
        private static readonly string appKey = "ef8d773fe9f01f0ccc3f32678b8666b2";
        private const int RecipeFetchCount = 40;
        private DataTable recipeTable;
        private List<DataRow> favoriteRecipes;
        private List<DataRow> recipesiMade;
        private int UserId;
        private add_recipe UCAddRecipe;

        public home(int UserId)
        {
            System.Globalization.CultureInfo culture = new System.Globalization.CultureInfo("en-US");
            System.Threading.Thread.CurrentThread.CurrentCulture = culture;
            System.Threading.Thread.CurrentThread.CurrentUICulture = culture;

            

            this.UserId = UserId;
            InitializeComponent();
            InitializeUCAddRecipe();
            favoriteRecipes = new List<DataRow>();
            recipesiMade = new List<DataRow>();
        }

        private void InitializeUCAddRecipe()
        {
            UCAddRecipe = new add_recipe();
            UCAddRecipe.Dock = DockStyle.Fill;
            pnl_add.Controls.Add(UCAddRecipe);
        }

        private async void home_Load(object sender, EventArgs e)
        {
            saat.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
            await LoadAllRecipes();
            await LoadEggRecipes();
            AddCheckButtonColumn();
            AddFavoriteButtonColumn();
            SQL.Connect();
            pnl_add.Visible = false;
            foreach (DataGridViewColumn column in dgv_recipe.Columns)
            {
                if (column.Name != "check" && column.Name != "btn_delete" && column.Name != "btn_fav" && column.Name != "btn_remove")
                {
                    column.ReadOnly = true;
                }
            }
        }
        private void home_FormClosing(object sender, FormClosingEventArgs e)
        {
            SQL.Disconnect();
        }
        private async Task LoadEggRecipes()
        {
            var eggRecipesTable = await GetEggRecipes();

            if (eggRecipesTable != null)
            {
                dgv_recipe.DataSource = eggRecipesTable;
            }
            else
            {
                MessageBox.Show("No egg recipes found.");
            }
        }
        private async Task<DataTable> GetEggRecipes()
        {
            string ingredients = "egg";
            return await GetRecipesFromEdamam(ingredients);
        }

        private void AddFavoriteButtonColumn()
        {

            if (!dgv_recipe.Columns.Contains("btn_fav"))
            {
                DataGridViewButtonColumn btn = new DataGridViewButtonColumn
                {
                    HeaderText = "Favorites",
                    Name = "btn_fav",
                    Text = "♥",
                    UseColumnTextForButtonValue = true,
                    FlatStyle = FlatStyle.Popup
                   
                };
                btn.DefaultCellStyle.ForeColor = Color.White;
                btn.DefaultCellStyle.BackColor = Color.Orange;
                dgv_recipe.Columns.Add(btn);
                dgv_recipe.Columns["btn_fav"].Width = 45;
                dgv_recipe.Columns["btn_fav"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            }
        }

        private void AddCheckButtonColumn()
        {

            if (!dgv_recipe.Columns.Contains("check"))
            {
                DataGridViewButtonColumn check = new DataGridViewButtonColumn
                {
                    HeaderText = "Recipes I Made",
                    Name = "check",
                    Text = "Add",
                    UseColumnTextForButtonValue = true,
                    FlatStyle = FlatStyle.Popup,
                    Width = 2
                };
                check.DefaultCellStyle.ForeColor = Color.White;
                check.DefaultCellStyle.BackColor = Color.Green;
                dgv_recipe.Columns.Add(check);
                dgv_recipe.Columns["check"].Width = 60;
                dgv_recipe.Columns["check"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            }
        }

        private void RemoveFavoriteButtonColumn()
        {
            if (dgv_recipe.Columns.Contains("btn_remove"))
            {
                dgv_recipe.Columns.Remove("btn_remove");
            }

            DataGridViewButtonColumn btn = new DataGridViewButtonColumn
            {
                HeaderText = "Remove",
                Name = "btn_remove",
                Text = "x",
                UseColumnTextForButtonValue = true,
                FlatStyle = FlatStyle.Popup
            };
            btn.DefaultCellStyle.ForeColor = Color.White;
            btn.DefaultCellStyle.BackColor = Color.OrangeRed;
            dgv_recipe.Columns.Add(btn);
            dgv_recipe.Columns["btn_remove"].Width = 50;
            dgv_recipe.Columns["btn_remove"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
        }
        private void AddDeleteButtonColumn()
        {
            if (!dgv_recipe.Columns.Contains("btn_delete"))
            {
                DataGridViewButtonColumn deleteButton = new DataGridViewButtonColumn
                {
                    HeaderText = "Remove",
                    Name = "btn_delete",
                    Text = "x",
                    UseColumnTextForButtonValue = true,
                    FlatStyle = FlatStyle.Popup,
                };

                deleteButton.DefaultCellStyle.ForeColor = Color.White;
                deleteButton.DefaultCellStyle.BackColor = Color.Red;
                dgv_recipe.Columns.Add(deleteButton);
                dgv_recipe.Columns["btn_delete"].Width = 50;
                dgv_recipe.Columns["btn_delete"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            }
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            saat.Text = DateTime.Now.ToLongTimeString();
        }

        private async void btn_goster_Click(object sender, EventArgs e)
        {
            string ingredients = txtIngredients.Text;
            if (string.IsNullOrWhiteSpace(ingredients))
            {
                dgv_recipe.DataSource = recipeTable;
            }
            else
            {
                var filteredRecipesTable = await GetRecipesFromEdamam(ingredients);

                if (filteredRecipesTable != null)
                {
                    dgv_recipe.DataSource = filteredRecipesTable;
                }
                else
                {
                    MessageBox.Show("No recipes found.");
                }
            }
            txtIngredients.Text = "";
        }

        private async Task<DataTable> GetRecipesFromEdamam(string ingredients)
        {
            string url = $"https://api.edamam.com/search?q={ingredients}&app_id={appId}&app_key={appKey}&from=0&to={RecipeFetchCount}";

            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = await client.GetAsync(url);
                if (response.IsSuccessStatusCode)
                {
                    string jsonResponse = await response.Content.ReadAsStringAsync();
                    JObject data = JObject.Parse(jsonResponse);

                    // Extract recipes from JSON
                    var recipes = data["hits"]?.Select(hit => hit["recipe"]);

                    if (recipes != null)
                    {
                        DataTable table = new DataTable();
                        table.Columns.Add("Name");
                        table.Columns.Add("Ingredients");

                        foreach (var recipe in recipes)
                        {
                            DataRow row = table.NewRow();
                            row["Name"] = recipe["label"].ToString();
                            row["Ingredients"] = string.Join(", ", recipe["ingredientLines"].Select(il => il.ToString()));
                            table.Rows.Add(row);
                        }

                        // Verileri SQL Server'a kaydet
                        await new SQL().SaveRecipesToDatabase(table);

                        return table;
                    }
                }
            }

            return null;
        }

        private async Task LoadAllRecipes()
        {
            var allRecipesTable = await GetRecipesFromEdamam("");

            if (allRecipesTable != null)
            {
                recipeTable = allRecipesTable;
                dgv_recipe.DataSource = recipeTable;


                await new SQL().SaveRecipesToDatabase(allRecipesTable);
            }
            else
            {
                MessageBox.Show("No recipes found.");

            }
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Çıkış yapmak istediğinize emin misiniz?", "Çıkış", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Hide();
                login loginForm = new login();
                loginForm.ShowDialog();      
                this.Close();
            }
        }

        private void btn_fav_Click(object sender, EventArgs e)
        {
            pnl_ingredients.Visible = false;
            pnl_add.Visible = false;
            dgv_recipe.Visible = true;
            string userName = Session.userName;


            dgv_recipe.DataSource = SQL.ShowFavRecipes(userName);
            if(dgv_recipe.RowCount < 2)
            {
                MessageBox.Show("Favori tarifiniz bulunmuyor.");
                dgv_recipe.Refresh();
            }
            string columnName = "btn_fav";
            if (dgv_recipe.Columns.Contains(columnName))
            {
                dgv_recipe.Columns.Remove(columnName);
            }
            string ColumnName = "btn_delete";
            if (dgv_recipe.Columns.Contains(ColumnName))
            {
                dgv_recipe.Columns.Remove(ColumnName);
            }
            string column_Name = "check";
            if (dgv_recipe.Columns.Contains(column_Name))
            {
                dgv_recipe.Columns.Remove(column_Name);
            }

            RemoveFavoriteButtonColumn();

        }


        private async void dgv_recipe_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex < 0 || e.RowIndex < 0)
            {
                return; // Geçersiz sütun ya da satır indeksinde işlem yapma.
            }
            if (dgv_recipe.Columns[e.ColumnIndex].Name == "btn_fav" )
            {
                DataGridViewRow row = dgv_recipe.Rows[e.RowIndex];
                DataRow dataRow = ((DataRowView)row.DataBoundItem).Row;

                string name = dataRow["Name"].ToString();
                string ingredients = dataRow["Ingredients"].ToString();
                string userName = Session.userName;


                bool isFavorite = await Task.Run(() => SQL.IsRecipeFavorite(name, ingredients, userName));

                if (isFavorite)
                {
                    MessageBox.Show($"{name} zaten favorilerde.");
                }
                else
                {
                    
                    bool success = await Task.Run(() => SQL.AddFavRecipes(name, ingredients, userName));

                    if (success)
                    {
                        favoriteRecipes.Add(dataRow);
                        MessageBox.Show($"{name} favorilere eklendi.");

                    }
                    else
                    {
                        MessageBox.Show("Favorilere ekleme başarısız oldu.");
                    }
                }
            }
            else if ( dgv_recipe.Columns[e.ColumnIndex].Name == "btn_remove")
            {
                DataGridViewRow row = dgv_recipe.Rows[e.RowIndex];
                DataRow dataRow = ((DataRowView)row.DataBoundItem).Row;
                string name = dataRow["Name"].ToString();
                string ingredients = dataRow["Ingredients"].ToString();
                string userName = Session.userName;

                bool success = SQL.RemoveFavRecipe(name, ingredients, userName);
                
                if (success)
                {
                    dgv_recipe.Rows.RemoveAt(e.RowIndex);
                    favoriteRecipes.Remove(dataRow);
                    // MessageBox.Show($"{name} favorilerden çıkarıldı.");
                }
                else
                {
                    // MessageBox.Show("Favorilerden çıkarma başarısız oldu.");
                }
            }
            if (dgv_recipe.Columns[e.ColumnIndex].Name == "btn_delete" )
            {
                DataGridViewRow row = dgv_recipe.Rows[e.RowIndex];
                DataRow dataRow = ((DataRowView)row.DataBoundItem).Row;

                string name = dataRow["Name"].ToString();
                string ingredients = dataRow["Ingredients"].ToString();

               
                {
                    bool success = SQL.RemoveRecipe(name, ingredients);

                    if (success)
                    {
                        dgv_recipe.Rows.RemoveAt(e.RowIndex);
                        
                    }

                }
            }

            if (dgv_recipe.Columns[e.ColumnIndex].Name == "check" )
            {
                DataGridViewRow row = dgv_recipe.Rows[e.RowIndex];
                DataRow dataRow = ((DataRowView)row.DataBoundItem).Row;

                string name = dataRow["Name"].ToString();
                string ingredients = dataRow["Ingredients"].ToString();
                string userName = Session.userName;


                bool isRecipe = await Task.Run(() => SQL.IsRecipe(name, ingredients, userName));

                if (isRecipe)
                {
                    MessageBox.Show($"{name} zaten yaptığım tariflerde.");
                }
                else
                {
                    bool success = await Task.Run(() => SQL.RecipesIMade(userName, name, ingredients));

                    if (success)
                    {
                        recipesiMade.Add(dataRow);
                        MessageBox.Show($"{name} yaptığım tariflere eklendi.");

                    }
                    else
                    {
                        MessageBox.Show("Yaptığım tariflere ekleme başarısız oldu.");
                    }
                }
            }
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
        }

        private void find_recipe_Click(object sender, EventArgs e)
        {
           
                pnl_ingredients.Visible = true;
                pnl_add.Visible = false;
                dgv_recipe.Visible = true;
                home_Load(sender, e);
                AddFavoriteButtonColumn();
                if (dgv_recipe.Columns.Contains("btn_remove"))
                {
                    dgv_recipe.Columns.Remove("btn_remove");
                }
                if (dgv_recipe.Columns.Contains("btn_delete"))
                {
                    dgv_recipe.Columns.Remove("btn_delete");
                }
            
    

        }
 
        private void btn_add_Click_1(object sender, EventArgs e)
        {
            string userName = Session.userName;
            add_recipe myAddRecipeControl = new add_recipe();
            AddRecipe addrecipeForm = new AddRecipe(myAddRecipeControl);
            addrecipeForm.ShowDialog();
            pnl_add.Visible=false;
            dgv_recipe.Visible = true;
            pnl_ingredients.Visible=false;

            //MyRecipes tablosunu çağırıyoruz.
            pnl_add.Controls.Clear();
            add_recipe MyRecipes = new add_recipe();
            pnl_add.Controls.Add(MyRecipes);

            dgv_recipe.Visible = false;
            pnl_add.Visible = true;
            DataTable dataTable = SQL.MyRecipes(userName);
            if (dataTable != null && dataTable.Rows.Count > 0)
            {
                MyRecipes.dgv_add.DataSource = dataTable;
                MyRecipes.dgv_add.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            }
            else
            {
                dgv_recipe.DataSource = null;
            }
            pnl_ingredients.Visible = false;

        }

        private void btn_myrecipes_Click(object sender, EventArgs e)
        {
            string userName = Session.userName;
            pnl_add.Controls.Clear();
            add_recipe MyRecipes = new add_recipe();
            pnl_add.Controls.Add(MyRecipes);
            MyRecipes.AddDeleteButtonColumn2();
            MyRecipes.UpdateButtonColumn();
            dgv_recipe.Visible = false;
            pnl_add.Visible = true;
            if (MyRecipes.dgv_add.Rows.Count > 0)
            {
                MyRecipes.dgv_add.Visible = true;
            }
            else
            {
                //MyRecipes.dgv_add.Visible = false;
            }
            DataTable dataTable = SQL.MyRecipes(userName);
           
            if (dataTable != null && dataTable.Rows.Count > 0)
            {
                MyRecipes.dgv_add.DataSource = dataTable;
                MyRecipes.dgv_add.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
                //MyRecipes.dgv_add.Rows[MyRecipes.dgv_add.Rows.Count - 1].Visible = false;
            }
            else
            {
                if (MyRecipes.dgv_add.RowCount < 2)
                {
                    if (MyRecipes.dgv_add.Columns.Contains("btn_update"))
                    {
                        MyRecipes.dgv_add.Columns.Remove("btn_update");
                    }
                    if (MyRecipes.dgv_add.Columns.Contains("btn_delete"))
                    {
                        MyRecipes.dgv_add.Columns.Remove("btn_delete");
                    }

                    MessageBox.Show("Yaptığınız tarif bulunmuyor.");
                    MyRecipes.dgv_add.Refresh();
                    MyRecipes.dgv_add.DataSource = null;
                }
                
            }
            pnl_ingredients.Visible = false;
        }
        
        private void recipesImade_Click(object sender, EventArgs e)
        {
            pnl_ingredients.Visible=false;
            pnl_add.Visible = false;
            dgv_recipe.Visible = true;
            string userName = Session.userName;


            dgv_recipe.DataSource = SQL.ShowRecipesIMade(userName);
            if (dgv_recipe.RowCount < 2)
            {
                MessageBox.Show("Yaptığınız tarif bulunmuyor.");
                dgv_recipe.Refresh();
            }
            string columnName = "btn_fav";
            if (dgv_recipe.Columns.Contains(columnName))
            {
                dgv_recipe.Columns.Remove(columnName);
            }
            string column_name = "btn_remove";
            if (dgv_recipe.Columns.Contains(column_name))
            {
                dgv_recipe.Columns.Remove(column_name);
            }
            string column_Name = "check";
            if (dgv_recipe.Columns.Contains(column_Name))
            {
                dgv_recipe.Columns.Remove(column_Name);
            }
            AddDeleteButtonColumn();
        }
    }
}
