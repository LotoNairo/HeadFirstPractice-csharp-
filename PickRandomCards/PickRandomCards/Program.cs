using System;

namespace PickRandomCards
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of cards to pick: ");
            string line = Console.ReadLine();
            //Если строка может быть преобразована в int то итог преобразования сохранаяетмя в переменной numderOfCards
            if (int.TryParse(line, out int numberOfCards))
            {
                foreach (string card in CardPicker.PickSomeCards(numberOfCards))
                {
                    Console.WriteLine(card);
                }
            }
            else 
            {
                Console.WriteLine("Please inter a valid numder.");
            }
        }
    }
}
