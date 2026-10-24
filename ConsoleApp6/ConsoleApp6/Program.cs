using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<string> donishjuyon = new List<string>();
        bool davom = true;

        while (davom)
        {
            Console.WriteLine("\n--- МЕНЮ ---");
            Console.WriteLine("1. Илова кардани донишҷӯ");
            Console.WriteLine("2. Нест кардани донишҷӯ");
            Console.WriteLine("3. Ҷустуҷӯ аз рӯи ном");
            Console.WriteLine("4. Нишон додани ҳамаи донишҷӯён");
            Console.WriteLine("5. Чорабинӣ (Баромад)");
            Console.Write("Интихоби худро ворид кунед (1-5): ");

            string intikhob = Console.ReadLine();

            if (intikhob == "1")
            {
                Console.Write("Номи донишҷӯро ворид кунед: ");
                string nom = Console.ReadLine();
                donishjuyon.Add(nom);
                Console.WriteLine("Донишҷӯ бо муваффақият илова шуд.");
            }
            else if (intikhob == "2")
            {
                Console.Write("Номи донишҷӯро барои нест кардан ворид кунед: ");
                string nom = Console.ReadLine();

                if (donishjuyon.Remove(nom))
                {
                    Console.WriteLine("Донишҷӯ нест карда шуд.");
                }
                else
                {
                    Console.WriteLine("Чунин донишҷӯ ёфт нашуд!");
                }
            }
            else if (intikhob == "3")
            {
                Console.Write("Номи донишҷӯро барои ҷустуҷӯ ворид кунед: ");
                string nom = Console.ReadLine();

                if (donishjuyon.Contains(nom))
                {
                    Console.WriteLine("Донишҷӯ дар рӯйхат ҳаст.");
                }
                else
                {
                    Console.WriteLine("Донишҷӯ дар рӯйхат ёфт нашуд.");
                }
            }
            else if (intikhob == "4")
            {
                Console.WriteLine("\n--- Рӯйхати ҳамаи донишҷӯён ---");
                if (donishjuyon.Count == 0)
                {
                    Console.WriteLine("Рӯйхат холӣ аст.");
                }
                else
                {
                    for (int i = 0; i < donishjuyon.Count; i++)
                    {
                        Console.WriteLine((i + 1) + ". " + donishjuyon[i]);
                    }
                }
            }
            else if (intikhob == "5")
            {
                davom = false;
                Console.WriteLine("Барнома анҷом ёфт.");
            }
            else
            {
                Console.WriteLine("Интихоби нодуруст! Лутфан рақами аз 1 то 5-ро интихоб кунед.");
            }
        }
    }
}