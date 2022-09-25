using System;
using System.Collections.Generic;
using System.Text;

namespace Consoleproject1.Models
{
    class Employee
    {
        public Employee(int no, string fullName,string position,double salary)
        {
            No = no;
            FullName = fullName;
            Position = position;
            Salary = salary;

        }
        public int No { get; set; }
        public string FullName { get; set; }
        public string Position { get; set; }
        public double Salary { get; set; }
        public Department Department { get; set; }

    }

   
}
    

