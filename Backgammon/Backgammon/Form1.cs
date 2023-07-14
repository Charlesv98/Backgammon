using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Backgammon
{
    public partial class Form1 : Form
    {

        // zadefinovat classu board
        public Form1()
        {
            InitializeComponent();
           
        }
        


        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Point[] points = new Point[3];
            points[0] = new Point(0, Spike1.Height);
            points[1] = new Point(Spike1.Width / 2, 0);
            points[2] = new Point(Spike1.Width, Spike1.Height);
            e.Graphics.FillPolygon(Brushes.Blue, points);
        }

        private void pictureBox2_Paint(object sender, PaintEventArgs e)
        {
            Point[] points = new Point[3];
            points[0] = new Point(0, Spike1.Height);
            points[1] = new Point(Spike1.Width / 2, 0);
            points[2] = new Point(Spike1.Width, Spike1.Height);
            e.Graphics.FillPolygon(Brushes.Red, points);
        }

        private void pictureBox3_Paint(object sender, PaintEventArgs e)
        {
            Point[] points = new Point[3];
            points[0] = new Point(0, Spike1.Height);
            points[1] = new Point(Spike1.Width / 2, 0);
            points[2] = new Point(Spike1.Width, Spike1.Height);
            e.Graphics.FillPolygon(Brushes.Blue, points);
        }

        private void pictureBox4_Paint(object sender, PaintEventArgs e)
        {
            Point[] points = new Point[3];
            points[0] = new Point(0, Spike1.Height);
            points[1] = new Point(Spike1.Width / 2, 0);
            points[2] = new Point(Spike1.Width, Spike1.Height);
            e.Graphics.FillPolygon(Brushes.Red  , points);
        }

        private void pictureBox5_Paint(object sender, PaintEventArgs e)
        {
            Point[] points = new Point[3];
            points[0] = new Point(0, Spike1.Height);
            points[1] = new Point(Spike1.Width / 2, 0);
            points[2] = new Point(Spike1.Width, Spike1.Height);
            e.Graphics.FillPolygon(Brushes.Blue, points);
        }

        private void pictureBox6_Paint(object sender, PaintEventArgs e)
        {
            Point[] points = new Point[3];
            points[0] = new Point(0, Spike1.Height);
            points[1] = new Point(Spike1.Width / 2, 0);
            points[2] = new Point(Spike1.Width, Spike1.Height);
            e.Graphics.FillPolygon(Brushes.Red, points);
        }

        private void pictureBox7_Paint(object sender, PaintEventArgs e)
        {
            Point[] points = new Point[3];
            points[0] = new Point(0, Spike1.Height);
            points[1] = new Point(Spike1.Width / 2, 0);
            points[2] = new Point(Spike1.Width, Spike1.Height);
            e.Graphics.FillPolygon(Brushes.Blue, points);
        }

        private void pictureBox8_Paint(object sender, PaintEventArgs e)
        {
            Point[] points = new Point[3];
            points[0] = new Point(0, Spike1.Height);
            points[1] = new Point(Spike1.Width / 2, 0);
            points[2] = new Point(Spike1.Width, Spike1.Height);
            e.Graphics.FillPolygon(Brushes.Red, points);
        }

        private void pictureBox9_Paint(object sender, PaintEventArgs e)
        {
            Point[] points = new Point[3];
            points[0] = new Point(0, Spike1.Height);
            points[1] = new Point(Spike1.Width / 2, 0);
            points[2] = new Point(Spike1.Width, Spike1.Height);
            e.Graphics.FillPolygon(Brushes.Blue, points);
        }

        private void pictureBox10_Paint(object sender, PaintEventArgs e)
        {
            Point[] points = new Point[3];
            points[0] = new Point(0, Spike1.Height);
            points[1] = new Point(Spike1.Width / 2, 0);
            points[2] = new Point(Spike1.Width, Spike1.Height);
            e.Graphics.FillPolygon(Brushes.Red, points);
        }

        private void pictureBox11_Paint(object sender, PaintEventArgs e)
        {
            Point[] points = new Point[3];
            points[0] = new Point(0, Spike1.Height);
            points[1] = new Point(Spike1.Width / 2, 0);
            points[2] = new Point(Spike1.Width, Spike1.Height);
            e.Graphics.FillPolygon(Brushes.Blue, points);
        }
            
        private void pictureBox12_Paint(object sender, PaintEventArgs e)
        {
            Point[] points = new Point[3];
            points[0] = new Point(0, Spike1.Height);
            points[1] = new Point(Spike1.Width / 2, 0);
            points[2] = new Point(Spike1.Width, Spike1.Height);
            e.Graphics.FillPolygon(Brushes.Red, points);
        }

        private void pictureBox13_Paint(object sender, PaintEventArgs e)
        {
            Point[] points = new Point[3];
            points[0] = new Point(0, 0);
            points[1] = new Point(Spike1.Width / 2, Spike1.Height);
            points[2] = new Point(Spike1.Width, 0);
            e.Graphics.FillPolygon(Brushes.Red, points);
        }

        private void pictureBox14_Paint(object sender, PaintEventArgs e)
        {
            Point[] points = new Point[3];
            points[0] = new Point(0, 0);
            points[1] = new Point(Spike1.Width / 2, Spike1.Height);
            points[2] = new Point(Spike1.Width, 0);
            e.Graphics.FillPolygon(Brushes.Blue, points);
        }

        private void pictureBox15_Paint(object sender, PaintEventArgs e)
        {
            Point[] points = new Point[3];
            points[0] = new Point(0, 0);
            points[1] = new Point(Spike1.Width / 2, Spike1.Height);
            points[2] = new Point(Spike1.Width, 0);
            e.Graphics.FillPolygon(Brushes.Red, points);
        }

        private void pictureBox16_Paint(object sender, PaintEventArgs e)
        {
            Point[] points = new Point[3];
            points[0] = new Point(0, 0);
            points[1] = new Point(Spike1.Width / 2, Spike1.Height);
            points[2] = new Point(Spike1.Width, 0);
            e.Graphics.FillPolygon(Brushes.Blue, points);
        }

        private void pictureBox17_Paint(object sender, PaintEventArgs e)
        {
            Point[] points = new Point[3];
            points[0] = new Point(0, 0);
            points[1] = new Point(Spike1.Width / 2, Spike1.Height);
            points[2] = new Point(Spike1.Width, 0);
            e.Graphics.FillPolygon(Brushes.Red, points);
        }

        private void pictureBox18_Paint(object sender, PaintEventArgs e)
        {
            Point[] points = new Point[3];
            points[0] = new Point(0, 0);
            points[1] = new Point(Spike1.Width / 2, Spike1.Height);
            points[2] = new Point(Spike1.Width, 0);
            e.Graphics.FillPolygon(Brushes.Blue, points);
        }

        private void pictureBox19_Paint(object sender, PaintEventArgs e)
        {
            Point[] points = new Point[3];
            points[0] = new Point(0, 0);
            points[1] = new Point(Spike1.Width / 2, Spike1.Height);
            points[2] = new Point(Spike1.Width, 0);
            e.Graphics.FillPolygon(Brushes.Red, points);
        }

        private void pictureBox20_Paint(object sender, PaintEventArgs e)
        {
            Point[] points = new Point[3];
            points[0] = new Point(0, 0);
            points[1] = new Point(Spike1.Width / 2, Spike1.Height);
            points[2] = new Point(Spike1.Width, 0);
            e.Graphics.FillPolygon(Brushes.Blue, points);
        }

        private void pictureBox21_Paint(object sender, PaintEventArgs e)
        {
            Point[] points = new Point[3];
            points[0] = new Point(0, 0);
            points[1] = new Point(Spike1.Width / 2, Spike1.Height);
            points[2] = new Point(Spike1.Width, 0);
            e.Graphics.FillPolygon(Brushes.Red, points);
        }

        private void pictureBox23_Paint(object sender, PaintEventArgs e)
        {
            Point[] points = new Point[3];
            points[0] = new Point(0, 0);
            points[1] = new Point(Spike1.Width / 2, Spike1.Height);
            points[2] = new Point(Spike1.Width, 0);
            e.Graphics.FillPolygon(Brushes.Blue, points);
        }

        private void pictureBox22_Paint(object sender, PaintEventArgs e)
        {
            Point[] points = new Point[3];
            points[0] = new Point(0, 0);
            points[1] = new Point(Spike1.Width / 2, Spike1.Height);
            points[2] = new Point(Spike1.Width, 0);
            e.Graphics.FillPolygon(Brushes.Red, points);
        }

        private void pictureBox24_Paint(object sender, PaintEventArgs e)
        {
            Point[] points = new Point[3];
            points[0] = new Point(0, 0);
            points[1] = new Point(Spike1.Width / 2, Spike1.Height);
            points[2] = new Point(Spike1.Width, 0);
            e.Graphics.FillPolygon(Brushes.Blue, points);
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            this.BackColor = Color.Khaki;
        }

        private void pictureBox25_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(Color.Brown);
        }

        private void pictureBox26_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(Color.Black);
        }

        private void pictureBox27_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(Color.White);
        }

        private void Throw_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();

            int dice1 = rnd.Next(1, 7);
            int dice2 = rnd.Next(1, 7);

            Bitmap bmp = new Bitmap(Dices.Width, Dices.Height);

            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.Clear(Color.White);
                Font font = new Font("Arial", 30);
                g.DrawString(dice1.ToString(), font, Brushes.Black, 20, 20);
                g.DrawString(dice2.ToString(), font, Brushes.Black, 75, 20);

                Pen pen = new Pen(Color.Black);

            }
            Dices.Image = bmp;
        }

        
    }
    
}
