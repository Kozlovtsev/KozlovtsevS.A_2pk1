using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pz_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //            Дан текст, состоящий из нескольких строк.Создайте на основе него двумерный
            //массив, в котором в строку массива записываются все слова каждого
            //предложения.Используйте ступенчатые двумерные массивы

            //Создание текста
            string phrase = "Привет всем." +
                "Меня зовут Сергей." +
                "Я новенький в этой группе." +
                "А как зовут вас?";

            //Запись текста в ступенчатый массив
            string[] words = phrase.Split('.', 4);

            //Вывод массива
            foreach (var word in words)
            {
                Console.WriteLine($"<{word}>");
            }
        }
    }
}
