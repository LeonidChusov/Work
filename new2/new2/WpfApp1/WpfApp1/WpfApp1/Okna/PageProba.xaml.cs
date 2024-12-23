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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для PageProba.xaml
    /// </summary>
    public partial class PageProba : Window
    {
        public PageProba()
        {
            InitializeComponent();
        }

        private bool IsToggle;

        private void btn_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();
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
            UserBaza userBaza = new UserBaza();
            userBaza.Show();
        }
    }
}
