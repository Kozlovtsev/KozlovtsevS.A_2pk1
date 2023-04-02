using System.Data;
using System;

namespace pz_27
{
    internal class Program
    {
        struct TRAIN
        {
            public string NAZN;
            public int NUMR;
            public DateTime TIME;
        }
        static void Main(string[] args)
        {
            TRAIN[] RASP = new TRAIN[8];
            for (int i = 0; i < RASP.Length; i++)
            {
                Console.WriteLine($"Введите номер поезда");
                RASP[i].NUMR = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Название пункта назначения: ");
                RASP[i].NAZN = Console.ReadLine();
                Console.WriteLine("Время отправления формата(часы:минуты): ");
                RASP[i].TIME = DateTime.Parse(Console.ReadLine());
            }
            Array.Sort(RASP,(a, b) => a.NUMR.CompareTo(b.NUMR));

            Console.WriteLine("Введите номер интересующего поезда");
            int number = Convert.ToInt32(Console.ReadLine());
            bool poezd = false;
            Console.WriteLine($"Информация о пункте назначения или дате по {number} поезду");
            for (int i = 0; i < 8;i++)
            {
                if (RASP[i].NUMR == number) 
                {
                    Console.WriteLine("Пункт назначения: " + RASP[i].NAZN + " Время отправления: " + RASP[i].TIME);
                    poezd = true;
                    break;
                }   

            }
            if (!poezd)
            {
                Console.WriteLine("Данных по этому поезда нет");
            }
            Console.ReadKey();
        }
    }
}