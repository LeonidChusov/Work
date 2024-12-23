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
    /// Логика взаимодействия для InfoClients.xaml
    /// </summary>
    public partial class InfoClients : Window
    {
        public InfoClients()
        {
            InitializeComponent();
            WindowState = WindowState.Maximized;
            WindowStyle = WindowStyle.None; //Делает окно на весь экран
            SssContext d = new SssContext(); //Добовление базы данных

            userList2.ItemsSource = d.Userssses.ToList(); //Определенный класс из базы данных
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            SssContext d = new SssContext();
            var item = userList2.SelectedItem as Usersss;
            int rezult = Convert.ToInt32(MessageBox.Show($"Вы точно хотите удалить {item}объект?", "NO", MessageBoxButton.YesNo));
            if (rezult == Convert.ToInt32(MessageBoxResult.Yes))
            {
                if(item != null)
                {
                    d.Userssses.Remove(item);
                    d.SaveChanges();
                    MessageBox.Show("Удалено, обновите");
                }
                else
                {
                    MessageBox.Show("Ошибка");
                }
                
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }

        private void userList2_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
