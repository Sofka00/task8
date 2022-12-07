using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_8._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number1 = Convert.ToInt32(Console.ReadLine());
            int number2 = Convert.ToInt32(Console.ReadLine());
            int number3 = Convert.ToInt32(Console.ReadLine());
            int x;
            if (number3 < number1)
            {
                x = number3;
                number3 = number1;
                number1 = x;
            }
            if (number3< number2)
            {
                x = number3;
                number3 = number2;
                number2 = x;
            }

           if (number2 < number1 )
            {
                x = number2;
                number2 = number1;
                number1 = x;
             }

            Console.WriteLine($"{number1},{number2},{number3}");


        }
    }
}
