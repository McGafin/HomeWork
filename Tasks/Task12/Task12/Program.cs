using System;

namespace Task12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите радиус:");
            int r = int.Parse(Console.ReadLine());
            double l = 2 * Math.Round(Math.PI, 2) * r;
            double S = Math.Round(Math.PI,2) * Math.Pow(r, 2);
            Console.WriteLine("l="+l);
            Console.WriteLine("S="+S);
        }
    }
}
