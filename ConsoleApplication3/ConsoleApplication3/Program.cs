using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            int value1;
            int value2;
            

            Console.WriteLine("Please enter a number");
            value1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter another number");
            value2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Max value" + Math.Max(value1, value2));
            Console.ReadLine();
        }
    }
}
