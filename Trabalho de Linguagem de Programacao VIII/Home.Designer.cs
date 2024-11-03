﻿namespace Locadora
{
    partial class Home
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_alocar = new System.Windows.Forms.Button();
            this.btn_gameManagement = new System.Windows.Forms.Button();
            this.btn_userManagement = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.picture_user = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture_user)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(180)))), ((int)(((byte)(178)))));
            this.panel2.BackgroundImage = global::Locadora.Properties.Resources.bg_galaxy;
            this.panel2.Location = new System.Drawing.Point(188, -3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(737, 611);
            this.panel2.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(88)))), ((int)(((byte)(90)))));
            this.panel1.BackgroundImage = global::Locadora.Properties.Resources.bc_color1;
            this.panel1.Controls.Add(this.btn_alocar);
            this.panel1.Controls.Add(this.btn_gameManagement);
            this.panel1.Controls.Add(this.btn_userManagement);
            this.panel1.Controls.Add(this.btn_close);
            this.panel1.Controls.Add(this.picture_user);
            this.panel1.Location = new System.Drawing.Point(0, -3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(182, 611);
            this.panel1.TabIndex = 0;
            // 
            // btn_alocar
            // 
            this.btn_alocar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(18)))), ((int)(((byte)(28)))));
            this.btn_alocar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_alocar.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.btn_alocar.FlatAppearance.BorderSize = 3;
            this.btn_alocar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_alocar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_alocar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(186)))), ((int)(((byte)(11)))));
            this.btn_alocar.Location = new System.Drawing.Point(22, 307);
            this.btn_alocar.Name = "btn_alocar";
            this.btn_alocar.Size = new System.Drawing.Size(148, 49);
            this.btn_alocar.TabIndex = 0;
            this.btn_alocar.Text = "Alocar";
            this.btn_alocar.UseVisualStyleBackColor = false;
            // 
            // btn_gameManagement
            // 
            this.btn_gameManagement.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(18)))), ((int)(((byte)(28)))));
            this.btn_gameManagement.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_gameManagement.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.btn_gameManagement.FlatAppearance.BorderSize = 3;
            this.btn_gameManagement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_gameManagement.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_gameManagement.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(186)))), ((int)(((byte)(11)))));
            this.btn_gameManagement.Location = new System.Drawing.Point(22, 246);
            this.btn_gameManagement.Name = "btn_gameManagement";
            this.btn_gameManagement.Size = new System.Drawing.Size(148, 49);
            this.btn_gameManagement.TabIndex = 0;
            this.btn_gameManagement.Text = "Gerenciar Jogos";
            this.btn_gameManagement.UseVisualStyleBackColor = false;
            // 
            // btn_userManagement
            // 
            this.btn_userManagement.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(18)))), ((int)(((byte)(28)))));
            this.btn_userManagement.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_userManagement.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.btn_userManagement.FlatAppearance.BorderSize = 3;
            this.btn_userManagement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_userManagement.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_userManagement.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(186)))), ((int)(((byte)(11)))));
            this.btn_userManagement.Location = new System.Drawing.Point(22, 185);
            this.btn_userManagement.Name = "btn_userManagement";
            this.btn_userManagement.Size = new System.Drawing.Size(148, 49);
            this.btn_userManagement.TabIndex = 0;
            this.btn_userManagement.Text = "Gerenciar Usuarios";
            this.btn_userManagement.UseVisualStyleBackColor = false;
            this.btn_userManagement.Click += new System.EventHandler(this.btn_userManagement_Click);
            // 
            // btn_close
            // 
            this.btn_close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(18)))), ((int)(((byte)(28)))));
            this.btn_close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_close.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.btn_close.FlatAppearance.BorderSize = 3;
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_close.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_close.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(186)))), ((int)(((byte)(11)))));
            this.btn_close.Location = new System.Drawing.Point(48, 545);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(75, 25);
            this.btn_close.TabIndex = 2;
            this.btn_close.Text = "Sair";
            this.btn_close.UseVisualStyleBackColor = false;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // picture_user
            // 
            this.picture_user.Location = new System.Drawing.Point(54, 65);
            this.picture_user.Name = "picture_user";
            this.picture_user.Size = new System.Drawing.Size(64, 64);
            this.picture_user.TabIndex = 0;
            this.picture_user.TabStop = false;
            this.picture_user.Click += new System.EventHandler(this.picture_user_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackgroundImage = global::Locadora.Properties.Resources.bg_galaxy;
            this.ClientSize = new System.Drawing.Size(924, 601);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "Home";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picture_user)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.PictureBox picture_user;
        private System.Windows.Forms.Button btn_alocar;
        private System.Windows.Forms.Button btn_gameManagement;
        private System.Windows.Forms.Button btn_userManagement;
    }
}
