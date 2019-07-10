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

namespace View
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

        private void convertFahrenheit(object sender, RoutedEventArgs e)
        {
            var fahrenheit = double.Parse(fahrenheitTextBox.Text);
            var celsius = (fahrenheit - 32) / 1.8;
            celsiusTextBox.Text = celsius.ToString();
            var kelvin = (fahrenheit + 459.67) / 1.8;
            kelvinTextBox.Text = kelvin.ToString();
        }

        private void convertCelsius(object sender, RoutedEventArgs e)
        {
            var celsius = double.Parse(celsiusTextBox.Text);
            var fahrenheit = celsius * 1.8 + 32;
            fahrenheitTextBox.Text = fahrenheit.ToString();
            var kelvin = celsius + 273.15;
            kelvinTextBox.Text = kelvin.ToString();
        }
        private void convertKelvin(object sender, RoutedEventArgs e)
        {
            var kelvin = double.Parse(kelvinTextBox.Text);
            var celsius = kelvin - 273.15;
            celsiusTextBox.Text = celsius.ToString();
            var fahrenheit = (kelvin * 1.8) - 459.67;
            fahrenheitTextBox.Text = fahrenheit.ToString();
        }
    }
}
