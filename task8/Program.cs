using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task8
{
    internal class Program
    {
        static void Main(string[] args)
        { int number = Convert.ToInt32(Console.ReadLine());
            if (number % 2 == 0)
            {
                Console.WriteLine("Четное");

            }
            else if (number % 2 != 0)
            {
                Console.WriteLine("Нечетное");
            }
               
        }
    }
}
