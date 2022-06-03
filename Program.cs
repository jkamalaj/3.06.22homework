


using System;
namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Department department1 = new Department()
            {
                Employeelimit = 34,
                Salarylimit=2000,

            };
            Employee employee1 = new Employee()
            {
                Name = "Semed",
                Surname = "Jamalova",
                Salary=1780,

            };
            Employee employee2 = new Employee()
            {
                Name = "Nargiz",
                Surname = "Amirova",
                Salary = 2200,
            };

            department1.AddEmployee(employee1);
            department1.AddEmployee(employee2);

            Console.WriteLine($"{department1.Name}{department1.Surname}");
            foreach(var item in department1.Employees)
            {
                Console.WriteLine(item.Name);
            }
        }
    }
}
