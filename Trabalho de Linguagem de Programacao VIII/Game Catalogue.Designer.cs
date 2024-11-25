namespace Locadora
{
    partial class Catalogo_Jogos
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
            this.dgv_list_games = new System.Windows.Forms.DataGridView();
            this.btt_search = new System.Windows.Forms.Button();
            this.txtbox_search = new System.Windows.Forms.TextBox();
            this.btn_newGame = new System.Windows.Forms.Button();
            this.btt_close = new System.Windows.Forms.Button();
            this.btt_delete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_list_games)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_list_games
            // 
            this.dgv_list_games.AllowUserToAddRows = false;
            this.dgv_list_games.AllowUserToDeleteRows = false;
            this.dgv_list_games.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            this.dgv_list_games.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_list_games.Location = new System.Drawing.Point(12, 36);
            this.dgv_list_games.MultiSelect = false;
            this.dgv_list_games.Name = "dgv_list_games";
            this.dgv_list_games.ReadOnly = true;
            this.dgv_list_games.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dgv_list_games.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_list_games.Size = new System.Drawing.Size(581, 520);
            this.dgv_list_games.TabIndex = 0;
            this.dgv_list_games.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_list_games_CellClick);
            // 
            // btt_search
            // 
            this.btt_search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(18)))), ((int)(((byte)(28)))));
            this.btt_search.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.btt_search.FlatAppearance.BorderSize = 3;
            this.btt_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btt_search.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(186)))), ((int)(((byte)(11)))));
            this.btt_search.Location = new System.Drawing.Point(471, 4);
            this.btt_search.Name = "btt_search";
            this.btt_search.Size = new System.Drawing.Size(75, 29);
            this.btt_search.TabIndex = 4;
            this.btt_search.Text = "Pesquisar";
            this.btt_search.UseVisualStyleBackColor = false;
            this.btt_search.Click += new System.EventHandler(this.btt_search_Click);
            // 
            // txtbox_search
            // 
            this.txtbox_search.Location = new System.Drawing.Point(59, 9);
            this.txtbox_search.Name = "txtbox_search";
            this.txtbox_search.Size = new System.Drawing.Size(406, 20);
            this.txtbox_search.TabIndex = 3;
            // 
            // btn_newGame
            // 
            this.btn_newGame.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(18)))), ((int)(((byte)(28)))));
            this.btn_newGame.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.btn_newGame.FlatAppearance.BorderSize = 3;
            this.btn_newGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_newGame.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(186)))), ((int)(((byte)(11)))));
            this.btn_newGame.Location = new System.Drawing.Point(81, 562);
            this.btn_newGame.Name = "btn_newGame";
            this.btn_newGame.Size = new System.Drawing.Size(75, 32);
            this.btn_newGame.TabIndex = 10;
            this.btn_newGame.Text = "Novo";
            this.btn_newGame.UseVisualStyleBackColor = false;
            this.btn_newGame.Click += new System.EventHandler(this.btn_newGame_Click);
            // 
            // btt_close
            // 
            this.btt_close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(18)))), ((int)(((byte)(28)))));
            this.btt_close.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.btt_close.FlatAppearance.BorderSize = 3;
            this.btt_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btt_close.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(186)))), ((int)(((byte)(11)))));
            this.btt_close.Location = new System.Drawing.Point(449, 562);
            this.btt_close.Name = "btt_close";
            this.btt_close.Size = new System.Drawing.Size(75, 32);
            this.btt_close.TabIndex = 9;
            this.btt_close.Text = "Fechar";
            this.btt_close.UseVisualStyleBackColor = false;
            this.btt_close.Click += new System.EventHandler(this.btt_close_Click);
            // 
            // btt_delete
            // 
            this.btt_delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(18)))), ((int)(((byte)(28)))));
            this.btt_delete.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.btt_delete.FlatAppearance.BorderSize = 3;
            this.btt_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btt_delete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(186)))), ((int)(((byte)(11)))));
            this.btt_delete.Location = new System.Drawing.Point(265, 562);
            this.btt_delete.Name = "btt_delete";
            this.btt_delete.Size = new System.Drawing.Size(75, 32);
            this.btt_delete.TabIndex = 8;
            this.btt_delete.Text = "Excluir";
            this.btt_delete.UseVisualStyleBackColor = false;
            this.btt_delete.Click += new System.EventHandler(this.btt_delete_Click);
            // 
            // Catalogo_Jogos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Locadora.Properties.Resources.bg_galaxy;
            this.ClientSize = new System.Drawing.Size(605, 600);
            this.Controls.Add(this.btn_newGame);
            this.Controls.Add(this.btt_close);
            this.Controls.Add(this.btt_delete);
            this.Controls.Add(this.btt_search);
            this.Controls.Add(this.txtbox_search);
            this.Controls.Add(this.dgv_list_games);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Catalogo_Jogos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Catalogo_Jogos";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_list_games)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_list_games;
        private System.Windows.Forms.Button btt_search;
        private System.Windows.Forms.TextBox txtbox_search;
        private System.Windows.Forms.Button btn_newGame;
        private System.Windows.Forms.Button btt_delete;
        private System.Windows.Forms.Button btt_close;
    }
}