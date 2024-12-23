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
    /// Логика взаимодействия для UserBaza.xaml
    /// </summary>
    public partial class UserBaza : Window
    {
        SssContext db = new SssContext();
        public UserBaza()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            this.Close();
            
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
           
            string fio = fioText.Text.Trim().ToLower();
            string datar = datarogdText.Text.Trim().ToLower();
            string sernom = seriaText.Text.Trim().ToLower();
            string kemvid = kemvidanText.Text.Trim().ToLower();
            string adresreg = adresregText.Text.Trim().ToLower();
            string adressnew = adresnewText.Text.Trim().ToLower();
            string tel = telefonText.Text.Trim().ToLower();
            /*string fio = imagessText.ImageFailed;*/

            Usersss rezult = new Usersss { Fio = fio, Datarogden = datar, SreiaNomer = sernom, KemVidan = kemvid, AdressReg = adresreg, AdresNew = adressnew, NomerTelefon = tel };

            try
            {
                db.Userssses.Add(rezult);
                db.SaveChanges();
                MessageBox.Show("Все хорошо");
            }
            catch
            {
                MessageBox.Show("Ошибка при сохранение", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
