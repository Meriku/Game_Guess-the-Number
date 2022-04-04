using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskGame
{
    internal class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {

                // Game - Guess the Number

                Console.Clear();
                Console.WriteLine("\nДобро пожаловать в игру! Выберите свой вариант:");
                Console.WriteLine("1 - Компьютер загадывает, игрок отгадывает");
                Console.WriteLine("2 - Игрок загадывает, игрок отгадывает");
                Console.WriteLine("3 - Игрок загадывает, компьютер отгадывает");

                int answer;
                while (!int.TryParse(Console.ReadLine(), out answer) && answer > 0 && answer < 4)
                {
                    Console.WriteLine($"Введите корректную цифру от 1 до 3");
                }

                Console.Clear();
                switch (answer)
                {
                    case 1:
                    PersonvsComp.NewGame();
                    break;
                    case 2:
                    PersonvsPerson.NewGame();
                    break;
                    case 3:
                    CompvsPerson.NewGame();
                    break;
                }

            }








        }
    }
}
