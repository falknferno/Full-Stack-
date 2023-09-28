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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Employee personnelDetail = new Employee();
        private void btnSetValue_Click(object sender, EventArgs e)
        {
            
            personnelDetail.EmployeeID = Convert.ToInt32(txtEmployeeID.Text);
            personnelDetail.Name = txtName.Text;
            personnelDetail.Age = Convert.ToInt32(txtAge.Text);
            MessageBox.Show("All Data Received");
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            personnelDetail.EmployeeID = Convert.ToInt32(txtEmployeeID.Text);
            personnelDetail.Name = txtName.Text;
            personnelDetail.Age = Convert.ToInt32(txtAge.Text);
            Form2 frm = new Form2();
            frm.personnelDetail = personnelDetail;
            frm.ShowDialog();
        }
    }
}
