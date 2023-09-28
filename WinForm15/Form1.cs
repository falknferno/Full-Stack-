using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm15
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //MessageBox.Show("timer value"); // this pops up until you stop debug
            progressBar1.Value = counter; // has max value off 100
            //counter++;
            counter--;  //count down timer, will crash when timer goes below 0, will need to control it
            label1.Text = counter.ToString();
            if (counter == 0)
            {
                timer1.Stop();
                MessageBox.Show("timer stopped");
            }
            if (counter % 2 == 1)
                button3.BackColor = Color.Red;
            else
                button3.BackColor = Color.White;
        }
        //int counter = 0;
        int counter = 60;
        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = 60.ToString();
        }
    }
}
