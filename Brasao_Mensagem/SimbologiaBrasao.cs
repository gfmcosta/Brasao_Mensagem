using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class SimbologiaBrasao : Form
    {
        public SimbologiaBrasao()
        {
            InitializeComponent();
        }

        private void gunaLinePanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gunaPictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Brasao_Mensagem.Menu simbologiaBrasao = new Brasao_Mensagem.Menu();
            simbologiaBrasao.StartPosition = FormStartPosition.CenterScreen;
            simbologiaBrasao.ShowDialog();
            this.Close();
        }
    }
}
