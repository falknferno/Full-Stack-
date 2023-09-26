using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Sunday");
            comboBox1.Items.Add("Monday");
            comboBox1.Items.Add("Tuesday");
            comboBox1.Items.Add("Wednsday");
            //comboBox1.SelectedIndex = 1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //string selecteditem = comboBox1.SelectedItem.ToString();
            //MessageBox.Show(selecteditem);

            //int valueorder = comboBox1.SelectedIndex;  // command only selected items
            //MessageBox.Show(valueorder.ToString());  // gives a value to the item 0 or 1 (sorted false/true)
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //label1.Text = "combobox selected index was changed";
        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            //label2.Text = "combobox selected value changed";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DateTime birthday = dateTimePicker2.Value;
            label3.Text = birthday.AddYears(2).ToShortDateString();
            label4.Text = birthday.AddYears(-2).ToShortDateString();
            MessageBox.Show(birthday.ToString());

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            MessageBox.Show(dateTimePicker2.Value.ToShortDateString());
        }
    }
}
