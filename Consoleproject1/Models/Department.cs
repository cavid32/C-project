using System;
using System.Collections.Generic;
using System.Text;

namespace Consoleproject1.Models
{
    class Department
    {
        public Department(string name, int workerlimit, double salarylimit)
        {
            Name = name;
            WorkerLimit = workerlimit;
            SalaryLimit = salarylimit;
        }

        public string Name { get; set; }
        public int WorkerLimit { get; set; }
        public double SalaryLimit { get; set; }
        public Employee[] Employees { get; set; }

        public double CalcSalaryAverage()
        {
            double SalarySum = 0;

            for (int i = 0; i < Employees.Length; i++)
            {
                double salary = Employees[i].Salary;

                SalarySum += salary;

            }

            double AverageSalary = SalarySum / Employees.Length;

            return AverageSalary;
        }


    }
}
