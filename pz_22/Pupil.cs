using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pz_22
{
    internal class Pupil
    {
        public string name;
        public int age;
        public int clas;
        public float mathmark;
        public float physmark;
        public float chemmark;
        public int otlichniki = 0;
        public int bad_marks = 0;
        public string Name
        {
            get { return name; }
            set
            {
                if (value == "")
                {
                    Console.WriteLine("имя не существует");
                }
                else
                {
                    name = value;
                }
            }
        }
        public int Age
        {
            get { return age; }
            set
            {
                if (age <= 7 && age >= 18)
                {
                    Console.WriteLine("Неккоректно заданный возраст");
                }
                else
                {
                    age = value;
                }
            }
        }
        public int Clas
        {
            get { return clas; }
            set
            {
                clas = value;
            }
        }
        public float mathMark
        {
            get { return mathmark; }
            set
            {
                if (mathmark <= 2 & mathmark >= 5) { Console.WriteLine("Неккоректная оценка"); }
                else { mathmark = value; }
            }
        }
        public float physMark
        {
            get { return physmark; }
            set
            {
                if (physmark <= 2 & physmark >= 5) { Console.WriteLine("Неккоректная оценка"); }
                else { physmark = value; }
            }
        }
        public float chemMark
        {
            get { return chemmark; }
            set
            {
                if (chemmark <= 2 & chemmark >= 5) { Console.WriteLine("Неккоректная оценка"); }
                else { chemmark = value; }
            }
        }
        public void PrintInfo()
        {
            Console.WriteLine($"Имя: {Name}\nВозраст: {Age}\nКласс:{Clas}\nОценка по математике: {mathMark}\nОценка по физике: {physMark}\nОценка по химии:{chemMark}");
        }
        public double GetMediumMark()
        {
            float average_value = (physMark + mathMark + chemMark) / 3;
            Console.WriteLine("Среднее арифметическое оценок:" + average_value);
            return average_value;
        }
    }
}
