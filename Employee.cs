using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1.Class
{
    internal class Employee:Department
    {
        private string _name;
        private string _surname;
        private int _salary;
        public Employee[] employees = new Employee[0];
        public string Name 
        {
            get
            {
                return _name;
            }
            set
            {
                for (int i = 0; i < value.Length; i++)
                    if (!string.IsNullOrEmpty(value) && Char.IsUpper(value[0]))

                           _name = value;
            }
        }
        public string Surname
        {
            get
            {
                return _surname;
            }
            set
            {
                for (int i = 0; i < value.Length; i++)
                    if (!string.IsNullOrEmpty(value) && Char.IsUpper(value[i]))
                        _surname = value;
            }
        }
        public int Salary
        {
            get
            {
                return _salary;
            }
            set
            {
                if (value > 250)
                    _salary = value;
            }
        }

        public void AddEmployee(Employee employee)
        {
            if(Employees.Length < Employeelimit)
            {
                Array.Resize(ref employees , Employees.Length + 1);
                employees[Employees.Length - 1] = employee;
            }
        }

    }
}
