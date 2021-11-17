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
using System.Windows.Navigation;
using System.Windows.Shapes;
using Stambul_DB.db;

namespace Stambul_DB.Pages
{

    /// <summary>
    /// Логика взаимодействия для IstanbulDB.xaml
    /// </summary>
    public partial class IstanbulDB : Window
    {
        public static Istanbul_urban_dbEntities dbEntities = new Istanbul_urban_dbEntities();
        public static User authUser;
        public IstanbulDB()
        {
            InitializeComponent();
        }

        private void _1815_CM1_IsChecked(object sender, RoutedEventArgs e)
        {
            _1815_CM.Visibility = Visibility.Visible;
            
        }

        private void _1815_CM1_Unchecked(object sender, RoutedEventArgs e)
        {
            _1815_CM.Visibility = Visibility.Hidden;
        }

        private void Add_initialaized(object sender, EventArgs e)
        {
            foreach (var user in MainWindow.dbEntities.User)
            {
                if (user.Id_Role == 1)
                {
                    Add.Visibility = Visibility.Visible;
                }
            }
        }

        private void Delete_initialaized(object sender, EventArgs e)
        {
            foreach (var user in MainWindow.dbEntities.User)
            {
                if (user.Id_Role == 1)
                {
                    Delete.Visibility = Visibility.Visible;
                }
            }
        }

        private void _1821_CM1_Cheked(object sender, RoutedEventArgs e)
        {
            _1821_CM.Visibility = Visibility.Visible;
        }

        private void _1821_CM1_Unchecked(object sender, RoutedEventArgs e)
        {
            _1821_CM.Visibility = Visibility.Hidden;
        }
    }
}
