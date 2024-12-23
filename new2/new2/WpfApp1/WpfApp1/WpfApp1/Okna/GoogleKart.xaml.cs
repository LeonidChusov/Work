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
using GMap.NET;
using GMap.NET.MapProviders;

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для GoogleKart.xaml
    /// </summary>
    public partial class GoogleKart : Window
    {
        public GoogleKart()
        {
            InitializeComponent();
            InitializeMap();
        }
        private void InitializeMap()
        {
            // Установите провайдер карт
            gmapControl.MapProvider = GMapProviders.GoogleMap;
            // Установите начальное положение и зум
            gmapControl.Position = new PointLatLng(56.8439, 60.6524); // Нью-Йорк
            gmapControl.MinZoom = 2;
            gmapControl.MaxZoom = 17;
            gmapControl.Zoom = 10;
            /*// Включите отображение слоев и другие параметры
            gmapControl.DragButton = System.Windows.Forms.MouseButtons.Left;
            gmapControl.ShowCenter = false;*/

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mai = new MainWindow();
            mai.Show();
            this.Close();
        }
    }
}
