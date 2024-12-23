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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            WindowState = WindowState.Maximized;
            WindowStyle = WindowStyle.None;
        }

        private void SorsComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            UserBaza userBaza = new UserBaza();
            userBaza.Show();
        }

        private void Button_Clickl(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void Giloy_Click(object sender, RoutedEventArgs e)
        {
            House house = new House();
            house.Show();
            this.Close();
        }

        private void Giloy2_Click(object sender, RoutedEventArgs e)
        {
            Flat flat = new Flat();
            flat.Show();
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            InfoClients infoClients = new InfoClients();
            infoClients.Show();
            this.Close();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Kalkulator kalkulator = new Kalkulator();
            kalkulator.Show();

        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            PageProba pageProba = new PageProba();
            pageProba.Show();
            this.Close();
        }

        private void Giloy22_Click(object sender, RoutedEventArgs e)
        {
            GoogleKart gog = new GoogleKart();
            gog.Show();
            this.Close();
        }
    }
}
