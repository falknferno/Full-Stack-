﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WinForm28
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            //File.Create("firstfile.txt");
            if(!File.Exists("secondfile.txt"))
            {
                //FileInfo ourfile = new FileInfo("firstfile.txt");//already made file, now to ctrl with exist
                FileInfo ourfile = new FileInfo("secondfile.txt");
                ourfile.Create();
            }
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            File.Delete("firstfile.txt");
        }

        private void btnWrite_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream("third.txt", FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);
            sw.WriteLine("This is First Line");
            sw.WriteLine("This is Second Line");
            sw.Flush();
            sw.Close();
            sw.Close();
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream("third.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            string text = "";
            while (!sr.EndOfStream)
            {
                text += sr.ReadLine() + Environment.NewLine;
            }
            sr.Close();
            fs.Close();
            textBox1.Text = text;
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            File.Copy("secondfile.txt", @"C:\temp\secondfile.txt");
        }

        private void btnProperty_Click(object sender, EventArgs e)
        {
            FileInfo ourfile = new FileInfo("secondfile.txt");
            //string name = ourfile.Name;
            //string name = ourfile.FullName;
            string name = ourfile.LastAccessTime.ToString();
            MessageBox.Show(name);
        }
    }
}
