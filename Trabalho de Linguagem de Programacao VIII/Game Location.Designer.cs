namespace Locadora
{
    partial class Game_Location
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
            this.btn_newLocation = new System.Windows.Forms.Button();
            this.btt_close = new System.Windows.Forms.Button();
            this.btt_locationDone = new System.Windows.Forms.Button();
            this.btt_update = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_newLocation
            // 
            this.btn_newLocation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(18)))), ((int)(((byte)(28)))));
            this.btn_newLocation.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.btn_newLocation.FlatAppearance.BorderSize = 3;
            this.btn_newLocation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_newLocation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(186)))), ((int)(((byte)(11)))));
            this.btn_newLocation.Location = new System.Drawing.Point(71, 547);
            this.btn_newLocation.Name = "btn_newLocation";
            this.btn_newLocation.Size = new System.Drawing.Size(75, 32);
            this.btn_newLocation.TabIndex = 10;
            this.btn_newLocation.Text = "Novo";
            this.btn_newLocation.UseVisualStyleBackColor = false;
            // 
            // btt_close
            // 
            this.btt_close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(18)))), ((int)(((byte)(28)))));
            this.btt_close.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.btt_close.FlatAppearance.BorderSize = 3;
            this.btt_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btt_close.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(186)))), ((int)(((byte)(11)))));
            this.btt_close.Location = new System.Drawing.Point(439, 547);
            this.btt_close.Name = "btt_close";
            this.btt_close.Size = new System.Drawing.Size(75, 32);
            this.btt_close.TabIndex = 9;
            this.btt_close.Text = "Fechar";
            this.btt_close.UseVisualStyleBackColor = false;
            // 
            // btt_locationDone
            // 
            this.btt_locationDone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(18)))), ((int)(((byte)(28)))));
            this.btt_locationDone.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.btt_locationDone.FlatAppearance.BorderSize = 3;
            this.btt_locationDone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btt_locationDone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(186)))), ((int)(((byte)(11)))));
            this.btt_locationDone.Location = new System.Drawing.Point(317, 547);
            this.btt_locationDone.Name = "btt_locationDone";
            this.btt_locationDone.Size = new System.Drawing.Size(75, 32);
            this.btt_locationDone.TabIndex = 8;
            this.btt_locationDone.Text = "Dar Baixa";
            this.btt_locationDone.UseVisualStyleBackColor = false;
            // 
            // btt_update
            // 
            this.btt_update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(18)))), ((int)(((byte)(28)))));
            this.btt_update.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.btt_update.FlatAppearance.BorderSize = 3;
            this.btt_update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btt_update.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(186)))), ((int)(((byte)(11)))));
            this.btt_update.Location = new System.Drawing.Point(194, 547);
            this.btt_update.Name = "btt_update";
            this.btt_update.Size = new System.Drawing.Size(75, 32);
            this.btt_update.TabIndex = 7;
            this.btt_update.Text = "Atualizar";
            this.btt_update.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(581, 513);
            this.dataGridView1.TabIndex = 11;
            // 
            // Game_Location
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Locadora.Properties.Resources.bg_galaxy;
            this.ClientSize = new System.Drawing.Size(605, 600);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_newLocation);
            this.Controls.Add(this.btt_close);
            this.Controls.Add(this.btt_locationDone);
            this.Controls.Add(this.btt_update);
            this.Name = "Game_Location";
            this.Text = "Game_Location";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_newLocation;
        private System.Windows.Forms.Button btt_close;
        private System.Windows.Forms.Button btt_locationDone;
        private System.Windows.Forms.Button btt_update;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}