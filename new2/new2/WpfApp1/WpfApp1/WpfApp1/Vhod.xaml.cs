using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
    /// Логика взаимодействия для Vhod.xaml
    /// </summary>
    public partial class Vhod : Window
    {
        public Vhod()
        {
            InitializeComponent();
        }

        private void RegistBT_Click(object sender, RoutedEventArgs e)
        {
            Reg reg = new Reg();
            reg.Show();
            this.Close();
        }

        private void EnterBT_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }

        private void regin_Click(object sender, RoutedEventArgs e)
        {
            Reg reg = new Reg();
            reg.Show();
            this.Close();
        }

        private void enter_Click(object sender, RoutedEventArgs e)
        {
            string login = textBox_login.Text;
            string pass = password.Password;

            /*MainWindow service = new MainWindow();
            service.Show();
            Close();*/

            //проверка логина
            if (login.Length < 4 || login.Length > 20 || !Regex.IsMatch(login, "^[a-zA-Z0-9_.-]*$"))
            {
                textBox_login.ToolTip = "Логин должен содержать только буквы английского алфавита, цифры и символы '_', '-', '.' и быть длиной от 4 до 20 символов";
                textBox_login.Background = Brushes.White;
                MessageBox.Show("Не правильный логин или пароль");
            }

            // проверки пароля
            else if (!Regex.IsMatch(password.Password, @"^(?=.*[0-9])(?=.*[a-zA-Z])[a-zA-Z0-9]{6,}$"))
            {
                password.ToolTip = "Пароль должен содержать только буквы английского алфавита, хотя бы одну цифру и не менее 6 символов";
                password.Background = Brushes.White;
                MessageBox.Show("Не правильный логин или пароль");
            }

            else
            {
                Regestrat authUser = null;
                using (SssContext db = new SssContext())
                {
                    authUser = db.Regestrats.Where(b => b.Login == login && b.Password == pass).FirstOrDefault();
                }
                if (authUser != null)
                {
                    Regestrat.Current = new Regestrat
                    {
                        Login = textBox_login.Text

                    };
                    var MainWwin = new MainWindow();
                    //personalAccountWindow.ShowDialog();
                    MessageBox.Show("Пользователь авторизовался");

                    MainWindow services = new MainWindow();
                    services.Show();
                    Close();
                }

                else
                {
                    MessageBox.Show("Вы вввели что-то неккоректно либо такого пользователя нет");
                }






            }
        }
    }
}
