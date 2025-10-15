using Microsoft.Identity.Client;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace recipes
{
    public partial class add_recipe : UserControl
    {

        public add_recipe()
        {
            InitializeComponent();

        }

        public void add_recipe_Load(object sender, EventArgs e)
        {
            SQL.Connect();
            AddDeleteButtonColumn2();
            //dgv_add.Visible = false;
            foreach (DataGridViewColumn column in dgv_add.Columns)
            {
                if (column.Name != "btn_delete" && column.Name != "btn_update")
                {
                    column.ReadOnly = true;
                }
            }

        }
        public void AddDeleteButtonColumn2()
        {
            if (!dgv_add.Columns.Contains("btn_delete"))
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
                dgv_add.Columns.Add(deleteButton);
                dgv_add.Columns["btn_delete"].Width = 60;
                dgv_add.Columns["btn_delete"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            }

        }
        public void UpdateButtonColumn()
        {
            if (!dgv_add.Columns.Contains("btn_update"))
            {
                DataGridViewButtonColumn updateButton = new DataGridViewButtonColumn
                {
                    HeaderText = "Update",
                    Name = "btn_update",
                    Text = "↷",
                    UseColumnTextForButtonValue = true,
                    FlatStyle = FlatStyle.Popup,
                };

                updateButton.DefaultCellStyle.ForeColor = Color.White;
                updateButton.DefaultCellStyle.BackColor = Color.Green;
                dgv_add.Columns.Add(updateButton);
                dgv_add.Columns["btn_update"].Width = 60;
                dgv_add.Columns["btn_update"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            }
        }

        public void AddRecipeToGrid(string Name, string Ingredients)
        {
            if (dgv_add.Columns.Count == 0)
            {
                dgv_add.Columns.Add("Name", "Name");
                dgv_add.Columns.Add("Ingredients", "Ingredients");
            }
            dgv_add.Rows.Add(Name, Ingredients);
        }

        public void dgv_add_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgv_add_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            
            foreach (DataGridViewColumn column in dgv_add.Columns)
            {
                if (column.Name != "btn_delete" && column.Name != "btn_update")
                {
                    column.ReadOnly = true;
                }
            }
            if (dgv_add.Columns[e.ColumnIndex].Name == "btn_delete" && e.RowIndex >= 0)
            {
                DataGridViewRow row = dgv_add.Rows[e.RowIndex];
                DataRow dataRow = ((DataRowView)row.DataBoundItem).Row;

                string name = dataRow["Name"].ToString();
                string ingredients = dataRow["Ingredients"].ToString();
                string userName = Session.userName;

                {
                    bool success = SQL.RemoveMyRecipe(name, ingredients, userName);

                    if (success)
                    {
                        dgv_add.Rows.RemoveAt(e.RowIndex);
                        //MessageBox.Show($"{name} silindi.");
                    }

                }
            }
            else if (dgv_add.Columns[e.ColumnIndex].Name == "btn_update")
            {
                DataGridViewRow row = dgv_add.Rows[e.RowIndex];
                DataRow dataRow = ((DataRowView)row.DataBoundItem).Row;

                string name = dataRow["Name"].ToString();
                string ingredients = dataRow["Ingredients"].ToString();
                string userName = Session.userName;
                add_recipe myAddRecipeControl = new add_recipe();
                update updateForm = new update(myAddRecipeControl);
                updateForm.ShowDialog();

            }
        }

        private void dgv_add_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
