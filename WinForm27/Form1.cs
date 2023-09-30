using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WinForm27
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            //if (!Directory.Exists("folder2"))
            {
                //Directory.CreateDirectory("folder2");
                //Directory.CreateDirectory("temp"); // creates a folder in bin debug folder, file explorer
                //DirectoryInfo dr = new DirectoryInfo("temp2"); // creates a new folder
                //DirectoryInfo dr = new DirectoryInfo(@"C:\temp2");
                //dr.Create();
                //MessageBox.Show("Folder was created");
                //DirectoryInfo dr = new DirectoryInfo("folder2");
                //string accesstime = dr.LastAccessTime.ToString();
                //MessageBox.Show(accesstime);
                DirectoryInfo dr = new DirectoryInfo("folder2");
                string accesstime = dr.CreationTime.ToString();
                MessageBox.Show(accesstime);
            }
        }

        private void btnMove_Click(object sender, EventArgs e)
        {
            Directory.Move("temp2", @"C:\newfolder\temp2");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Directory.Delete("temp");
        }
    }
}
