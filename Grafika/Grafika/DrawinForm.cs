using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grafika
{
    public partial class DrawinForm : Form
    {
        private Color selectColor;
        private List<PointWithColor> points = new List<PointWithColor>();

        public DrawinForm()
        {
            InitializeComponent();
            //DOUBLEBUFFER
            typeof(Panel).InvokeMember("DoubleBuffered", BindingFlags.SetProperty| BindingFlags.Instance | BindingFlags.NonPublic, null, panel1, new object[] { true });
        }

        private void buttonColor_Click(object sender, EventArgs e)
        {
           DialogResult result = colorDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                selectColor = colorDialog1.Color;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            

            for (int i = 1; i < points.Count; i++)
            {
                Pen myPen = new Pen(points[i].color);
                g.DrawLine(myPen, points[i-1].point, points[i].point);
            }
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                PointWithColor pwc = new PointWithColor();
                pwc.point = e.Location;
                pwc.color = selectColor;

                Point p = e.Location;
                points.Add(pwc);
                panel1.Refresh();
            }
        }
    }
}
