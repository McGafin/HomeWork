using System;

namespace Task6
{
    class Program
    {
        static void Main(string[] args)
        {
            bool A = true;
            bool B = false;
            bool C = false;
            Console.WriteLine($"a. {A || B}");
            Console.WriteLine($"b. {A&&B}");
            Console.WriteLine($"c. {B||C}");
        }
    }
}
