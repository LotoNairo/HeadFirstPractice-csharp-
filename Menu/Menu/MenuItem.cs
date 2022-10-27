using System;
using System.Collections.Generic;
using System.Text;

namespace Menu
{
    class MenuItem
    {
        public Random Randomaizer = new Random();
        public string[] Proteins = { "Roast Beef", "Salami", "Turkey", "Ham", "Pastrami", "Tofu" };
        public string[] Condiments = { "yellow mustard", "brown nestard","honey mustard",
            "mayo","relish","french dressing" };
        public string[] Breads = { "rye", "wite", "wheat", "pumpernickel", "a roll" };
        public string Description = "";
        public string Prise;
        public void GenerateMenuItem()
        {
            string RandomProtein = Proteins[Randomaizer.Next(Proteins.Length)];
            string RandomCondiments = Condiments[Randomaizer.Next(Condiments.Length)];
            string RandomBread = Breads[Randomaizer.Next(Breads.Length)];
            Description = RandomProtein + " with " + RandomCondiments + " on " + RandomBread;
            decimal bucks = Randomaizer.Next(2, 5);
            decimal cents = Randomaizer.Next(1, 98);
            decimal prise = bucks + (cents * .01M);
            //Параметр "c" приказывает ToString отформатировать значение с локальной денежной единицей (К примеру $)
            Prise = prise.ToString("c");
        }
    }
}
