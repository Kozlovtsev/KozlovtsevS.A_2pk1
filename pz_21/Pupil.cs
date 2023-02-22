using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pz_21
{
    internal class Pupil
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int Clas { get; set; }
        public int mathMark { get; set; }
        public int physMark { get; set; }
        public int chemMark { get; set; }
        public Pupil(string name, int age, int clas, int mathmark, int physmark, int chemmark)
        {
            Name = name;
            Age = age;
            Clas = clas;
            mathMark = mathmark;
            physMark = physmark;
            chemMark = chemmark;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Имя: {Name}\n" +
                                $"Возраст: {Age}\n" +
                                $"Класс: {Clas}\n" +
                                $"Оценка по математике: {mathMark}\n" +
                                $"Оценка по физике: {physMark}\n" +
                                $"Оценка по химии: {chemMark}");
        }
        public double GetMediumMark()
        {
            float average_value = (physMark + mathMark + chemMark) / 3;
            Console.WriteLine("Среднее арифметическое оценок:", average_value);
            return average_value;
        }
    }
}
