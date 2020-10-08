using System;

namespace Task8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите массу 1:");
            double m1 = double.Parse(Console.ReadLine());
            Console.Write("Введите объем 1:");
            double v1 = double.Parse(Console.ReadLine());

            Console.Write($"Введите массу 2:");
            double m2 = double.Parse(Console.ReadLine());
            Console.Write($"Введите объем 2:");
            double v2 = double.Parse(Console.ReadLine());


            double p1 = m1 / v1;
            double p2 = m2 / v2;

            if (p1 > p2)
                Console.WriteLine("Плотность первого больше");
            else if (p1 < p2)
                Console.WriteLine("Плотность второго больше");
            else
                Console.WriteLine("Их плотность ровна");

        }
    }
}
