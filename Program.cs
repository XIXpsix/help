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

            Console.WriteLine("Введите должность сотрудника:");
            string postInput = Console.ReadLine();

            Post worker;
            if (!Enum.TryParse(postInput, true, out worker) || !Enum.IsDefined(typeof(Post), worker))
            {
                Console.WriteLine("Должность не найдена.");
                return;
            }

            Console.WriteLine("Введите количество отработанных часов:");
            int hours;
            if (!int.TryParse(Console.ReadLine(), out hours))
            {
                Console.WriteLine("Некорректный ввод часов.");
                return;
            }

            Accauntant acc = new Accauntant();
            if (acc.AskForBonus(worker, hours))
                Console.WriteLine("Сотруднику положена премия.");
            else
                Console.WriteLine("Сотруднику не положена премия.");
        }
    }
}
