namespace recipes
{
    partial class add_recipe
    {
        /// <summary> 
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Bileşen Tasarımcısı üretimi kod

        /// <summary> 
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgv_add = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_add)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_add
            // 
            this.dgv_add.AllowUserToAddRows = false;
            this.dgv_add.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_add.Location = new System.Drawing.Point(0, 0);
            this.dgv_add.Name = "dgv_add";
            this.dgv_add.Size = new System.Drawing.Size(918, 409);
            this.dgv_add.TabIndex = 0;
            this.dgv_add.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_add_CellClick);
            this.dgv_add.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_add_CellContentClick_1);
            // 
            // add_recipe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgv_add);
            this.Name = "add_recipe";
            this.Size = new System.Drawing.Size(1290, 742);
            this.Load += new System.EventHandler(this.add_recipe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_add)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView dgv_add;
    }
}
