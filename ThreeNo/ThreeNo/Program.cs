using System;

namespace ThreeNo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter b number");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter c number");
            int c = int.Parse(Console.ReadLine());
            Console.WriteLine("Result of specified numbers {0},{1} and {2},(x+y).z is {3} and x.y+y.z is {4}\n\n",
                a, b, c, ((a + b) * c), (a * b + b * c)); 
        }
    }
}
