using Consoleproject1.Interface;
using Consoleproject1.Models;
using System;

namespace Consoleproject1
{
    class Program
    {
        private static object Name;
        private static object position;
        private static object salary;
        private static object departmentname;

        static void Main(string[] args)
        {
            IHumanResourceManagerService managerService = new HumanResourceManager();
            do
            {
                Console.WriteLine("1.Departmentlerin siyahisini gostermek" +
                    "\n2.Department yaratmaq" +
                    "\n3.Departamentde deyisiklik etmek" +
                    "\n4.Iscilerin siyahisini gostermek" +
                    "\n5.Departamentdeki iscilerin siyahisini gostermrek" +
                    "\n6.Isci elave etmek" +
                    "\n7.Isci uzerinde deyisiklik etmek" +
                    "\n8.Departamentden isci silinmesi\n" +
                    "\n0.Programdan çıx");
                Console.WriteLine("Zehmet olmasa secimlerden birini secin");
                string chooseStr = Console.ReadLine();
                int chooseNumber;
                while (!int.TryParse(chooseStr, out chooseNumber) || chooseNumber > 9 || chooseNumber < 0)
                {
                    Console.WriteLine("Duzgun daxil edt");
                    chooseStr = Console.ReadLine();
                }

                switch (chooseNumber)
                {
                    case 1:
                        Department[] departmets = managerService.GetDepartments();
                        foreach (var department in departmets)
                        {
                            Console.WriteLine($"Name-{department.Name}\nWork limit - {department.WorkerLimit} \nSalary - {department.SalaryLimit}");
                            Console.WriteLine($"---------------------------------------------------------");
                        }
                        break;

                    case 2:

                        Console.WriteLine("Departamentin adini daxil edin");
                        string departmentname1 = Console.ReadLine();
                        while (departmentname1.Length < 2)
                        {
                            Console.WriteLine("department adi minimum 2 herfden ibaret olmalidir");
                            departmentname1 = Console.ReadLine();

                        }


                        Console.WriteLine("Worklimit daxil edin");
                        string departmentworkerlimitStr = Console.ReadLine();
                        int departmentworkerlimitNum;
                        while (!int.TryParse(departmentworkerlimitStr, out departmentworkerlimitNum) || departmentworkerlimitNum < 1)
                        {
                            Console.WriteLine("Worklimit 1 den kicik ola bilmez");
                            departmentworkerlimitStr = Console.ReadLine();

                        };


                        Console.WriteLine("Salarylimit daxil edin");
                        string Salarylimitstr = Console.ReadLine();
                        double salarylimitdouble;
                        while (!double.TryParse(Salarylimitstr, out salarylimitdouble) || salarylimitdouble < 250)
                        {
                            Console.WriteLine("Salarylimit min 250 olmalidir");
                            Salarylimitstr = Console.ReadLine();

                        };
                        

                        managerService.AddDepartment(departmentname1, departmentworkerlimitNum, salarylimitdouble);
                        Console.WriteLine("Department yaradildi");
                        break;

                    case 3:

                        Console.WriteLine("deyismek isdedyiniz departamentin adini daxil edin");
                        string oldname = Console.ReadLine();
                        while (oldname.Length < 2)
                        {
                            Console.WriteLine("department adi minimum 2 herfden ibaret olmalidir");
                            oldname = Console.ReadLine();

                        }
                        Console.WriteLine("Yeni Department adi daxil edin");
                            string newname = Console.ReadLine();
                        while (newname.Length < 2)
                        {
                            Console.WriteLine("department adi minimum 2 herfden ibaret olmalidir");
                            newname = Console.ReadLine();

                        }
                       Department FindDep=managerService.EditDepartment(oldname, newname);
                        if(FindDep==null)
                        {
                            Console.WriteLine("Bu adda department yoxdur");
                        }
                        else
                        {
                            Console.WriteLine("Ad ugurla deyisildi");

                        }

                        
                        break;

                    case 4:
                        
                        Employee[] emps =  managerService.GetEmployees();
                        foreach (var emp in emps)
                        {
                            Console.WriteLine($"No-{emp.No}\nName-{emp.FullName}\nPosition - {emp.Position} \nSalary - {emp.Salary}\nDepartment name - {emp.Department.Name}");
                            Console.WriteLine($"---------------------------------------------------------");
                        }
                        break;
                    case 5:
                        Console.WriteLine("departmentin adini daxil edin");
                        string departmentname = Console.ReadLine();
                        while (departmentname.Length < 2)
                        {
                            Console.WriteLine("minimum 2 herf olmalidir");
                            departmentname = Console.ReadLine();

                        }
                       Employee[] employees= managerService.GetDepartmentEmployees(departmentname);
                        if (employees == null)
                        {
                            Console.WriteLine("Bu department movcud deyil!!");
                        }
                        else {

                            foreach (var emp in employees)
                            {
                                Console.WriteLine($"No-{emp.No}\nName-{emp.FullName}\nPosition - {emp.Position} \nSalary - {emp.Salary}\nDepartment name - {emp.Department.Name}");
                                Console.WriteLine($"---------------------------------------------------------");
                            }
                        }
                        break;
                    case 6:
                        Console.WriteLine("Iscinin adini ve soyadini daxil edin");
                        string employeename = Console.ReadLine();
                        while (employeename.Length < 2)
                        {
                            Console.WriteLine("Iscinin adi ve soyadi minimum 2 herfden ibaret olmalidir");
                            employeename = Console.ReadLine();

                        }

                        Console.WriteLine("Iscinin vezifesini daxil edin");
                        string position = Console.ReadLine();
                        while (position.Length < 2)
                        {
                            Console.WriteLine("Iscinin vezifesi minimum 2 herfden ibaret olmalidir");
                            position = Console.ReadLine();

                        }

                        Console.WriteLine("Iscinin maasini daxil edin");
                        string salary = Console.ReadLine();
                        double salarynum;
                        while (!double.TryParse(salary, out salarynum) || salarynum < 250)
                        {
                            Console.WriteLine("Salary min 250 olmalidir");
                            salary = Console.ReadLine();

                        };

                        Console.WriteLine("departmentin adini  daxil edin");
                        string depname = Console.ReadLine();
                        while (depname.Length < 2)
                        {
                            Console.WriteLine("departmentin adi minimum 2 herfden ibaret olmalidir");
                            depname = Console.ReadLine();

                        }
                        Employee AddEmp = managerService.AddEmployee(employeename, position, salarynum, depname);
                        if (AddEmp == null)
                        {

                            Console.WriteLine("Deparment adini duzgun daxil edin!!");
                        }
                        else {
                            Console.WriteLine("Ugurla Elave Olundu!!");
                        }

                        break;

                    case 7:
                        //managerService.EditEmployee();
                        break;
                    case 8:
                        Console.WriteLine("Departmentin adini daxil edin");
                        string depName = Console.ReadLine();
                        while (depName.Length < 2)
                        {
                            Console.WriteLine("minimum 2 herf olmalidir");
                            depName = Console.ReadLine();
                        }
                        Console.WriteLine("Iscinin nomresin daxil edin");
                        string no = Console.ReadLine();
                        while (no.Length < 6)
                        {
                            Console.WriteLine("Iscinin nomresi minimum 6 sinvoldan ibaret olmalidir");
                            no = Console.ReadLine();
                        }
                        managerService.RemoveEmployee(no, depName);

                        break;
                    default:

                        break;

                }

                }
            while (true);


        }
    }
}
