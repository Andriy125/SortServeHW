using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            while (true)
            {
                Console.Clear();
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

                        Console.WriteLine("Push enter to go start menu");
                        Console.ReadLine();
                        break;
                    // ------- end task 1 -------


                    case 2:
                        // Task 2
                        string number;
                        int lenght_number = 0;
                        do
                        {
                            Console.Clear();
                            Console.WriteLine("Enter a six-digit number");
                            number = Console.ReadLine();
                            lenght_number = number.ToString().Length;
                            if (lenght_number < 6) Console.WriteLine("you didn't enter six digits"); 
                        }
                        while (lenght_number < 6);

                        int index = 0, sum_1 = 0, sum_2 = 0;

                        foreach (var item in number)
                        {
                            int converted_numb = Convert.ToInt32(item.ToString());
                            if (index < 3) sum_1 += converted_numb;
                            else sum_2 += converted_numb;
                            index++;
                        }
                        if (sum_1 == sum_2) Console.WriteLine("You have a lucky ticket");
                        else Console.WriteLine("You don't have a lucky ticket");

                        Console.WriteLine("Push enter to go start menu");
                        Console.ReadLine();

                        break;
                    // ------- end task 2 -------


                    case 3:
                        // Task 3
                        Console.Clear();
                        Console.WriteLine("Please enter two number A and B. Keep in mind (A < B)");
                        Console.Write("Enter nubmer A: ");
                        int A = int.Parse(Console.ReadLine());

                        Console.Write("Enter nubmer B: ");
                        int B = int.Parse(Console.ReadLine());

                        if ( (A < 0) || (B < 0) ) Console.WriteLine("You entered a negative number, please enter a number greater than 0");
                        else if (A > B) Console.WriteLine("A > B, try again");
                        
                        Console.WriteLine();

                        while (A <= B)
                        {
                            for (int i = 0; i < A; i++) Console.Write($"{A} ");
                            Console.WriteLine();
                            A++;
                        }

                        Console.WriteLine("\nPush enter to go start menu");
                        Console.ReadLine();
                        break;
                    // ------- end task 3 -------

                    case 4:
                        // Task 4
                        Console.Clear();
                        Console.WriteLine("Please enter integer number that is greater than 0");
                        string enter_text = Console.ReadLine();
                        int enter_int_text = int.Parse(enter_text);

                        if (enter_int_text < 0) Console.WriteLine("You entered a number less than 0, try again");
                        else
                        {
                            char[] char_array = enter_text.ToCharArray();
                            int i = char_array.Length;

                            Console.Write("Reverse number: ");
                            while (i > 0)
                            {
                                i--;
                                Console.Write(char_array[i]);
                            }
                        }

                        Console.WriteLine("\nPush enter to go start menu");
                        Console.ReadLine();

                        break;
                    // ------- end task 4 -------
                    
                    case 5:
                        // Task 5
                        Console.Clear();
                        Console.WriteLine("Enter the interest rate of P%. Keep in mind (0 < P < 25)");
                        double P = Double.Parse(Console.ReadLine());
                        if ((0.0 > P) || (P > 25.0)) Console.WriteLine("You input incorect interest rate of P, try again");
                        else
                        {
                            double S = 10000.0;
                            double monthly_profit = 0;
                            int number_of_months_K = 0;

                            while (S < 11000.0)
                            {
                                monthly_profit = (S / 100) * P;
                                S += monthly_profit;
                                number_of_months_K++;
                            }
                            Console.WriteLine($"number_of_months : {number_of_months_K}, profit: {S}");
                        }
                        Console.WriteLine("Push enter to go start menu");
                        Console.ReadLine();
                        break;
                    // ------- end task 5 -------


                }

            }
    }
    }
}
