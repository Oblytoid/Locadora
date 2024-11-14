namespace Locadora
{
    partial class Game_Register
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
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_novo = new System.Windows.Forms.Button();
            this.game_pictureBox = new System.Windows.Forms.PictureBox();
            this.lbl_nome = new System.Windows.Forms.Label();
            this.lbl_desc = new System.Windows.Forms.Label();
            this.lbl_plataforma = new System.Windows.Forms.Label();
            this.lbl_genero = new System.Windows.Forms.Label();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.txt_desc = new System.Windows.Forms.TextBox();
            this.checkList_plataform = new System.Windows.Forms.CheckedListBox();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            ((System.ComponentModel.ISupportInitialize)(this.game_pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_cancel
            // 
            this.btn_cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(18)))), ((int)(((byte)(28)))));
            this.btn_cancel.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.btn_cancel.FlatAppearance.BorderSize = 3;
            this.btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(186)))), ((int)(((byte)(11)))));
            this.btn_cancel.Location = new System.Drawing.Point(194, 418);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 37);
            this.btn_cancel.TabIndex = 21;
            this.btn_cancel.Text = "Cancelar";
            this.btn_cancel.UseVisualStyleBackColor = false;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_novo
            // 
            this.btn_novo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(18)))), ((int)(((byte)(28)))));
            this.btn_novo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_novo.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.btn_novo.FlatAppearance.BorderSize = 3;
            this.btn_novo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_novo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(186)))), ((int)(((byte)(11)))));
            this.btn_novo.Location = new System.Drawing.Point(40, 418);
            this.btn_novo.Name = "btn_novo";
            this.btn_novo.Size = new System.Drawing.Size(75, 37);
            this.btn_novo.TabIndex = 20;
            this.btn_novo.Text = "Novo";
            this.btn_novo.UseVisualStyleBackColor = false;
            // 
            // game_pictureBox
            // 
            this.game_pictureBox.Location = new System.Drawing.Point(99, 20);
            this.game_pictureBox.Name = "game_pictureBox";
            this.game_pictureBox.Size = new System.Drawing.Size(101, 117);
            this.game_pictureBox.TabIndex = 22;
            this.game_pictureBox.TabStop = false;
            this.game_pictureBox.Click += new System.EventHandler(this.game_pictureBox_Click);
            // 
            // lbl_nome
            // 
            this.lbl_nome.AutoSize = true;
            this.lbl_nome.Location = new System.Drawing.Point(44, 167);
            this.lbl_nome.Name = "lbl_nome";
            this.lbl_nome.Size = new System.Drawing.Size(35, 13);
            this.lbl_nome.TabIndex = 23;
            this.lbl_nome.Text = "Nome";
            // 
            // lbl_desc
            // 
            this.lbl_desc.AutoSize = true;
            this.lbl_desc.Location = new System.Drawing.Point(25, 205);
            this.lbl_desc.Name = "lbl_desc";
            this.lbl_desc.Size = new System.Drawing.Size(55, 13);
            this.lbl_desc.TabIndex = 24;
            this.lbl_desc.Text = "Descrição";
            // 
            // lbl_plataforma
            // 
            this.lbl_plataforma.AutoSize = true;
            this.lbl_plataforma.Location = new System.Drawing.Point(25, 242);
            this.lbl_plataforma.Name = "lbl_plataforma";
            this.lbl_plataforma.Size = new System.Drawing.Size(57, 13);
            this.lbl_plataforma.TabIndex = 25;
            this.lbl_plataforma.Text = "Plataforma";
            // 
            // lbl_genero
            // 
            this.lbl_genero.AutoSize = true;
            this.lbl_genero.Location = new System.Drawing.Point(37, 278);
            this.lbl_genero.Name = "lbl_genero";
            this.lbl_genero.Size = new System.Drawing.Size(42, 13);
            this.lbl_genero.TabIndex = 26;
            this.lbl_genero.Text = "Genero";
            // 
            // txt_nome
            // 
            this.txt_nome.Location = new System.Drawing.Point(100, 164);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(169, 20);
            this.txt_nome.TabIndex = 27;
            // 
            // txt_desc
            // 
            this.txt_desc.Location = new System.Drawing.Point(99, 205);
            this.txt_desc.Name = "txt_desc";
            this.txt_desc.Size = new System.Drawing.Size(169, 20);
            this.txt_desc.TabIndex = 28;
            // 
            // checkList_plataform
            // 
            this.checkList_plataform.FormattingEnabled = true;
            this.checkList_plataform.Items.AddRange(new object[] {
            "Playstation 1",
            "Playstation 2",
            "Playstation 3",
            "Playstation 4",
            "Playstation 5",
            "Playstation Portable",
            "Playstaton Vita"});
            this.checkList_plataform.Location = new System.Drawing.Point(100, 242);
            this.checkList_plataform.Name = "checkList_plataform";
            this.checkList_plataform.Size = new System.Drawing.Size(168, 19);
            this.checkList_plataform.TabIndex = 30;
            this.checkList_plataform.MouseEnter += new System.EventHandler(this.checkList_plataform_MouseEnter);
            this.checkList_plataform.MouseLeave += new System.EventHandler(this.checkList_plataform_MouseLeave);
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "Playstation 1",
            "Playstation 2",
            "Playstation 3",
            "Playstation 4",
            "Playstation 5",
            "Playstation Portable",
            "Playstaton Vita"});
            this.checkedListBox1.Location = new System.Drawing.Point(99, 275);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(168, 19);
            this.checkedListBox1.TabIndex = 31;
            
            // 
            // Game_Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Locadora.Properties.Resources.bg_galaxy;
            this.ClientSize = new System.Drawing.Size(308, 483);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.checkList_plataform);
            this.Controls.Add(this.txt_desc);
            this.Controls.Add(this.txt_nome);
            this.Controls.Add(this.lbl_genero);
            this.Controls.Add(this.lbl_plataforma);
            this.Controls.Add(this.lbl_desc);
            this.Controls.Add(this.lbl_nome);
            this.Controls.Add(this.game_pictureBox);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_novo);
            this.Name = "Game_Register";
            this.Text = "Game Register";
            ((System.ComponentModel.ISupportInitialize)(this.game_pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_novo;
        private System.Windows.Forms.PictureBox game_pictureBox;
        private System.Windows.Forms.Label lbl_nome;
        private System.Windows.Forms.Label lbl_desc;
        private System.Windows.Forms.Label lbl_plataforma;
        private System.Windows.Forms.Label lbl_genero;
        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.TextBox txt_desc;
        private System.Windows.Forms.CheckedListBox checkList_plataform;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
    }
}