using System;
using System.Collections.Generic;
using System.Text;

namespace Consoleproject1.Models
{
    class Employee
    {
   

        public Employee(string no, string name, string position, double salary, Department department)
        {
            No = no;
            FullName = name;
            Position = position;
            Salary = salary;
            Department = department;
        }

        public string No { get; set; }  
        public string FullName { get; set; }
        public string Position { get; set; }
        public double Salary { get; set; }
        public Department Department { get; set; }

    }

   
}
    

