using System;

namespace Task7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите радиус:");
            int r = int.Parse(Console.ReadLine());
            Console.Write("Введите сторону квадрата:");
            int a = int.Parse(Console.ReadLine());
            double Sr = Math.PI * Math.Pow(r, 2);
            double Sa = Math.Pow(a, 2);
            if (Sr > Sa)
                Console.WriteLine("Площадь круга больше");
            else if (Sr < Sa)
                Console.WriteLine("Площадь квадрата больше");
            else
                Console.WriteLine("Они равны");

        }
    }
}
