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
    /// Логика взаимодействия для SpacesOfEverydayLife.xaml
    /// </summary>
    public partial class SpacesOfEverydayLife : Window
    {
        public static Istanbul_urban_dbEntities dbEntities = new Istanbul_urban_dbEntities();
        public SpacesOfEverydayLife()
        {
            InitializeComponent();
            dbEntities = new Istanbul_urban_dbEntities();

            Spaces_Of_Everyday_Life.ItemsSource = dbEntities.Spaces_of_Everyday_Life.ToList();
        }

        private void ButtonAdd(object sender, RoutedEventArgs e)
        {

            var q = Spaces_Of_Everyday_Life.SelectedItem as Spaces_of_Everyday_Life;
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
                    dbEntities.Spaces_of_Everyday_Life.Add(q);
                    dbEntities.SaveChanges();
                    Spaces_Of_Everyday_Life.ItemsSource = dbEntities.Spaces_of_Everyday_Life.ToList();
                }
                catch
                {
                    MessageBox.Show("Удалите соединения связанные с этим данным или таких данных нет");
                }

            }
        }

        private void ButtonDel(object sender, RoutedEventArgs e)
        {
            var q = Spaces_Of_Everyday_Life.SelectedItem as Spaces_of_Everyday_Life;
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
                    dbEntities.Spaces_of_Everyday_Life.Remove(q);
                    dbEntities.SaveChanges();
                    Spaces_Of_Everyday_Life.ItemsSource = dbEntities.Spaces_of_Everyday_Life.ToList();
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
