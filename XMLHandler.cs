using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace help
{
    public class XMLHandler : AbstractHandler
    {
        public override void Open() { Console.WriteLine("Open document format - XML"); }
        public override void Create() { Console.WriteLine("Creat document format - XML"); }
        public override void Chenge() { Console.WriteLine("Change document format - XML"); }
        public override void Save() { Console.WriteLine("Save document format - XML"); }
    }
}
