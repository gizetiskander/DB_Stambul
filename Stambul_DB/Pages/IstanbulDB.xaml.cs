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
            if (_1815_CM1.IsChecked == true)
            {
                _1821_CM1.Visibility = Visibility.Hidden;
                _1853_CM1.Visibility = Visibility.Hidden;
                _1860_CM1.Visibility = Visibility.Hidden;
                _1882_CM1.Visibility = Visibility.Hidden;
                _1913_CM1.Visibility = Visibility.Hidden;
                _1918_CM1.Visibility = Visibility.Hidden;
            }
            
        }

        private void _1815_CM1_Unchecked(object sender, RoutedEventArgs e)
        {
            _1815_CM.Visibility = Visibility.Hidden;
            _1821_CM1.Visibility = Visibility.Visible;
            _1853_CM1.Visibility = Visibility.Visible;
            _1860_CM1.Visibility = Visibility.Visible;
            _1882_CM1.Visibility = Visibility.Visible;
            _1913_CM1.Visibility = Visibility.Visible;
            _1918_CM1.Visibility = Visibility.Visible;

        }

        private void Add_initialaized(object sender, EventArgs e)
        {
            if (MainWindow.authUser.Id_Role == 1)
            {
                Add_CM.Visibility = Visibility.Visible;
            }
            else if (MainWindow.authUser.Id_Role == 2)
            {
                Add_CM.Visibility = Visibility.Hidden;
            }
        }

        private void Add_CM_Click(object sender, RoutedEventArgs e)
        {
            Redirection redirection = new Redirection();
            this.Close();
            redirection.Show();
        }

        private void _1821_CM1_IsCheked(object sender, RoutedEventArgs e)
        {
            _1821_CM.Visibility = Visibility.Visible;
            if (_1821_CM1.IsChecked == true)
            {
                _1815_CM1.Visibility = Visibility.Hidden;
                _1853_CM1.Visibility = Visibility.Hidden;
                _1860_CM1.Visibility = Visibility.Hidden;
                _1882_CM1.Visibility = Visibility.Hidden;
                _1913_CM1.Visibility = Visibility.Hidden;
                _1918_CM1.Visibility = Visibility.Hidden;
            }
        }

        private void _1821_CM1_Unchecked(object sender, RoutedEventArgs e)
        {
            _1821_CM.Visibility = Visibility.Hidden;
            _1815_CM1.Visibility = Visibility.Visible;
            _1853_CM1.Visibility = Visibility.Visible;
            _1860_CM1.Visibility = Visibility.Visible;
            _1882_CM1.Visibility = Visibility.Visible;
            _1913_CM1.Visibility = Visibility.Visible;
            _1918_CM1.Visibility = Visibility.Visible;
        }

        private void _1853_CM1_IsCheked(object sender, RoutedEventArgs e)
        {
            _1853_CM.Visibility = Visibility.Visible;
            if (_1853_CM1.IsChecked == true)
            {
                _1815_CM1.Visibility = Visibility.Hidden;
                _1821_CM1.Visibility = Visibility.Hidden;
                _1860_CM1.Visibility = Visibility.Hidden;
                _1882_CM1.Visibility = Visibility.Hidden;
                _1913_CM1.Visibility = Visibility.Hidden;
                _1918_CM1.Visibility = Visibility.Hidden;
            }
        }

        private void _1853_CM1_Unchecked(object sender, RoutedEventArgs e)
        {
            _1853_CM.Visibility = Visibility.Hidden;
            _1815_CM1.Visibility = Visibility.Visible;
            _1821_CM1.Visibility = Visibility.Visible;
            _1860_CM1.Visibility = Visibility.Visible;
            _1882_CM1.Visibility = Visibility.Visible;
            _1913_CM1.Visibility = Visibility.Visible;
            _1918_CM1.Visibility = Visibility.Visible;
        }

        private void _1860_CM1_IsCheked(object sender, RoutedEventArgs e)
        {
            _1860_CM.Visibility = Visibility.Visible;
            if (_1860_CM1.IsChecked == true)
            {
                _1815_CM1.Visibility = Visibility.Hidden;
                _1853_CM1.Visibility = Visibility.Hidden;
                _1821_CM1.Visibility = Visibility.Hidden;
                _1882_CM1.Visibility = Visibility.Hidden;
                _1913_CM1.Visibility = Visibility.Hidden;
                _1918_CM1.Visibility = Visibility.Hidden;
            }
        }

        private void _1860_CM1_Unchecked(object sender, RoutedEventArgs e)
        {
            _1860_CM.Visibility = Visibility.Hidden;
            _1815_CM1.Visibility = Visibility.Visible;
            _1853_CM1.Visibility = Visibility.Visible;
            _1821_CM1.Visibility = Visibility.Visible;
            _1882_CM1.Visibility = Visibility.Visible;
            _1913_CM1.Visibility = Visibility.Visible;
            _1918_CM1.Visibility = Visibility.Visible;
        }

        private void _1882_CM1_IsCheked(object sender, RoutedEventArgs e)
        {
            _1882_CM.Visibility = Visibility.Visible;
            if (_1882_CM1.IsChecked == true)
            {
                _1815_CM1.Visibility = Visibility.Hidden;
                _1853_CM1.Visibility = Visibility.Hidden;
                _1860_CM1.Visibility = Visibility.Hidden;
                _1821_CM1.Visibility = Visibility.Hidden;
                _1913_CM1.Visibility = Visibility.Hidden;
                _1918_CM1.Visibility = Visibility.Hidden;
            }
        }

        private void _1882_CM1_Unchecked(object sender, RoutedEventArgs e)
        {
            _1882_CM.Visibility = Visibility.Hidden;
            _1815_CM1.Visibility = Visibility.Visible;
            _1853_CM1.Visibility = Visibility.Visible;
            _1860_CM1.Visibility = Visibility.Visible;
            _1821_CM1.Visibility = Visibility.Visible;
            _1913_CM1.Visibility = Visibility.Visible;
            _1918_CM1.Visibility = Visibility.Visible;
        }

        private void _1913_CM1_IsCheked(object sender, RoutedEventArgs e)
        {
            _1913_CM.Visibility = Visibility.Visible;
            if (_1913_CM1.IsChecked == true)
            {
                _1815_CM1.Visibility = Visibility.Hidden;
                _1853_CM1.Visibility = Visibility.Hidden;
                _1860_CM1.Visibility = Visibility.Hidden;
                _1882_CM1.Visibility = Visibility.Hidden;
                _1821_CM1.Visibility = Visibility.Hidden;
                _1918_CM1.Visibility = Visibility.Hidden;
            }
        }

        private void _1913_CM1_Unchecked(object sender, RoutedEventArgs e)
        {
            _1913_CM.Visibility = Visibility.Hidden;
            _1815_CM1.Visibility = Visibility.Visible;
            _1853_CM1.Visibility = Visibility.Visible;
            _1860_CM1.Visibility = Visibility.Visible;
            _1882_CM1.Visibility = Visibility.Visible;
            _1821_CM1.Visibility = Visibility.Visible;
            _1918_CM1.Visibility = Visibility.Visible;

        }

        private void _1918_CM1_IsCheked(object sender, RoutedEventArgs e)
        {
            _1918_CM.Visibility = Visibility.Visible;
            if (_1918_CM1.IsChecked == true)
            {
                _1815_CM1.Visibility = Visibility.Hidden;
                _1853_CM1.Visibility = Visibility.Hidden;
                _1860_CM1.Visibility = Visibility.Hidden;
                _1882_CM1.Visibility = Visibility.Hidden;
                _1913_CM1.Visibility = Visibility.Hidden;
                _1821_CM1.Visibility = Visibility.Hidden;
            }
        }

        private void _1918_CM1_Unchecked(object sender, RoutedEventArgs e)
        {
            _1918_CM.Visibility = Visibility.Hidden;
            _1815_CM1.Visibility = Visibility.Visible;
            _1853_CM1.Visibility = Visibility.Visible;
            _1860_CM1.Visibility = Visibility.Visible;
            _1882_CM1.Visibility = Visibility.Visible;
            _1913_CM1.Visibility = Visibility.Visible;
            _1821_CM1.Visibility = Visibility.Visible;
        }

        private void _1899_RM1_IsCheked(object sender, RoutedEventArgs e)
        {
            _1899_RM.Visibility = Visibility.Visible;
            if(_1899_RM1.IsChecked == true)
            {
                _1900_RM1.Visibility = Visibility.Hidden;
            }
        }

        private void _1899_RM1_Unchecked(object sender, RoutedEventArgs e)
        {
            _1899_RM.Visibility = Visibility.Hidden;
            _1900_RM1.Visibility = Visibility.Visible;
        }

        private void _1900_RM1_IsCheked(object sender, RoutedEventArgs e)
        {
            _1900_RM.Visibility = Visibility.Visible;
            if (_1900_RM1.IsChecked == true)
            {
                _1899_RM1.Visibility = Visibility.Hidden;
            }
        }
        private void _1900_RM1_Unchecked(object sender, RoutedEventArgs e)
        {
            _1900_RM.Visibility = Visibility.Hidden;
            _1899_RM1.Visibility = Visibility.Visible;
        }

        private void _1875_SM1_IsCheked(object sender, RoutedEventArgs e)
        {
            _1875_SM.Visibility = Visibility.Visible;
            if (_1875_SM1.IsChecked == true)
            {
                _1865_SM1.Visibility = Visibility.Hidden;
            }
        }
        private void _1875_SM1_Unchecked(object sender, RoutedEventArgs e)
        {
            _1875_SM.Visibility = Visibility.Hidden;
            _1865_SM1.Visibility = Visibility.Visible;
        }

        private void _1865_SM1_IsCheked(object sender, RoutedEventArgs e)
        {
            _1865_SM.Visibility = Visibility.Visible;
            if (_1865_SM1.IsChecked == true)
            {
                _1875_SM1.Visibility = Visibility.Hidden;
            }
        }
        private void _1865_SM1_Unchecked(object sender, RoutedEventArgs e)
        {
            _1865_SM.Visibility = Visibility.Hidden;
            _1875_SM1.Visibility = Visibility.Visible;
        }
        private void _1923_B1_IsCheked(object sender, RoutedEventArgs e)
        {
            _1923_B.Visibility = Visibility.Visible;
            if (_1923_B1.IsChecked == true)
            {
                _1924_N1.Visibility = Visibility.Hidden;
                _1927_O1.Visibility = Visibility.Hidden;
                _1939_K1.Visibility = Visibility.Hidden;
                _1941_E1.Visibility = Visibility.Hidden;
                _1944_T1.Visibility = Visibility.Hidden;
            }
        }
        private void _1923_B1_Unchecked(object sender, RoutedEventArgs e)
        {
            _1923_B.Visibility = Visibility.Hidden;
            _1924_N1.Visibility = Visibility.Visible;
            _1927_O1.Visibility = Visibility.Visible;
            _1939_K1.Visibility = Visibility.Visible;
            _1941_E1.Visibility = Visibility.Visible;
            _1944_T1.Visibility = Visibility.Visible;
        }

        private void _1924_N1_IsCheked(object sender, RoutedEventArgs e)
        {
            _1924_N.Visibility = Visibility.Visible;
            if (_1924_N1.IsChecked == true)
            {
                _1923_B1.Visibility = Visibility.Hidden;
                _1927_O1.Visibility = Visibility.Hidden;
                _1939_K1.Visibility = Visibility.Hidden;
                _1941_E1.Visibility = Visibility.Hidden;
                _1944_T1.Visibility = Visibility.Hidden;
            }
        }
        private void _1924_N1_Unchecked(object sender, RoutedEventArgs e)
        {
            _1924_N.Visibility = Visibility.Hidden;
            _1924_N1.Visibility = Visibility.Visible;
            _1927_O1.Visibility = Visibility.Visible;
            _1939_K1.Visibility = Visibility.Visible;
            _1941_E1.Visibility = Visibility.Visible;
            _1944_T1.Visibility = Visibility.Visible;
        }


    }
}
