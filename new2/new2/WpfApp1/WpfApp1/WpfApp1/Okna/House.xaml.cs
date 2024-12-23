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
using System.Net.Http;
using Newtonsoft.Json;
using static WpfApp1.House;


namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для House.xaml
    /// </summary>
    public partial class House : Window
    {
        private readonly ApiService _apiService;

        public House()
        {
            InitializeComponent();
            _apiService = new ApiService();
        }

        private async void Button_Click_1(object sender, RoutedEventArgs e)
        {
           
                List<User> users = await _apiService.GetUsersAsync();
                UserListBox.ItemsSource = users;
            UserListBox2.ItemsSource = users;
            UserListBox3.ItemsSource = users;


        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();
            main.Show();
            this.Close();
        }

        private void UserListBox3_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
