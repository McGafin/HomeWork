using System;

namespace Task17
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 456;
            x= (x / 100)*100 + (x % 10)*10 + ((x / 10) % 10);
            Console.WriteLine(x);


      
        }
    }
}
