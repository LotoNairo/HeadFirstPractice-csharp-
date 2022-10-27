using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Menu
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            MakeTheMenue();
        }

        private void MakeTheMenue()
        {
            MenuItem[] menuItems = new MenuItem[5];
            string guacamolePrise;


            for (int i=0;i<5;i++) 
            {
                menuItems[i] = new MenuItem();
                if (i >= 3) 
                {
                    menuItems[i].Breads = new string[] {"plain bagel","onion bagel",
                        "pampernickel bagel","everything bagel" };
                }
                menuItems[i].GenerateMenuItem();
            }


            item1.Text = menuItems[0].Description;
            prise1.Text = menuItems[0].Prise;
            item2.Text = menuItems[1].Description;
            prise2.Text = menuItems[1].Prise;
            item3.Text = menuItems[2].Description;
            prise3.Text = menuItems[2].Prise;
            item4.Text = menuItems[3].Description;
            prise4.Text = menuItems[3].Prise;
            item5.Text = menuItems[4].Description;
            prise5.Text = menuItems[4].Prise;

            MenuItem specialMenuItem = new MenuItem()
            {
                Proteins= new string[] {"Organic Ham","Mashroom patty","Mortadella"},
                Breads= new string[] {"a gluten free roll","a warp","pita"},
                Condiments=new string[] {"dijon mustard","miso dressing","au jus"}
            };
            specialMenuItem.GenerateMenuItem();

            item6.Text = specialMenuItem.Description;
            prise6.Text = specialMenuItem.Prise;

            MenuItem guacamoleMenuItem = new MenuItem();
            guacamoleMenuItem.GenerateMenuItem();
            guacamolePrise = guacamoleMenuItem.Prise;
            guacamole.Text = "Add guacamole for " + guacamoleMenuItem.Prise;
        }
    }
}
