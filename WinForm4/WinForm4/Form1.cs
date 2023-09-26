using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm4
{
    public partial class frmGetData : Form
    {
        public frmGetData()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //frmShowData frmShow = new frmShowData(); // shows both forms after clicking button
            //frmShow.Show();
            // frmShow = new frmShowData();
            //frmShow.ShowDialog();  //  doesn't allow access the other form

            // combines both boxes after clicking button ie., names
            string Name = txtName.Text;
            string surname = txtSurname.Text;
            string NameSurname = Name + surname;
            frmShowData frmShow = new frmShowData();
            frmShow.lblNameSurname.Text = NameSurname;
            frmShow.Show();
        }
    }
}
