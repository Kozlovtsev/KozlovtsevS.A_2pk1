using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pz_23
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
                if (name != null) { value = name; }
                else { Console.WriteLine("Неккоректно заданное имя"); }
            }
        }
        public int Age
        {
            get { return age; }
            set
            {
                if (age >= 7 & age <= 18) { value = age; }
                else { Console.WriteLine("Неккоректно заданный возраст"); }
            }
        }
        public int Clas
        {
            get { return clas; }
            set
            {
                value = clas;
            }
        }
        public float mathMark
        {
            get { return mathmark; }
            set
            {
                if (mathmark >= 2 & mathmark <= 5) { value = mathmark; }
                else { Console.WriteLine("Неккоректная оценка"); }
            }
        }
        public float physMark
        {
            get { return physmark; }
            set
            {
                if (physmark >= 2 & physmark <= 5) { value = physmark; }
                else { Console.WriteLine("Неккоректная оценка"); }
            }
        }
        public float chemMark
        {
            get { return chemmark; }
            set
            {
                if (chemmark >= 2 & chemmark <= 5) { value = chemmark; }
                else { Console.WriteLine("Неккоректная оценка"); }
            }
        }
        public void PrintInfo()
        {
            Console.WriteLine($"Имя: {Name}\n Возраст: {Age}\n Класс:{Clas}\n Оценка по математике: {mathMark}\n Оценка по физике: {physMark}\n Оценка по химии:{chemMark}");
        }
        public double GetMediumMark()
        {
            float average_value = (physMark + mathMark + chemMark) / 3;
            Console.WriteLine("Среднее арифметическое оценок:", average_value);
            return average_value;
        }
    }
}        
