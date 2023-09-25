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
    public partial class Buttons : Form
    {
        public Buttons()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //firstbutton.Text = "Changed";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //string labeltext = textBox1.Text;
            //label1.Text = labeltext;
        }

        private void firstbutton_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Hello");
            //firstbutton.Text = "Clicked";
        }

        private void firstbutton_KeyPress(object sender, KeyPressEventArgs e)
        {
            //firstbutton.Text = "Enter";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //label1.Text = "first label";
            //label1.BackColor = Color.Blue;
            //label1.ForeColor = Color.White;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            //radioButton1.Checked = true;
            //radioButton1.Checked = false;
            //bool control = radioButton1.Checked;

            //MessageBox.Show("checked changed");
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            //checkBox1.Checked = true;
            //checkBox1.Checked = false;
            //bool control = checkBox1.Checked;

            //MessageBox.Show("checked changed");  // both events work
            //MessageBox.Show("checked state change");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Sunday");
            comboBox1.Items.Add("Monday");
            comboBox1.Items.Add("Tuesday");
            comboBox1.Items.Add("Wednsday");
            comboBox1.SelectedIndex = 2;
        }
    }
}
