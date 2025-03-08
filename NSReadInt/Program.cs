using System;

namespace NSReadInt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GetUserNumber(out int number);
            Console.WriteLine($"Ввод успешно конвертирован в число: {number}.");
            Console.ReadKey();
        }

        private static int GetUserNumber(out int number)
        {
            bool isWork = true;
            number = 0;

            while (isWork)
            {
                Console.WriteLine("Введите число: ");
                string userInput = Console.ReadLine();

                if (int.TryParse(userInput, out int result))
                {
                    Console.WriteLine("Успешно.");
                    number = result;
                    isWork = false;
                }
                else
                {
                    Console.WriteLine("Это не число, попробуйте ещё раз...");
                }

                Console.ReadKey();
                Console.Clear();
            }

            return number;
        }
    }
}