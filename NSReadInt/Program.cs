using System;

namespace NSReadInt
{
    internal class Program
    {
        static void Main(string[] args)
        {           
            Console.WriteLine($"Ввод успешно конвертирован в число: {GetUserNumber()}.");
            Console.ReadKey();
        }

        private static int GetUserNumber()
        {
            int number;
            string userInput;

            do
            {
                Console.Clear();
                Console.WriteLine("Введите число: ");
                userInput = Console.ReadLine();
            }
            while (int.TryParse(userInput, out number) == false);

            return number;
        }
    }
}