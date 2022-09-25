using Consoleproject1.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Consoleproject1.Interface
{
    class HumanResourceManager : IHumanResourceManagerService
    {

        private Department[] _departments;
        private Employee[] _employee;

        public HumanResourceManager()
        {
            _departments = new Department[0];
            _employee = new Employee[0];
        }

        public Department[] Departments => _departments;

        public Employee[] Employees => _employee;


        public void AddDepartment(string name, int workerlimit, double salarylimit)
        {
            Department department = new Department(name, workerlimit, salarylimit);
            Array.Resize(ref _departments, _departments.Length + 1);
            _departments[_departments.Length - 1] = department;
        }

        public void AddEmployee(string name, string position, double salary, string departmentname)
        {
            throw new NotImplementedException();
        }

        public Department EditDepartment(string oldname, string newname)
        {
            throw new NotImplementedException();
        }

        public Employee EditEmployee(string departmentname, int no, string fullname, double salary, string position)
        {
            throw new NotImplementedException();
        }

        public Department[] GetDepartments()
        {
            return _departments;
        }

        public void RemoveEmployee(int no, string departmentname)
        {
            throw new NotImplementedException();
        }
    }
}
