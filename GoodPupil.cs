using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace help
{
    internal class GoodPupil : Pupil
    {
        public GoodPupil(string lastName) : base(lastName) { }

        public override void Study()
        {
            Console.WriteLine($"{LastName}: Учится хорошо.");
        }
        public override void Read()
        {
            Console.WriteLine($"{LastName}: Читает достаточно.");
        }
        public override void Write()
        {
            Console.WriteLine($"{LastName}: Пишет хорошо.");
        }
        public override void Relax()
        {
            Console.WriteLine($"{LastName}: Умеет отдыхать и учиться.");
        }
    }
}
