using Microsoft.EntityFrameworkCore;
using System;
using System.Collections;
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
using WpfApp1.Models;
using static MaterialDesignThemes.Wpf.Theme;

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для Flat.xaml
    /// </summary>
    public partial class Flat : Window
    {
        public Flat()
        {
            InitializeComponent();
            WindowState = WindowState.Maximized;
            WindowStyle = WindowStyle.None;

            SssContext d = new SssContext();
            userList.ItemsSource = d.Roomims.ToList();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            var personalAccountWindow = new MainWindow();
            MainWindow mainWindow = new MainWindow();
            personalAccountWindow.Show();
            this.Close();


        }
        private void Poisk()
        {
            SssContext d = new SssContext();
            if (Convert.ToInt32(poiskKvadrantmetr.Text != null) != 0 && Convert.ToInt32(poiskKvadrantmetr.Text != null) != 0 && Convert.ToInt32(poiskPrice.Text != null) != 0 && Convert.ToInt32(poiskFloot.Text != null) != 0 && Convert.ToInt32(poiskAtag.Text != null) != 0)
            {
                userList.ItemsSource = d.Roomims
                    .Where(item => item.Metr == poiskKvadrantmetr.Text || item.Metr.Contains(poiskKvadrantmetr.Text)
                    && item.Price.Contains(poiskPrice.Text)
                    && item.FlootKom.Contains(poiskFloot.Text) && item.Ittag.Contains(poiskAtag.Text)).ToList();
            }

        }

        private void poiskPrice_TextChanged(object sender, TextChangedEventArgs e)
        {
            SssContext d = new SssContext();

            /*userList.ItemsSource = d.Roomims.Where(item => item.Price.Contains(poiskPrice.Text)).ToList();*/
            Poisk();
        }

        private void poiskKvadrantmetr_TextChanged(object sender, TextChangedEventArgs e)
        {
            SssContext d = new SssContext();

            /*userList.ItemsSource = d.Roomims.Where(item => item.Metr == poiskKvadrantmetr.Text || item.Metr.Contains(poiskKvadrantmetr.Text)).ToList();*/
            Poisk();
        }

        private void poiskFloot_TextChanged(object sender, TextChangedEventArgs e)
        {
            SssContext d = new SssContext();

            /*userList.ItemsSource = d.Roomims.Where(item => item.FlootKom.Contains(poiskFloot.Text)).ToList();*/
            Poisk();
        }

        private void poiskAtag_TextChanged(object sender, TextChangedEventArgs e)
        {
            SssContext d = new SssContext();

            /*userList.ItemsSource = d.Roomims.Where(item => item.Ittag.Contains(poiskAtag.Text)).ToList();*/
            Poisk();
        }

        private void userList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void BtnYourButton_Click(object sender, RoutedEventArgs e)
        {
            SssContext d = new SssContext();
            userList.ItemsSource = d.Roomims.ToList();
        }

        private void button_Click_3(object sender, RoutedEventArgs e)
        {

        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {

        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            Prosmotr mainWindow = new Prosmotr();
            mainWindow.Show();
            this.Close();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            SssContext d = new SssContext();             
            var item = userList.SelectedItem as Roomim;
            int rezult = Convert.ToInt32(MessageBox.Show($"Вы точно хотите удалить {item}объект?", "NO", MessageBoxButton.YesNo));
            if (rezult == Convert.ToInt32(MessageBoxResult.Yes))
            {              
                d.Roomims.Remove(item);
                d.SaveChanges();
                MessageBox.Show("Все хорошо");
            }
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            AddFloot addFloot = new AddFloot(); 
            addFloot.Show();

        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
           /* SssContext d = new SssContext();
            var item = userList.SelectedItem as Roomim;
            Prosmotr prosm = new Prosmotr(item);
            prosm.Show();
            this.Close();*/
        }
    }
}
