using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            firstbutton.Text = "Changed";
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void firstbutton_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Hello");
            //firstbutton.Text = "Clicked";
        }

        private void firstbutton_KeyPress(object sender, KeyPressEventArgs e)
        {
            firstbutton.Text = "Enter";
        }
    }
}
