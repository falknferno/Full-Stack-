using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Teacher : Employee
    {
        public string Branch {  get; set; }
        public void FindSalary()
        {
            Salary = 2500;
        }
        public void Setvalues2()
        {
            Position = "Teacher";
            Branch = "Math";
        }
    }
}
