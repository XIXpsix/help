using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace help
{
    internal class Player : IPlayable, IRecodable
    {
        public void Play()
        {
            Console.WriteLine("Воспроизведение запущено");
        }

        public void Pause()
        {
            Console.WriteLine("Воспроизведение приостановлено");
        }

        public void Stop()
        {
            Console.WriteLine("Воспроизведение остановлено");
        }

        public void Record()
        {
            Console.WriteLine("Запись начата");
        }

        // Для IRecodable.Pause и IPlayable.Pause используем одну реализацию
        void IRecodable.Pause()
        {
            Console.WriteLine("Запись приостановлена");
        }

        void IRecodable.Stop()
        {
            Console.WriteLine("Запись остановлена");
        }
    }
}
