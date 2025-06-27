using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace help
{
    public class ClassRoom
    {
        private Pupil[] pupils = new Pupil[4];

        public ClassRoom(Pupil p1, Pupil p2, Pupil p3 = null, Pupil p4 = null)
        {
            pupils[0] = p1;
            pupils[1] = p2;
            pupils[2] = p3 ?? new GoodPupil("Иванов");
            pupils[3] = p4 ?? new BadPupil("Петров");
        }

        public void ShowAll()
        {
            foreach (var p in pupils)
            {
                p.Study();
                p.Read();
                p.Write();
                p.Relax();
                Console.WriteLine();
            }
        }
    }
}
