using System;

namespace Problem1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("A = ");
            int a = int.Parse(Console.ReadLine());
            
            Console.Write("B = ");
            int b = int.Parse(Console.ReadLine());

            int new_a =(a == b)?0:Math.Max(a,b);
            b = (a == b)?0:Math.Max(a,b);
            
            Console.WriteLine($"new A = {new_a}");
            Console.WriteLine($"new B = {b}");
            Console.ReadKey();
        }
    }
}
