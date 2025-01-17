﻿namespace Locadora
{
    partial class User_Management
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView_user = new System.Windows.Forms.DataGridView();
            this.txtBox_search = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btt_search = new System.Windows.Forms.Button();
            this.btt_update = new System.Windows.Forms.Button();
            this.btt_delete = new System.Windows.Forms.Button();
            this.btt_close = new System.Windows.Forms.Button();
            this.btn_newUser = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_user)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_user
            // 
            this.dataGridView_user.AllowUserToDeleteRows = false;
            this.dataGridView_user.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.NullValue = null;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_user.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_user.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            this.dataGridView_user.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView_user.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_user.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_user.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView_user.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dataGridView_user.Location = new System.Drawing.Point(12, 36);
            this.dataGridView_user.MaximumSize = new System.Drawing.Size(720, 520);
            this.dataGridView_user.MultiSelect = false;
            this.dataGridView_user.Name = "dataGridView_user";
            this.dataGridView_user.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dataGridView_user.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_user.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView_user.RowTemplate.Height = 40;
            this.dataGridView_user.Size = new System.Drawing.Size(581, 520);
            this.dataGridView_user.TabIndex = 0;
            // 
            // txtBox_search
            // 
            this.txtBox_search.Location = new System.Drawing.Point(30, 9);
            this.txtBox_search.Name = "txtBox_search";
            this.txtBox_search.Size = new System.Drawing.Size(406, 20);
            this.txtBox_search.TabIndex = 1;
            this.txtBox_search.Enter += new System.EventHandler(this.btt_search_Click);
            // 
            // btt_search
            // 
            this.btt_search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(18)))), ((int)(((byte)(28)))));
            this.btt_search.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.btt_search.FlatAppearance.BorderSize = 3;
            this.btt_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btt_search.Location = new System.Drawing.Point(442, 4);
            this.btt_search.Name = "btt_search";
            this.btt_search.Size = new System.Drawing.Size(75, 29);
            this.btt_search.TabIndex = 2;
            this.btt_search.Text = "Pesquisar";
            this.btt_search.UseVisualStyleBackColor = false;
            this.btt_search.Click += new System.EventHandler(this.btt_search_Click);
            // 
            // btt_update
            // 
            this.btt_update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(18)))), ((int)(((byte)(28)))));
            this.btt_update.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.btt_update.FlatAppearance.BorderSize = 3;
            this.btt_update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btt_update.Location = new System.Drawing.Point(197, 562);
            this.btt_update.Name = "btt_update";
            this.btt_update.Size = new System.Drawing.Size(75, 32);
            this.btt_update.TabIndex = 3;
            this.btt_update.Text = "Atualizar";
            this.btt_update.UseVisualStyleBackColor = false;
            this.btt_update.Click += new System.EventHandler(this.btt_update_Click);
            // 
            // btt_delete
            // 
            this.btt_delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(18)))), ((int)(((byte)(28)))));
            this.btt_delete.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.btt_delete.FlatAppearance.BorderSize = 3;
            this.btt_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btt_delete.Location = new System.Drawing.Point(320, 562);
            this.btt_delete.Name = "btt_delete";
            this.btt_delete.Size = new System.Drawing.Size(75, 32);
            this.btt_delete.TabIndex = 4;
            this.btt_delete.Text = "Excluir";
            this.btt_delete.UseVisualStyleBackColor = false;
            this.btt_delete.Click += new System.EventHandler(this.btt_delete_Click);
            // 
            // btt_close
            // 
            this.btt_close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(18)))), ((int)(((byte)(28)))));
            this.btt_close.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.btt_close.FlatAppearance.BorderSize = 3;
            this.btt_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btt_close.Location = new System.Drawing.Point(442, 562);
            this.btt_close.Name = "btt_close";
            this.btt_close.Size = new System.Drawing.Size(75, 32);
            this.btt_close.TabIndex = 5;
            this.btt_close.Text = "Fechar";
            this.btt_close.UseVisualStyleBackColor = false;
            this.btt_close.Click += new System.EventHandler(this.btt_close_Click);
            // 
            // btn_newUser
            // 
            this.btn_newUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(18)))), ((int)(((byte)(28)))));
            this.btn_newUser.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.btn_newUser.FlatAppearance.BorderSize = 3;
            this.btn_newUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_newUser.Location = new System.Drawing.Point(74, 562);
            this.btn_newUser.Name = "btn_newUser";
            this.btn_newUser.Size = new System.Drawing.Size(75, 32);
            this.btn_newUser.TabIndex = 6;
            this.btn_newUser.Text = "Novo";
            this.btn_newUser.UseVisualStyleBackColor = false;
            this.btn_newUser.Click += new System.EventHandler(this.btn_newUser_Click);
            // 
            // User_Management
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Locadora.Properties.Resources.bg_galaxy;
            this.ClientSize = new System.Drawing.Size(605, 600);
            this.Controls.Add(this.btn_newUser);
            this.Controls.Add(this.btt_close);
            this.Controls.Add(this.btt_delete);
            this.Controls.Add(this.btt_update);
            this.Controls.Add(this.btt_search);
            this.Controls.Add(this.txtBox_search);
            this.Controls.Add(this.dataGridView_user);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(186)))), ((int)(((byte)(11)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "User_Management";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Gerenciar Usuarios";
            this.Load += new System.EventHandler(this.User_Management_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_user)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_user;
        private System.Windows.Forms.TextBox txtBox_search;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btt_search;
        private System.Windows.Forms.Button btt_update;
        private System.Windows.Forms.Button btt_delete;
        private System.Windows.Forms.Button btt_close;
        private System.Windows.Forms.Button btn_newUser;
    }
}