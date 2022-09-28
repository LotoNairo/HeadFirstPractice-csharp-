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

namespace ExprtimentWithControls
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void numberTextBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            // Пропучкает только числа для TextBox и ComboBox
            e.Handled = !int.TryParse(e.Text, out int result);
        }

        private void numberTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            number.Text = numberTextBox.Text;
        }

        private void smallSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            //Значение элемента слайдер изначально дробное, ToSrting("0") приведёт его в начале в целое, а потом в строку.
            number.Text = smallSlider.Value.ToString("0");
        }

        private void bigSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            //Придаем вид телефонного номера
            number.Text = bigSlider.Value.ToString("000-000-0000");
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            if (sender is RadioButton radioButton) 
            {
                number.Text = radioButton.Content.ToString();
            }
        }

        private void myListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //Срабатывает при изменении  выбранного элемента в списке
            if (myListBox.SelectedItem is ListBoxItem listBoxItem) 
            {
                number.Text = listBoxItem.Content.ToString();
            }
        }

        private void editableComboBox_TextChanged(object sender, TextChangedEventArgs e)
        {

            if (sender is ComboBox comboBox) 
            {
                number.Text = comboBox.Text;
            }
        }
    }
}
