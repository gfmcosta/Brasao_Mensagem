using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Brasao_Mensagem
{
    public partial class Book : Form
    {
        public Book()
        {
            InitializeComponent();
        }
        int npag=0;
        ArrayList Titulos = new ArrayList();
        ArrayList Poemas = new ArrayList();
        void Escolha()
        {
            Poemas.Clear();
            String Texto;

            if (Globais.Tema== "Campos")
            {
                Texto = "A Europa jaz, posta nos cotovelos:" + System.Environment.NewLine + "De Oriente a Ocidente jaz, fitando," + System.Environment.NewLine + "E toldam-lhe românticos cabelos" + System.Environment.NewLine +
                           "Olhos gregos, lembrando." + System.Environment.NewLine + System.Environment.NewLine + "O cotovelo esquerdo é recuado;" + System.Environment.NewLine + "O direito é em ângulo disposto." + System.Environment.NewLine +
                           "Aquele diz Itália onde é pousado;" + System.Environment.NewLine + "Este diz Inglaterra onde, afastado," + System.Environment.NewLine + System.Environment.NewLine +
                           "A mão sustenta, em que se apoia o rosto." + System.Environment.NewLine + "Fita, com olhar ’sfíngico e fatal," + System.Environment.NewLine + "O Ocidente, futuro do passado." + System.Environment.NewLine + "O rosto com que fita é Portugal.";
                Poemas.Add(Texto);
                Titulos.Add("O dos Castelos");

                //Outro poema

                Texto = "Os Deuses vendem quando dão." + System.Environment.NewLine + "Compra-se a glória com desgraça." + System.Environment.NewLine + "Ai dos felizes, porque são" + System.Environment.NewLine +
                           "Só o que passa!" + System.Environment.NewLine + System.Environment.NewLine + "Baste a quem baste o que lhe basta" + System.Environment.NewLine + "O bastante de lhe bastar!" + System.Environment.NewLine +
                           "A vida é breve, a alma é vasta:" + System.Environment.NewLine + "Ter é tardar." + System.Environment.NewLine + System.Environment.NewLine +
                           "Foi com desgraça e com vileza" + System.Environment.NewLine + "Que Deus ao Cristo definiu:" + System.Environment.NewLine + "Assim o opôs à Natureza" + System.Environment.NewLine + "E Filho o ungiu.";
                Poemas.Add(Texto);
                Titulos.Add("O das Quinas");

            }else if (Globais.Tema == "Castelos")
            {
                Texto = "O mito é o nada que é tudo." + System.Environment.NewLine +"O mesmo sol que abre os céus" + System.Environment.NewLine +"É um mito brilhante e mudo —" + System.Environment.NewLine +"O corpo morto de Deus," + System.Environment.NewLine +
                 "Vivo e desnudo." + System.Environment.NewLine + System.Environment.NewLine +"Este, que aqui aportou," + System.Environment.NewLine +"Foi por não ser existindo." + System.Environment.NewLine +"Sem existir nos bastou." + System.Environment.NewLine +
                 "Por não ter vindo foi vindo" + System.Environment.NewLine +"E nos criou." + System.Environment.NewLine + System.Environment.NewLine +"Assim a lenda se escorre" + System.Environment.NewLine +"A entrar na realidade," + System.Environment.NewLine +
                 "E a fecundá-la decorre." + System.Environment.NewLine +"Em baixo, a vida, metade" + System.Environment.NewLine +"De nada, morre.";
                Poemas.Add(Texto);
                Titulos.Add("Ulisses");

                //Outro Poema

                Texto = "Se a alma que sente e faz conhece" + System.Environment.NewLine +"Só porque lembra o que esqueceu," + System.Environment.NewLine +"Vivemos, raça, porque houvesse" + System.Environment.NewLine +"Memória em nós do instinto teu."
                    + System.Environment.NewLine + System.Environment.NewLine +"Nação porque reincarnaste," + System.Environment.NewLine +"Povo porque ressuscitou" + System.Environment.NewLine +"Ou tu, ou o de que eras a haste —" + System.Environment.NewLine +
                    "Assim se Portugal formou." + System.Environment.NewLine + System.Environment.NewLine +"Teu ser é como aquela fria" + System.Environment.NewLine +"Luz que precede a madrugada," + System.Environment.NewLine +"E é já o ir a haver o dia" + System.Environment.NewLine +
                    "Na antemanhã, confuso nada.";
                Poemas.Add(Texto);
                Titulos.Add("Viriato");

                //Outro Poema

                Texto = "Todo começo é involuntário." + System.Environment.NewLine +"Deus é o agente." + System.Environment.NewLine +"O herói a si assiste, vário" + System.Environment.NewLine +"E inconsciente." + System.Environment.NewLine +System.Environment.NewLine +
                    "À espada em tuas mãos achada" + System.Environment.NewLine +"Teu olhar desce." + System.Environment.NewLine +"«Que farei eu com esta espada?»" + System.Environment.NewLine +"Ergueste-a, e fez-se.";
                Poemas.Add(Texto);
                Titulos.Add("O Conde D. Henrique");

                //Outro Poema

                Texto = "As nações todas são mistérios." + System.Environment.NewLine +"Cada uma é todo o mundo a sós." + System.Environment.NewLine +"Ó mãe de reis e avó de impérios," + System.Environment.NewLine +"Vela por nós!" + System.Environment.NewLine + System.Environment.NewLine +
                    "Teu seio augusto amamentou" + System.Environment.NewLine +"Com bruta e natural certeza" + System.Environment.NewLine +"O que, imprevisto, Deus fadou." + System.Environment.NewLine +"Por ele reza!" + System.Environment.NewLine + System.Environment.NewLine +
                    "Dê tua prece outro destino" + System.Environment.NewLine +"A quem fadou o instinto teu!" + System.Environment.NewLine +"O homem que foi o teu menino" + System.Environment.NewLine +"Envelheceu." + System.Environment.NewLine + System.Environment.NewLine +
                    "Mas todo vivo é eterno infante" + System.Environment.NewLine +"Onde estás e não há o dia." + System.Environment.NewLine +"No antigo seio, vigilante," + System.Environment.NewLine +"De novo o cria!";
                Poemas.Add(Texto);
                Titulos.Add("D. Tareja");

                //Outro Poema

                Texto = "Pai, foste cavaleiro." + System.Environment.NewLine + "Hoje a vigília é nossa." + System.Environment.NewLine + "Dá-nos o exemplo inteiro" + System.Environment.NewLine + "E a tua inteira força!" + System.Environment.NewLine + System.Environment.NewLine +
                    "Dá, contra a hora em que, errada," + System.Environment.NewLine +"Novos infiéis vençam," + System.Environment.NewLine +"A bênção como espada," + System.Environment.NewLine +"A espada como bênção!";
                Poemas.Add(Texto);
                Titulos.Add("D. Afonso Henriques");

                //Outro Poema

                Texto = "Na noite escreve um seu Cantar de Amigo" + System.Environment.NewLine +"O plantador de naus a haver," + System.Environment.NewLine +"E ouve um silêncio múrmuro consigo:" + System.Environment.NewLine +"É o rumor dos pinhais que, como um trigo" + System.Environment.NewLine +
                    "De Império, ondulam sem se poder ver." + System.Environment.NewLine + System.Environment.NewLine +"Arroio, esse cantar, jovem e puro," + System.Environment.NewLine +"Busca o oceano por achar;" + System.Environment.NewLine +"E a fala dos pinhais, marulho obscuro," + System.Environment.NewLine +
                    "É o som presente desse mar futuro," + System.Environment.NewLine +"É a voz da terra ansiando pelo mar.";
                Poemas.Add(Texto);
                Titulos.Add("D. Dinis");

                //Outro Poema

                Texto = "O homem e a hora são um só" + System.Environment.NewLine +"Quando Deus faz e a história é feita." + System.Environment.NewLine +"O mais é carne, cujo pó" + System.Environment.NewLine +"A terra espreita." + System.Environment.NewLine + System.Environment.NewLine +
                    "Mestre, sem o saber, do Templo" + System.Environment.NewLine +"Que Portugal foi feito ser," + System.Environment.NewLine +"Que houveste a glória e deste o exemplo" + System.Environment.NewLine +"De o defender." + System.Environment.NewLine + System.Environment.NewLine +
                    "Teu nome, eleito em sua fama," + System.Environment.NewLine +"É, na ara da nossa alma interna," + System.Environment.NewLine +"A que repele, eterna chama," + System.Environment.NewLine +"A sombra eterna.";
                Poemas.Add(Texto);
                Titulos.Add("D. João, o Primeiro");

                //Outro Poema

                Texto = "Que enigma havia em teu seio" + System.Environment.NewLine + "Que só génios concebia?" + System.Environment.NewLine + "Que arcanjo teus sonhos veio" + System.Environment.NewLine + "Velar, maternos, um dia?" + System.Environment.NewLine + System.Environment.NewLine +
                    "Volve a nós teu rosto sério," + System.Environment.NewLine + "Princesa do Santo Graal," + System.Environment.NewLine + "Humano ventre do Império," + System.Environment.NewLine + "Madrinha de Portugal!";
                Poemas.Add(Texto);
                Titulos.Add("D. Filipa de Lencastre");
            }
            else if (Globais.Tema == "Quinas")
            {

            }
            else if (Globais.Tema == "Coroa")
            {
                Texto = "Que auréola te cerca?" + System.Environment.NewLine +"É a espada que, volteando," + System.Environment.NewLine +"Faz que o ar alto perca" + System.Environment.NewLine +"Seu azul negro e brando." + System.Environment.NewLine + System.Environment.NewLine +
            "Mas que espada é que, erguida," + System.Environment.NewLine +"Faz esse halo no céu?" + System.Environment.NewLine +"É Excalibur, a ungida," + System.Environment.NewLine +"Que o Rei Artur te deu." + System.Environment.NewLine + System.Environment.NewLine +
            "’Sperança consumada," + System.Environment.NewLine +"S. Portugal em ser," + System.Environment.NewLine +"Ergue a luz da tua espada" + System.Environment.NewLine +"Para a estrada se ver!";
                Poemas.Add(Texto);
                Titulos.Add("Nun’Álvares Pereira");
            }
            else if (Globais.Tema == "Timbre")
            {

            }




        }
        private void Book_Load(object sender, EventArgs e)
        {
            Escolha();
            if (Globais.Tema == "Coroa")
            {
                I1.Text = Poemas[0].ToString();
                Titulo.Text = Titulos[0].ToString();
                I2.Text = Environment.NewLine + Environment.NewLine + Environment.NewLine + Environment.NewLine + Environment.NewLine + Environment.NewLine + "--FIM--";
                Titulo2.Text = "";
                pictureBox3.Visible = false;
            }
            else if (Globais.Tema == "Campos")
            {
                I1.Text = Poemas[0].ToString();
                Titulo.Text = Titulos[0].ToString();
                I2.Text = Poemas[1].ToString();
                Titulo2.Text = Titulos[1].ToString();
                pictureBox3.Visible = false;
            }
            else
            {
                I1.Text = Poemas[0].ToString();
                Titulo.Text = Titulos[0].ToString();
                I2.Text = Poemas[1].ToString();
                Titulo2.Text = Titulos[1].ToString();
                pictureBox3.Visible = true;
                npag = 1;

            }
            
        }

        private void guna2GroupBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void guna2CirclePictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void guna2CirclePictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            //Se nao funciaonar, só funciona para Castelos
            pictureBox3.Visible = true;
            int i;
            for (i = npag-2; i < Poemas.Count; i--)
            {
                I2.Text = Poemas[i].ToString();
                Titulo2.Text = Titulos[i].ToString();
                i--;
                I1.Text = Poemas[i].ToString();
                Titulo.Text = Titulos[i].ToString();
                if (i % 2 == 0)
                {
                    break;
                }

            }
            npag = i+1;
            if (i == 0)
            {
                pictureBox2.Visible = false;
                pictureBox3.Visible = true;
            }

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            //Se nao funciaonar, só funciona para Castelos
            pictureBox2.Visible = true;
            int i;
            for(i=npag+1; i<Poemas.Count; i++)
            {
                I1.Text = Poemas[i].ToString();
                Titulo.Text = Titulos[i].ToString();
                i++;
                I2.Text = Poemas[i].ToString();
                Titulo2.Text = Titulos[i].ToString();
                if (i % 2 != 0)
                {
                    break;
                }

            }
            npag = i;
            if (i == 0)
            {
                pictureBox3.Visible = true;
                pictureBox2.Visible = false;
            }
            if (i == Poemas.Count-1)
            {
                pictureBox3.Visible = false;
            }

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Poemas_Escolha PE = new Poemas_Escolha();
            PE.ShowDialog();
            this.Close();
        }
    }
}
