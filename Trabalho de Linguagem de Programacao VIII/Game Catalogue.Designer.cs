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
            this.DataGrindView_list_games = new System.Windows.Forms.DataGridView();
            this.btt_close = new System.Windows.Forms.Button();
            this.btt_delete = new System.Windows.Forms.Button();
            this.btt_add = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrindView_list_games)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGrindView_list_games
            // 
            this.DataGrindView_list_games.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGrindView_list_games.Location = new System.Drawing.Point(0, 0);
            this.DataGrindView_list_games.Name = "DataGrindView_list_games";
            this.DataGrindView_list_games.Size = new System.Drawing.Size(471, 514);
            this.DataGrindView_list_games.TabIndex = 0;
            // 
            // btt_close
            // 
            this.btt_close.Location = new System.Drawing.Point(374, 520);
            this.btt_close.Name = "btt_close";
            this.btt_close.Size = new System.Drawing.Size(75, 23);
            this.btt_close.TabIndex = 0;
            this.btt_close.Text = "Fechar";
            // 
            // btt_delete
            // 
            this.btt_delete.Location = new System.Drawing.Point(196, 520);
            this.btt_delete.Name = "btt_delete";
            this.btt_delete.Size = new System.Drawing.Size(75, 23);
            this.btt_delete.TabIndex = 1;
            this.btt_delete.Text = "Excluir";
            this.btt_delete.UseVisualStyleBackColor = true;
            // 
            // btt_add
            // 
            this.btt_add.Location = new System.Drawing.Point(31, 520);
            this.btt_add.Name = "btt_add";
            this.btt_add.Size = new System.Drawing.Size(75, 23);
            this.btt_add.TabIndex = 2;
            this.btt_add.Text = "Adicionar";
            this.btt_add.UseVisualStyleBackColor = true;
            this.btt_add.Click += new System.EventHandler(this.btt_add_Click);
            // 
            // Catalogo_Jogos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(973, 573);
            this.Controls.Add(this.btt_add);
            this.Controls.Add(this.btt_delete);
            this.Controls.Add(this.btt_close);
            this.Controls.Add(this.DataGrindView_list_games);
            this.Name = "Catalogo_Jogos";
            this.Text = "Catalogo_Jogos";
            ((System.ComponentModel.ISupportInitialize)(this.DataGrindView_list_games)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DataGrindView_list_games;
        private System.Windows.Forms.Button btt_close;
        private System.Windows.Forms.Button btt_delete;
        private System.Windows.Forms.Button btt_add;
    }
}