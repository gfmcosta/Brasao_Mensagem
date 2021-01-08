using System;
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
    public partial class Poemas_Escolha : Form
    {
        public Poemas_Escolha()
        {
            InitializeComponent();
        }

        private void gunaLinePanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu Menu = new Menu();
            Menu.ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Globais.Tema = "Campos";

            this.Hide();
            Book bk = new Book();
            bk.ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Globais.Tema = "Castelos";

            this.Hide();
            Book bk = new Book();
            bk.ShowDialog();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Globais.Tema = "Quinas";

            this.Hide();
            Book bk = new Book();
            bk.ShowDialog();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Globais.Tema = "Coroa";

            this.Hide();
            Book bk = new Book();
            bk.ShowDialog();
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Globais.Tema = "Timbre";

            this.Hide();
            Book bk = new Book();
            bk.ShowDialog();
            this.Close();
        }
    }
}
