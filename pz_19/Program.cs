using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace pz_19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FileStream file1 = new FileStream("text1.txt", FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(file1);
            string text = reader.ReadToEnd();
            file1.Close();
            string pattern = @"([А-Я][а-я]+\s?[А-Я][а-я]+)\s[+]";
            Regex regex = new Regex(pattern);
            foreach (Match match in regex.Matches(text))
            {
                Console.WriteLine(match.Value);
            }

            FileStream file2 = new FileStream("text2.txt", FileMode.Open, FileAccess.Read);
            StreamReader reader2 = new StreamReader(file2);
            string text2 = reader2.ReadToEnd();
            file2.Close();
            string pattern2 = @"(\d+[.]\d+[.]\d+[.]\d+\s)";
            Console.WriteLine("IP-адресс : ");
            Regex regex2 = new Regex(pattern2);
            foreach (Match match2 in regex2.Matches(text2))
            {
                Console.WriteLine(match2.Value);
            }

            Console.WriteLine("Дата : ");
            string pattern3 = @"(\d+[/]\w+[/]\d+)";
            Regex regex3 = new Regex(pattern3);
            foreach (Match match3 in regex3.Matches(text2))
            {
                Console.WriteLine(match3.Value);
            }
            Console.Read();
        }
    }
}
