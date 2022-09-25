using Consoleproject1.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Consoleproject1.Interface
{
    interface IHumanResourceManagerService
    {
        public Employee[] Employees { get; }
        public Department[] Departments { get; }
        public void AddDepartment(string name, int workerlimit, double salarylimit);
        public Department[] GetDepartments();
        public Employee[] GetEmployees();
        public Employee[] GetDepartmentEmployees(string depName);
        public Department EditDepartment(string oldname, string newname);
        public Employee AddEmployee(string name, string position, double salary, string departmentname);
        public void RemoveEmployee(string no, string departmentname);
        public Employee EditEmployee(string departmentname, int no, string fullname, double salary, string position);
    }
}
