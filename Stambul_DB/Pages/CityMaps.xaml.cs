using System;
using System.Collections.Generic;
using System.IO;
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
using Microsoft.Win32;
using Stambul_DB.db;
using Stambul_DB.Pages;

namespace Stambul_DB.Pages
{
    /// <summary>
    /// Логика взаимодействия для CityMaps.xaml
    /// </summary>
    public partial class CityMaps : Window
    {

        public static Istanbul_urban_dbEntities dbEntities = new Istanbul_urban_dbEntities();
        public CityMaps()
        {
            InitializeComponent();
            dbEntities = new Istanbul_urban_dbEntities();

            City_Maps.ItemsSource = dbEntities.City_Maps.ToList();
        }

        private void ButtonAdd(object sender, RoutedEventArgs e)
        {
            var q = City_Maps.SelectedItem as City_Maps;
            if (q == null)
            {
                MessageBox.Show("Эта строка пуста.");
                return;
            }
            MessageBoxResult result = MessageBox.Show("Вы действительно хотите сохранить?", "Сохранить?", MessageBoxButton.YesNoCancel);
            if (result == MessageBoxResult.Yes)
            {
                try
                {
                    dbEntities.City_Maps.Add(q);
                    dbEntities.SaveChanges();
                    City_Maps.ItemsSource = dbEntities.City_Maps.ToList();
                }
                catch
                {
                    MessageBox.Show("Удалите соединения связанные с этим данным или таких данных нет");
                }

            }
        }

        private void ButtonDel(object sender, RoutedEventArgs e)
        {
            var q = City_Maps.SelectedItem as City_Maps;
            if (q == null)
            {
                MessageBox.Show("Эта строка и так пустая.");
                return;
            }
            MessageBoxResult result = MessageBox.Show("Вы действительно хотите удалить строку?", "Удалить?", MessageBoxButton.YesNoCancel);
            if (result == MessageBoxResult.Yes)
            {
                try
                {
                    dbEntities.City_Maps.Remove(q);
                    dbEntities.SaveChanges();
                    City_Maps.ItemsSource = dbEntities.City_Maps.ToList();
                }
                catch
                {
                    MessageBox.Show("Удалите соединения связанные с этим данным");
                }

            }

        }


        private void Back_Click(object sender, RoutedEventArgs e)
        {
            Redirection r = new Redirection();
            this.Close();
            r.Show();
        }

        private void Add_I_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog ofdImage = new OpenFileDialog();
            ofdImage.Filter = "Image files|*.bmp;*.jpg;*.png|All files|*.*";
            ofdImage.FilterIndex = 1;
            if (ofdImage.ShowDialog() == true)
            {
                BitmapImage image = new BitmapImage();
                image.BeginInit();
                image.UriSource = new Uri(ofdImage.FileName);
                image.EndInit();
                City_Maps cm = new City_Maps();
                playim.Source = image;
                cm.Image_CM = File.ReadAllBytes(ofdImage.FileName);
                dbEntities.City_Maps.Add(cm);
                dbEntities.SaveChanges();
            }
        }

    }
}
