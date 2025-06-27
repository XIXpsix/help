using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace help
{     // Хорошист

     public class GoodPupil : Pupil
     {
            public GoodPupil(string lastName) : base(lastName) { }

            public override void Study() { Console.WriteLine($"{LastName}: Учится хорошо."); }
            public override void Read() { Console.WriteLine($"{LastName}: Читает внимательно."); }
            public override void Write() { Console.WriteLine($"{LastName}: Пишет с небольшими ошибками."); }
            public override void Relax() { Console.WriteLine($"{LastName}: Отдыхает в меру."); }
     }
}
