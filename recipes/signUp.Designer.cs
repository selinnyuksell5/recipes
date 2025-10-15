using System.Windows.Forms;

namespace recipes
{
    partial class signUp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(signUp));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.userNametb = new System.Windows.Forms.TextBox();
            this.passwordtb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_signUp = new System.Windows.Forms.Button();
            this.rpasswordtb = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_password = new System.Windows.Forms.Button();
            this.btn_rpassword = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-4, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(565, 438);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(369, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sign Up";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(315, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "User Name";
            // 
            // userNametb
            // 
            this.userNametb.Location = new System.Drawing.Point(318, 140);
            this.userNametb.MaxLength = 20;
            this.userNametb.Name = "userNametb";
            this.userNametb.Size = new System.Drawing.Size(152, 20);
            this.userNametb.TabIndex = 3;
            // 
            // passwordtb
            // 
            this.passwordtb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.passwordtb.Location = new System.Drawing.Point(318, 204);
            this.passwordtb.MaxLength = 15;
            this.passwordtb.Name = "passwordtb";
            this.passwordtb.Size = new System.Drawing.Size(152, 22);
            this.passwordtb.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(315, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Password";
            // 
            // btn_signUp
            // 
            this.btn_signUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btn_signUp.FlatAppearance.BorderSize = 0;
            this.btn_signUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_signUp.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_signUp.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_signUp.Location = new System.Drawing.Point(318, 305);
            this.btn_signUp.Name = "btn_signUp";
            this.btn_signUp.Size = new System.Drawing.Size(152, 23);
            this.btn_signUp.TabIndex = 6;
            this.btn_signUp.Text = "Sign Up";
            this.btn_signUp.UseVisualStyleBackColor = false;
            this.btn_signUp.Click += new System.EventHandler(this.btn_signUp_Click);
            // 
            // rpasswordtb
            // 
            this.rpasswordtb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rpasswordtb.Location = new System.Drawing.Point(318, 266);
            this.rpasswordtb.MaxLength = 15;
            this.rpasswordtb.Name = "rpasswordtb";
            this.rpasswordtb.Size = new System.Drawing.Size(152, 22);
            this.rpasswordtb.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.Gray;
            this.label4.Location = new System.Drawing.Point(315, 247);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Repeat Password";
            // 
            // btn_password
            // 
            this.btn_password.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_password.BackgroundImage")));
            this.btn_password.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_password.Location = new System.Drawing.Point(442, 204);
            this.btn_password.Name = "btn_password";
            this.btn_password.Size = new System.Drawing.Size(28, 23);
            this.btn_password.TabIndex = 9;
            this.btn_password.UseVisualStyleBackColor = true;
            this.btn_password.Click += new System.EventHandler(this.btn_password_Click);
            // 
            // btn_rpassword
            // 
            this.btn_rpassword.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_rpassword.BackgroundImage")));
            this.btn_rpassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_rpassword.Location = new System.Drawing.Point(442, 265);
            this.btn_rpassword.Name = "btn_rpassword";
            this.btn_rpassword.Size = new System.Drawing.Size(28, 23);
            this.btn_rpassword.TabIndex = 10;
            this.btn_rpassword.UseVisualStyleBackColor = true;
            this.btn_rpassword.Click += new System.EventHandler(this.btn_rpassword_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(468, 403);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Sign In";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_close
            // 
            this.btn_close.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_close.BackgroundImage")));
            this.btn_close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_close.Location = new System.Drawing.Point(523, 12);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(25, 23);
            this.btn_close.TabIndex = 12;
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // signUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 438);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_rpassword);
            this.Controls.Add(this.btn_password);
            this.Controls.Add(this.rpasswordtb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_signUp);
            this.Controls.Add(this.passwordtb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.userNametb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "signUp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "signUp";
            this.Load += new System.EventHandler(this.signUp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox userNametb;
        private System.Windows.Forms.TextBox passwordtb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_signUp;
        private System.Windows.Forms.TextBox rpasswordtb;
        private System.Windows.Forms.Label label4;
        private Button btn_password;
        private Button btn_rpassword;
        private Button button1;
        private Button btn_close;
    }
}