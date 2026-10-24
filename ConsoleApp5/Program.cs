using System;

class Program
{
    static void Main()
    {
        int[] bahoho = new int[20];
        Console.WriteLine("Баҳои 20 донишҷӯро ворид кунед:");

        for (int i = 0; i < 20; i++)
        {
            Console.Write($"Донишҷӯи {i + 1}: ");
            bahoho[i] = Convert.ToInt32(Console.ReadLine());
        }

        int jamiBahoho = 0;
        int balandtarin = bahoho[0];
        int pasttarin = bahoho[0];
        int guzashta = 0;
        int naguzashta = 0;

        for (int i = 0; i < 20; i++)
        {
            int b = bahoho[i];
            jamiBahoho += b;

            if (b > balandtarin)
            {
                balandtarin = b;
            }

            if (b < pasttarin)
            {
                pasttarin = b;
            }

            if (b >= 50)
            {
                guzashta++;
            }
            else
            {
                naguzashta++;
            }
        }

        double miyona = (double)jamiBahoho / 20;

        Console.WriteLine("\n--- Натиҷаҳои таҳлил ---");
        Console.WriteLine("Баҳои миёна: " + miyona);
        Console.WriteLine("Баландтарин баҳо: " + balandtarin);
        Console.WriteLine("Пасттарин баҳо: " + pasttarin);
        Console.WriteLine("Шумораи донишҷӯёни гузашта (>= 50): " + guzashta);
        Console.WriteLine("Шумораи донишҷӯёни нагузашта (< 50): " + naguzashta);
    }
}
