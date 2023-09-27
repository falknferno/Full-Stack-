using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public void HideRadioButton()
        {
            groupBox1.Visible = false;
        }
        public void ClearAllText()
        {
            textBox1.Clear();
            textBox2.Clear();
        }
        public void FillTextBox(string text)
        {
            textBox2.Text = text;
        }
        public void SetNumber(int age)
        {
            label1.Text = "You are " + age.ToString() + " years old.";
        }
        string GetName()
        {
            string name = "Tony";
            return name;
        }
        int Sum(int x, int y)
        {
            int result = x + y;
            return result;
        }
        string ValueControl() // overloading
        {
            string text = "";
            return text;
        }
        string ValueControl(string name) 
        {
            string text = "";
            return text;
        }
        string ValueControl(string name,bool control) 
        {
            string text = "";
            return text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //HideRadioButton();
            //ClearAllText();
            //FillTextBox(textBox1.Text); // copies into the 2nd box
            //SetNumber(35);
            //string name = GetName();
            //MessageBox.Show(name);
            //int result = Sum(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text));
            //MessageBox.Show(result.ToString()); // adds both boxes
            string name = ValueControl("Tony",true); // executes 1st thru 3rd breakpoints
            MessageBox.Show(name); // able to remove all 3 breakpoints, but adding one just above for name
        }
    }
}
