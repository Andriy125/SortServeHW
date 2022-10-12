using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_Classes
{
    internal class Factory
    {
        public string Name { get; set; }
        public Employees[] Employee;
        public Product[] Products;

        public void createmas(int count)
        {
            Employee = new Employees[count];
        }

        public void createmas_product(int count)
        {
            Products = new Product[count];
        }
        decimal AvgSalary
        {
            get 
            { 
                decimal sum = 0;
                for (int i = 0; i < Employee.Length; i++)
                {
                    sum += Employee[i].Salary;
                }
                decimal result = sum / Employee.Length;
                return result;
            }
        }

        decimal TotalSalary
        {
            get
            {
                decimal sum = 0;
                for (int i = 0; i < Employee.Length; i++)
                {
                    sum += Employee[i].Salary;
                }

                return sum;
            }
        }

        decimal GDP
        {
            get
            {
                decimal sum = 0;
                for (int i = 0; i < Products.Length; i++)
                {
                    sum += Products[i].Price;
                }

                decimal result = sum / Products.Length;
                return result;
            }
        }

        decimal EmpCount => Employee.Length;

        public override string ToString()
        {
            string facrory_info = "\nName: " + Name + "AvgSalary: " + AvgSalary + "\nTotalSalary: " + TotalSalary + "\nGDP: " + "EmpCount: " + EmpCount;
            return facrory_info;
        }
    }
}
