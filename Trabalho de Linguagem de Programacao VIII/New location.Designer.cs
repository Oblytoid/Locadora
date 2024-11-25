namespace Locadora
{
    partial class New_Alocation
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
            this.btn_new = new System.Windows.Forms.Button();
            this.btt_cancel = new System.Windows.Forms.Button();
            this.listBox_game = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listBox_user = new System.Windows.Forms.ListBox();
            this.pictureBox_user = new System.Windows.Forms.PictureBox();
            this.pictureBox_game = new System.Windows.Forms.PictureBox();
            this.dateTimePicker_withdrawal = new System.Windows.Forms.DateTimePicker();
            this.lbl_date = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker_devolution = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_user)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_game)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_new
            // 
            this.btn_new.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(18)))), ((int)(((byte)(28)))));
            this.btn_new.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.btn_new.FlatAppearance.BorderSize = 3;
            this.btn_new.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_new.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(186)))), ((int)(((byte)(11)))));
            this.btn_new.Location = new System.Drawing.Point(80, 364);
            this.btn_new.Name = "btn_new";
            this.btn_new.Size = new System.Drawing.Size(75, 32);
            this.btn_new.TabIndex = 14;
            this.btn_new.Text = "Alugar";
            this.btn_new.UseVisualStyleBackColor = false;
            this.btn_new.Click += new System.EventHandler(this.btn_newLocation_Click);
            // 
            // btt_cancel
            // 
            this.btt_cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(18)))), ((int)(((byte)(28)))));
            this.btt_cancel.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.btt_cancel.FlatAppearance.BorderSize = 3;
            this.btt_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btt_cancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(186)))), ((int)(((byte)(11)))));
            this.btt_cancel.Location = new System.Drawing.Point(297, 364);
            this.btt_cancel.Name = "btt_cancel";
            this.btt_cancel.Size = new System.Drawing.Size(75, 32);
            this.btt_cancel.TabIndex = 13;
            this.btt_cancel.Text = "Cancelar";
            this.btt_cancel.UseVisualStyleBackColor = false;
            this.btt_cancel.Click += new System.EventHandler(this.btt_close_Click);
            // 
            // listBox_game
            // 
            this.listBox_game.FormattingEnabled = true;
            this.listBox_game.Items.AddRange(new object[] {
            ""});
            this.listBox_game.Location = new System.Drawing.Point(68, 201);
            this.listBox_game.Name = "listBox_game";
            this.listBox_game.Size = new System.Drawing.Size(125, 17);
            this.listBox_game.Sorted = true;
            this.listBox_game.TabIndex = 15;
            this.listBox_game.SelectedIndexChanged += new System.EventHandler(this.listBox_game_SelectedIndexChanged);
            this.listBox_game.MouseEnter += new System.EventHandler(this.listBox_game_MouseEnter);
            this.listBox_game.MouseLeave += new System.EventHandler(this.listBox_game_MouseLeave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(24, 203);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Jogos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Location = new System.Drawing.Point(229, 205);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Usuarios";
            // 
            // listBox_user
            // 
            this.listBox_user.FormattingEnabled = true;
            this.listBox_user.Items.AddRange(new object[] {
            ""});
            this.listBox_user.Location = new System.Drawing.Point(285, 205);
            this.listBox_user.Name = "listBox_user";
            this.listBox_user.Size = new System.Drawing.Size(125, 17);
            this.listBox_user.Sorted = true;
            this.listBox_user.TabIndex = 17;
            this.listBox_user.SelectedIndexChanged += new System.EventHandler(this.listBox_user_SelectedIndexChanged);
            this.listBox_user.MouseEnter += new System.EventHandler(this.listBox_user_MouseEnter);
            this.listBox_user.MouseLeave += new System.EventHandler(this.listBox_user_MouseLeave);
            // 
            // pictureBox_user
            // 
            this.pictureBox_user.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox_user.Location = new System.Drawing.Point(285, 44);
            this.pictureBox_user.Name = "pictureBox_user";
            this.pictureBox_user.Size = new System.Drawing.Size(100, 113);
            this.pictureBox_user.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_user.TabIndex = 19;
            this.pictureBox_user.TabStop = false;
            // 
            // pictureBox_game
            // 
            this.pictureBox_game.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox_game.Location = new System.Drawing.Point(68, 44);
            this.pictureBox_game.Name = "pictureBox_game";
            this.pictureBox_game.Size = new System.Drawing.Size(100, 113);
            this.pictureBox_game.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_game.TabIndex = 20;
            this.pictureBox_game.TabStop = false;
            // 
            // dateTimePicker_withdrawal
            // 
            this.dateTimePicker_withdrawal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_withdrawal.Location = new System.Drawing.Point(114, 260);
            this.dateTimePicker_withdrawal.Name = "dateTimePicker_withdrawal";
            this.dateTimePicker_withdrawal.Size = new System.Drawing.Size(79, 20);
            this.dateTimePicker_withdrawal.TabIndex = 21;
            // 
            // lbl_date
            // 
            this.lbl_date.AutoSize = true;
            this.lbl_date.BackColor = System.Drawing.Color.Transparent;
            this.lbl_date.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl_date.Location = new System.Drawing.Point(21, 263);
            this.lbl_date.Name = "lbl_date";
            this.lbl_date.Size = new System.Drawing.Size(86, 13);
            this.lbl_date.TabIndex = 22;
            this.lbl_date.Text = "Data de retirada:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Location = new System.Drawing.Point(229, 263);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "Data de devolução:";
            // 
            // dateTimePicker_devolution
            // 
            this.dateTimePicker_devolution.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_devolution.Location = new System.Drawing.Point(331, 260);
            this.dateTimePicker_devolution.Name = "dateTimePicker_devolution";
            this.dateTimePicker_devolution.Size = new System.Drawing.Size(79, 20);
            this.dateTimePicker_devolution.TabIndex = 23;
            // 
            // New_Alocation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Locadora.Properties.Resources.bc_color1;
            this.ClientSize = new System.Drawing.Size(434, 420);
            this.Controls.Add(this.listBox_game);
            this.Controls.Add(this.listBox_user);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbl_date);
            this.Controls.Add(this.pictureBox_game);
            this.Controls.Add(this.pictureBox_user);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_new);
            this.Controls.Add(this.btt_cancel);
            this.Controls.Add(this.dateTimePicker_withdrawal);
            this.Controls.Add(this.dateTimePicker_devolution);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "New_Alocation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Nova locação";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_user)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_game)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_new;
        private System.Windows.Forms.Button btt_cancel;
        private System.Windows.Forms.ListBox listBox_game;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBox_user;
        private System.Windows.Forms.PictureBox pictureBox_user;
        private System.Windows.Forms.PictureBox pictureBox_game;
        private System.Windows.Forms.DateTimePicker dateTimePicker_withdrawal;
        private System.Windows.Forms.Label lbl_date;
        private System.Windows.Forms.DateTimePicker dateTimePicker_devolution;
        private System.Windows.Forms.Label label3;
    }
}