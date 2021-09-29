using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MemoryMarcoMalanchin
{
    public partial class Form1 : Form
    {
        int numeroTessere;
        public Form1()
        {
            InitializeComponent();
            SceltaTessereLbl.Visible = false;
            SceltaTessereLbl.Enabled = false;
            ValoreTessereBtn1.Visible = false;
            ValoreTessereBtn1.Enabled = false;
            ValoreTessereBtn2.Visible = false;
            ValoreTessereBtn2.Enabled = false;
            ValoreTessereBtn3.Visible = false;
            ValoreTessereBtn3.Enabled = false;
        }

        private void CreaBottoni()
        {
            int x = 0;
            int PosizioneTessereX = 70;
            int PosizioneTessereY = 40;
            do
            {
                Random generaFigure = new Random();
                generaFigure.Next(1, numeroTessere / 2);
                Button newButton = new Button();
                this.Controls.Add(newButton);
                newButton.Text = "Btn prova";
                newButton.Size = new Size(50, 100);
                newButton.Location = new Point(PosizioneTessereX, PosizioneTessereY);
                x++;
                PosizioneTessereX = PosizioneTessereX + 60;
                if (x == 8)
                {
                    PosizioneTessereX = 70;
                    PosizioneTessereY = PosizioneTessereY + 110;
                }
                else if (x == 16)
                {
                    PosizioneTessereX = 70;
                    PosizioneTessereY = PosizioneTessereY + 110;
                }
            }
            while (x < numeroTessere);
        }


        private void GiocaBtn_Click(object sender, EventArgs e)
        {
            GiocaBtn.Visible = false;
            GiocaBtn.Enabled = false;
            ClassificaBtn.Visible = false;
            ClassificaBtn.Enabled = false;
            EsciBtn.Visible = false;
            EsciBtn.Enabled = false;
            InformazioniBtn.Visible = false;
            InformazioniBtn.Enabled = false;
            SceltaTessereLbl.Visible = true;
            SceltaTessereLbl.Enabled = true;
            ValoreTessereBtn1.Visible = true;
            ValoreTessereBtn1.Enabled = true;
            ValoreTessereBtn2.Visible = true;
            ValoreTessereBtn2.Enabled = true;
            ValoreTessereBtn3.Visible = true;
            ValoreTessereBtn3.Enabled = true;
        }

        private void ClasificaBtn_Click(object sender, EventArgs e)
        {
            GiocaBtn.Visible = false;
            GiocaBtn.Enabled = false;
            ClassificaBtn.Visible = false;
            ClassificaBtn.Enabled = false;
            EsciBtn.Visible = false;
            EsciBtn.Enabled = false;
            InformazioniBtn.Visible = false;
            InformazioniBtn.Enabled = false;
        }

        private void EsciBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void InformazioniBtn_Click(object sender, EventArgs e)
        {
            GiocaBtn.Visible = false;
            GiocaBtn.Enabled = false;
            ClassificaBtn.Visible = false;
            ClassificaBtn.Enabled = false;
            EsciBtn.Visible = false;
            EsciBtn.Enabled = false;
            InformazioniBtn.Visible = false;
            InformazioniBtn.Enabled = false;
        }

        private void ValoreTessereBtn1_Click(object sender, EventArgs e)
        {
            numeroTessere = 8;
            SceltaTessereLbl.Visible = false;
            SceltaTessereLbl.Enabled = false;
            ValoreTessereBtn1.Visible = false;
            ValoreTessereBtn1.Enabled = false;
            ValoreTessereBtn2.Visible = false;
            ValoreTessereBtn2.Enabled = false;
            ValoreTessereBtn3.Visible = false;
            ValoreTessereBtn3.Enabled = false;
            CreaBottoni();
        }

        private void ValoreTessereBtn2_Click(object sender, EventArgs e)
        {
            numeroTessere = 16;
            SceltaTessereLbl.Visible = false;
            SceltaTessereLbl.Enabled = false;
            ValoreTessereBtn1.Visible = false;
            ValoreTessereBtn1.Enabled = false;
            ValoreTessereBtn2.Visible = false;
            ValoreTessereBtn2.Enabled = false;
            ValoreTessereBtn3.Visible = false;
            ValoreTessereBtn3.Enabled = false;
            CreaBottoni();
        }

        private void ValoreTessereBtn3_Click(object sender, EventArgs e)
        {
            numeroTessere = 24;
            SceltaTessereLbl.Visible = false;
            SceltaTessereLbl.Enabled = false;
            ValoreTessereBtn1.Visible = false;
            ValoreTessereBtn1.Enabled = false;
            ValoreTessereBtn2.Visible = false;
            ValoreTessereBtn2.Enabled = false;
            ValoreTessereBtn3.Visible = false;
            ValoreTessereBtn3.Enabled = false;
            CreaBottoni();
        }
    }
}
