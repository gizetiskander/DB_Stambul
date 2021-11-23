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
using Stambul_DB.db;
using Stambul_DB.Pages;

namespace Stambul_DB.Pages
{
    /// <summary>
    /// Логика взаимодействия для CityGrowth.xaml
    /// </summary>
    public partial class CityGrowth : Window
    {
        public static Istanbul_urban_dbEntities dbEntities = new Istanbul_urban_dbEntities();
        public CityGrowth()
        {
            InitializeComponent();
            dbEntities = new Istanbul_urban_dbEntities();

            City_Growth.ItemsSource = dbEntities.City_Growth.ToList();
        }
        private void ButtonAdd(object sender, RoutedEventArgs e)
        {

            var q = City_Growth.SelectedItem as City_Growth;
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
                    dbEntities.City_Growth.Add(q);
                    dbEntities.SaveChanges();
                    City_Growth.ItemsSource = dbEntities.City_Growth.ToList();
                }
                catch
                {
                    MessageBox.Show("Удалите соединения связанные с этим данным или таких данных нет");
                }

            }
        }

        private void ButtonDel(object sender, RoutedEventArgs e)
        {
            var q = City_Growth.SelectedItem as City_Growth;
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
                    dbEntities.City_Growth.Remove(q);
                    dbEntities.SaveChanges();
                    City_Growth.ItemsSource = dbEntities.City_Growth.ToList();
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
    }
}
