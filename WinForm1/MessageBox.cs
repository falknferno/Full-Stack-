using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //string messagetext = "Simple message text";
            //MessageBox.Show(messagetext); 

            //MessageBox.Show("Simple message text");

            //string message = "Simple message text";
            //string messagetitle = "message title";
            //MessageBox.Show(message, messagetitle);

            //string message = "Do you want to close window?";
            //string messagetitle = "Close window";
            //MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            //DialogResult result = MessageBox.Show(message, messagetitle, buttons);
            //if (result == DialogResult.Yes)
            {
                //this.Close();
            }
            //else if (result == DialogResult.No)
            {
                // do nothing
            }

            string message = "Did you see Icon?";
            string title = "OK";
            MessageBox.Show(message, title, MessageBoxButtons.YesNo, MessageBoxIcon.Information);
           
        }
    }
}
