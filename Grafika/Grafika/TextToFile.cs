using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grafika
{
    public partial class TextToFile : Form
    { 
        
    
        public TextToFile()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) // Name
        {
            StreamReader sr = new StreamReader(textBoxFile.Text + ".txt");
            StringBuilder sb = new StringBuilder();
            string line = "";
            while ((line = sr.ReadLine()) != null) 
                sb.Append(line); 
            sr.Close();

            StreamWriter sw = new StreamWriter(textBoxFile.Text + ".txt");
            sw.Write (sb.ToString() + textBoxName.Text + " ");
            sw.Close();
            
        }

        private void button2_Click(object sender, EventArgs e) //Content
        { 
            StreamReader sr = new StreamReader(textBoxFile.Text + ".txt");
            textBoxContent.Text = sr.ReadToEnd();
            sr.Close();
        }

        private void button3_Click(object sender, EventArgs e) //Delete
        {
            StreamWriter sw = new StreamWriter(textBoxFile.Text + ".txt");
            sw.Write("");
            sw.Close();
        }

        private void textBoxFile_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
