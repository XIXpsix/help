using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace help
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.InputEncoding = System.Text.Encoding.UTF8;

            var pupil1 = new ExcelentPupil("Сидоров");
            var pupil2 = new GoodPupil("Кузнецов");
            var pupil3 = new BadPupil("Смирнов");

            ClassRoom classRoom = new ClassRoom(pupil1, pupil2, pupil3);
            classRoom.ShowAll();
        }
    }
}
