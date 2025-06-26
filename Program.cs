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
            Player player = new Player();

            IPlayable playable = player;
            IRecodable recodable = player;

            // Проигрывание
            playable.Play();
            playable.Pause();
            playable.Stop();

            // Запись
            recodable.Record();
            recodable.Pause();
            recodable.Stop();

            Console.WriteLine("Нажмите любую клавишу для выхода...");
            Console.ReadKey();
        }
    }
}
