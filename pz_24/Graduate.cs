using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace pz_24
{
    internal class Graduate : Pupil, ICloneable
    {
        private DateTime releaseDate;
        private DateTime dateEntrance;
        DateTime aa = new DateTime(0001, 01, 01);
        public DateTime DateEntrance
        {
            get { return dateEntrance; }
            set
            {
                if (value == aa)
                {
                    Console.WriteLine("даты поступления не существует");
                }
                else
                {
                    dateEntrance = value;
                }
            }
        }
        public override void PrintInfo()
        {
            releaseDate = DateEntrance.AddYears(4);
            Console.WriteLine($"Дата выпуска ученика {Name} : {releaseDate}");
        }
        public new object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
