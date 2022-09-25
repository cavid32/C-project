using Consoleproject1.Interface;
using Consoleproject1.Models;
using System;

namespace Consoleproject1
{
    class Program
    {
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
                    Console.WriteLine("Dwzgun daxol edt0");
                    chooseStr = Console.ReadLine();
                }

                switch (chooseNumber)
                {
                    case 1:
                        Department[] departmets = managerService.GetDepartments();
                        foreach (var department in departmets)
                        {
                            Console.WriteLine($"Name-{department.Name} Work limit - {department.WorkerLimit} Salary - {department.SalaryLimit}");
                        }
                        break;

                    case 2:
                        managerService.AddDepartment("HR", 5, 500.4);
                        break;
                    default:
                        break;

                }

            }
            while (true);


        }
    }
}
