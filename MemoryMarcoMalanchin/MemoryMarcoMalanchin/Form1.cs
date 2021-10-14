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
        PictureBox primoClick, secondoClick;
        bool turno = true;
        int coppieGiocatore1 = 0;
        int coppieGiocatore2 = 0;
        string nomeGiocatore1;
        string nomeGiocatore2;

        public Form1()
        {
            //Dichiaro quali bottoni/label sarranno visibili caricando il programma inizialmente.
            InitializeComponent();
            SceltaTessereLbl.Visible = false;
            SceltaTessereLbl.Enabled = false;
            ValoreTessereBtn1.Visible = false;
            ValoreTessereBtn1.Enabled = false;
            ValoreTessereBtn2.Visible = false;
            ValoreTessereBtn2.Enabled = false;
            ValoreTessereBtn3.Visible = false;
            ValoreTessereBtn3.Enabled = false;
            lblPuntiGiocatore1.Enabled = false;
            lblPuntiGiocatore1.Visible = false;
            lblPuntiGiocatore2.Enabled = false;
            lblPuntiGiocatore2.Visible = false;
            lblChiediGiocatori.Visible = false;
            lblChiediGiocatori.Enabled = false;
            txtBxGiocatore1.Enabled = false;
            txtBxGiocatore1.Visible = false;
            txtBxGiocatore2.Enabled = false;
            txtBxGiocatore2.Visible = false;
            btnGioca2.Visible = false;
            btnGioca2.Enabled = false;
            lblTurno.Visible = false;
            lblTurno.Enabled = false;
            lblInfomazioni.Enabled = false;
            lblInfomazioni.Visible = false;
            btnMenù.Visible = false;
            btnMenù.Enabled = false;
            lblTitolo.Visible = true;
            lblTitolo.Enabled = true;
        }
        public void CreaBottoni()
        {
            //Creo un Random e dichiaro la posizione iniziale della prima tessere generata.
            Random generatoreNumeri = new Random();
            int PosizioneTesseraX = 70;
            int PosizioneTesseraY = 50;
            int x = 0;
            for (int i = 0; i < memory.Length; i++) //Con il random assegno le immagini a le schede del memory, se l'immagine è già stata assegnata due volte assegno un' altra immagine.
            {
                int numeroFigura = generatoreNumeri.Next(0, memory.Length / 2);
                if (controlloFigure(numeroFigura) > 2)
                {
                    i--;
                }
                else
                {                                           //Creo la picturbox alla quale verrà assegnata un immagine grazie alla funzione generaImmagine.
                    memory[i] = new PictureBox();
                    memory[i].Image = generaImmagine(numeroFigura);
                    memory[i].SizeMode = PictureBoxSizeMode.StretchImage;
                    memory[i].BorderStyle = BorderStyle.FixedSingle;
                    memory[i].Location = new Point(PosizioneTesseraX, PosizioneTesseraY); 
                    memory[i].Size = new Size(75, 100);
                    memory[i].BackColor = Color.Black;
                    memory[i].Padding = new Padding(5000, 0, 0, 0); //Aumento il padding della figura per non far vedere l'immagine della carta memory.
                    memory[i].Name = nomeFigura(numeroFigura);
                    memory[i].Click += new EventHandler(resettaImmagine);
                    this.Controls.Add(memory[i]);
                    x++;
                    PosizioneTesseraX += 80; //ad ogni scheda memory creata aumento ogni volta la x della prossima tessera, così facendo si creeranno distanziate tra di loro.
                    if (x == 8 || x == 16) //Ogni 8 tessere la posizione x torna normale mentre la Y aumenta per creare un altra fila di carte memory.
                    {
                        PosizioneTesseraX = 70;
                        PosizioneTesseraY += 110;
                    }
                }
            }
        }

        public Image generaImmagine(int generaFigure) //Viene assegnata l'immagine della picturbox a seconda del numero generato dal random.
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

        public int controlloFigure(int generaFigure) // se le figure sono ripetute per più di due volte l'immagine non viene assegnata e si assegna un altra immagine.
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
        public string nomeFigura(int generaFigure) //Assegno i nomi alle varie picturBox per effetuare successivamente i controlli dell'assegnazione dei punti ai giocatori.
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
                primoClick = resetta; //faccio ritornare il padding della figura normale per mostrare al giocatore la figura.
                primoClick.BackColor = Color.Transparent;
                primoClick.Image = resetta.Image;
                primoClick.Padding = new Padding(0, 0, 0, 0);
                primoClick.Enabled = false;
                return;
                
            }

            secondoClick = resetta;
            secondoClick.BackColor = Color.Transparent;
            secondoClick.Image = resetta.Image;

            secondoClick.Padding = new Padding(0, 0, 0, 0);

            if (primoClick.Name == secondoClick.Name) //se i nomi delle due picturbox sono uguali viene assegnato il punto al giocatore e le carte scompaiono.
            {
                this.Controls.Remove(primoClick);
                this.Controls.Remove(secondoClick);
                primoClick = null;
                secondoClick = null;
                if (turno) // faccio aumentare i punti dei giocatori a seconda del turno in cui siamo.
                {
                    coppieGiocatore1++; 
                    this.BackColor = Color.LightBlue; //il colore blu indica il turno del primo giocatore.
                    lblPuntiGiocatore1.Text = $"{nomeGiocatore1}:{coppieGiocatore1}"; //Aggiorno il punteggio dei giocatori.
                    lblPuntiGiocatore2.Text = $"{nomeGiocatore2}:{coppieGiocatore2}";
                    lblTurno.Text = $"Turno di: {nomeGiocatore1}";
                }
                else
                {
                    coppieGiocatore2++;
                    this.BackColor = Color.LightSalmon; //il colore rosa indica il turno del secondo giocatore.
                    lblPuntiGiocatore1.Text = $"{nomeGiocatore1}:{coppieGiocatore1}";
                    lblPuntiGiocatore2.Text = $"{nomeGiocatore2}:{coppieGiocatore2}";
                    lblTurno.Text = $"Turno di: {nomeGiocatore2}";
                }
                if (coppieGiocatore1 + coppieGiocatore2 == memory.Length / 2) // quando le carte finiscono si controlla chi ha vinto
                {
                    controlloVittoria();
                }
            }
            else
            {
                timer1.Start();
                turno = !turno; //cambio turno.
                lblPuntiGiocatore1.Text = $"{nomeGiocatore1}:{coppieGiocatore1}";
                lblPuntiGiocatore2.Text = $"{nomeGiocatore2}:{coppieGiocatore2}";
            }
            if (turno)
            {
                this.BackColor = Color.LightBlue;
                lblPuntiGiocatore1.Text = $"{nomeGiocatore1}:{coppieGiocatore1}";
                lblPuntiGiocatore2.Text = $"{nomeGiocatore2}:{coppieGiocatore2}";
                lblTurno.Text = $"Turno di: {nomeGiocatore1}";
            }
            else
            {
                this.BackColor = Color.LightSalmon;
                lblPuntiGiocatore1.Text = $"{nomeGiocatore1}:{coppieGiocatore1}";
                lblPuntiGiocatore2.Text = $"{nomeGiocatore2}:{coppieGiocatore2}";
                lblTurno.Text = $"Turno di: {nomeGiocatore2}";
            }
        }
        private void controlloVittoria() //controllo quale giocatore ha più punti e assegno la vittoria o il pareggio.
        {
            if (coppieGiocatore1 > coppieGiocatore2)
                MessageBox.Show($"Vince {nomeGiocatore1}");
            else if (coppieGiocatore1 < coppieGiocatore2)
                MessageBox.Show($"Vince {nomeGiocatore2}");
            else if (coppieGiocatore1 == coppieGiocatore2)
                MessageBox.Show("Pareggio");
            this.Close();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop(); //se le carte non vengono abbinate corretamente, le tessere ritornano coperte.

            primoClick.BackColor = Color.Black;
            secondoClick.BackColor = Color.Black;
            primoClick.Padding = new Padding(5000, 0, 0, 0);
            secondoClick.Padding = new Padding(5000, 0, 0, 0);
            primoClick.Enabled = true;
            secondoClick.Enabled = true;
            primoClick = null;
            secondoClick = null;
            
        }

        public void GiocaBtn_Click(object sender, EventArgs e)
        {
            GiocaBtn.Visible = false;
            GiocaBtn.Enabled = false;
            InformazioniBtn.Visible = false;
            InformazioniBtn.Enabled = false;
            lblChiediGiocatori.Visible = true;
            lblChiediGiocatori.Enabled = true;
            SceltaTessereLbl.Visible = false;
            SceltaTessereLbl.Enabled = false;
            ValoreTessereBtn1.Visible = false;
            ValoreTessereBtn1.Enabled = false;
            ValoreTessereBtn2.Visible = false;
            ValoreTessereBtn2.Enabled = false;
            ValoreTessereBtn3.Visible = false;
            ValoreTessereBtn3.Enabled = false;
            lblPuntiGiocatore1.Enabled = false;
            lblPuntiGiocatore1.Visible = false;
            lblPuntiGiocatore2.Enabled = false;
            lblPuntiGiocatore2.Visible = false;
            txtBxGiocatore1.Enabled = true;
            txtBxGiocatore1.Visible = true;
            txtBxGiocatore2.Enabled = true;
            txtBxGiocatore2.Visible = true;
            btnGioca2.Visible = true;
            btnGioca2.Enabled = true;
            lblTitolo.Visible = false;
            lblTitolo.Enabled = false;

        }
        private void InformazioniBtn_Click(object sender, EventArgs e)
        {
            GiocaBtn.Visible = false;
            GiocaBtn.Enabled = false;
            InformazioniBtn.Visible = false;
            InformazioniBtn.Enabled = false;
            lblInfomazioni.Enabled = true;
            lblInfomazioni.Visible = true;
            btnMenù.Visible = true;
            btnMenù.Enabled = true;
            lblTitolo.Visible = false;
            lblTitolo.Enabled = false;
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
            this.BackColor = Color.LightBlue;
            lblPuntiGiocatore1.Text = $"{nomeGiocatore1}:{coppieGiocatore1}";
            lblPuntiGiocatore2.Text = $"{nomeGiocatore2}:{coppieGiocatore2}";
            lblTurno.Visible = true;
            lblTurno.Enabled = true;
            lblTurno.Text = $"Turno di: {nomeGiocatore1}";
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
            this.BackColor = Color.LightBlue;
            lblPuntiGiocatore1.Text = $"{nomeGiocatore1}:{coppieGiocatore1}";
            lblPuntiGiocatore2.Text = $"{nomeGiocatore2}:{coppieGiocatore2}";
            lblTurno.Visible = true;
            lblTurno.Enabled = true;
            lblTurno.Text = $"Turno di: {nomeGiocatore1}";
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
            this.BackColor = Color.LightBlue;
            lblPuntiGiocatore1.Text = $"{nomeGiocatore1}:{coppieGiocatore1}";
            lblPuntiGiocatore2.Text = $"{nomeGiocatore2}:{coppieGiocatore2}";
            lblTurno.Visible = true;
            lblTurno.Enabled = true;
            lblTurno.Text = $"Turno di: {nomeGiocatore1}";
        }
        private void btnGioca2_Click(object sender, EventArgs e)
        {
            SceltaTessereLbl.Visible = true;
            SceltaTessereLbl.Enabled = true;
            ValoreTessereBtn1.Visible = true;
            ValoreTessereBtn1.Enabled = true;
            ValoreTessereBtn2.Visible = true;
            ValoreTessereBtn2.Enabled = true;
            ValoreTessereBtn3.Visible = true;
            ValoreTessereBtn3.Enabled = true;
            lblPuntiGiocatore1.Enabled = true;
            lblPuntiGiocatore1.Visible = true;
            lblPuntiGiocatore2.Enabled = true;
            lblPuntiGiocatore2.Visible = true;
            txtBxGiocatore1.Enabled = false;
            txtBxGiocatore1.Visible = false;
            txtBxGiocatore2.Enabled = false;
            txtBxGiocatore2.Visible = false;
            btnGioca2.Visible = false;
            btnGioca2.Enabled = false;
            nomeGiocatore1 = txtBxGiocatore1.Text;
            nomeGiocatore2 = txtBxGiocatore2.Text;
            lblChiediGiocatori.Visible = false;
            lblChiediGiocatori.Enabled = false;
        }
        private void Menù_Click(object sender, EventArgs e)
        {
            GiocaBtn.Visible = true;
            GiocaBtn.Enabled = true;
            InformazioniBtn.Visible = true;
            InformazioniBtn.Enabled = true;
            lblInfomazioni.Enabled = false;
            lblInfomazioni.Visible = false;
            btnMenù.Visible = false;
            btnMenù.Enabled = false;
            lblTitolo.Visible = true;
            lblTitolo.Enabled = true;
        }
    }
}
