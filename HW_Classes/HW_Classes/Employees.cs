using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_Classes
{
    internal class Employees
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime BirthDate { get; set; }
        public decimal Salary { get; set; }

        public Employees() { }

        public Employees (string name, string surname, DateTime birthDate, decimal salary)
        {
            this.Name = name;
            this.Surname = surname;
            this.BirthDate = birthDate;
            this.Salary = salary;
        }
    }
}
