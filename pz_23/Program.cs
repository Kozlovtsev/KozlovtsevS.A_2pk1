using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pz_23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pupil fn = new Pupil("", 25, 11, 10, 10, 10);
            fn.PrintInfo();
            Console.WriteLine(fn.GetMediumMark());
            Pupil fn2 = new Pupil("Сергей", 17, 11, 5, 2, 5);
            fn2.PrintInfo();
            Console.WriteLine(fn2.GetMediumMark());
            Pupil fn3 = new Pupil("Женя", 17, 11, 4, 5, 5);
            fn3.PrintInfo();
            Console.WriteLine(fn3.GetMediumMark());
            Pupil fn4 = new Pupil("Рома", 17, 11, 5, 5, 5);
            fn4.PrintInfo();
            Console.WriteLine(fn4.GetMediumMark());
            Pupil fn5 = new Pupil("Никита", 16, 9, 5, 5, 5);
            fn5.PrintInfo();
            Console.WriteLine(fn5.GetMediumMark());
            Pupil fn6 = new Pupil("Ваня", 17, 11, 5, 5, 5);
            fn6.PrintInfo();
            Console.WriteLine(fn6.GetMediumMark());
            Console.WriteLine($"Количество учеников с двойками: {Pupil.bad_marks}\nКоличество круглых отличников: {Pupil.otlichniki}");

            Graduate fn7 = new Graduate(5);
            fn7.PrintInfo();
            Console.ReadKey();
        }
    }
}
