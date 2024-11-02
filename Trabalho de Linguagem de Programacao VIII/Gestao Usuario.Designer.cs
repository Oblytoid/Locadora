namespace Locadora
{
    partial class Gestao_Usuario
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
            this.dataGridView_user = new System.Windows.Forms.DataGridView();
            this.txtBox_search = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btt_search = new System.Windows.Forms.Button();
            this.btt_update = new System.Windows.Forms.Button();
            this.btt_delete = new System.Windows.Forms.Button();
            this.btt_close = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_user)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_user
            // 
            this.dataGridView_user.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_user.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridView_user.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedHeaders;
            this.dataGridView_user.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_user.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dataGridView_user.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dataGridView_user.Location = new System.Drawing.Point(12, 36);
            this.dataGridView_user.MaximumSize = new System.Drawing.Size(720, 520);
            this.dataGridView_user.MinimumSize = new System.Drawing.Size(720, 520);
            this.dataGridView_user.MultiSelect = false;
            this.dataGridView_user.Name = "dataGridView_user";
            this.dataGridView_user.ReadOnly = true;
            this.dataGridView_user.Size = new System.Drawing.Size(720, 520);
            this.dataGridView_user.TabIndex = 0;
            this.dataGridView_user.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // txtBox_search
            // 
            this.txtBox_search.Location = new System.Drawing.Point(158, 10);
            this.txtBox_search.Name = "txtBox_search";
            this.txtBox_search.Size = new System.Drawing.Size(290, 20);
            this.txtBox_search.TabIndex = 1;
            // 
            // btt_search
            // 
            this.btt_search.Location = new System.Drawing.Point(454, 10);
            this.btt_search.Name = "btt_search";
            this.btt_search.Size = new System.Drawing.Size(75, 20);
            this.btt_search.TabIndex = 2;
            this.btt_search.Text = "Pesquisar";
            this.btt_search.UseVisualStyleBackColor = true;
            this.btt_search.Click += new System.EventHandler(this.btt_search_Click);
            // 
            // btt_update
            // 
            this.btt_update.Location = new System.Drawing.Point(52, 565);
            this.btt_update.Name = "btt_update";
            this.btt_update.Size = new System.Drawing.Size(75, 23);
            this.btt_update.TabIndex = 3;
            this.btt_update.Text = "Atualizar";
            this.btt_update.UseVisualStyleBackColor = true;
            // 
            // btt_delete
            // 
            this.btt_delete.Location = new System.Drawing.Point(335, 565);
            this.btt_delete.Name = "btt_delete";
            this.btt_delete.Size = new System.Drawing.Size(75, 23);
            this.btt_delete.TabIndex = 4;
            this.btt_delete.Text = "Excluir";
            this.btt_delete.UseVisualStyleBackColor = true;
            this.btt_delete.Click += new System.EventHandler(this.btt_delete_Click);
            // 
            // btt_close
            // 
            this.btt_close.Location = new System.Drawing.Point(618, 565);
            this.btt_close.Name = "btt_close";
            this.btt_close.Size = new System.Drawing.Size(75, 23);
            this.btt_close.TabIndex = 5;
            this.btt_close.Text = "Fechar";
            this.btt_close.UseVisualStyleBackColor = true;
            this.btt_close.Click += new System.EventHandler(this.btt_close_Click);
            // 
            // Gestao_Usuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 600);
            this.Controls.Add(this.btt_close);
            this.Controls.Add(this.btt_delete);
            this.Controls.Add(this.btt_update);
            this.Controls.Add(this.btt_search);
            this.Controls.Add(this.txtBox_search);
            this.Controls.Add(this.dataGridView_user);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Gestao_Usuario";
            this.Text = "Gestao_Usuario";
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
    }
}