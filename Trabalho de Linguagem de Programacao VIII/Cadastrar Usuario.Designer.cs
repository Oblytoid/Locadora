namespace Trabalho_de_Linguagem_de_Programacao_VIII
{
    partial class Cadastrar_Usuario
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.lbl_nome = new System.Windows.Forms.Label();
            this.lbl_sobrenome = new System.Windows.Forms.Label();
            this.txt_sobrenome = new System.Windows.Forms.TextBox();
            this.txt_cpf = new System.Windows.Forms.TextBox();
            this.lbl_dataNascimento = new System.Windows.Forms.Label();
            this.dtp_nascimento = new System.Windows.Forms.DateTimePicker();
            this.txt_endereco = new System.Windows.Forms.TextBox();
            this.lbl_endereco = new System.Windows.Forms.Label();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.lbl_email = new System.Windows.Forms.Label();
            this.lbl_cpf = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_telefone = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 186);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(564, 52);
            this.panel1.TabIndex = 0;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(210, 17);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 18;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(477, 17);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 17;
            this.button3.Text = "Fechar";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(111, 17);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 16;
            this.button2.Text = "Salvar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 17);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "Novo";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // txt_nome
            // 
            this.txt_nome.Location = new System.Drawing.Point(53, 35);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(188, 20);
            this.txt_nome.TabIndex = 1;
            this.txt_nome.TextChanged += new System.EventHandler(this.txt_nome_TextChanged);
            // 
            // lbl_nome
            // 
            this.lbl_nome.AutoSize = true;
            this.lbl_nome.Location = new System.Drawing.Point(12, 38);
            this.lbl_nome.Name = "lbl_nome";
            this.lbl_nome.Size = new System.Drawing.Size(38, 13);
            this.lbl_nome.TabIndex = 2;
            this.lbl_nome.Text = "Nome:";
            // 
            // lbl_sobrenome
            // 
            this.lbl_sobrenome.AutoSize = true;
            this.lbl_sobrenome.Location = new System.Drawing.Point(247, 38);
            this.lbl_sobrenome.Name = "lbl_sobrenome";
            this.lbl_sobrenome.Size = new System.Drawing.Size(64, 13);
            this.lbl_sobrenome.TabIndex = 3;
            this.lbl_sobrenome.Text = "Sobrenome:";
            // 
            // txt_sobrenome
            // 
            this.txt_sobrenome.Location = new System.Drawing.Point(317, 35);
            this.txt_sobrenome.Name = "txt_sobrenome";
            this.txt_sobrenome.Size = new System.Drawing.Size(198, 20);
            this.txt_sobrenome.TabIndex = 4;
            this.txt_sobrenome.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txt_cpf
            // 
            this.txt_cpf.Location = new System.Drawing.Point(53, 73);
            this.txt_cpf.Name = "txt_cpf";
            this.txt_cpf.Size = new System.Drawing.Size(188, 20);
            this.txt_cpf.TabIndex = 5;
            this.txt_cpf.TextChanged += new System.EventHandler(this.txt_cpf_TextChanged);
            // 
            // lbl_dataNascimento
            // 
            this.lbl_dataNascimento.AutoSize = true;
            this.lbl_dataNascimento.Location = new System.Drawing.Point(12, 155);
            this.lbl_dataNascimento.Name = "lbl_dataNascimento";
            this.lbl_dataNascimento.Size = new System.Drawing.Size(107, 13);
            this.lbl_dataNascimento.TabIndex = 7;
            this.lbl_dataNascimento.Text = "Data de Nascimento:";
            this.lbl_dataNascimento.Click += new System.EventHandler(this.lbl_dataNascimento_Click);
            // 
            // dtp_nascimento
            // 
            this.dtp_nascimento.CustomFormat = "dd/MM/yyyy";
            this.dtp_nascimento.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_nascimento.Location = new System.Drawing.Point(125, 149);
            this.dtp_nascimento.MaxDate = new System.DateTime(2024, 10, 22, 0, 0, 0, 0);
            this.dtp_nascimento.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dtp_nascimento.Name = "dtp_nascimento";
            this.dtp_nascimento.Size = new System.Drawing.Size(79, 20);
            this.dtp_nascimento.TabIndex = 8;
            this.dtp_nascimento.Value = new System.DateTime(2024, 10, 22, 0, 0, 0, 0);
            // 
            // txt_endereco
            // 
            this.txt_endereco.Location = new System.Drawing.Point(317, 75);
            this.txt_endereco.Name = "txt_endereco";
            this.txt_endereco.Size = new System.Drawing.Size(198, 20);
            this.txt_endereco.TabIndex = 10;
            // 
            // lbl_endereco
            // 
            this.lbl_endereco.AutoSize = true;
            this.lbl_endereco.Location = new System.Drawing.Point(247, 78);
            this.lbl_endereco.Name = "lbl_endereco";
            this.lbl_endereco.Size = new System.Drawing.Size(56, 13);
            this.lbl_endereco.TabIndex = 11;
            this.lbl_endereco.Text = "Endereço:";
            this.lbl_endereco.Click += new System.EventHandler(this.lbl_endereco_Click);
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(317, 115);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(198, 20);
            this.txt_email.TabIndex = 12;
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.Location = new System.Drawing.Point(247, 118);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(38, 13);
            this.lbl_email.TabIndex = 13;
            this.lbl_email.Text = "E-mail:";
            // 
            // lbl_cpf
            // 
            this.lbl_cpf.AutoSize = true;
            this.lbl_cpf.Location = new System.Drawing.Point(12, 77);
            this.lbl_cpf.Name = "lbl_cpf";
            this.lbl_cpf.Size = new System.Drawing.Size(30, 13);
            this.lbl_cpf.TabIndex = 14;
            this.lbl_cpf.Text = "CPF:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Telefone:";
            // 
            // txt_telefone
            // 
            this.txt_telefone.Location = new System.Drawing.Point(70, 111);
            this.txt_telefone.Name = "txt_telefone";
            this.txt_telefone.Size = new System.Drawing.Size(171, 20);
            this.txt_telefone.TabIndex = 17;
            this.txt_telefone.TextChanged += new System.EventHandler(this.txt_telefone_TextChanged);
            // 
            // Cadastrar_Usuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 238);
            this.Controls.Add(this.txt_telefone);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_cpf);
            this.Controls.Add(this.lbl_email);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.lbl_endereco);
            this.Controls.Add(this.txt_endereco);
            this.Controls.Add(this.dtp_nascimento);
            this.Controls.Add(this.lbl_dataNascimento);
            this.Controls.Add(this.txt_cpf);
            this.Controls.Add(this.txt_sobrenome);
            this.Controls.Add(this.lbl_sobrenome);
            this.Controls.Add(this.lbl_nome);
            this.Controls.Add(this.txt_nome);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Cadastrar_Usuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrar_Usuario";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.Label lbl_nome;
        private System.Windows.Forms.Label lbl_sobrenome;
        private System.Windows.Forms.TextBox txt_sobrenome;
        private System.Windows.Forms.TextBox txt_cpf;
        private System.Windows.Forms.Label lbl_dataNascimento;
        private System.Windows.Forms.DateTimePicker dtp_nascimento;
        private System.Windows.Forms.TextBox txt_endereco;
        private System.Windows.Forms.Label lbl_endereco;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbl_cpf;
        private System.Windows.Forms.TextBox txt_telefone;
        private System.Windows.Forms.Label label2;
    }
}