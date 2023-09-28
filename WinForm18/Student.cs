using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm18
{
    public class Student
    {
        public static int StudentNumber { get; set; }
        public static void getAddNote() // static method name
            //don't need a code to access getAddNote, but can add method 
        {
            MessageBox.Show("Static");
        }
    }
}
