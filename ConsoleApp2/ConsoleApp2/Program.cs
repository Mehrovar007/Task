using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
        {
            
            {
                Console.Write("Барои имтиҳон баллро ворид кунед (0-100): ");
                double score = Convert.ToDouble(Console.ReadLine());

                if (score >= 90 && score <= 100)
                {
                    Console.WriteLine("Натиҷа: Аъло");
                }
                else if (score >= 75 && score < 90)
                {
                    Console.WriteLine("Натиҷа: Хуб");
                }
                else if (score >= 55 && score < 75)
                {
                    Console.WriteLine("Натиҷа: Қаноатбахш");
                }
                else if (score >= 0 && score < 55)
                {
                    Console.WriteLine("Натиҷа: Ноком");
                }
                else
                {
                    Console.WriteLine("Хатогӣ: Балли нодуруст ворид карда шуд!");
                }
            }
        }
    }
    }
}
