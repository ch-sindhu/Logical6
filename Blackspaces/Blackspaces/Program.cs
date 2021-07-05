using System;

namespace Blackspaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            int a = int.Parse(Console.ReadLine());
            Console.Write(a);
            Console.Write("  ");
            Console.Write(a);
            Console.Write("  ");
            Console.Write(a);
            Console.Write("  ");
            Console.Write(a);
            Console.WriteLine("  "); 


            Console.Write(a);
            Console.Write(a);
            Console.Write(a);
            Console.Write(a);
            Console.WriteLine("");


            Console.WriteLine("{0}  {0}  {0}  {0}", a);
                Console.WriteLine("{0}{0}{0}{0}", a);



        }
    }
}
