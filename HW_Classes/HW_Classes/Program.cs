using System;
using System.Drawing;

namespace HW_Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Factory factory = new Factory();

            Console.WriteLine("Enter name of factory: ");
            factory.Name = Console.ReadLine();

            Console.WriteLine("Enter count of employers: ");
            int counter = int.Parse(Console.ReadLine());
            //factory.Employee = new Employees[counter];
            factory.createmas(counter);
            //factory.Employee[] mas= new Employees[counter];

            for (int i = 0; i < counter; i++)
            {
                factory.Employee[i] = new Employees();
                Console.WriteLine("Enter Employee name: ");
                factory.Employee[i].Name = Console.ReadLine();

                Console.WriteLine("Enter Employee surname: ");
                factory.Employee[i].Surname = Console.ReadLine();

                Console.WriteLine("Enter Employee birthdate: ");
                factory.Employee[i].BirthDate = DateTime.Parse(Console.ReadLine());

                Console.WriteLine("Enter Employee salary: ");
                factory.Employee[i].Salary = decimal.Parse(Console.ReadLine());
            }

            Console.WriteLine("Enter data for employee end");


            Console.WriteLine("Enter count of products: ");
            counter = int.Parse(Console.ReadLine());
            factory.createmas_product(counter);

            for (int i = 0; i < counter; i++)
            {
                factory.Products[i] = new Product();

                Console.WriteLine("Enter product name: ");
                factory.Products[i].Name = Console.ReadLine();

                Console.WriteLine("Enter price: ");
                factory.Products[i].Price = decimal.Parse(Console.ReadLine());
            }

            Console.WriteLine("Enter data about product end");


        }
    }
}
