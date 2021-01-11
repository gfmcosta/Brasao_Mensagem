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
    public partial class Form2 : Form
    {


    
        private int _xPos;
        private int _yPos;
        private bool _dragging;

        

     PictureBox[] array = new PictureBox[5];
     PictureBox nearest = new PictureBox();
   int TotalCertas;

        public Form2()
        {
            InitializeComponent();
            array[0] = gunaPictureBox9;
            array[1] = gunaPictureBox7;
            array[2] = gunaPictureBox11;
            array[3] = gunaPictureBox12;
            array[4] = gunaPictureBox10;

        }





        private void gunaLinePanel4_Paint(object sender, PaintEventArgs e)
        {

        }


/// <summary>
/// /////////////////////////////////////////////////////////////////////////////////////////


        private void gunaPictureBox3_MouseDown(object sender, MouseEventArgs e)
        {
        

            if (e.Button != MouseButtons.Left) return;
            _dragging = true;
            _xPos = e.X;
            _yPos = e.Y;

        }

        private void gunaPictureBox3_MouseUp(object sender, MouseEventArgs e)
        {

            Boolean noIntersects = true;
            var c = sender as PictureBox;
      
            if (null == c) return;
            _dragging = false;



            foreach(PictureBox pb in array)
            {
           

             if(gunaPictureBox3.Bounds.IntersectsWith(pb.Bounds)) {

                    pb.Image = gunaPictureBox3.Image;
                    pb.Name = pb.Tag.ToString() + "DEU";
                    gunaPictureBox3.Name = pb.Tag.ToString() + "DEU";
                    gunaPictureBox3.Location = gunaPictureBox1.Location;
                    gunaPictureBox3.Enabled = false;
                    gunaPictureBox3.Image = Brasao_Mensagem.Properties.Resources.quinasDisnabled;
                    noIntersects = false;
                    break;
                }
                
            }

            if (noIntersects == true)
            {
                gunaPictureBox3.Location = gunaPictureBox1.Location;
                gunaPictureBox3.Enabled = true;
            }

        }                                                                                                               

        private void gunaPictureBox3_MouseMove(object sender, MouseEventArgs e)
        {
            var c = sender as PictureBox;
            if (!_dragging || null == c) return;
            c.Top = e.Y + c.Top - _yPos;
            c.Left = e.X + c.Left - _xPos;
        }



/// ////////////////////////////////////////////////////////////////////////////////////////////////


        private void gunaPictureBox15_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            _dragging = true;
            _xPos = e.X;
            _yPos = e.Y;
        }

        private void gunaPictureBox15_MouseUp(object sender, MouseEventArgs e)
        {
            Boolean noIntersects = true;
                var c = sender as PictureBox;
            if (null == c) return;
            _dragging = false;


            foreach (PictureBox pb in array)
            {


                if (gunaPictureBox15.Bounds.IntersectsWith(pb.Bounds))
                {

                    pb.Image = gunaPictureBox15.Image;
                    pb.Name = pb.Tag.ToString() + "DEU";
                    gunaPictureBox15.Name = pb.Tag.ToString() + "DEU";
                    gunaPictureBox15.Location = gunaPictureBox6.Location;
                    gunaPictureBox15.Enabled = false;
                    gunaPictureBox15.Image = Brasao_Mensagem.Properties.Resources.GrifoDisnabled;
                    noIntersects = false;
                    break;
                }
              
            
            }

            if (noIntersects==true)
            {
                gunaPictureBox15.Location = gunaPictureBox6.Location;
                gunaPictureBox15.Enabled = true;
            }
        }

        private void gunaPictureBox15_MouseMove(object sender, MouseEventArgs e)
        {
            var c = sender as PictureBox;
            if (!_dragging || null == c) return;
            c.Top = e.Y + c.Top - _yPos;
            c.Left = e.X + c.Left - _xPos;
        }



     
        /// //////////////////////////////////////////////////////////////////////////////////////
        

   
        private void gunaPictureBox13_MouseDown(object sender, MouseEventArgs e)
        {

            if (e.Button != MouseButtons.Left) return;
            _dragging = true;
            _xPos = e.X;
            _yPos = e.Y;
        }

        private void gunaPictureBox13_MouseUp(object sender, MouseEventArgs e)
        {  
            Boolean  noIntersects = true;
            var c = sender as PictureBox;
            if (null == c) return;
            _dragging = false;


            foreach (PictureBox pb in array)
            {
            

                if (gunaPictureBox13.Bounds.IntersectsWith(pb.Bounds))
                {

                    pb.Image = gunaPictureBox13.Image;
                    pb.Name = pb.Tag.ToString() + "DEU";
                    gunaPictureBox13.Name = pb.Tag.ToString() + "DEU";
                    gunaPictureBox13.Location = gunaPictureBox4.Location;
                    gunaPictureBox13.Enabled = false;
                    gunaPictureBox13.Image = Brasao_Mensagem.Properties.Resources.CrownDisnabled;
                    noIntersects = false;
                    break;
                }
               
            }

            if (noIntersects == true)
            {
                gunaPictureBox13.Location = gunaPictureBox4.Location;
                gunaPictureBox13.Enabled = true;
            }

        }

        private void gunaPictureBox13_MouseMove(object sender, MouseEventArgs e)
        {
            var c = sender as PictureBox;
            if (!_dragging || null == c) return;
            c.Top = e.Y + c.Top - _yPos;
            c.Left = e.X + c.Left - _xPos;
        }


        ///////////////////////////////////////////////////////////////////////////////////


        private void gunaPictureBox14_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            _dragging = true;
            _xPos = e.X;
            _yPos = e.Y;
        }

        private void gunaPictureBox14_MouseUp(object sender, MouseEventArgs e)
        {
            Boolean noIntersects = true;
            var c = sender as PictureBox;
            if (null == c) return;
            _dragging = false;


            foreach (PictureBox pb in array)
            {


                if (gunaPictureBox14.Bounds.IntersectsWith(pb.Bounds))
                {

                    pb.Image = gunaPictureBox14.Image;
                    pb.Name = pb.Tag.ToString() + "DEU";
                    gunaPictureBox14.Name = pb.Tag.ToString() + "DEU";
                    gunaPictureBox14.Location = gunaPictureBox5.Location;
                    gunaPictureBox14.Enabled = false;
                    gunaPictureBox14.Image = Brasao_Mensagem.Properties.Resources.casteloDisnabled;
                    noIntersects = false;
                    break;
                }
             

            }

            if (noIntersects == true)
            {
                gunaPictureBox14.Location = gunaPictureBox5.Location;
                gunaPictureBox14.Enabled = true;
            }
        }

        private void gunaPictureBox14_MouseMove(object sender, MouseEventArgs e)
        {
            var c = sender as PictureBox;
            if (!_dragging || null == c) return;
            c.Top = e.Y + c.Top - _yPos;
            c.Left = e.X + c.Left - _xPos;
        }


