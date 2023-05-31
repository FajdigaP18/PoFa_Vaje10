namespace GraficniVmesnikBazaPodatkov
{
    partial class Filmi
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ocena = new System.Windows.Forms.TextBox();
            this.idFilma = new System.Windows.Forms.TextBox();
            this.prilazFilmaReziser = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.novReziser = new System.Windows.Forms.TextBox();
            this.prikazFilmov = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pokazi = new System.Windows.Forms.Button();
            this.spremeni = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.prilazFilmaReziser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prikazFilmov)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(12, 183);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(275, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Poišči filme z oceno :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(12, 332);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(449, 37);
            this.label2.TabIndex = 1;
            this.label2.Text = "Spremeni ime režiserja v filmu z id ";
            // 
            // ocena
            // 
            this.ocena.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ocena.Location = new System.Drawing.Point(316, 183);
            this.ocena.Name = "ocena";
            this.ocena.Size = new System.Drawing.Size(100, 44);
            this.ocena.TabIndex = 2;
            // 
            // idFilma
            // 
            this.idFilma.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.idFilma.Location = new System.Drawing.Point(482, 332);
            this.idFilma.Name = "idFilma";
            this.idFilma.Size = new System.Drawing.Size(100, 44);
            this.idFilma.TabIndex = 3;
            // 
            // prilazFilmaReziser
            // 
            this.prilazFilmaReziser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.prilazFilmaReziser.Location = new System.Drawing.Point(685, 356);
            this.prilazFilmaReziser.Name = "prilazFilmaReziser";
            this.prilazFilmaReziser.RowHeadersWidth = 51;
            this.prilazFilmaReziser.RowTemplate.Height = 24;
            this.prilazFilmaReziser.Size = new System.Drawing.Size(506, 185);
            this.prilazFilmaReziser.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(12, 425);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(249, 37);
            this.label3.TabIndex = 5;
            this.label3.Text = "Novo ime ržiserja: ";
            // 
            // novReziser
            // 
            this.novReziser.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.novReziser.Location = new System.Drawing.Point(267, 422);
            this.novReziser.Name = "novReziser";
            this.novReziser.Size = new System.Drawing.Size(100, 44);
            this.novReziser.TabIndex = 6;
            // 
            // prikazFilmov
            // 
            this.prikazFilmov.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.prikazFilmov.Location = new System.Drawing.Point(685, 107);
            this.prikazFilmov.Name = "prikazFilmov";
            this.prikazFilmov.RowHeadersWidth = 51;
            this.prikazFilmov.RowTemplate.Height = 24;
            this.prikazFilmov.Size = new System.Drawing.Size(506, 185);
            this.prikazFilmov.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.DarkTurquoise;
            this.label4.Font = new System.Drawing.Font("Calibri", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(39, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(222, 97);
            this.label4.TabIndex = 8;
            this.label4.Text = "Filmi ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(678, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(177, 37);
            this.label5.TabIndex = 9;
            this.label5.Text = "Prikaz filmov";
            // 
            // pokazi
            // 
            this.pokazi.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.pokazi.Location = new System.Drawing.Point(515, 242);
            this.pokazi.Name = "pokazi";
            this.pokazi.Size = new System.Drawing.Size(134, 50);
            this.pokazi.TabIndex = 10;
            this.pokazi.Text = "Pokaži";
            this.pokazi.UseVisualStyleBackColor = true;
            this.pokazi.Click += new System.EventHandler(this.pokazi_Click);
            // 
            // spremeni
            // 
            this.spremeni.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.spremeni.Location = new System.Drawing.Point(494, 485);
            this.spremeni.Name = "spremeni";
            this.spremeni.Size = new System.Drawing.Size(155, 56);
            this.spremeni.TabIndex = 11;
            this.spremeni.Text = "Srpemeni";
            this.spremeni.UseVisualStyleBackColor = true;
            this.spremeni.Click += new System.EventHandler(this.spremeni_Click);
            // 
            // Filmi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(1203, 556);
            this.Controls.Add(this.spremeni);
            this.Controls.Add(this.pokazi);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.prikazFilmov);
            this.Controls.Add(this.novReziser);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.prilazFilmaReziser);
            this.Controls.Add(this.idFilma);
            this.Controls.Add(this.ocena);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Filmi";
            this.Text = "Iskanje filmov";
            ((System.ComponentModel.ISupportInitialize)(this.prilazFilmaReziser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prikazFilmov)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ocena;
        private System.Windows.Forms.TextBox idFilma;
        private System.Windows.Forms.DataGridView prilazFilmaReziser;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox novReziser;
        private System.Windows.Forms.DataGridView prikazFilmov;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button pokazi;
        private System.Windows.Forms.Button spremeni;
    }
}

