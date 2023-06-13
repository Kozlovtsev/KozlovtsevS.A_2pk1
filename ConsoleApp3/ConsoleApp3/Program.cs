using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program

    {

        static void Main(string[] args)

        {

            Console.WriteLine("Введите длину прямоугольника:");

            double length = Convert.ToDouble(Console.ReadLine());



            Console.WriteLine("Введите ширину прямоугольника:");

            double width = Convert.ToDouble(Console.ReadLine());



            double area = length * width;

            double perimeter = 2 * (length + width);



            Console.WriteLine($"Площадь прямоугольника: {area}");

            Console.WriteLine($"Периметр прямоугольника: {perimeter}");



            Console.ReadKey();

        }

    }
}
