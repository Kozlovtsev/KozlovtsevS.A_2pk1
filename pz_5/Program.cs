using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pz_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 30; i <= 100; i += 7)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Первое задание выполнено");


            for (char a = 'L'; a <= 'R'; a++)
            {
                Console.WriteLine(a);
            }
            Console.WriteLine("Второе задание выполнено");

            int n = 4;
            int m = 4;
            for (int i = 0; i < m; i++)
            {
                for (int x = 0; x < n; x++)
                {
                    Console.Write('#');
                }
                Console.WriteLine();
            }
            Console.WriteLine("Третье задание выполнено");


            for (int i = 0; i <= 100; i++)
            {
                if (i % 9 == 0)
                {
                    Console.WriteLine(i + " ");
                }
            }
            Console.WriteLine("Четвертое задание выполнено");


            for (int i = 4, j = 50; i - j <= 11; i++, j--)
            {
                Console.WriteLine(i - j);
            }
            Console.WriteLine("Пятое задание выполнено");
        }
    }
    
}
