using Consoleproject1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
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

        public Employee AddEmployee(string name, string position, double salary, string departmentname)
        {
            Department department1=null;
            foreach (var department in _departments)
            {
                if (department.Name.ToLower() == departmentname.ToLower()) {
                    department1 = department;  
                }
            }
            if (department1 != null)
            {
                string no = new string(department1.Name.Take(2).ToArray());
                no = no + (1000 + department1.Employees.Length + 1);
                Employee employee = new Employee(no, name, position, salary, department1);

                Employee[] EMPS = department1.Employees;
                department1.Employees = (Employee[])department1.Employees.Concat(new Employee[] { employee }).ToArray();

                Array.Resize(ref _employee, _employee.Length + 1);
                _employee[_employee.Length - 1] = employee;
                return employee;
            }
            else {
                return null;
            }

        }

        public Department EditDepartment(string oldname, string newname)
        {
            foreach (var dp in _departments)
            {
                if (dp.Name.ToLower() == oldname.ToLower()) {
                    dp.Name = newname;
                    return dp;
                }
            }

            return null;
        }

        public Employee EditEmployee(string departmentname, int no, string fullname, double salary, string position)
        {
            throw new NotImplementedException();
        }

        public Employee[] GetDepartmentEmployees(string depName)
        {
            Department department1 = null;

            foreach (var department in _departments)
            {
                if (department.Name.ToLower() == depName.ToLower())
                {
                    department1 = department;
                }
            }
            if (department1 != null)
            {
                return department1.Employees;
            }
            else {
                return null;
            }
        }

        public Department[] GetDepartments()
        {
            return _departments;
        }

        public Employee[] GetEmployees()
        {
            return _employee;
        }

        public void RemoveEmployee(int no, string departmentname)
        {
            throw new NotImplementedException();
        }
    }
}
