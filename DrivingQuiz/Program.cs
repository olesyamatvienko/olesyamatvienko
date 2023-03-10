using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrivingQuiz
{
    using System;

    class DrivingQuiz
    {
        static void Main()
        {
            Console.OutputEncoding= Encoding.Unicode;

            string[] questions = new string[]
            {
            "1. Яка максимальна швидкість в населеному пункті в Україні?",
            "2. Які дії слід вжити, якщо ви під’їжджаєте до жовтого світлофора?",
            "3. Коли дозволено зробити поворот наліво на перехресті?",
            "4. Як правильно здійснювати поворот направо на червоне світло світлофора?"
            };

            string[][] options = new string[][]
            {
            new string[] {"А) 50 км/год", "Б) 60 км/год", "В) 70 км/год", "Г) 80 км/год" },
            new string[] { "А) Прискорити, щоб проїхати перехрестя", "Б) Зупинитися, якщо це можливо",
                "В) Зменшити швидкість та проїхати з обережністю", "Г) Сповістити інших водіїв гудком" },
            new string[] { "А) Коли немає зустрічного руху", "Б) Коли є дозвілний знак", "В) Ніколи",
                "Г) Тільки у вихідні" },
            new string[] { "А) Повністю зупинитися, а потім продовжувати рух, якщо це безпечно",
                "Б) Зменшити швидкість та здійснити поворот без зупинки",
                "В) Здійснити поворот звичайною швидкістю", "Г) Сповістити інших водіїв гудком" } 
            };

            int[] answers = new int[] { 0, 1, 3, 2 }; // Index of correct option for each question

            int score = 0;
            for (int questionIndex = 0; questionIndex < questions.Length; questionIndex++)
            {
                Console.WriteLine(questions[questionIndex]);

                string[] optionsForAQuestion = options[questionIndex];

                for (int optionIndex = 0; optionIndex < optionsForAQuestion.Length; optionIndex++)
                {
                    Console.WriteLine(optionsForAQuestion[optionIndex]);
                }

                Console.Write("Ваша відповідь: ");
                string userInput = Console.ReadLine();
                int userChoice = -1;

                switch (userInput.ToUpper())
                {
                    case "А":
                        userChoice = 0;
                        break;
                    case "Б":
                        userChoice = 1;
                        break;
                    case "В":
                        userChoice = 2;
                        break;
                    case "Г":
                        userChoice = 3;
                        break;
                    default:
                        Console.WriteLine("Неправильно введене значення. Будь ласка, введіть А, Б, В або Г.");
                        break;
                }

                if (userChoice == answers[questionIndex])
                {
                    Console.WriteLine("Правильно!");
                    score++;
                }
                else
                {
                    Console.WriteLine("Неправильно.");
                }

                Console.WriteLine();
            }

            Console.WriteLine($"Ваша остаточна оцінка - {score} з {questions.Length}");

            Console.ReadLine();
        }
    }

}
