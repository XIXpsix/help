using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace help
{
    class TXTHandler : AbstractHandler
    {
        public override void Open()
        {
            Console.WriteLine("Открыт TXT-документ");
        }
        public override void Create()
        {
            Console.WriteLine("Создан TXT-документ");
        }
        public override void Chenge()
        {
            Console.WriteLine("Изменён TXT-документ");
        }
        public override void Save()
        {
            Console.WriteLine("Сохранён TXT-документ");
        }
    }
}
