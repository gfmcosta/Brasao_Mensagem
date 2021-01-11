using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;using WindowsFormsApp1;

namespace Brasao_Mensagem
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void gunaLinePanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Poemas_Escolha PE = new Poemas_Escolha();
            PE.ShowDialog();
            this.Close();


        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            ToolTip toolTip1 = new ToolTip();
            toolTip1.SetToolTip(pictureBox1, "Clique para saber mais");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            WindowsFormsApp1.Form1 Quiz = new WindowsFormsApp1.Form1();
            Quiz.StartPosition = FormStartPosition.CenterScreen;
            Quiz.ShowDialog();
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            WindowsFormsApp1.SimbologiaBrasao simbologiaBrasao = new SimbologiaBrasao();
            simbologiaBrasao.StartPosition = FormStartPosition.CenterScreen;
            simbologiaBrasao.ShowDialog();
            this.Close();
        }
    }
}
