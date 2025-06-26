using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace help
{
    internal class ClassRoom
    {
        private Pupil[] pupils = new Pupil[4];

        public ClassRoom(Pupil p1, Pupil p2)
        {
            pupils[0] = p1;
            pupils[1] = p2;
            pupils[2] = new GoodPupil("Иванов");
            pupils[3] = new BadPupil("Петров");
        }

        public ClassRoom(Pupil p1, Pupil p2, Pupil p3)
        {
            pupils[0] = p1;
            pupils[1] = p2;
            pupils[2] = p3;
            pupils[3] = new GoodPupil("Иванов");
        }

        public ClassRoom(Pupil p1, Pupil p2, Pupil p3, Pupil p4)
        {
            pupils[0] = p1;
            pupils[1] = p2;
            pupils[2] = p3;
            pupils[3] = p4;
        }

        public void ShowAll()
        {
            Console.WriteLine("Как учатся ученики:");
            foreach (var p in pupils)
                p.Study();
            Console.WriteLine("\nКак читают ученики:");
            foreach (var p in pupils)
                p.Read();
            Console.WriteLine("\nКак пишут ученики:");
            foreach (var p in pupils)
                p.Write();
            Console.WriteLine("\nКак отдыхают ученики:");
            foreach (var p in pupils)
                p.Relax();
        }
    }
}
