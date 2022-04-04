using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskGame
{
    public class PersonvsComp
    {
        public static void NewGame()
        {
            var rnd = new Random();

            int min = 0;
            int max = 100;
            int life = 5;       // Жизни
            int secretnumber = rnd.Next(min, max + 1);
            Console.WriteLine("\nИгра начинается! Угадайте число!");

            while (true)
            {
                if (life == 0)
                {
                    Console.WriteLine($"Игра окончена. Вы потратили все попытки. Загаданное число - {secretnumber}");
                    Console.ReadLine();
                    break;

                }
                int result;
                Console.WriteLine($"Введите число от {min} до {max}");
                while (!int.TryParse(Console.ReadLine(), out result) || (result < min || result > max))
                {
                    Console.WriteLine($"Введите корректную цифру от {min} до {max}");
                }

                if (result == secretnumber)
                {
                    Console.WriteLine($"Ура! Вы победили! Загаданное число - {secretnumber}");
                    break;
                }
                if (result < secretnumber)
                {
                    Console.WriteLine("Неправильно. Ваше число меньше загаданного.");
                    min = result;
                    life--;
                    Console.WriteLine($"Осталось {life} попыток");

                }
                if (result > secretnumber)
                {
                    Console.WriteLine("Неправильно. Ваше число больше загаданного.");
                    max = result;
                    life--;
                    Console.WriteLine($"Осталось {life} попыток");

                }


            }
        }

    }
}
