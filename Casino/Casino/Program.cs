using System;

namespace Casino
{
    class Program
    {
        public static void Main(string[] args)
        {
            Random random = new Random();
            double odds = 0.75;
            Guy player = new Guy() { Name = "ThePlayer", Cash = 100 };
            Console.WriteLine("Welcome to the casino. The odds are "+odds);
            while (player.Cash != 0) 
            {
                player.WriteMyInfo();
                Console.Write("How mach do you wont to bet : ");
                string howMach = Console.ReadLine();
                if(int.TryParse(howMach, out int amount)) 
                {
                    int pot = amount;
                    if (random.NextDouble() > odds) 
                    {
                        pot *= 2;
                        Console.WriteLine("You win "+pot);
                        player.ReceiveCash(pot);
                    }
                    else 
                    {
                        Console.WriteLine("Bad luck, you lose.");
                        player.GiveCash(pot);
                    }
                }
                
            }
            Console.WriteLine("The Casino always win.");
        }
    }
}
