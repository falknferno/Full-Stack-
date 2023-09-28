using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm12
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public Employee personnelDetail = new Employee();
        private void Form2_Load(object sender, EventArgs e)
        {
            textBox1.Text = personnelDetail.EmployeeID.ToString();
            textBox2.Text = personnelDetail.Name;
            textBox3.Text = personnelDetail.Age.ToString();
        }
    }
}
