using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_8._4
{
    internal class Program
    {
        static void Main(string[] args)
        //* Пользователь вводит 3 числа (A, B и С). Выведите в консоль решение(значения X)
        //квадратного уравнения стандартного вида, где AX^2+BX+C=0.
        // Формула дискриминанта D = b^2 * 4ac

        {
            double a = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());
            double c = Convert.ToDouble(Console.ReadLine());
            double discriminant;
            
          
            discriminant = (b * b) * (4 * a * c);
            Console.WriteLine( "Дискриминант равен " + discriminant);
            // Если D<0 - корней нет,
            if (discriminant < 0) 
            {
                Console.WriteLine("Корней нет");
            } 
            if (discriminant > 0)
            {
                double x1 = (-b + Math.Sqrt(discriminant))/2 * a;
                double x2 = (-b - Math.Sqrt(discriminant)) / 2 * a;
                Console.WriteLine("X1 = " + x1 + "," + "X2 = " + x2);
            }
            if (discriminant == 0)
            {
                double x = (- b )/ ( 2 * a);
                Console.WriteLine(" x = " + x);
            }
                

            // Если D = 0 - один корень,
            // Если D>0 - два корня.
             

        }

    }
}
