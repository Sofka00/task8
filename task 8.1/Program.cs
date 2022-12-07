using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_8._1
{
    internal class Program
    {
        static void Main(string[] args)
        {int number1 = Convert.ToInt32(Console.ReadLine());
            int number2 = Convert.ToInt32(Console.ReadLine());
            if (number1 > number2)
            {
                Console.WriteLine(number1 - number2);

            }
            else if (number1 <= number2)
            
            {
                Console.WriteLine("Меньше или равно второму числу");
                
            }
        } 
    }
}
