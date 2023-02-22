using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pz_15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] txt1 = File.ReadAllLines(@"B:\прогги\zadanie.txt");
            string[] txt2 = new string[txt1.Length];
            for (int i = 0; i < txt1.Length; i++)
            {
                if (i % 2 == 0)
                {
                    txt2[i] = txt1[i];
                }
            }
            for (int i = 0; i < txt2.Length; i++)
            {
                using (StreamWriter streamWriter = new StreamWriter(@"B:\прогги\zadanie.txt", true))
                {
                    streamWriter.WriteLine(txt2[i] + "\n");
                }
            }

        }
    }
}

