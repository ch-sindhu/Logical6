using System;

namespace True
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter a number");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("check wheather positive or negative no");
            Console.WriteLine((a < 0 && b > 0) || (b > 0 && a < 0));
        }
    }
}
