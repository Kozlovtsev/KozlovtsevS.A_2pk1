using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pz_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите длинну отрезка А:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите длинну отрезка В:");
            int b = Convert.ToInt32(Console.ReadLine());
            int box = 0;
            int c = a - b;
            while (c >= 0)
            {
                box++;
                c = c - b;
            }
            Console.WriteLine($"Количество отрезков В в отрезке А: {box}");
        }
    }
}
