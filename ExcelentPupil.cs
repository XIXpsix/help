using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace help
{    // Отличник
    public class ExcelentPupil : Pupil
    {
        public ExcelentPupil(string lastName) : base(lastName) { }

        public override void Study() { Console.WriteLine($"{LastName}: Учится отлично."); }
        public override void Read() { Console.WriteLine($"{LastName}: Читает быстро и с интересом."); }
        public override void Write() { Console.WriteLine($"{LastName}: Пишет грамотно."); }
        public override void Relax() { Console.WriteLine($"{LastName}: Отдыхает мало."); }
    }
}
