using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
        {
           
            {
                Console.Write("Баҳои худро ворид кунед (2, 3, 4, 5): ");
                int grade = Convert.ToInt32(Console.ReadLine());

                switch (grade)
                {
                    case 5:
                        Console.WriteLine("Натиҷа: Аъло");
                        break;
                    case 4:
                        Console.WriteLine("Натиҷа: Хуб");
                        break;
                    case 3:
                        Console.WriteLine("Натиҷа: Қаноатбахш");
                        break;
                    case 2:
                        Console.WriteLine("Натиҷа: Ноком");
                        break;
                    default:
                        Console.WriteLine("Хатогӣ: Чунин баҳо вуҷуд надорад!");
                        break;
                }
            }
        }
    }
    }
}
