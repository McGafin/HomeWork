using System;

namespace Task11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите x=");
            int x = int.Parse(Console.ReadLine());
            int y = 7 * x*x - 3 * x + 4;
            Console.WriteLine("y="+y);
        }
    }
}
