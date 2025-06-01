using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication_15
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double m = 30; //scale
            int xc = pictureBox1.Width / 2;   // center coordinates
            int yc = pictureBox1.Height / 2;
            int xe, ye;     // point "screen" coordinates
            double x, y;   // point "math" coordinates
            double step = 0.005;    // step
            Graphics G = pictureBox1.CreateGraphics();
            G.Clear(System.Drawing.Color.White);
            Pen myPen = new Pen(Color.Silver);
            G.DrawLine(myPen, 10, yc, 2 * xc - 10, yc);   // axes
            G.DrawLine(myPen, xc, 10, xc, 2 * yc - 10);
            myPen = new Pen(Color.Black);
            x = -Math.PI;
            // function graph design loop
            while (x < Math.PI)
            {
                try   // if the function does not exist at any point 
                {
                    y = 1/Math.Sin(x);   // Function formula!!!
                    xe = (int)(xc + m * x);
                    ye = (int)(yc - m * y);
                    G.DrawEllipse(myPen, xe, ye, 1, 1);
                }
                catch { }
                x += step;
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            double m = 30; //scale
            int xc = pictureBox1.Width / 2;   // center coordinates
            int yc = pictureBox1.Height / 2;
            int xe, ye;     // point "screen" coordinates
            double x, y;   // point "math" coordinates
            double step = 0.005;    // step
            Graphics G = pictureBox1.CreateGraphics();
            G.Clear(System.Drawing.Color.White);
            Pen myPen = new Pen(Color.Silver);
            G.DrawLine(myPen, 10, yc, 2 * xc - 10, yc);   // axes
            G.DrawLine(myPen, xc, 10, xc, 2 * yc - 10);
            myPen = new Pen(Color.Black);
            x = -Math.PI;
            // function graph design loop
            while (x < Math.PI)
            {
                try   // if the function does not exist at any point 
                {
                    y = x * x; // Function formula!!!
                    xe = (int)(xc + m * x);
                    ye = (int)(yc - m * y);
                    G.DrawEllipse(myPen, xe, ye, 1, 1);
                }
                catch { }
                x += step;
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {


            
            {
                
                if (pictureBox1.Image != null)
                    pictureBox1.Image.Dispose();

                // Create a blank image to draw on
                Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
                Graphics g = Graphics.FromImage(bmp);

                double m = 30;
                int xc = pictureBox1.Width / 2;
                int yc = pictureBox1.Height / 2;
                double step = 0.01;

                Pen p = new Pen(Color.Purple, 2);

                for (double x = -Math.PI; x <= Math.PI; x += step)
                {
                    double y = Math.Sin(x);
                    int xe = (int)(xc + x * m);
                    int ye = (int)(yc - y * m);
                    g.DrawEllipse(p, xe, ye, 1, 1);
                }

                // Set the drawing to the PictureBox
                pictureBox1.Image = bmp;
            }
        }

        }
    }

