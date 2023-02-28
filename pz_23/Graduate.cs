using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace pz_23
{
    internal class Graduate : Pupil
    {
        public int ReleaseDate { get; set; }
        public Graduate(string name, int age, int clas, float mathmark, float physmark, float chemmark, int releaseDate)
        {
            Name = name;
            Age = age;
            Clas = clas;
            mathMark = mathmark;
            physMark = physmark;
            chemMark = chemmark;
            ReleaseDate = releaseDate;
        }
        public Graduate(int releaseDate)
        {
            ReleaseDate = releaseDate;
        }
        public override void PrintInfo()
        {
            Console.WriteLine($"Количество выпускников в этом году равен: {ReleaseDate}");
        }
    }
}
