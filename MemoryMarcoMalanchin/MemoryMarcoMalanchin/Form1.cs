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
        PictureBox[] memory;
        int Bulbasaur, Charmander, Squirtle, Chikorita, Cyndaquil, Totodile, Treecko, Torchic, Mudkip, Turtwig, Chimchar, Piplup;
        Image iniziale = Properties.Resources.qq;
        PictureBox primoClick, secondoClick;
        int turno;

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
        public void CreaBottoni()
        {
            Random generatoreNumeri = new Random();
            int PosizioneTesseraX = 70;
            int PosizioneTesseraY = 50;
            int x = 0;
            for (int i = 0; i < memory.Length; i++)
            {
                int numeroFigura = generatoreNumeri.Next(0, memory.Length / 2);
                if (controlloFigure(numeroFigura) > 2)
                {
                    i--;
                }
                else
                {
                    memory[i] = new PictureBox();
                    memory[i].Image = generaImmagine(numeroFigura);
                    memory[i].SizeMode = PictureBoxSizeMode.StretchImage;
                    memory[i].BorderStyle = BorderStyle.FixedSingle;
                    memory[i].Location = new Point(PosizioneTesseraX, PosizioneTesseraY);
                    memory[i].Size = new Size(75, 100);
                    memory[i].BackColor = Color.Black;
                    memory[i].Padding = new Padding(5000, 0, 0, 0);
                    memory[i].Name = nomeFigura(numeroFigura);
                    memory[i].Click += new EventHandler(resettaImmagine);
                    this.Controls.Add(memory[i]);
                    x++;
                    PosizioneTesseraX += 80;
                    if (x == 8 || x == 16)
                    {
                        PosizioneTesseraX = 70;
                        PosizioneTesseraY += 110;
                    }
                }
            }
        }

        public Image generaImmagine(int generaFigure)
        {
            Image figuraMemory = null;
            switch (generaFigure)
            {
                case 0:
                    figuraMemory = Properties.Resources.Bulbasaur;
                    return figuraMemory;
                case 1:
                    figuraMemory = Properties.Resources.Charmander;
                    return figuraMemory;
                case 2:
                    figuraMemory = Properties.Resources.Squirtle;
                    return figuraMemory;
                case 3:
                    figuraMemory = Properties.Resources.Chikorita;
                    return figuraMemory;
                case 4:
                    figuraMemory = Properties.Resources.Cyndaquil;
                    return figuraMemory;
                case 5:
                    figuraMemory = Properties.Resources.Totodile;
                    return figuraMemory;
                case 6:
                    figuraMemory = Properties.Resources.Treecko;
                    return figuraMemory;
                case 7:
                    figuraMemory = Properties.Resources.Torchic;
                    return figuraMemory;
                case 8:
                    figuraMemory = Properties.Resources.Mudkip;
                    return figuraMemory;
                case 9:
                    figuraMemory = Properties.Resources.Turtwig;
                    return figuraMemory;
                case 10:
                    figuraMemory = Properties.Resources.Chimchar;
                    return figuraMemory;
                case 11:
                    figuraMemory = Properties.Resources.Piplup;
                    return figuraMemory;
            }
            return figuraMemory;
        }
        public int controlloFigure(int generaFigure)
        {
            switch (generaFigure)
            {
                case 0:
                    Bulbasaur++;
                    return Bulbasaur;
                case 1:
                    Charmander++;
                    return Charmander;
                case 2:
                    Squirtle++;
                    return Squirtle;
                case 3:
                    Chikorita++;
                    return Chikorita;
                case 4:
                    Cyndaquil++;
                    return Cyndaquil;
                case 5:
                    Totodile++;
                    return Totodile;
                case 6:
                    Treecko++;
                    return Treecko;
                case 7:
                    Torchic++;
                    return Torchic;
                case 8:
                    Mudkip++;
                    return Mudkip;
                case 9:
                    Turtwig++;
                    return Turtwig;
                case 10:
                    Chimchar++;
                    return Chimchar;
                case 11:
                    Piplup++;
                    return Piplup;
            }
            return -1;
        }
        public string nomeFigura(int generaFigure)
        {
            switch (generaFigure)
            {
                case 0:
                    return "Bulbasaur";
                case 1:
                    return "Charmander";
                case 2:
                    return "Squirtle";
                case 3:
                    return "Chikorita";
                case 4:
                    return "Cyndaquil";
                case 5:
                    return "Totodile";
                case 6:
                    return "Treecko";
                case 7:
                    return "Torchic";
                case 8:
                    return "Mudkip";
                case 9:
                    return "Turtwig";
                case 10:
                    return "Chimchar";
                case 11:
                    return "Piplup";
            }
            return "";
        }
            public void resettaImmagine(object sender, EventArgs e)
        {

            if (primoClick != null && secondoClick != null)
                return;
            
            PictureBox resetta = sender as PictureBox;
            if (resetta == null)
                return;

            if (primoClick == null)
            {
                primoClick = resetta;
                primoClick.BackColor = Color.Transparent;
                primoClick.Image = resetta.Image;
                primoClick.Padding = new Padding(0, 0, 0, 0);
                return;
            }

            secondoClick = resetta;
            secondoClick.BackColor = Color.Transparent;
            secondoClick.Image = resetta.Image;

            secondoClick.Padding = new Padding(0, 0, 0, 0);

            if (primoClick.Name == secondoClick.Name)
            {
                this.Controls.Remove(primoClick);
                this.Controls.Remove(secondoClick);
                primoClick = null;
                secondoClick = null;
            }
            else
                timer1.Start();
        }
        private void controlloVittoria()
        {
            
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();

            primoClick.BackColor = Color.Black;
            secondoClick.BackColor = Color.Black;
            primoClick.Padding = new Padding(5000, 0, 0, 0);
            secondoClick.Padding = new Padding(5000, 0, 0, 0);
            primoClick = null;
            secondoClick = null;
            
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
            memory = new PictureBox[numeroTessere];
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
            memory = new PictureBox[numeroTessere];
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
            memory = new PictureBox[numeroTessere];
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
