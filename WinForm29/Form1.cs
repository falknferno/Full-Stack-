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

namespace WinForm29
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            string ourfile = @"C:\newfolder\temp\landscape.jpeg";
            textBox1.Text += Path.GetDirectoryName(ourfile)+Environment.NewLine;
            //string directorypath = Path.GetDirectoryName(ourfile);
            //textBox1.Text = directorypath;   // adds text file after clicking Show
            textBox1.Text += Path.GetExtension(ourfile) + Environment.NewLine;
            textBox1.Text += Path.GetFileName(ourfile) + Environment.NewLine;
            textBox1.Text += Path.GetFileNameWithoutExtension(ourfile) + Environment.NewLine;
            textBox1.Text += Path.GetPathRoot(ourfile)+ Environment.NewLine;
            textBox1.Text += Path.GetFullPath(ourfile) + Environment.NewLine;
        }
    }
}
