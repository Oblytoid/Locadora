namespace Locadora
{
    partial class User_Update
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(User_Update));
            this.txt_telefone = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_cpf = new System.Windows.Forms.Label();
            this.lbl_email = new System.Windows.Forms.Label();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.lbl_endereco = new System.Windows.Forms.Label();
            this.txt_endereco = new System.Windows.Forms.TextBox();
            this.lbl_dataNascimento = new System.Windows.Forms.Label();
            this.lbl_sobrenome = new System.Windows.Forms.Label();
            this.lbl_nome = new System.Windows.Forms.Label();
            this.picture_user = new System.Windows.Forms.PictureBox();
            this.lbl_cpf_show = new System.Windows.Forms.Label();
            this.lbl_date_show = new System.Windows.Forms.Label();
            this.lbl_first_name_show = new System.Windows.Forms.Label();
            this.lbl_last_name_show = new System.Windows.Forms.Label();
            this.btt_close = new System.Windows.Forms.Button();
            this.btt_update = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picture_user)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_telefone
            // 
            this.txt_telefone.Location = new System.Drawing.Point(84, 287);
            this.txt_telefone.Name = "txt_telefone";
            this.txt_telefone.Size = new System.Drawing.Size(212, 20);
            this.txt_telefone.TabIndex = 32;
            this.txt_telefone.TextChanged += new System.EventHandler(this.txt_telefone_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
            this.label2.Location = new System.Drawing.Point(22, 291);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 31;
            this.label2.Text = "Telefone:";
            // 
            // lbl_cpf
            // 
            this.lbl_cpf.AutoSize = true;
            this.lbl_cpf.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lbl_cpf.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl_cpf.Image = ((System.Drawing.Image)(resources.GetObject("lbl_cpf.Image")));
            this.lbl_cpf.Location = new System.Drawing.Point(40, 226);
            this.lbl_cpf.Name = "lbl_cpf";
            this.lbl_cpf.Size = new System.Drawing.Size(30, 13);
            this.lbl_cpf.TabIndex = 30;
            this.lbl_cpf.Text = "CPF:";
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lbl_email.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl_email.Image = ((System.Drawing.Image)(resources.GetObject("lbl_email.Image")));
            this.lbl_email.Location = new System.Drawing.Point(36, 322);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(38, 13);
            this.lbl_email.TabIndex = 29;
            this.lbl_email.Text = "E-mail:";
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(84, 319);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(212, 20);
            this.txt_email.TabIndex = 28;
            // 
            // lbl_endereco
            // 
            this.lbl_endereco.AutoSize = true;
            this.lbl_endereco.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lbl_endereco.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl_endereco.Image = ((System.Drawing.Image)(resources.GetObject("lbl_endereco.Image")));
            this.lbl_endereco.Location = new System.Drawing.Point(18, 258);
            this.lbl_endereco.Name = "lbl_endereco";
            this.lbl_endereco.Size = new System.Drawing.Size(56, 13);
            this.lbl_endereco.TabIndex = 27;
            this.lbl_endereco.Text = "Endereço:";
            // 
            // txt_endereco
            // 
            this.txt_endereco.Location = new System.Drawing.Point(84, 255);
            this.txt_endereco.Name = "txt_endereco";
            this.txt_endereco.Size = new System.Drawing.Size(212, 20);
            this.txt_endereco.TabIndex = 26;
            // 
            // lbl_dataNascimento
            // 
            this.lbl_dataNascimento.AutoSize = true;
            this.lbl_dataNascimento.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lbl_dataNascimento.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl_dataNascimento.Image = ((System.Drawing.Image)(resources.GetObject("lbl_dataNascimento.Image")));
            this.lbl_dataNascimento.Location = new System.Drawing.Point(2, 357);
            this.lbl_dataNascimento.Name = "lbl_dataNascimento";
            this.lbl_dataNascimento.Size = new System.Drawing.Size(107, 13);
            this.lbl_dataNascimento.TabIndex = 24;
            this.lbl_dataNascimento.Text = "Data de Nascimento:";
            // 
            // lbl_sobrenome
            // 
            this.lbl_sobrenome.AutoSize = true;
            this.lbl_sobrenome.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lbl_sobrenome.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl_sobrenome.Image = ((System.Drawing.Image)(resources.GetObject("lbl_sobrenome.Image")));
            this.lbl_sobrenome.Location = new System.Drawing.Point(14, 194);
            this.lbl_sobrenome.Name = "lbl_sobrenome";
            this.lbl_sobrenome.Size = new System.Drawing.Size(64, 13);
            this.lbl_sobrenome.TabIndex = 21;
            this.lbl_sobrenome.Text = "Sobrenome:";
            // 
            // lbl_nome
            // 
            this.lbl_nome.AutoSize = true;
            this.lbl_nome.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lbl_nome.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl_nome.Image = ((System.Drawing.Image)(resources.GetObject("lbl_nome.Image")));
            this.lbl_nome.Location = new System.Drawing.Point(36, 162);
            this.lbl_nome.Name = "lbl_nome";
            this.lbl_nome.Size = new System.Drawing.Size(38, 13);
            this.lbl_nome.TabIndex = 20;
            this.lbl_nome.Text = "Nome:";
            // 
            // picture_user
            // 
            this.picture_user.Location = new System.Drawing.Point(105, 28);
            this.picture_user.Name = "picture_user";
            this.picture_user.Size = new System.Drawing.Size(100, 115);
            this.picture_user.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picture_user.TabIndex = 33;
            this.picture_user.TabStop = false;
            this.picture_user.Click += new System.EventHandler(this.picture_user_Click);
            // 
            // lbl_cpf_show
            // 
            this.lbl_cpf_show.AutoSize = true;
            this.lbl_cpf_show.Location = new System.Drawing.Point(84, 226);
            this.lbl_cpf_show.Name = "lbl_cpf_show";
            this.lbl_cpf_show.Size = new System.Drawing.Size(22, 13);
            this.lbl_cpf_show.TabIndex = 34;
            this.lbl_cpf_show.Text = "cpf";
            // 
            // lbl_date_show
            // 
            this.lbl_date_show.AutoSize = true;
            this.lbl_date_show.Location = new System.Drawing.Point(115, 357);
            this.lbl_date_show.Name = "lbl_date_show";
            this.lbl_date_show.Size = new System.Drawing.Size(35, 13);
            this.lbl_date_show.TabIndex = 35;
            this.lbl_date_show.Text = "label1";
            // 
            // lbl_first_name_show
            // 
            this.lbl_first_name_show.AutoSize = true;
            this.lbl_first_name_show.Location = new System.Drawing.Point(84, 162);
            this.lbl_first_name_show.Name = "lbl_first_name_show";
            this.lbl_first_name_show.Size = new System.Drawing.Size(35, 13);
            this.lbl_first_name_show.TabIndex = 36;
            this.lbl_first_name_show.Text = "label1";
            // 
            // lbl_last_name_show
            // 
            this.lbl_last_name_show.AutoSize = true;
            this.lbl_last_name_show.Location = new System.Drawing.Point(84, 194);
            this.lbl_last_name_show.Name = "lbl_last_name_show";
            this.lbl_last_name_show.Size = new System.Drawing.Size(35, 13);
            this.lbl_last_name_show.TabIndex = 37;
            this.lbl_last_name_show.Text = "label3";
            // 
            // btt_close
            // 
            this.btt_close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(18)))), ((int)(((byte)(28)))));
            this.btt_close.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.btt_close.FlatAppearance.BorderSize = 3;
            this.btt_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btt_close.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(186)))), ((int)(((byte)(11)))));
            this.btt_close.Location = new System.Drawing.Point(186, 432);
            this.btt_close.Name = "btt_close";
            this.btt_close.Size = new System.Drawing.Size(75, 32);
            this.btt_close.TabIndex = 39;
            this.btt_close.Text = "Fechar";
            this.btt_close.UseVisualStyleBackColor = false;
            this.btt_close.Click += new System.EventHandler(this.btt_close_Click);
            // 
            // btt_update
            // 
            this.btt_update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(18)))), ((int)(((byte)(28)))));
            this.btt_update.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.btt_update.FlatAppearance.BorderSize = 3;
            this.btt_update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btt_update.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(186)))), ((int)(((byte)(11)))));
            this.btt_update.Location = new System.Drawing.Point(48, 432);
            this.btt_update.Name = "btt_update";
            this.btt_update.Size = new System.Drawing.Size(75, 32);
            this.btt_update.TabIndex = 38;
            this.btt_update.Text = "Atualizar";
            this.btt_update.UseVisualStyleBackColor = false;
            this.btt_update.Click += new System.EventHandler(this.btt_update_Click);
            // 
            // User_Update
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Locadora.Properties.Resources.bg_galaxy;
            this.ClientSize = new System.Drawing.Size(308, 483);
            this.Controls.Add(this.btt_close);
            this.Controls.Add(this.btt_update);
            this.Controls.Add(this.lbl_last_name_show);
            this.Controls.Add(this.lbl_first_name_show);
            this.Controls.Add(this.lbl_date_show);
            this.Controls.Add(this.lbl_cpf_show);
            this.Controls.Add(this.picture_user);
            this.Controls.Add(this.txt_telefone);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_cpf);
            this.Controls.Add(this.lbl_email);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.lbl_endereco);
            this.Controls.Add(this.txt_endereco);
            this.Controls.Add(this.lbl_dataNascimento);
            this.Controls.Add(this.lbl_sobrenome);
            this.Controls.Add(this.lbl_nome);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "User_Update";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Atualizar Usuario";
            ((System.ComponentModel.ISupportInitialize)(this.picture_user)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picture_user;
        private System.Windows.Forms.TextBox txt_telefone;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_cpf;
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.Label lbl_endereco;
        private System.Windows.Forms.TextBox txt_endereco;
        private System.Windows.Forms.Label lbl_dataNascimento;
        private System.Windows.Forms.Label lbl_sobrenome;
        private System.Windows.Forms.Label lbl_nome;
        private System.Windows.Forms.Label lbl_cpf_show;
        private System.Windows.Forms.Label lbl_date_show;
        private System.Windows.Forms.Label lbl_first_name_show;
        private System.Windows.Forms.Label lbl_last_name_show;
        private System.Windows.Forms.Button btt_close;
        private System.Windows.Forms.Button btt_update;
    }
}