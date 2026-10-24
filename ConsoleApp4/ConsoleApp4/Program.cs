using System;

class Program
{
    static double HisobiMaosh(double soat, double narx)
    {
        double meyor = 40.0;
        double maosh = 0;

        if (soat <= meyor)
        {
            maosh = soat * narx;
        }
        else
        {
            double maoshiOdi = meyor * narx;
            double soathoiIlovagi = soat - meyor;
            double maoshiIlovagi = soathoiIlovagi * (narx * 1.5);

            maosh = maoshiOdi + maoshiIlovagi;
        }

        return maosh;
    }

    static void Main()
    {
        Console.Write("Шумораи соатҳои кориро ворид кунед: ");
        double soat = Convert.ToDouble(Console.ReadLine());

        Console.Write("Нархи як соати кориро ворид кунед: ");
        double narx = Convert.ToDouble(Console.ReadLine());

        double natija = HisobiMaosh(soat, narx);

        Console.WriteLine("Маоши умумӣ: " + natija);
    }
}
