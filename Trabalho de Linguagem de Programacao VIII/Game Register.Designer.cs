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
            this.btn_newgame = new System.Windows.Forms.Button();
            this.game_pictureBox = new System.Windows.Forms.PictureBox();
            this.lbl_name = new System.Windows.Forms.Label();
            this.lbl_desc = new System.Windows.Forms.Label();
            this.lbl_plataform = new System.Windows.Forms.Label();
            this.lbl_genero = new System.Windows.Forms.Label();
            this.txt_gameName = new System.Windows.Forms.TextBox();
            this.txt_gameDescription = new System.Windows.Forms.TextBox();
            this.listbox_gender = new System.Windows.Forms.ListBox();
            this.listbox_plataform = new System.Windows.Forms.ListBox();
            this.lbl_dev = new System.Windows.Forms.Label();
            this.listbox_publisher = new System.Windows.Forms.ListBox();
            this.dtp_LaunchDate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
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
            // btn_newgame
            // 
            this.btn_newgame.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(18)))), ((int)(((byte)(28)))));
            this.btn_newgame.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_newgame.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.btn_newgame.FlatAppearance.BorderSize = 3;
            this.btn_newgame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_newgame.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(186)))), ((int)(((byte)(11)))));
            this.btn_newgame.Location = new System.Drawing.Point(40, 418);
            this.btn_newgame.Name = "btn_newgame";
            this.btn_newgame.Size = new System.Drawing.Size(75, 37);
            this.btn_newgame.TabIndex = 20;
            this.btn_newgame.Text = "Novo";
            this.btn_newgame.UseVisualStyleBackColor = false;
            this.btn_newgame.Click += new System.EventHandler(this.btn_newgame_Click);
            // 
            // game_pictureBox
            // 
            this.game_pictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.game_pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.game_pictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.game_pictureBox.Location = new System.Drawing.Point(99, 20);
            this.game_pictureBox.Name = "game_pictureBox";
            this.game_pictureBox.Size = new System.Drawing.Size(101, 117);
            this.game_pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.game_pictureBox.TabIndex = 22;
            this.game_pictureBox.TabStop = false;
            this.game_pictureBox.Click += new System.EventHandler(this.game_pictureBox_Click);
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.BackColor = System.Drawing.Color.Transparent;
            this.lbl_name.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl_name.Location = new System.Drawing.Point(54, 167);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(35, 13);
            this.lbl_name.TabIndex = 23;
            this.lbl_name.Text = "Nome";
            // 
            // lbl_desc
            // 
            this.lbl_desc.AutoSize = true;
            this.lbl_desc.BackColor = System.Drawing.Color.Transparent;
            this.lbl_desc.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl_desc.Location = new System.Drawing.Point(35, 198);
            this.lbl_desc.Name = "lbl_desc";
            this.lbl_desc.Size = new System.Drawing.Size(55, 13);
            this.lbl_desc.TabIndex = 24;
            this.lbl_desc.Text = "Descrição";
            // 
            // lbl_plataform
            // 
            this.lbl_plataform.AutoSize = true;
            this.lbl_plataform.BackColor = System.Drawing.Color.Transparent;
            this.lbl_plataform.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl_plataform.Location = new System.Drawing.Point(35, 260);
            this.lbl_plataform.Name = "lbl_plataform";
            this.lbl_plataform.Size = new System.Drawing.Size(57, 13);
            this.lbl_plataform.TabIndex = 25;
            this.lbl_plataform.Text = "Plataforma";
            // 
            // lbl_genero
            // 
            this.lbl_genero.AutoSize = true;
            this.lbl_genero.BackColor = System.Drawing.Color.Transparent;
            this.lbl_genero.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl_genero.Location = new System.Drawing.Point(47, 291);
            this.lbl_genero.Name = "lbl_genero";
            this.lbl_genero.Size = new System.Drawing.Size(42, 13);
            this.lbl_genero.TabIndex = 26;
            this.lbl_genero.Text = "Genero";
            // 
            // txt_gameName
            // 
            this.txt_gameName.Location = new System.Drawing.Point(100, 163);
            this.txt_gameName.Name = "txt_gameName";
            this.txt_gameName.Size = new System.Drawing.Size(169, 20);
            this.txt_gameName.TabIndex = 27;
            // 
            // txt_gameDescription
            // 
            this.txt_gameDescription.Location = new System.Drawing.Point(99, 196);
            this.txt_gameDescription.Name = "txt_gameDescription";
            this.txt_gameDescription.Size = new System.Drawing.Size(169, 20);
            this.txt_gameDescription.TabIndex = 28;
            // 
            // listbox_gender
            // 
            this.listbox_gender.FormattingEnabled = true;
            this.listbox_gender.Location = new System.Drawing.Point(99, 289);
            this.listbox_gender.Name = "listbox_gender";
            this.listbox_gender.Size = new System.Drawing.Size(170, 17);
            this.listbox_gender.Sorted = true;
            this.listbox_gender.TabIndex = 32;
            this.listbox_gender.MouseEnter += new System.EventHandler(this.listBox_gender_MouseEnter);
            this.listbox_gender.MouseLeave += new System.EventHandler(this.listBox_gender_MouseLeave);
            // 
            // listbox_plataform
            // 
            this.listbox_plataform.FormattingEnabled = true;
            this.listbox_plataform.Location = new System.Drawing.Point(99, 259);
            this.listbox_plataform.Name = "listbox_plataform";
            this.listbox_plataform.Size = new System.Drawing.Size(169, 17);
            this.listbox_plataform.TabIndex = 33;
            this.listbox_plataform.MouseEnter += new System.EventHandler(this.listbox_plataform_MouseEnter);
            this.listbox_plataform.MouseLeave += new System.EventHandler(this.listbox_plataform_MouseLeave);
            // 
            // lbl_dev
            // 
            this.lbl_dev.AutoSize = true;
            this.lbl_dev.BackColor = System.Drawing.Color.Transparent;
            this.lbl_dev.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl_dev.Location = new System.Drawing.Point(7, 229);
            this.lbl_dev.Name = "lbl_dev";
            this.lbl_dev.Size = new System.Drawing.Size(85, 13);
            this.lbl_dev.TabIndex = 34;
            this.lbl_dev.Text = "Desenvolvedora";
            // 
            // listbox_publisher
            // 
            this.listbox_publisher.FormattingEnabled = true;
            this.listbox_publisher.Location = new System.Drawing.Point(99, 229);
            this.listbox_publisher.Name = "listbox_publisher";
            this.listbox_publisher.Size = new System.Drawing.Size(169, 17);
            this.listbox_publisher.TabIndex = 35;
            this.listbox_publisher.SelectedIndexChanged += new System.EventHandler(this.listbox_publisher_SelectedIndexChanged);
            this.listbox_publisher.MouseEnter += new System.EventHandler(this.listbox_publisher_MouseEnter);
            this.listbox_publisher.MouseLeave += new System.EventHandler(this.listbox_publisher_MouseLeave);
            // 
            // dtp_LaunchDate
            // 
            this.dtp_LaunchDate.CustomFormat = "";
            this.dtp_LaunchDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_LaunchDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_LaunchDate.Location = new System.Drawing.Point(119, 315);
            this.dtp_LaunchDate.MinDate = new System.DateTime(1950, 1, 1, 0, 0, 0, 0);
            this.dtp_LaunchDate.Name = "dtp_LaunchDate";
            this.dtp_LaunchDate.Size = new System.Drawing.Size(149, 20);
            this.dtp_LaunchDate.TabIndex = 36;
            this.dtp_LaunchDate.Value = new System.DateTime(2024, 11, 17, 0, 0, 0, 0);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Location = new System.Drawing.Point(7, 321);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 13);
            this.label2.TabIndex = 37;
            this.label2.Text = "Data de Lançamento";
            // 
            // Game_Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Locadora.Properties.Resources.bg_galaxy;
            this.ClientSize = new System.Drawing.Size(308, 483);
            this.Controls.Add(this.listbox_publisher);
            this.Controls.Add(this.listbox_plataform);
            this.Controls.Add(this.txt_gameDescription);
            this.Controls.Add(this.txt_gameName);
            this.Controls.Add(this.game_pictureBox);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_newgame);
            this.Controls.Add(this.listbox_gender);
            this.Controls.Add(this.dtp_LaunchDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_dev);
            this.Controls.Add(this.lbl_genero);
            this.Controls.Add(this.lbl_plataform);
            this.Controls.Add(this.lbl_desc);
            this.Controls.Add(this.lbl_name);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Game_Register";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Game Register";
            ((System.ComponentModel.ISupportInitialize)(this.game_pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_newgame;
        private System.Windows.Forms.PictureBox game_pictureBox;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Label lbl_desc;
        private System.Windows.Forms.Label lbl_plataform;
        private System.Windows.Forms.Label lbl_genero;
        private System.Windows.Forms.TextBox txt_gameName;
        private System.Windows.Forms.TextBox txt_gameDescription;
        private System.Windows.Forms.ListBox listbox_gender;
        private System.Windows.Forms.ListBox listbox_plataform;
        private System.Windows.Forms.Label lbl_dev;
        private System.Windows.Forms.ListBox listbox_publisher;
        private System.Windows.Forms.DateTimePicker dtp_LaunchDate;
        private System.Windows.Forms.Label label2;
    }
}