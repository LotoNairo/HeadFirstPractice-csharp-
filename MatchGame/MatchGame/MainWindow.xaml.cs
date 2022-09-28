//                                            Улучшения
// 1) Эмодзи скрыты и раскрываются при нажатии(при неудачной попытке снова скрываются)
// 2) Лучший результат (В отдельном файле)
// 3) Обратный отсчет
// 4) Количество неудачных попыток (при выборе двух разных эмодзи)
// 5) Больше живиоьных
// 6)
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

namespace MatchGame
{
    using System.Windows.Threading;
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //                               Внешние переменные                                  
        DispatcherTimer timer = new DispatcherTimer();
        int tenthsOfSecondsElapsed;
        int matchesFound;
        TextBlock LastTextBlockClicked;
        bool findingMatch = false;


        //                                     main ?
        public MainWindow()
        {
            InitializeComponent();
            timer.Interval = TimeSpan.FromSeconds(.1);
            timer.Tick += Timer_Tick;
            SetUpGame();
        }

       




        //                                  Запуск и сброс игры 
        private void SetUpGame()
        {
            List<string> animalEmoji = new List<string>()
            {
               "🦊","🦊",
               "🐵","🐵",
               "🦝","🦝",
               "🦓","🦓",
               "🐷","🐷",
               "🐻","🐻",
               "🐼","🐼",
               "🐸","🐸",
            };
            Random random = new Random();
            foreach (TextBlock textBlock in mainGrid.Children.OfType<TextBlock>()) 
            {
                if (textBlock.Name != "timeTextBlock")
                {
                    int index = random.Next(animalEmoji.Count);
                    string nextEmoji = animalEmoji[index];
                    textBlock.Text = nextEmoji;
                    animalEmoji.RemoveAt(index);
                }
            }

            //               Запуск таймера и сброс содержимого полей
            timer.Start();
            tenthsOfSecondsElapsed = 0;
            matchesFound = 0;
        }



        //                              Обработчик нажатия на картинки 
        private void TextBlock_MouseDown(object sender, MouseButtonEventArgs e)
        {
            TextBlock textBlock = sender as TextBlock;
            if (findingMatch == false)
            {
                textBlock.Visibility = Visibility.Hidden;
                LastTextBlockClicked = textBlock;
                findingMatch = true;
            }
            else if (textBlock.Text == LastTextBlockClicked.Text)
            {
                matchesFound++; //Увеличивает количество найденных пар для остановки таймера при 8
                textBlock.Visibility = Visibility.Hidden;
                findingMatch = false;
            }
            else 
            {
                LastTextBlockClicked.Visibility = Visibility.Visible;
                findingMatch = false;
            }
        }





        //                    Перезапуск игры при нажатии на таймер(Если найдены все пары)
        private void TimeTextBlock_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (matchesFound == 8) 
            {
                SetUpGame();
            }
        }




        //                                          Таймер
        private void Timer_Tick(object sender, EventArgs e)
        {
            tenthsOfSecondsElapsed++;
            timeTextBlock.Text = (tenthsOfSecondsElapsed / 10F).ToString("0.0s");
            if (matchesFound == 8)
            {
                timer.Stop();
                timeTextBlock.Text = timeTextBlock.Text + " - Play again?";
            }
        }
    }
}