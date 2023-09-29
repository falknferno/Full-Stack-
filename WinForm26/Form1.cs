using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm26
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            try
            {
                int resutl = Convert.ToInt32(txtFirst.Text) / Convert.ToInt32(txtSecond.Text);
            }
            catch (DivideByZeroException ex)
            {

                //MessageBox.Show(ex.ToString());
                throw new Exception("You can not divide any number by zero");
            }
            catch (Exception ex)
            {

                //MessageBox.Show(ex.ToString());
                throw new Exception("Please use only numbers");
            }
            finally
            {
                MessageBox.Show("Program was finished");
            }
            
        }
    }
}
