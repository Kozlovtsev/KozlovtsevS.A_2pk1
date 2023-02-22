using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pz_22
{
    internal class Pupil
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int Clas { get; set; }
        public float mathMark { get; set; }
        public float physMark { get; set; }
        public float chemMark { get; set; }

        static public int otlichniki = 0;
        static public int bad_marks = 0;
        public Pupil(string name, int age, int clas, float mathmark, float physmark, float chemmark)

        {
            if (name != null) { Name = name; }
            else { Console.WriteLine("Неккоректно заданное имя"); }
            if (age >= 7 & age <= 18) { Age = age; }
            else { Console.WriteLine("Неккоректно заданный возраст"); }
            Clas = clas;
            if (mathmark >= 2 & mathmark <= 5) { mathMark = mathmark; }
            else { Console.WriteLine("Неккоректная оценка"); }
            if (physmark >= 2 & physmark <= 5) { physMark = physmark; }
            else { Console.WriteLine("Неккоректная оценка"); }
            if (chemmark >= 2 & chemmark <= 5) { chemMark = chemmark; }
            else { Console.WriteLine("Неккоректная оценка"); }
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Имя: {Name}\n" +
                                $"Возраст: {Age}\n" +
                                $"Класс: {Clas}\n" +
                                $"Оценка по математике: {mathMark}\n" +
                                $"Оценка по физике: {physMark}\n" +
                                $"Оценка по химии: {chemMark}");
            if (chemMark == 2 || physMark == 2 || mathMark == 2) { bad_marks++; }
            if (chemMark == 5 & physMark == 5 & mathMark == 5) { otlichniki++; }
        }
        public double GetMediumMark()
        {
            float average_value = (physMark + mathMark + chemMark) / 3;
            Console.WriteLine("Среднее арифметическое оценок:", average_value);
            return average_value;
        }
    }
}
