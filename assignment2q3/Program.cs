using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment2q3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a;
            Console.WriteLine("enter a number");
            a = int.Parse(Console.ReadLine());
            if(a>0)
            {
                Console.WriteLine("a is positive number");
                if (a % 2 == 0)
                {
                    Console.WriteLine("a is even");
                }
                else
                {
                    Console.WriteLine("a is odd");
                }
            }
            else if (a < 0)
            {
                Console.WriteLine("a is negetive number");
            }
            else
            {
                Console.WriteLine("a is zero");
            }
            Console.ReadKey();
        }
    }
}
