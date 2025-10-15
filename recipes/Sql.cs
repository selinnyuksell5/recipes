using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace recipes
{
    public class SQL
    {
        private static SqlConnection conn = new SqlConnection("Data Source=SELIN\\SQLEXPRESS;Initial Catalog=recipes;Integrated Security=True");
        private SqlCommand cmd;

        public static void Connect()
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                    conn.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while connecting to the database: " + ex.Message);
            }
        }

        public static void Disconnect()
        {
            try
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while disconnecting from the database: " + ex.Message);
            }
        }

        public SqlDataReader ExecuteQuery(string sql, SqlParameter[] parameters)
        {
            try
            {
                cmd = new SqlCommand(sql, conn);
                if (parameters != null)
                {
                    cmd.Parameters.AddRange(parameters);
                }

                return cmd.ExecuteReader();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return null;
            }
        }

        public bool ExecuteNonQuery(string sql, SqlParameter[] parameters)
        {
            try
            {
                cmd = new SqlCommand(sql, conn);
                if (parameters != null)
                {
                    cmd.Parameters.AddRange(parameters);
                }
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return false;
            }
        }


        public static bool SignUp(string userName, string password)
        {
            try
            {
                string sqlCheckUser = "SELECT * FROM logIn WHERE userName = @userName";
                SqlCommand cmdCheckUser = new SqlCommand(sqlCheckUser, conn);
                cmdCheckUser.Parameters.AddWithValue("@userName", userName);


                object result = cmdCheckUser.ExecuteScalar();
                int userCount = result != null ? Convert.ToInt32(result) : 0;
                //Bu kodda, ExecuteScalar() metodundan dönen değeri object türünde bir değişkene atıyoruz.Daha sonra bu değerin null olup olmadığını kontrol ediyoruz.
                //Eğer null değilse, değeri int türüne dönüştürüyoruz; null ise, userCount değişkenine 0 değeri atıyoruz.

                if (userCount > 0)
                {
                    MessageBox.Show("Bu kullanıcı adı zaten mevcut.", "Mevcut", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
                else
                {
                    string sqlInsertUser = "INSERT INTO logIn(userName, password) VALUES (@userName, @password)";
                    SqlCommand cmdInsertUser = new SqlCommand(sqlInsertUser, conn);
                    cmdInsertUser.Parameters.AddWithValue("@userName", userName);
                    cmdInsertUser.Parameters.AddWithValue("@password", password);

                    cmdInsertUser.ExecuteNonQuery();
                    MessageBox.Show("Kaydınız başarıyla oluşturuldu.", "Başarılı Kayıt", MessageBoxButtons.OK, MessageBoxIcon.Information);


                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return false;
            }
        }

        public static bool LogIn(string userName, string password)
        {
            try
            {
                string sql = "SELECT COUNT(*) FROM logIn WHERE userName = @userName AND password = @password";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@userName", userName);
                cmd.Parameters.AddWithValue("@password", password);

                int userCount = (int)cmd.ExecuteScalar();

                return userCount > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return false;
            }
        }
        public static bool AddFavRecipes(string Name, string Ingredients, string userName)
        {
            try
            {
                string sql = "INSERT INTO favorite (userName,Name, Ingredients) VALUES (@userName, @Name, @Ingredients)";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@userName", userName);
                cmd.Parameters.AddWithValue("@Name", Name);
                cmd.Parameters.AddWithValue("@Ingredients", Ingredients);
               
                cmd.ExecuteNonQuery();

                //MessageBox.Show("Favorilere eklendi","Favori", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return false;
            }
        }
        public static bool RecipesIMade(string userName, string Name, string Ingredients)
        {
            try
            {
                string sql = "INSERT INTO RecipesIMade  (userName, Name, Ingredients) VALUES (@userName, @Name, @Ingredients)";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@userName", userName);
                cmd.Parameters.AddWithValue("@Name", Name);
                cmd.Parameters.AddWithValue("@Ingredients", Ingredients);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return false;
            }
        }
        public static DataTable ShowRecipesIMade(string userName)
        {
            DataTable table = new DataTable();
            try
            {

                string sql = "SELECT Name, Ingredients FROM RecipesIMade WHERE userName = @userName";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@userName", userName);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(table);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return null;
            }
            return table;
        }



        public static bool AddRecipes(string Name, string Ingredients, string userName)
        {
            try
            {
                string sql = "INSERT INTO addRecipe (Name, Ingredients, userName) VALUES (@Name, @Ingredients, @userName)";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@Name", Name);
                cmd.Parameters.AddWithValue("@Ingredients", Ingredients);
                cmd.Parameters.AddWithValue("@userName", userName);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return false;
            }
        }
        public static DataTable MyRecipes(string userName)
        {
            try
            {
                string sql = "SELECT Name, Ingredients FROM addRecipe WHERE userName = @userName";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@userName", userName);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                return dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error checking favorite recipe: " + ex.Message);
                return null;
            }
        }

        public static bool IsRecipeFavorite(string Name, string Ingredients, string userName)
        {
            try
            {
                string query = "SELECT COUNT(*) FROM favorite WHERE Name = @Name AND Ingredients = @Ingredients AND userName = @userName";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Name", Name);
                cmd.Parameters.AddWithValue("@Ingredients", Ingredients);
                cmd.Parameters.AddWithValue("@userName", userName);
                int count = (int)cmd.ExecuteScalar();

                return count > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error checking favorite recipe: " + ex.Message);
                return false;
            }
        }
        public static bool IsRecipe(string Name, string Ingredients, string userName)
        {
            try
            {
                string query = "SELECT COUNT(*) FROM RecipesIMade WHERE Name = @Name AND Ingredients = @Ingredients AND userName = @userName";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Name", Name);
                cmd.Parameters.AddWithValue("@Ingredients", Ingredients);
                cmd.Parameters.AddWithValue("@userName", userName);
                int count = (int)cmd.ExecuteScalar();

                return count > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error checking favorite recipe: " + ex.Message);
                return false;
            }
        }

        public static bool RemoveFavRecipe(string name, string ingredients, string userName)
        {
            try
            {
                string sql = "DELETE FROM favorite WHERE Name = @Name AND Ingredients = @Ingredients AND userName = @userName";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@Name", name);
                cmd.Parameters.AddWithValue("@Ingredients", ingredients);
                cmd.Parameters.AddWithValue("@userName", userName);

                int rowsAffected = cmd.ExecuteNonQuery(); // Silinen satır sayısını döner

                return rowsAffected > 0; // Eğer satır silindiyse true döner
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return false;
            }
        }
        public static bool RemoveRecipe(string name, string ingredients)
        {
            try
            {
                string sql = "DELETE FROM RecipesIMade WHERE Name = @Name AND Ingredients = @Ingredients ";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@Name", name);
                cmd.Parameters.AddWithValue("@Ingredients", ingredients);
                //cmd.Parameters.AddWithValue("@userName", userName);

                int rowsAffected = cmd.ExecuteNonQuery(); // Silinen satır sayısını döner

                return rowsAffected>0; // Eğer satır silindiyse true döner
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return false;
            }
        }
        public static bool RemoveMyRecipe(string name, string ingredients, string userName)
        {
            try
            {
                string sql = "DELETE FROM addRecipe WHERE Name = @Name AND Ingredients = @Ingredients AND userName = @userName";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@Name", name);
                cmd.Parameters.AddWithValue("@Ingredients", ingredients);
                cmd.Parameters.AddWithValue("@userName", userName);

                int rowsAffected = cmd.ExecuteNonQuery(); // Silinen satır sayısını döner

                return rowsAffected > 0; // Eğer satır silindiyse true döner
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return false;
            }
        }
        public static bool UpdateMyRecipe(string userName,string Name, string Ingredients)
        {
            try
            {
                string sql = "UPDATE addRecipe SET Ingredients = @Ingredients  WHERE userName = @userName AND Name = @Name";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@userName", userName);
                cmd.Parameters.AddWithValue("@Name", Name);
                cmd.Parameters.AddWithValue("@Ingredients", Ingredients);

                int rowsAffected = cmd.ExecuteNonQuery(); // Silinen satır sayısını döner

                return rowsAffected > 0; // Eğer satır silindiyse true döner
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return false;
            }
        }

        public static DataTable ShowFavRecipes(string userName)
        {
            DataTable table = new DataTable();
            try
            {

                string sql = "SELECT Name, Ingredients FROM favorite WHERE userName = @userName";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@userName", userName);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(table);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return null;
            }
            return table;
        }
        public async Task SaveRecipesToDatabase(DataTable recipes)
        {
            string connectionString = "Data Source=SELIN\\SQLEXPRESS;Initial Catalog=recipes;Integrated Security=True";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                await connection.OpenAsync();

                foreach (DataRow row in recipes.Rows)
                {
                    string query = "INSERT INTO find (Name, Ingredients) VALUES (@Name, @Ingredients)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Name", row["Name"]);
                        command.Parameters.AddWithValue("@Ingredients", row["Ingredients"]);

                        try
                        {
                            await command.ExecuteNonQueryAsync();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Veritabanına veri ekleme hatası: {ex.Message}");
                        }
                    }
                }
            }
        }
    }
}
