using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pz_24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Graduate pupil1 = new Graduate();
            pupil1.Name = "Сергей";
            pupil1.Age = 17;
            pupil1.Clas = 11;
            pupil1.mathMark = 5;
            pupil1.physMark = 2;
            pupil1.chemMark = 5;
            pupil1.DateEntrance = new DateTime(2020, 08, 15);
            Graduate piple1 = (Graduate)pupil1.Clone();

            Graduate pupil2 = new Graduate();
            pupil2.Name = "Женя";
            pupil2.Age = 17;
            pupil2.Clas = 11;
            pupil2.mathMark = 4;
            pupil2.physMark = 5;
            pupil2.chemMark = 5;
            pupil2.DateEntrance = new DateTime(2021, 08, 15);
            Graduate piple2 = (Graduate)pupil2.Clone();

            Graduate pupil3 = new Graduate();
            pupil3.Name = "Рома";
            pupil3.Age = 17;
            pupil3.Clas = 11;
            pupil3.mathMark = 5;
            pupil3.physMark = 5;
            pupil3.chemMark = 5;
            pupil3.DateEntrance = new DateTime(2020, 08, 15);
            Graduate piple3 = (Graduate)pupil3.Clone();

            Graduate pupil4 = new Graduate();
            pupil4.Name = "Никита";
            pupil4.Age = 16;
            pupil4.Clas = 11;
            pupil4.mathMark = 5;
            pupil4.physMark = 5;
            pupil4.chemMark = 5;
            pupil4.DateEntrance = new DateTime(2021, 08, 15);
            Graduate piple4 = (Graduate)pupil4.Clone();

            Graduate pupil5 = new Graduate();
            pupil5.Name = "Ваня";
            pupil5.Age = 18;
            pupil5.Clas = 11;
            pupil5.mathMark = 5;
            pupil5.physMark = 5;
            pupil5.chemMark = 5;
            pupil5.DateEntrance = new DateTime(2019, 08, 15);
            Graduate piple5 = (Graduate)pupil5.Clone();

            pupil1.PrintInfo();
            //pupil1.GetMediumMark();
            pupil2.PrintInfo();
            //pupil2.GetMediumMark();
            pupil3.PrintInfo();
            //pupil3.GetMediumMark();
            pupil4.PrintInfo();
            //pupil4.GetMediumMark();
            pupil5.PrintInfo();
            //pupil5.GetMediumMark();

            pupil1.Name = "Дамир";
            pupil2.Name = "Сергей";
            pupil3.Name = "Кто-то";
            pupil4.Name = "Зачем то";
            pupil5.Name = "Не знаю";

            Console.WriteLine($"клонированные объекты остались без изменений 1: {piple1.Name}\nклонированные объекты остались без изменений 2: {piple2.Name}\nклонированные объекты остались без изменений 3: {piple3.Name}\nклонированные объекты остались без изменений 4: {piple4.Name}\nклонированные объекты остались без изменений 5: {piple5.Name}\n");
            Console.WriteLine($"клонирование объекта с изменениями 1: {pupil1.Name}\nклонирование объекта с изменениями 2: {pupil2.Name}\nклонирование объекта с изменениями 3: {pupil3.Name}\nклонирование объекта с изменениями 4: {pupil4.Name}\nклонирование объекта с изменениями 5: {pupil5.Name}\n");





            Console.ReadLine();
        }
    }
}
