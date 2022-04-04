using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TaskGame
{
    public class CompvsPerson
    {
        public static void NewGame()
        {
            int min = 0;
            int max = 100;
            int life = 5;       // Жизни

            var rnd = new Random();

            Console.WriteLine("Введите число которое будет угадывать компьютер!");
            int secretnumber;
            while (!int.TryParse(Console.ReadLine(), out secretnumber) || (secretnumber < min || secretnumber > max))
            {
                Console.WriteLine($"Введите корректную цифру от {min} до {max}");
            }


            Console.Clear();
            Console.WriteLine("\nИгра начинается! Компьютер угадывает число!");

            while (true)
            {
                if (life == 0)
                {
                    Console.WriteLine($"Игра окончена. Компьютер проиграл. Загаданное число - {secretnumber}");
                    break;

                }
                Console.WriteLine($"\nКомпьютер выбирает число в диапазоне между {min} и {max}");   
                var result = rnd.Next(min, max+1);
                Console.WriteLine($"Компьютер ввел: {result}");

                if (result == secretnumber)
                {
                    Console.WriteLine($"Компьютер победил! Загаданное число - {secretnumber}");
                    break;
                }
                if (result < secretnumber)
                {
                    Console.WriteLine("Неправильно. Компьютер ввел число меньше загаданного.");
                    min = result;
                    life--;
                    Console.WriteLine($"Осталось {life} попыток");

                }
                if (result > secretnumber)
                {
                    Console.WriteLine("Неправильно. Компьютер ввел число больше загаданного.");
                    max = result;
                    life--;
                    Console.WriteLine($"Осталось {life} попыток");

                }

                Thread.Sleep(1000);

            }
        }
    }
}
