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
using System.Windows.Shapes;
using WpfApp1.Models;

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для AddFloot.xaml
    /// </summary>
    public partial class AddFloot : Window
    {
        public AddFloot()
        {
            InitializeComponent();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Неподходящие данные");

            /*SssContext d =  new SssContext();
            string imag = imagText.Text.Trim().ToLower();
            string price = priceimagText.Text.Trim().ToLower();
            string komn = komnimagText.Text.Trim().ToLower();
            string metr = metreimagText.Text.Trim().ToLower();
            string itag = itaggimagText.Text.Trim().ToLower();
            string adress = adresimagText.Text.Trim().ToLower();
            string micro = microText.Text.Trim();
            string remoont = remontText.Text.Trim();
            string srok = srokVlText.Text.Trim();
            string opiss = opisText.Text.Trim();



            Roomim rezult = new Roomim { Imagge = imag, Price = price, FlootKom = komn, Metr = metr, Ittag = itag, Adreess = adress, MictoRoiin = micro, Remont = remoont, SrokVladenia= srok, Opisaninie = opiss };

            try
            {
                d.Roomims.Add(rezult);
                d.SaveChanges();
                MessageBox.Show("Все хорошо");
            }
            catch
            {
                MessageBox.Show("Ошибка при сохранение", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }*/
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            AddFloot addFloot = new AddFloot();
            this.Close();
        }
    }
}
