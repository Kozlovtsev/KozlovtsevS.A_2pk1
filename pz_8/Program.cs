using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pz_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Создание массива, объявление переменных
            int d = 0;
            Random rnd = new Random();
            int sum = 0;
            int m = 10;
            int n = 10;
            int[,] massiv = new int[m, n];
            // Заполнение массива
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {

                    massiv[i, j] = rnd.Next(1, 50);
                    Console.Write(massiv[i, j] + " ");
                }
                Console.WriteLine();
            }
            //Нахождение суммы каждой строки в массиве, а также сравнение этих сумм
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    sum += massiv[i, j];
                }
                if (sum >= d)
                {
                    d = sum;
                }
                Console.WriteLine("Сумма " + (i + 1) + " строки равна " + sum);
                sum = 0;
            }
            //Вывод наибольшей суммы
            Console.WriteLine();
            Console.WriteLine($"Наибольшая сумма в матрице = " + d);
        }
    }
}
