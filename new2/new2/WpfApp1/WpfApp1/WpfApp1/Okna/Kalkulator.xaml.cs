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
using System.Windows.Shapes;
using static MaterialDesignThemes.Wpf.Theme;

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для Kalkulator.xaml
    /// </summary>
    public partial class Kalkulator : Window
    {
        public Kalkulator()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ulong summa = Convert.ToUInt64(sum.Text);
            ushort srok = Convert.ToUInt16(sroki.Text);
            double stavka = Convert.ToDouble(stavkaki.Text);
            double plata = (summa + summa * stavka * srok / 100) / (srok * 12);
            platatka.Text = "" + Math.Round(plata, 2);
            MessageBox.Show("Неподходящие данные");

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();
            this.Close();
        }
    }
}
