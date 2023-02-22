using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pz_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // дано целое число N> 0 и строка S.Преобразовать строку S в строку длины N следующим
            //образом: если длина строки S больше N, то отбросить первые символы, если длина строки S
            //меньше N, то в ее начало добавить символы «.» (точка).
            Console.Write("Введите случайное число, большое нуля: ");
            int N = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите произвольное предложение: ");
            string S = Console.ReadLine();
            if (S.Length > N)
                S = S.Substring(S.Length - N, N);
            else
                S = new string('.', N - S.Length) + S;

            Console.WriteLine(S);
            Console.ReadKey(true);

        }
    }
}
