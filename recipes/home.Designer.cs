using System.Drawing;
using System.Windows.Forms;

namespace recipes
{
    partial class home
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(home));
            this.dgv_recipe = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btn_myrecipes = new System.Windows.Forms.Button();
            this.btn_fav = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.find_recipe = new System.Windows.Forms.Button();
            this.recipesImade = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.saat = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_exit = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.pnl_add = new System.Windows.Forms.Panel();
            this.pnl_ingredients = new System.Windows.Forms.FlowLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.txtIngredients = new System.Windows.Forms.TextBox();
            this.btn_goster = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.btn_close = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_recipe)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel6.SuspendLayout();
            this.pnl_ingredients.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_recipe
            // 
            this.dgv_recipe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_recipe.BackgroundColor = System.Drawing.Color.White;
            this.dgv_recipe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_recipe.Location = new System.Drawing.Point(38, 70);
            this.dgv_recipe.Name = "dgv_recipe";
            this.dgv_recipe.Size = new System.Drawing.Size(932, 308);
            this.dgv_recipe.TabIndex = 0;
            this.dgv_recipe.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_recipe_CellClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Location = new System.Drawing.Point(129, 88);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(726, 100);
            this.panel1.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panel4.Controls.Add(this.btn_myrecipes);
            this.panel4.Controls.Add(this.btn_fav);
            this.panel4.Controls.Add(this.btn_add);
            this.panel4.Controls.Add(this.find_recipe);
            this.panel4.Controls.Add(this.recipesImade);
            this.panel4.Location = new System.Drawing.Point(12, 13);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(701, 74);
            this.panel4.TabIndex = 3;
            // 
            // btn_myrecipes
            // 
            this.btn_myrecipes.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_myrecipes.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_myrecipes.ForeColor = System.Drawing.Color.Gray;
            this.btn_myrecipes.Location = new System.Drawing.Point(165, 17);
            this.btn_myrecipes.Name = "btn_myrecipes";
            this.btn_myrecipes.Size = new System.Drawing.Size(132, 38);
            this.btn_myrecipes.TabIndex = 4;
            this.btn_myrecipes.Text = "My Recipes";
            this.btn_myrecipes.UseVisualStyleBackColor = false;
            this.btn_myrecipes.Click += new System.EventHandler(this.btn_myrecipes_Click);
            // 
            // btn_fav
            // 
            this.btn_fav.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_fav.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_fav.ForeColor = System.Drawing.Color.Gray;
            this.btn_fav.Location = new System.Drawing.Point(551, 17);
            this.btn_fav.Name = "btn_fav";
            this.btn_fav.Size = new System.Drawing.Size(119, 38);
            this.btn_fav.TabIndex = 3;
            this.btn_fav.Text = "Favorites";
            this.btn_fav.UseVisualStyleBackColor = false;
            this.btn_fav.Click += new System.EventHandler(this.btn_fav_Click);
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_add.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_add.ForeColor = System.Drawing.Color.Gray;
            this.btn_add.Location = new System.Drawing.Point(303, 17);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(123, 38);
            this.btn_add.TabIndex = 1;
            this.btn_add.Text = "Add Recipe";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click_1);
            // 
            // find_recipe
            // 
            this.find_recipe.BackColor = System.Drawing.Color.WhiteSmoke;
            this.find_recipe.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.find_recipe.ForeColor = System.Drawing.Color.Gray;
            this.find_recipe.Location = new System.Drawing.Point(432, 17);
            this.find_recipe.Name = "find_recipe";
            this.find_recipe.Size = new System.Drawing.Size(113, 38);
            this.find_recipe.TabIndex = 2;
            this.find_recipe.Text = "Find Recipe";
            this.find_recipe.UseVisualStyleBackColor = false;
            this.find_recipe.Click += new System.EventHandler(this.find_recipe_Click);
            // 
            // recipesImade
            // 
            this.recipesImade.BackColor = System.Drawing.Color.WhiteSmoke;
            this.recipesImade.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.recipesImade.ForeColor = System.Drawing.Color.Gray;
            this.recipesImade.Location = new System.Drawing.Point(27, 17);
            this.recipesImade.Name = "recipesImade";
            this.recipesImade.Size = new System.Drawing.Size(132, 38);
            this.recipesImade.TabIndex = 0;
            this.recipesImade.Text = "Recipes I Made";
            this.recipesImade.UseVisualStyleBackColor = false;
            this.recipesImade.Click += new System.EventHandler(this.recipesImade_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.dateTimePicker1);
            this.panel2.Location = new System.Drawing.Point(861, 88);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 100);
            this.panel2.TabIndex = 2;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panel5.Controls.Add(this.saat);
            this.panel5.Location = new System.Drawing.Point(63, 63);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(82, 24);
            this.panel5.TabIndex = 1;
            // 
            // saat
            // 
            this.saat.AutoSize = true;
            this.saat.ForeColor = System.Drawing.Color.Black;
            this.saat.Location = new System.Drawing.Point(10, 6);
            this.saat.Name = "saat";
            this.saat.Size = new System.Drawing.Size(35, 13);
            this.saat.TabIndex = 0;
            this.saat.Text = "label2";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarForeColor = System.Drawing.Color.Gray;
            this.dateTimePicker1.CalendarTitleForeColor = System.Drawing.Color.Gray;
            this.dateTimePicker1.Location = new System.Drawing.Point(25, 37);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(157, 20);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(861, 88);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 29);
            this.panel3.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Peru;
            this.label1.Location = new System.Drawing.Point(59, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "CALENDER";
            // 
            // btn_exit
            // 
            this.btn_exit.BackColor = System.Drawing.Color.White;
            this.btn_exit.FlatAppearance.BorderSize = 0;
            this.btn_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_exit.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_exit.ForeColor = System.Drawing.Color.Gray;
            this.btn_exit.Location = new System.Drawing.Point(1103, 625);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(75, 23);
            this.btn_exit.TabIndex = 3;
            this.btn_exit.Text = "Exit";
            this.btn_exit.UseVisualStyleBackColor = false;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panel6.Controls.Add(this.pnl_add);
            this.panel6.Controls.Add(this.pnl_ingredients);
            this.panel6.Controls.Add(this.dgv_recipe);
            this.panel6.ForeColor = System.Drawing.Color.DimGray;
            this.panel6.Location = new System.Drawing.Point(91, 194);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1006, 401);
            this.panel6.TabIndex = 4;
            // 
            // pnl_add
            // 
            this.pnl_add.Location = new System.Drawing.Point(38, 12);
            this.pnl_add.Name = "pnl_add";
            this.pnl_add.Size = new System.Drawing.Size(932, 366);
            this.pnl_add.TabIndex = 5;
            // 
            // pnl_ingredients
            // 
            this.pnl_ingredients.BackColor = System.Drawing.Color.White;
            this.pnl_ingredients.Controls.Add(this.label3);
            this.pnl_ingredients.Controls.Add(this.txtIngredients);
            this.pnl_ingredients.Controls.Add(this.btn_goster);
            this.pnl_ingredients.Location = new System.Drawing.Point(38, 12);
            this.pnl_ingredients.Name = "pnl_ingredients";
            this.pnl_ingredients.Size = new System.Drawing.Size(400, 52);
            this.pnl_ingredients.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.Peru;
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "The ingredients i have:";
            // 
            // txtIngredients
            // 
            this.txtIngredients.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtIngredients.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtIngredients.Location = new System.Drawing.Point(3, 19);
            this.txtIngredients.Multiline = true;
            this.txtIngredients.Name = "txtIngredients";
            this.txtIngredients.Size = new System.Drawing.Size(299, 28);
            this.txtIngredients.TabIndex = 0;
            // 
            // btn_goster
            // 
            this.btn_goster.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_goster.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_goster.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_goster.ForeColor = System.Drawing.Color.Peru;
            this.btn_goster.Location = new System.Drawing.Point(308, 19);
            this.btn_goster.Name = "btn_goster";
            this.btn_goster.Size = new System.Drawing.Size(87, 28);
            this.btn_goster.TabIndex = 1;
            this.btn_goster.Text = "Find";
            this.btn_goster.UseVisualStyleBackColor = false;
            this.btn_goster.Click += new System.EventHandler(this.btn_goster_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(1067, 89);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(97, 99);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(132, -10);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(102, 93);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 6;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(947, -11);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(114, 93);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 7;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(1067, 1);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(78, 82);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 8;
            this.pictureBox6.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(24, 1);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(103, 93);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 1;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
            this.pictureBox7.Location = new System.Drawing.Point(24, 89);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(103, 100);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 5;
            this.pictureBox7.TabStop = false;
            // 
            // btn_close
            // 
            this.btn_close.BackColor = System.Drawing.Color.Transparent;
            this.btn_close.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_close.BackgroundImage")));
            this.btn_close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_close.ForeColor = System.Drawing.Color.Transparent;
            this.btn_close.Location = new System.Drawing.Point(1151, 12);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(30, 32);
            this.btn_close.TabIndex = 9;
            this.btn_close.UseVisualStyleBackColor = false;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(230)))), ((int)(((byte)(237)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1190, 660);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.Bisque;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Anasayfa";
            this.Load += new System.EventHandler(this.home_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_recipe)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.pnl_ingredients.ResumeLayout(false);
            this.pnl_ingredients.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_recipe;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label saat;
        private System.Windows.Forms.Button btn_exit;
        private Panel panel6;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private PictureBox pictureBox6;
        private Label label3;
        private TextBox txtIngredients;
        private Button btn_goster;
        private FlowLayoutPanel pnl_ingredients;
        private Timer timer1;
        private PictureBox pictureBox5;
        private PictureBox pictureBox7;
        private Panel panel4;
        private Button btn_fav;
        private Button btn_add;
        private Button find_recipe;
        private Button recipesImade;
        private Button btn_close;
        private Panel pnl_add;
        private Button btn_myrecipes;
    }
}