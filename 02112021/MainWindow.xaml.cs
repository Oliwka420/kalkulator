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

namespace _02112021
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
        float x;
        string dzialanie;
        private void siedem_Click(object sender, RoutedEventArgs e)
        {
            pelne.Content += "7";
        }

        private void osiem_Click(object sender, RoutedEventArgs e)
        {
            pelne.Content += "8";
        }

        private void dziewiec_Click(object sender, RoutedEventArgs e)
        {
            pelne.Content += "9";
        }

        private void cztery_Click(object sender, RoutedEventArgs e)
        {
            pelne.Content += "4";
        }

        private void piec_Click(object sender, RoutedEventArgs e)
        {
            pelne.Content += "5";
        }

        private void szesc_Click(object sender, RoutedEventArgs e)
        {
            pelne.Content += "6";
        }

        private void jeden_Click(object sender, RoutedEventArgs e)
        {
            pelne.Content += "1";
        }

        private void dwa_Click(object sender, RoutedEventArgs e)
        {
            pelne.Content += "2";
        }

        private void trzy_Click(object sender, RoutedEventArgs e)
        {
            pelne.Content += "3";
        }

        private void zeratrzy_Click(object sender, RoutedEventArgs e)
        {
            pelne.Content += "000";
        }

        private void zero_Click(object sender, RoutedEventArgs e)
        {
            pelne.Content += "0";
        }

        private void clear_Click(object sender, RoutedEventArgs e)
        {
            pelne.Content = "";
        }

        private void plus_Click(object sender, RoutedEventArgs e)
        {
            x = (float)pelne.Content;
            dzialanie = "dodaj";
            pelne.Content = "";
        }

        private void minus_Click(object sender, RoutedEventArgs e)
        {
            x = (float)pelne.Content;
            dzialanie = "odejmij";
            pelne.Content = "";
        }

        private void dziel_Click(object sender, RoutedEventArgs e)
        {
            x = float.Parse(pelne.Content.ToString());
            dzialanie = "podziel";
            pelne.Content = "";
        }

        private void moz_Click(object sender, RoutedEventArgs e)
        {
            x = (float)pelne.Content;
            dzialanie = "pomnoz";
            pelne.Content = "";
        }
        float wynik;
        private void rowna_sie_Click(object sender, RoutedEventArgs e)
        {
            string drugaliczba = (string)pelne.Content;
            x = (float)x;
            switch (dzialanie)
            {
                case "podziel":
                    wynik = x / float.Parse(drugaliczba);
                    break;
                case "dodaj":
                    wynik = x + float.Parse(drugaliczba);
                    break;
                case "pomnoz":
                    wynik = x * float.Parse(drugaliczba);
                    break;
                case "odejmij":
                    wynik = x - float.Parse(drugaliczba);
                    break;
                default: pelne.Content = "jakis problem";
                    break;
            }
           
            pelne.Content = wynik;        }

        private void przecinek_Click(object sender, RoutedEventArgs e)
        {
            pelne.Content += ",";
        }
    }
}
