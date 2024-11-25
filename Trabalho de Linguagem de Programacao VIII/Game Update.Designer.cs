namespace Locadora
{
    partial class Game_Update
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
            this.game_pictureBox = new System.Windows.Forms.PictureBox();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_dev = new System.Windows.Forms.Label();
            this.lbl_genre = new System.Windows.Forms.Label();
            this.lbl_plataform = new System.Windows.Forms.Label();
            this.lbl_desc = new System.Windows.Forms.Label();
            this.lbl_name = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.game_pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // game_pictureBox
            // 
            this.game_pictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.game_pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.game_pictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.game_pictureBox.Location = new System.Drawing.Point(104, 24);
            this.game_pictureBox.Name = "game_pictureBox";
            this.game_pictureBox.Size = new System.Drawing.Size(101, 117);
            this.game_pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.game_pictureBox.TabIndex = 40;
            this.game_pictureBox.TabStop = false;
            // 
            // btn_cancel
            // 
            this.btn_cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(18)))), ((int)(((byte)(28)))));
            this.btn_cancel.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.btn_cancel.FlatAppearance.BorderSize = 3;
            this.btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(186)))), ((int)(((byte)(11)))));
            this.btn_cancel.Location = new System.Drawing.Point(199, 422);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 37);
            this.btn_cancel.TabIndex = 39;
            this.btn_cancel.Text = "Cancelar";
            this.btn_cancel.UseVisualStyleBackColor = false;
            // 
            // btn_update
            // 
            this.btn_update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(18)))), ((int)(((byte)(28)))));
            this.btn_update.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_update.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.btn_update.FlatAppearance.BorderSize = 3;
            this.btn_update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_update.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(186)))), ((int)(((byte)(11)))));
            this.btn_update.Location = new System.Drawing.Point(45, 422);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(75, 37);
            this.btn_update.TabIndex = 38;
            this.btn_update.Text = "Atualizar";
            this.btn_update.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Location = new System.Drawing.Point(12, 325);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 13);
            this.label2.TabIndex = 46;
            this.label2.Text = "Data de Lançamento";
            // 
            // lbl_dev
            // 
            this.lbl_dev.AutoSize = true;
            this.lbl_dev.BackColor = System.Drawing.Color.Transparent;
            this.lbl_dev.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl_dev.Location = new System.Drawing.Point(12, 233);
            this.lbl_dev.Name = "lbl_dev";
            this.lbl_dev.Size = new System.Drawing.Size(85, 13);
            this.lbl_dev.TabIndex = 45;
            this.lbl_dev.Text = "Desenvolvedora";
            // 
            // lbl_genre
            // 
            this.lbl_genre.AutoSize = true;
            this.lbl_genre.BackColor = System.Drawing.Color.Transparent;
            this.lbl_genre.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl_genre.Location = new System.Drawing.Point(52, 295);
            this.lbl_genre.Name = "lbl_genre";
            this.lbl_genre.Size = new System.Drawing.Size(42, 13);
            this.lbl_genre.TabIndex = 44;
            this.lbl_genre.Text = "Genero";
            // 
            // lbl_plataform
            // 
            this.lbl_plataform.AutoSize = true;
            this.lbl_plataform.BackColor = System.Drawing.Color.Transparent;
            this.lbl_plataform.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl_plataform.Location = new System.Drawing.Point(40, 264);
            this.lbl_plataform.Name = "lbl_plataform";
            this.lbl_plataform.Size = new System.Drawing.Size(57, 13);
            this.lbl_plataform.TabIndex = 43;
            this.lbl_plataform.Text = "Plataforma";
            // 
            // lbl_desc
            // 
            this.lbl_desc.AutoSize = true;
            this.lbl_desc.BackColor = System.Drawing.Color.Transparent;
            this.lbl_desc.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl_desc.Location = new System.Drawing.Point(40, 202);
            this.lbl_desc.Name = "lbl_desc";
            this.lbl_desc.Size = new System.Drawing.Size(55, 13);
            this.lbl_desc.TabIndex = 42;
            this.lbl_desc.Text = "Descrição";
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.BackColor = System.Drawing.Color.Transparent;
            this.lbl_name.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl_name.Location = new System.Drawing.Point(59, 171);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(35, 13);
            this.lbl_name.TabIndex = 41;
            this.lbl_name.Text = "Nome";
            // 
            // Game_Update
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Locadora.Properties.Resources.bg_galaxy;
            this.ClientSize = new System.Drawing.Size(308, 483);
            this.Controls.Add(this.game_pictureBox);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_dev);
            this.Controls.Add(this.lbl_genre);
            this.Controls.Add(this.lbl_plataform);
            this.Controls.Add(this.lbl_desc);
            this.Controls.Add(this.lbl_name);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Game_Update";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Atualizar jogo";
            ((System.ComponentModel.ISupportInitialize)(this.game_pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox game_pictureBox;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_dev;
        private System.Windows.Forms.Label lbl_genre;
        private System.Windows.Forms.Label lbl_plataform;
        private System.Windows.Forms.Label lbl_desc;
        private System.Windows.Forms.Label lbl_name;
    }
}