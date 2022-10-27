using System;

namespace ClassRandom
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int randomInt = random.Next();
            Console.WriteLine(randomInt);
            int zroToNine = random.Next(10);
            Console.WriteLine(zroToNine);
            int daeRoll = random.Next(7);
            Console.WriteLine(daeRoll);
            double randomDouble = random.NextDouble();
            Console.WriteLine(randomDouble);
            Console.WriteLine(randomDouble * 100);
            Console.WriteLine((float)randomDouble*100F);
            Console.WriteLine((decimal)randomDouble*100M);
            int zeroOrOne = random.Next(2);
            bool coinFlip = Convert.ToBoolean(zeroOrOne);
            Console.WriteLine(zeroOrOne);
            Console.WriteLine(coinFlip);
        }
    }
}
