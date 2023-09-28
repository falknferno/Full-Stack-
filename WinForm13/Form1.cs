using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<int> numberlist = new List<int>();
        List<string> textlist = new List<string>();
        List<Employee> employeelist = new List<Employee>();

        //void fillList()
        public List<Employee> fillList()
        {
            employeelist.Clear();
            Employee employee1 = new Employee();
            employee1.ID = 1;
            employee1.Name = "Charles";
            employee1.Surname = "Dickens";
            employeelist.Add(employee1);
            Employee employee2 = new Employee();
            employee2.ID = 2;
            employee2.Name = "George";
            employee2.Surname = "Lucas";
            employeelist.Add(employee2);
            Employee employee3 = new Employee();
            employee3.ID = 3;
            employee3.Name = "Jane";
            employee3.Surname = "Austen";
            employeelist.Add(employee3);
            return employeelist;
        }
        List<days>comboList = new List<days>();
        //{
            //numberlist.Add(1);
            //numberlist.Add(2);
            //numberlist.Add(3);
        //}
        private void Form1_Load(object sender, EventArgs e)
        {
            days day1 = new days();
            day1.ID = 1;
            day1.textvalue = "Sunday";
            comboList.Add(day1);
            days day2 = new days();
            day2.ID = 2;
            day2.textvalue = "Monday";
            comboList.Add(day2);
            days day3 = new days();
            day3.ID = 3;
            day3.textvalue = "Tuesday";
            comboList.Add(day3);
            days day4 = new days();
            day4.ID = 4;
            day4.textvalue = "Wednesday";
            comboList.Add(day4);
            days day5 = new days();
            day5.ID = 5;
            day5.textvalue = "Thursday";
            comboList.Add (day5);
            days day6 = new days();
            day6.ID = 6;
            day6.textvalue = "Friday";
            comboList.Add(day6);
            comboList.Add(new days() { ID = 7, textvalue = "Saturday" });
            cmbDays.DataSource = comboList;
            cmbDays.ValueMember = "ID";
            cmbDays.DisplayMember = "textvalue";
            daylist.DataSource = comboList;
          /*Employee employee1 = new Employee();
            employee1.ID = 1;
            employee1.Name = "Charles";
            employee1.Surname = "Dickens";
            employeelist.Add(employee1);
            Employee employee2 = new Employee();
            employee2.ID = 2;
            employee2.Name = "George";
            employee2.Surname = "Lucas";
            employeelist.Add(employee2);
            Employee employee3 = new Employee();
            employee3.ID = 3;
            employee3.Name = "Jane";
            employee3.Surname = "Austen";
            employeelist.Add(employee3());
          */
        }

        private void btnFillList_Click(object sender, EventArgs e)
        {
            //fillList();
            //foreach (var item in numberlist)
            //{
                //txtNumber.Text += item.ToString() + Environment.NewLine;
            //}
            //MessageBox.Show("List was filled");
            fillList();
            foreach (var item in employeelist)
            {
                txtNumber.Text += item.ID + " " + item.Name + " " + item.Surname + Environment.NewLine;
            }
        }

        private void cmbDays_SelectedIndexChanged(object sender, EventArgs e)
        {
            //MessageBox.Show(cmbDays.SelectedValue.ToString());  //to show datagrid
        }
    }
}
