namespace MemoryMarcoMalanchin
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.GiocaBtn = new System.Windows.Forms.Button();
            this.ClassificaBtn = new System.Windows.Forms.Button();
            this.EsciBtn = new System.Windows.Forms.Button();
            this.InformazioniBtn = new System.Windows.Forms.Button();
            this.ValoreTessereBtn1 = new System.Windows.Forms.Button();
            this.ValoreTessereBtn2 = new System.Windows.Forms.Button();
            this.ValoreTessereBtn3 = new System.Windows.Forms.Button();
            this.SceltaTessereLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // GiocaBtn
            // 
            this.GiocaBtn.Location = new System.Drawing.Point(267, 228);
            this.GiocaBtn.Name = "GiocaBtn";
            this.GiocaBtn.Size = new System.Drawing.Size(216, 45);
            this.GiocaBtn.TabIndex = 0;
            this.GiocaBtn.Text = "Gioca";
            this.GiocaBtn.UseVisualStyleBackColor = true;
            this.GiocaBtn.Click += new System.EventHandler(this.GiocaBtn_Click);
            // 
            // ClassificaBtn
            // 
            this.ClassificaBtn.Location = new System.Drawing.Point(267, 279);
            this.ClassificaBtn.Name = "ClassificaBtn";
            this.ClassificaBtn.Size = new System.Drawing.Size(216, 45);
            this.ClassificaBtn.TabIndex = 1;
            this.ClassificaBtn.Text = "Classifica";
            this.ClassificaBtn.UseVisualStyleBackColor = true;
            this.ClassificaBtn.Click += new System.EventHandler(this.ClasificaBtn_Click);
            // 
            // EsciBtn
            // 
            this.EsciBtn.Location = new System.Drawing.Point(267, 330);
            this.EsciBtn.Name = "EsciBtn";
            this.EsciBtn.Size = new System.Drawing.Size(216, 45);
            this.EsciBtn.TabIndex = 2;
            this.EsciBtn.Text = "Esci";
            this.EsciBtn.UseVisualStyleBackColor = true;
            this.EsciBtn.Click += new System.EventHandler(this.EsciBtn_Click);
            // 
            // InformazioniBtn
            // 
            this.InformazioniBtn.Location = new System.Drawing.Point(12, 12);
            this.InformazioniBtn.Name = "InformazioniBtn";
            this.InformazioniBtn.Size = new System.Drawing.Size(107, 44);
            this.InformazioniBtn.TabIndex = 3;
            this.InformazioniBtn.Text = "Informazioni";
            this.InformazioniBtn.UseVisualStyleBackColor = true;
            this.InformazioniBtn.Click += new System.EventHandler(this.InformazioniBtn_Click);
            // 
            // ValoreTessereBtn1
            // 
            this.ValoreTessereBtn1.Location = new System.Drawing.Point(204, 71);
            this.ValoreTessereBtn1.Name = "ValoreTessereBtn1";
            this.ValoreTessereBtn1.Size = new System.Drawing.Size(90, 65);
            this.ValoreTessereBtn1.TabIndex = 4;
            this.ValoreTessereBtn1.Text = "8";
            this.ValoreTessereBtn1.UseVisualStyleBackColor = true;
            this.ValoreTessereBtn1.Click += new System.EventHandler(this.ValoreTessereBtn1_Click);
            // 
            // ValoreTessereBtn2
            // 
            this.ValoreTessereBtn2.Location = new System.Drawing.Point(323, 71);
            this.ValoreTessereBtn2.Name = "ValoreTessereBtn2";
            this.ValoreTessereBtn2.Size = new System.Drawing.Size(100, 65);
            this.ValoreTessereBtn2.TabIndex = 5;
            this.ValoreTessereBtn2.Text = "16";
            this.ValoreTessereBtn2.UseVisualStyleBackColor = true;
            this.ValoreTessereBtn2.Click += new System.EventHandler(this.ValoreTessereBtn2_Click);
            // 
            // ValoreTessereBtn3
            // 
            this.ValoreTessereBtn3.Location = new System.Drawing.Point(453, 71);
            this.ValoreTessereBtn3.Name = "ValoreTessereBtn3";
            this.ValoreTessereBtn3.Size = new System.Drawing.Size(100, 65);
            this.ValoreTessereBtn3.TabIndex = 6;
            this.ValoreTessereBtn3.Text = "24";
            this.ValoreTessereBtn3.UseVisualStyleBackColor = true;
            this.ValoreTessereBtn3.Click += new System.EventHandler(this.ValoreTessereBtn3_Click);
            // 
            // SceltaTessereLbl
            // 
            this.SceltaTessereLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SceltaTessereLbl.Location = new System.Drawing.Point(162, 10);
            this.SceltaTessereLbl.Name = "SceltaTessereLbl";
            this.SceltaTessereLbl.Size = new System.Drawing.Size(543, 52);
            this.SceltaTessereLbl.TabIndex = 7;
            this.SceltaTessereLbl.Text = "Scegli quante tessere generare:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SceltaTessereLbl);
            this.Controls.Add(this.ValoreTessereBtn3);
            this.Controls.Add(this.ValoreTessereBtn2);
            this.Controls.Add(this.ValoreTessereBtn1);
            this.Controls.Add(this.InformazioniBtn);
            this.Controls.Add(this.EsciBtn);
            this.Controls.Add(this.ClassificaBtn);
            this.Controls.Add(this.GiocaBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button GiocaBtn;
        private System.Windows.Forms.Button ClassificaBtn;
        private System.Windows.Forms.Button EsciBtn;
        private System.Windows.Forms.Button InformazioniBtn;
        private System.Windows.Forms.Button ValoreTessereBtn1;
        private System.Windows.Forms.Button ValoreTessereBtn2;
        private System.Windows.Forms.Button ValoreTessereBtn3;
        private System.Windows.Forms.Label SceltaTessereLbl;
    }
}

