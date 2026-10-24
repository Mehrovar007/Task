using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
         
        {
            
            {
                Console.Write("Адади аввалро ворид кунед: ");
                double num1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Амалиётро ворид кунед (+, -, *, /, %): ");
                string action = Console.ReadLine();

                Console.Write("Адади дуюмро ворид кунед: ");
                double num2 = Convert.ToDouble(Console.ReadLine());

                double result = 0;

                if (action == "+")
                {
                    result = num1 + num2;
                    Console.WriteLine("Натиҷа: " + result);
                }
                else if (action == "-")
                {
                    result = num1 - num2;
                    Console.WriteLine("Натиҷа: " + result);
                }
                else if (action == "*")
                {
                    result = num1 * num2;
                    Console.WriteLine("Натиҷа: " + result);
                }
                else if (action == "/")
                {
                    if (num2 == 0)
                    {
                        Console.WriteLine("Хатогӣ: Тақсим ба сифр мумкин нест!");
                    }
                    else
                    {
                        result = num1 / num2;
                        Console.WriteLine("Натиҷа: " + result);
                    }
                }
                else if (action == "%")
                {
                    if (num2 == 0)
                    {
                        Console.WriteLine("Хатогӣ: Ёфтани бақия ҳангоми тақсим ба сифр мумкин нест!");
                    }
                    else
                    {
                        result = num1 % num2;
                        Console.WriteLine("Натиҷа: " + result);
                    }
                }
                else
                {
                    Console.WriteLine("Хатогӣ: Амалиёти нодуруст ворид карда шуд!");
                }
            }
        }
    }
    }
}
