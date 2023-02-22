using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pz_21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pupil fn = new Pupil("ВЫГОАПРР", 17, 11, 5, 4, 3);
            fn.PrintInfo();
            Console.WriteLine(fn.GetMediumMark());
            Console.ReadKey();
        }
    }
}
