using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pz_22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pupil pupil1 = new Pupil();
            pupil1.Name = "Сергей";
            pupil1.Age = 17;
            pupil1.Clas = 11;
            pupil1.mathMark = 5;
            pupil1.physMark = 2;
            pupil1.chemMark = 5;

            Pupil pupil2 = new Pupil();
            pupil2.Name = "Женя";
            pupil2.Age = 17;
            pupil2.Clas = 11;
            pupil2.mathMark = 4;
            pupil2.physMark = 5;
            pupil2.chemMark = 5;

            Pupil pupil3 = new Pupil();
            pupil3.Name = "Рома";
            pupil3.Age = 17;
            pupil3.Clas = 11;
            pupil3.mathMark = 5;
            pupil3.physMark = 5;
            pupil3.chemMark = 5;

            Pupil pupil4 = new Pupil();
            pupil4.Name = "Никита";
            pupil4.Age = 16;
            pupil4.Clas = 11;
            pupil4.mathMark = 5;
            pupil4.physMark = 5;
            pupil4.chemMark = 5;

            Pupil pupil5 = new Pupil();
            pupil5.Name = "Ваня";
            pupil5.Age = 18;
            pupil5.Clas = 11;
            pupil5.mathMark = 5;
            pupil5.physMark = 5;
            pupil5.chemMark = 5;

            pupil1.PrintInfo();
            pupil1.GetMediumMark();
            pupil2.PrintInfo();
            pupil2.GetMediumMark();
            pupil3.PrintInfo();
            pupil3.GetMediumMark();
            pupil4.PrintInfo();
            pupil4.GetMediumMark();
            pupil5.PrintInfo();
            pupil5.GetMediumMark();
            Console.ReadLine();
        }
    }
}
