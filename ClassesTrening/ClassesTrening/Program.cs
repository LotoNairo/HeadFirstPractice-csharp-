
using System;
namespace ClassesTrening
{
    class Program
    {
        static void Main(string[] args)
        {
            Elephant lucinda = new Elephant { Name = "Lucinda", EarSize = 33 };
            Elephant lloyd = new Elephant { Name = "Lloyd", EarSize = 40 };
            Console.Write("Press 1 for Lloyd, 2 for Lucinda, 3 for swap : ");
            while (true) 
            {
                if (int.TryParse(Console.ReadLine(), out int choise))
                {
                    if (choise == 1) lloyd.WhoAmI();
                    if (choise == 2) lucinda.WhoAmI();
                    if (choise == 3)
                    {
                        Elephant holder;
                        holder = lucinda;
                        lucinda = lloyd;
                        lloyd = holder;
                    }
                    if (choise == 4) 
                    { 
                        lloyd = lucinda;
                        lloyd.EarSize = 4321;
                        lloyd.WhoAmI();
                    }
                    if (choise == 5)
                    {
                        lucinda.SpeakTo(lloyd,"Hi, Lloid!");
                    }
                }
                else Console.WriteLine("Plese enter right number..");
            }
        }
    }
}
