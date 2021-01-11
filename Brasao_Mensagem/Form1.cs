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

     
    public partial class Form1 : Form
    {
      int TotalCertas = 0;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void gunaLabel1_Click(object sender, EventArgs e)
        {

        }

        private void gunaLabel2_Click(object sender, EventArgs e)
        {

        }

        private void gunaLinePanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gunaLinePanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gunaLinePanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gunaComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void gunaComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void gunaLabel10_Click(object sender, EventArgs e)
        {

        }

        private void gunaLabel11_Click(object sender, EventArgs e)
        {

        }

        private void gunaAdvenceButton1_Click(object sender, EventArgs e)
        {
            TotalCertas = 0;

            if (gunaComboBox5.SelectedIndex != 2)
            {
                gunaComboBox5.ForeColor = Color.Red;

            }
            else
            {
                gunaComboBox5.ForeColor = Color.Green;
                TotalCertas++;
            }



            if (gunaComboBox1.SelectedIndex != 0)
            {
                gunaComboBox1.ForeColor = Color.Red;

            }
            else
            {
                gunaComboBox1.ForeColor = Color.Green;
                TotalCertas++;
            }


            if (gunaComboBox2.SelectedIndex != 1)
            {
                gunaComboBox2.ForeColor = Color.Red;

            }
            else
            {
                gunaComboBox2.ForeColor = Color.Green;
                TotalCertas++;
            }


            if (gunaComboBox3.SelectedIndex != 2)
            {
                gunaComboBox3.ForeColor = Color.Red;


            }
            else
            {
                gunaComboBox3.ForeColor = Color.Green;
                TotalCertas++;
            }


            if (gunaComboBox4.SelectedIndex != 0)
            {
                gunaComboBox4.ForeColor = Color.Red;

            }
            else
            {
                gunaComboBox4.ForeColor = Color.Green;
                TotalCertas++;
            }


            gunaLabel17.Text =Convert.ToString(TotalCertas);


        }

        private void gunaPictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Brasao_Mensagem.Menu menu= new Brasao_Mensagem.Menu();
            menu.StartPosition = FormStartPosition.CenterScreen;
            menu.ShowDialog();
            this.Close();

        }

        private void gunaPictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            WindowsFormsApp1.Form2 menu = new WindowsFormsApp1.Form2();
            menu.StartPosition = FormStartPosition.CenterScreen;
            menu.ShowDialog();
            this.Close();
        }
    }
}
