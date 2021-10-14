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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.GiocaBtn = new System.Windows.Forms.Button();
            this.InformazioniBtn = new System.Windows.Forms.Button();
            this.ValoreTessereBtn1 = new System.Windows.Forms.Button();
            this.ValoreTessereBtn2 = new System.Windows.Forms.Button();
            this.ValoreTessereBtn3 = new System.Windows.Forms.Button();
            this.SceltaTessereLbl = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblPuntiGiocatore1 = new System.Windows.Forms.Label();
            this.lblPuntiGiocatore2 = new System.Windows.Forms.Label();
            this.lblChiediGiocatori = new System.Windows.Forms.Label();
            this.txtBxGiocatore1 = new System.Windows.Forms.TextBox();
            this.txtBxGiocatore2 = new System.Windows.Forms.TextBox();
            this.btnGioca2 = new System.Windows.Forms.Button();
            this.lblTurno = new System.Windows.Forms.Label();
            this.lblInfomazioni = new System.Windows.Forms.Label();
            this.btnMenù = new System.Windows.Forms.Button();
            this.lblTitolo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // GiocaBtn
            // 
            this.GiocaBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GiocaBtn.Location = new System.Drawing.Point(343, 330);
            this.GiocaBtn.Name = "GiocaBtn";
            this.GiocaBtn.Size = new System.Drawing.Size(300, 75);
            this.GiocaBtn.TabIndex = 0;
            this.GiocaBtn.Text = "Gioca";
            this.GiocaBtn.UseVisualStyleBackColor = true;
            this.GiocaBtn.Click += new System.EventHandler(this.GiocaBtn_Click);
            // 
            // InformazioniBtn
            // 
            this.InformazioniBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InformazioniBtn.Location = new System.Drawing.Point(343, 411);
            this.InformazioniBtn.Name = "InformazioniBtn";
            this.InformazioniBtn.Size = new System.Drawing.Size(300, 75);
            this.InformazioniBtn.TabIndex = 3;
            this.InformazioniBtn.Text = "Informazioni";
            this.InformazioniBtn.UseVisualStyleBackColor = true;
            this.InformazioniBtn.Click += new System.EventHandler(this.InformazioniBtn_Click);
            // 
            // ValoreTessereBtn1
            // 
            this.ValoreTessereBtn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ValoreTessereBtn1.Location = new System.Drawing.Point(240, 162);
            this.ValoreTessereBtn1.Name = "ValoreTessereBtn1";
            this.ValoreTessereBtn1.Size = new System.Drawing.Size(175, 150);
            this.ValoreTessereBtn1.TabIndex = 4;
            this.ValoreTessereBtn1.Text = "8";
            this.ValoreTessereBtn1.UseVisualStyleBackColor = true;
            this.ValoreTessereBtn1.Click += new System.EventHandler(this.ValoreTessereBtn1_Click);
            // 
            // ValoreTessereBtn2
            // 
            this.ValoreTessereBtn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ValoreTessereBtn2.Location = new System.Drawing.Point(418, 162);
            this.ValoreTessereBtn2.Name = "ValoreTessereBtn2";
            this.ValoreTessereBtn2.Size = new System.Drawing.Size(175, 150);
            this.ValoreTessereBtn2.TabIndex = 5;
            this.ValoreTessereBtn2.Text = "16";
            this.ValoreTessereBtn2.UseVisualStyleBackColor = true;
            this.ValoreTessereBtn2.Click += new System.EventHandler(this.ValoreTessereBtn2_Click);
            // 
            // ValoreTessereBtn3
            // 
            this.ValoreTessereBtn3.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ValoreTessereBtn3.Location = new System.Drawing.Point(599, 161);
            this.ValoreTessereBtn3.Name = "ValoreTessereBtn3";
            this.ValoreTessereBtn3.Size = new System.Drawing.Size(175, 150);
            this.ValoreTessereBtn3.TabIndex = 6;
            this.ValoreTessereBtn3.Text = "24";
            this.ValoreTessereBtn3.UseVisualStyleBackColor = true;
            this.ValoreTessereBtn3.Click += new System.EventHandler(this.ValoreTessereBtn3_Click);
            // 
            // SceltaTessereLbl
            // 
            this.SceltaTessereLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SceltaTessereLbl.Location = new System.Drawing.Point(199, 96);
            this.SceltaTessereLbl.Name = "SceltaTessereLbl";
            this.SceltaTessereLbl.Size = new System.Drawing.Size(771, 62);
            this.SceltaTessereLbl.TabIndex = 7;
            this.SceltaTessereLbl.Text = "Scegli quante tessere generare:";
            // 
            // timer1
            // 
            this.timer1.Interval = 750;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblPuntiGiocatore1
            // 
            this.lblPuntiGiocatore1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPuntiGiocatore1.Location = new System.Drawing.Point(195, 507);
            this.lblPuntiGiocatore1.Name = "lblPuntiGiocatore1";
            this.lblPuntiGiocatore1.Size = new System.Drawing.Size(280, 50);
            this.lblPuntiGiocatore1.TabIndex = 8;
            // 
            // lblPuntiGiocatore2
            // 
            this.lblPuntiGiocatore2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPuntiGiocatore2.Location = new System.Drawing.Point(481, 507);
            this.lblPuntiGiocatore2.Name = "lblPuntiGiocatore2";
            this.lblPuntiGiocatore2.Size = new System.Drawing.Size(280, 50);
            this.lblPuntiGiocatore2.TabIndex = 9;
            // 
            // lblChiediGiocatori
            // 
            this.lblChiediGiocatori.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChiediGiocatori.Location = new System.Drawing.Point(187, 47);
            this.lblChiediGiocatori.Name = "lblChiediGiocatori";
            this.lblChiediGiocatori.Size = new System.Drawing.Size(783, 52);
            this.lblChiediGiocatori.TabIndex = 10;
            this.lblChiediGiocatori.Text = "Inserisci il nome dei due giocatori:";
            // 
            // txtBxGiocatore1
            // 
            this.txtBxGiocatore1.Location = new System.Drawing.Point(291, 108);
            this.txtBxGiocatore1.Name = "txtBxGiocatore1";
            this.txtBxGiocatore1.Size = new System.Drawing.Size(386, 22);
            this.txtBxGiocatore1.TabIndex = 11;
            // 
            // txtBxGiocatore2
            // 
            this.txtBxGiocatore2.Location = new System.Drawing.Point(291, 161);
            this.txtBxGiocatore2.Name = "txtBxGiocatore2";
            this.txtBxGiocatore2.Size = new System.Drawing.Size(386, 22);
            this.txtBxGiocatore2.TabIndex = 12;
            // 
            // btnGioca2
            // 
            this.btnGioca2.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGioca2.Location = new System.Drawing.Point(343, 199);
            this.btnGioca2.Name = "btnGioca2";
            this.btnGioca2.Size = new System.Drawing.Size(300, 75);
            this.btnGioca2.TabIndex = 13;
            this.btnGioca2.Text = "Gioca";
            this.btnGioca2.UseVisualStyleBackColor = true;
            this.btnGioca2.Click += new System.EventHandler(this.btnGioca2_Click);
            // 
            // lblTurno
            // 
            this.lblTurno.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblTurno.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTurno.Location = new System.Drawing.Point(599, 12);
            this.lblTurno.Name = "lblTurno";
            this.lblTurno.Size = new System.Drawing.Size(361, 35);
            this.lblTurno.TabIndex = 14;
            this.lblTurno.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblInfomazioni
            // 
            this.lblInfomazioni.BackColor = System.Drawing.Color.Transparent;
            this.lblInfomazioni.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfomazioni.Location = new System.Drawing.Point(39, 53);
            this.lblInfomazioni.Name = "lblInfomazioni";
            this.lblInfomazioni.Size = new System.Drawing.Size(917, 541);
            this.lblInfomazioni.TabIndex = 15;
            this.lblInfomazioni.Text = resources.GetString("lblInfomazioni.Text");
            // 
            // btnMenù
            // 
            this.btnMenù.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenù.Location = new System.Drawing.Point(0, -3);
            this.btnMenù.Name = "btnMenù";
            this.btnMenù.Size = new System.Drawing.Size(262, 38);
            this.btnMenù.TabIndex = 16;
            this.btnMenù.Text = "Torna al menù principale";
            this.btnMenù.UseVisualStyleBackColor = true;
            this.btnMenù.Click += new System.EventHandler(this.Menù_Click);
            // 
            // lblTitolo
            // 
            this.lblTitolo.Font = new System.Drawing.Font("Microsoft Sans Serif", 45F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitolo.ForeColor = System.Drawing.Color.Red;
            this.lblTitolo.Location = new System.Drawing.Point(12, 92);
            this.lblTitolo.Name = "lblTitolo";
            this.lblTitolo.Size = new System.Drawing.Size(963, 91);
            this.lblTitolo.TabIndex = 17;
            this.lblTitolo.Text = "IL GIOCO DEL MEMORY";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 603);
            this.Controls.Add(this.lblTitolo);
            this.Controls.Add(this.btnMenù);
            this.Controls.Add(this.lblInfomazioni);
            this.Controls.Add(this.lblTurno);
            this.Controls.Add(this.btnGioca2);
            this.Controls.Add(this.txtBxGiocatore2);
            this.Controls.Add(this.txtBxGiocatore1);
            this.Controls.Add(this.lblChiediGiocatori);
            this.Controls.Add(this.lblPuntiGiocatore2);
            this.Controls.Add(this.lblPuntiGiocatore1);
            this.Controls.Add(this.SceltaTessereLbl);
            this.Controls.Add(this.ValoreTessereBtn3);
            this.Controls.Add(this.ValoreTessereBtn2);
            this.Controls.Add(this.ValoreTessereBtn1);
            this.Controls.Add(this.InformazioniBtn);
            this.Controls.Add(this.GiocaBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button GiocaBtn;
        private System.Windows.Forms.Button InformazioniBtn;
        private System.Windows.Forms.Button ValoreTessereBtn1;
        private System.Windows.Forms.Button ValoreTessereBtn2;
        private System.Windows.Forms.Button ValoreTessereBtn3;
        private System.Windows.Forms.Label SceltaTessereLbl;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblPuntiGiocatore1;
        private System.Windows.Forms.Label lblPuntiGiocatore2;
        private System.Windows.Forms.Label lblChiediGiocatori;
        private System.Windows.Forms.TextBox txtBxGiocatore1;
        private System.Windows.Forms.TextBox txtBxGiocatore2;
        private System.Windows.Forms.Button btnGioca2;
        private System.Windows.Forms.Label lblTurno;
        private System.Windows.Forms.Label lblInfomazioni;
        private System.Windows.Forms.Button btnMenù;
        private System.Windows.Forms.Label lblTitolo;
    }
}

