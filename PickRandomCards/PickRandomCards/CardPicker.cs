using System;
using System.Collections.Generic;
using System.Text;

namespace PickRandomCards
{
    class CardPicker
    {
        static Random random = new Random();
        public static string[] PickSomeCards(int numberOfCards) 
        {
            string[] PickedCards = new string[numberOfCards];
            for (int i = 0; i < numberOfCards; i++) 
            {
                PickedCards[i] = RandomValue() + "of" + RandomSuit();
            }
            return PickedCards;
        }

        private static string RandomSuit()
        {

            int value = random.Next(1, 5);// Возвращает случаенйное число от одного до 4
            if (value == 1) return "Spades";
            if (value == 2) return "Hearts";
            if (value == 3) return "Clubs";
            return "Diamonds";

        }

        private static string RandomValue()
        {
            int value = random.Next(1, 14);
            if (value == 1) return "Ace";
            if (value == 11) return "Jack";
            if (value == 12) return "Queen";
            if (value == 13) return "King";
            return value.ToString();
        }
    }
}