///////////////////////////////////////////////////////////////////////////////////


        private void gunaPictureBox16_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            _dragging = true;
            _xPos = e.X;
            _yPos = e.Y;
        }

        private void gunaPictureBox16_MouseUp(object sender, MouseEventArgs e)
        {
            Boolean noIntersects = true;
            var c = sender as PictureBox;
            if (null == c) return;
            _dragging = false;


            foreach (PictureBox pb in array)
            {


                if (gunaPictureBox16.Bounds.IntersectsWith(pb.Bounds))
                {

                    pb.Image = gunaPictureBox16.Image;
                    pb.Name = pb.Tag.ToString()+"DEU";
                    gunaPictureBox16.Name = pb.Tag.ToString()+"DEU";
                    gunaPictureBox16.Location = gunaPictureBox8.Location;
                    gunaPictureBox16.Enabled = false;
                    gunaPictureBox16.Image = Brasao_Mensagem.Properties.Resources.CamposDisnabled;
                    noIntersects = false;
                    break;
                }
             
            }
            if (noIntersects == true)
            {
                gunaPictureBox16.Location = gunaPictureBox8.Location;
                gunaPictureBox16.Enabled = true;
            }
        }

        private void gunaPictureBox16_MouseMove(object sender, MouseEventArgs e)
        {
            var c = sender as PictureBox;
            if (!_dragging || null == c) return;
            c.Top = e.Y + c.Top - _yPos;
            c.Left = e.X + c.Left - _xPos;
        }

        private void gunaPictureBox15_Click(object sender, EventArgs e)
        {

        }

        private void gunaPictureBox17_Click(object sender, EventArgs e)
        {
            TotalCertas = 0;
            gunaLabel1.Text = "0";
            gunaPictureBox3.Image = Brasao_Mensagem.Properties.Resources.quinas;
            gunaPictureBox3.Enabled = true;
            gunaPictureBox15.Image = Brasao_Mensagem.Properties.Resources.Grifo;
            gunaPictureBox15.Enabled = true;
            gunaPictureBox13.Image = Brasao_Mensagem.Properties.Resources.Crown;
            gunaPictureBox13.Enabled = true;
            gunaPictureBox14.Image = Brasao_Mensagem.Properties.Resources.castelo;
            gunaPictureBox14.Enabled = true;
            gunaPictureBox16.Image = Brasao_Mensagem.Properties.Resources.Campos;
            gunaPictureBox16.Enabled = true;

            foreach (PictureBox pb in array)
            {
                pb.Image = null;
                pb.BackColor =SystemColors.Control;

            }


            }

        private void gunaAdvenceButton2_Click(object sender, EventArgs e)
        {
            TotalCertas = 0;



            if (array[0].Name != gunaPictureBox14.Name)
            {
                gunaPictureBox9.BackColor = Color.Red;

            }
            else
            {
                gunaPictureBox9.BackColor = Color.Green;
                TotalCertas++;
            }


            if (array[1].Name != gunaPictureBox3.Name)
            {
                gunaPictureBox7.BackColor = Color.Red;

            }
            else
            {
                gunaPictureBox7.BackColor = Color.Green;
                TotalCertas++;
            }



            if (array[2].Name != gunaPictureBox16.Name)
            {
                gunaPictureBox11.BackColor = Color.Red;

            }
            else
            {
                gunaPictureBox11.BackColor = Color.Green;
                TotalCertas++;
            }


            if (array[3].Name != gunaPictureBox13.Name)
            {
                gunaPictureBox12.BackColor = Color.Red;

            }
            else
            {
                gunaPictureBox12.BackColor = Color.Green;
                TotalCertas++;
            }


            if (array[4].Name != gunaPictureBox15.Name)
            {
                gunaPictureBox10.BackColor = Color.Red;

            }
            else
            {
                gunaPictureBox10.BackColor = Color.Green;
                TotalCertas++;
            }




            gunaLabel1.Text = Convert.ToString(TotalCertas);




        }

        private void gunaPictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            WindowsFormsApp1.Form1 menu = new WindowsFormsApp1.Form1();
            menu.StartPosition = FormStartPosition.CenterScreen;
            menu.ShowDialog();
            this.Close();

        }

        private void gunaPictureBox18_Click(object sender, EventArgs e)
        {

        }

        private void gunaPictureBox18_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Brasao_Mensagem.Menu menu = new Brasao_Mensagem.Menu();
            menu.StartPosition = FormStartPosition.CenterScreen;
            menu.ShowDialog();
            this.Close();

        }
    }
}
