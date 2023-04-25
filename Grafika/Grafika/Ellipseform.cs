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
    public partial class Ellipseform : Form
    {
        int x, y;
        public Ellipseform()
        {
            InitializeComponent();
        }

        private void buttonDraw_Click(object sender, EventArgs e)
        {
            y = Convert.ToInt32(textBoxHeight.Text);
            x = Convert.ToInt32(textBoxWidth.Text);
            panel1.Refresh();
        }

        private void textBoxHeight_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Graphics kp = e.Graphics;
            
            kp.DrawEllipse(Pens.DarkGoldenrod, 0, 0, x, y);
        }
    }
}
