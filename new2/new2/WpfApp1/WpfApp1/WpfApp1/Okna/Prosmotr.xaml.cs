using GSF;
using System;
using System.Collections.Generic;
using System.Diagnostics;
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
using System.Windows.Media.Media3D;
using System.Windows.Shapes;
using WpfApp1.Models;


namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для Prosmotr.xaml
    /// </summary>
    public partial class Prosmotr : Window
    {
        public Prosmotr()
        {
            InitializeComponent();
            WindowState = WindowState.Maximized;
            WindowStyle = WindowStyle.None;

            /*SssContext d = new SssContext();
            Live.ItemsSource = d.Roomims.ToList();*/

            SssContext db = new SssContext();
            Roomim lastService = db.Roomims.OrderByDescending(s => s.Id).FirstOrDefault();
            Live.ItemsSource = new List<Roomim> { lastService };
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            Process.Start(new ProcessStartInfo("C:\\Users\\Лёня\\Desktop\\new2\\new2\\WpfApp1\\WpfApp1\\presentation1.docx") { UseShellExecute = true });

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Flat flat = new Flat();
            flat.Show();
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Process.Start(new ProcessStartInfo("https://yandex.ru/maps/29397/berezovskyi/house/sovetskaya_ulitsa_107/YkkYcQ5nSEAFQFtsfXR4dHtqZQ==/?ll=60.797152%2C56.895792&z=16.69") { UseShellExecute = true });
        }
    }
}
