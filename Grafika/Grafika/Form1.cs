using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grafika
{
    public partial class Form1 : Form
    {
        Graphics g;

        public Form1()
        {
            InitializeComponent();

            g = panel1.CreateGraphics();
        }

        private void buttonEllipseForm_Click(object sender, EventArgs e)
        {
            Ellipseform ellipseForm = new Ellipseform();
            ellipseForm.Show();

        }

        private void buttonColor_Click(object sender, EventArgs e)
        {
            DrawinForm draw = new DrawinForm();
            draw.Show();
        }

        private void buttonZapsani_Click(object sender, EventArgs e)
        {
            TextToFile textToFile = new TextToFile();
            textToFile.Show();
        }

        private void buttonObrazec_Click(object sender, EventArgs e)
        {
            Obrazce obrazce = new Obrazce();
            obrazce.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Random rnd = new Random();

            Shape shape = (Shape)rnd.Next(0, 4);

            Color color = Color.FromArgb(rnd.Next(0, 250), rnd.Next(0, 250), rnd.Next(0, 250));

            Pen mypen = new Pen(color);
            Brush mybrush = new SolidBrush(color);


            g.DrawEllipse(mypen, rnd.Next(0, 500), rnd.Next(0, 400), rnd.Next(50, 100), rnd.Next(50, 100));
            switch (shape)
            {
                case Shape.Ellipse:
                    if (rnd.Next(0, 2) == 0)
                    {
                        g.DrawEllipse(mypen, rnd.Next(0, 500), rnd.Next(0, 400), rnd.Next(50, 100), rnd.Next(50, 100));
                        break;
                    }
                    else
                    {
                        g.FillEllipse(mybrush, rnd.Next(0, 500), rnd.Next(0, 400), rnd.Next(50, 100), rnd.Next(50, 100));
                        break;
                    }
                case Shape.Rectangle:
                    if (rnd.Next(0, 2) == 0)
                    {
                        g.DrawRectangle(mypen, rnd.Next(0, 500), rnd.Next(0, 400), rnd.Next(50, 100), rnd.Next(50, 100));
                        break;
                    }
                    else
                    {
                        g.FillRectangle(mybrush, rnd.Next(0, 500), rnd.Next(0, 400), rnd.Next(50, 100), rnd.Next(50, 100));
                        break;
                    }
                case Shape.Line:
                    int x = rnd.Next(0, 500);
                    int y = rnd.Next(0, 400);
                        g.DrawLine(mypen, x, y, rnd.Next(x - 100, x + 300), rnd.Next(y - 100, y + 300));
                        break;

                case Shape.String:
                    Font font = new Font("Arial", rnd.Next(1,100));
                    g.DrawString("yeet", font, mybrush, rnd.Next(0, 500), rnd.Next(0, 400));
                    break;
                default:
                    break;
            }
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void elipsaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ellipseform ellipseForm = new Ellipseform();
            ellipseForm.Show();
        }

        private void kreslitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DrawinForm draw = new DrawinForm();
            draw.Show();
        }

        private void souborToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TextToFile textToFile = new TextToFile();
            textToFile.Show();
        }
    }

    enum Shape
    {
        Ellipse,
        Rectangle,
        Line,
        String
    }
}
