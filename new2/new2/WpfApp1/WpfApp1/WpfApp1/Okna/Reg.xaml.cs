using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Diagnostics;
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
using static System.Net.Mime.MediaTypeNames;

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для Reg.xaml
    /// </summary>
    public partial class Reg : Window
    {
        public Reg()
        {
            InitializeComponent();
        }

        private void reg_Click(object sender, RoutedEventArgs e)
        {
            SssContext db = new SssContext();
            string login = textBox_login.Text;
            string pass = password.Password;

            Regestrat us = new Regestrat { Login = login, Password = pass };

            if (login.Length < 4 || login.Length > 20 || !Regex.IsMatch(login, "^[a-zA-Z0-9_.-]*$"))
            {
                textBox_login.ToolTip = "Логин должен содержать только буквы английского алфавита, цифры и символы '_', '-', '.' и быть длиной от 4 до 20 символов"; textBox_login.Background = Brushes.White;
                MessageBox.Show("Неподходящий логин");
            }

            else if (!Regex.IsMatch(password.Password, @"^(?=.*[0-9])(?=.*[a-zA-Z])[a-zA-Z0-9]{6,}$"))
            {
                password.ToolTip = "Пароль должен содержать только буквы английского алфавита, хотя бы одну цифру и не менее 6 символов";
                password.Background = Brushes.White;
                MessageBox.Show("Неподходящий пароль");

            }

            else if (password.Password != password_Copy.Password)
            {
                password_Copy.ToolTip = "Пароли не совпадают";
                password_Copy.Background = Brushes.White;
                MessageBox.Show("Пароли не совпадают");
            }

            else
            {

                MessageBox.Show("Вы зарегестрировались");
                db.Regestrats.Add(us);
                db.SaveChanges();
            }
        }

        private void back_Click(object sender, RoutedEventArgs e)
        {
            Vhod vhod = new Vhod();
            vhod.Show();
            this.Close();
        }
    }
}
