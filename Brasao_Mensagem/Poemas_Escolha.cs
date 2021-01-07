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
            Menu mn = new Menu();
            mn.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Globais.Tema = "Campos";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Globais.Tema = "Castelos";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Globais.Tema = "Quinas";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Globais.Tema = "Coroa";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Globais.Tema = "Timbre";
        }
    }
}
