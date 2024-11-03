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
            this.btt_close = new System.Windows.Forms.Button();
            this.btt_select_image = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pB_game = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pB_game)).BeginInit();
            this.SuspendLayout();
            // 
            // btt_close
            // 
            this.btt_close.Location = new System.Drawing.Point(520, 439);
            this.btt_close.Name = "btt_close";
            this.btt_close.Size = new System.Drawing.Size(75, 23);
            this.btt_close.TabIndex = 0;
            this.btt_close.Text = "Fechar";
            this.btt_close.UseVisualStyleBackColor = true;
            this.btt_close.Click += new System.EventHandler(this.btt_close_Click);
            // 
            // btt_select_image
            // 
            this.btt_select_image.Location = new System.Drawing.Point(59, 439);
            this.btt_select_image.Name = "btt_select_image";
            this.btt_select_image.Size = new System.Drawing.Size(110, 23);
            this.btt_select_image.TabIndex = 1;
            this.btt_select_image.Text = "Selecionar Imagem";
            this.btt_select_image.UseVisualStyleBackColor = true;
            this.btt_select_image.Click += new System.EventHandler(this.btt_select_image_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(321, 439);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pB_game
            // 
            this.pB_game.Location = new System.Drawing.Point(139, 42);
            this.pB_game.Name = "pB_game";
            this.pB_game.Size = new System.Drawing.Size(240, 360);
            this.pB_game.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pB_game.TabIndex = 2;
            this.pB_game.TabStop = false;
            // 
            // Game_Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 485);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pB_game);
            this.Controls.Add(this.btt_select_image);
            this.Controls.Add(this.btt_close);
            this.Name = "Game_Register";
            this.Text = "Game Register";
            ((System.ComponentModel.ISupportInitialize)(this.pB_game)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btt_close;
        private System.Windows.Forms.Button btt_select_image;
        private System.Windows.Forms.PictureBox pB_game;
        private System.Windows.Forms.Button button1;
    }
}