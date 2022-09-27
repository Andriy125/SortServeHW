using System;
using System.Linq;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            while (true)
            {
                Console.WriteLine("Enter number of task from 1 to 5:");
                int task_number = int.Parse(Console.ReadLine());

                switch (task_number)
                {
                    case 1:
                        // Task 1
                        string text = "";
                        char a;
                        int amount_of_space = 0;

                        do
                        {
                            a = Console.ReadKey().KeyChar;
                            text += a;
                            if (a == ' ') amount_of_space++;
                        }
                        while (a != '.');
                        Console.Clear();
                        Console.WriteLine($"You enter: {text}");
                        Console.WriteLine($"amount of space in text = {amount_of_space}");
                        break;

                    case 2:
                        //int leght_number = 0;
                        do
                        {
                            Console.WriteLine("Enter a six-digit number");
                            int number = int.Parse(Console.ReadLine());
                            //if (Math.Abs(number).ToString().Length < 6)
                            if (number < 1000000)
                            {
                                continue;
                            }
                        }
                        while (number < 1000000);
                        //Console.WriteLine("Enter a six-digit number");
                        //int number = int.Parse(Console.ReadLine());


                        break;


                }

            }
    }
    }
}
