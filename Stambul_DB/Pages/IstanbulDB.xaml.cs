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
using System.Drawing;
using System.Data.SqlClient;
using System.Data.Common;
using Microsoft.Win32;
using Stambul_DB.db;
using System.IO;
using System.Data;

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
            if (_1899_RM1.IsChecked == true)
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
            _1923_B1.Visibility = Visibility.Visible;
            _1927_O1.Visibility = Visibility.Visible;
            _1939_K1.Visibility = Visibility.Visible;
            _1941_E1.Visibility = Visibility.Visible;
            _1944_T1.Visibility = Visibility.Visible;
        }

        private void _1927_O1_IsCheked(object sender, RoutedEventArgs e)
        {
            _1927_O.Visibility = Visibility.Visible;
            if (_1927_O1.IsChecked == true)
            {
                _1923_B1.Visibility = Visibility.Hidden;
                _1924_N1.Visibility = Visibility.Hidden;
                _1939_K1.Visibility = Visibility.Hidden;
                _1941_E1.Visibility = Visibility.Hidden;
                _1944_T1.Visibility = Visibility.Hidden;
            }
        }
        private void _1927_O1_Unchecked(object sender, RoutedEventArgs e)
        {
            _1927_O.Visibility = Visibility.Hidden;
            _1923_B1.Visibility = Visibility.Visible;
            _1924_N1.Visibility = Visibility.Visible;
            _1939_K1.Visibility = Visibility.Visible;
            _1941_E1.Visibility = Visibility.Visible;
            _1944_T1.Visibility = Visibility.Visible;
        }

        private void _1939_K1_IsCheked(object sender, RoutedEventArgs e)
        {
            _1939_K.Visibility = Visibility.Visible;
            if (_1939_K1.IsChecked == true)
            {
                _1923_B1.Visibility = Visibility.Hidden;
                _1927_O1.Visibility = Visibility.Hidden;
                _1924_N1.Visibility = Visibility.Hidden;
                _1941_E1.Visibility = Visibility.Hidden;
                _1944_T1.Visibility = Visibility.Hidden;
            }
        }
        private void _1939_K1_Unchecked(object sender, RoutedEventArgs e)
        {
            _1939_K.Visibility = Visibility.Hidden;
            _1923_B1.Visibility = Visibility.Visible;
            _1927_O1.Visibility = Visibility.Visible;
            _1924_N1.Visibility = Visibility.Visible;
            _1941_E1.Visibility = Visibility.Visible;
            _1944_T1.Visibility = Visibility.Visible;
        }

        private void _1941_E1_IsCheked(object sender, RoutedEventArgs e)
        {
            _1941_E.Visibility = Visibility.Visible;
            if (_1941_E1.IsChecked == true)
            {
                _1923_B1.Visibility = Visibility.Hidden;
                _1927_O1.Visibility = Visibility.Hidden;
                _1939_K1.Visibility = Visibility.Hidden;
                _1924_N1.Visibility = Visibility.Hidden;
                _1944_T1.Visibility = Visibility.Hidden;
            }
        }
        private void _1941_E1_Unchecked(object sender, RoutedEventArgs e)
        {
            _1941_E.Visibility = Visibility.Hidden;
            _1923_B1.Visibility = Visibility.Visible;
            _1927_O1.Visibility = Visibility.Visible;
            _1939_K1.Visibility = Visibility.Visible;
            _1924_N1.Visibility = Visibility.Visible;
            _1944_T1.Visibility = Visibility.Visible;
        }

        private void _1944_T1_IsCheked(object sender, RoutedEventArgs e)
        {
            _1944_T.Visibility = Visibility.Visible;
            if (_1944_T1.IsChecked == true)
            {
                _1923_B1.Visibility = Visibility.Hidden;
                _1927_O1.Visibility = Visibility.Hidden;
                _1939_K1.Visibility = Visibility.Hidden;
                _1941_E1.Visibility = Visibility.Hidden;
                _1924_N1.Visibility = Visibility.Hidden;
            }
        }
        private void _1944_T1_Unchecked(object sender, RoutedEventArgs e)
        {
            _1944_T.Visibility = Visibility.Hidden;
            _1923_B1.Visibility = Visibility.Visible;
            _1927_O1.Visibility = Visibility.Visible;
            _1939_K1.Visibility = Visibility.Visible;
            _1941_E1.Visibility = Visibility.Visible;
            _1924_N1.Visibility = Visibility.Visible;
        }

        private void _1946_SAM1_IsCheked(object sender, RoutedEventArgs e)
        {
            _1946_SAM.Visibility = Visibility.Visible;
            if (_1946_SAM1.IsChecked == true)
            {
                _1946_SAM1.Visibility = Visibility.Hidden;
                _1966_SAM1.Visibility = Visibility.Hidden;
                _1970_SAM1.Visibility = Visibility.Hidden;
                _1982_SAM1.Visibility = Visibility.Hidden;
            }
        }
        private void _1946_SAM1_Unchecked(object sender, RoutedEventArgs e)
        {
            _1946_SAM.Visibility = Visibility.Hidden;
            _1946_SAM1.Visibility = Visibility.Visible;
            _1966_SAM1.Visibility = Visibility.Visible;
            _1970_SAM1.Visibility = Visibility.Visible;
            _1982_SAM1.Visibility = Visibility.Visible;
        }

        private void _1966_SAM1_IsCheked(object sender, RoutedEventArgs e)
        {
            _1966_SAM.Visibility = Visibility.Visible;
            if (_1966_SAM1.IsChecked == true)
            {
                _1966_SAM1.Visibility = Visibility.Hidden;
                _1970_SAM1.Visibility = Visibility.Hidden;
                _1982_SAM1.Visibility = Visibility.Hidden;
            }
        }
        private void _1966_SAM1_Unchecked(object sender, RoutedEventArgs e)
        {
            _1966_SAM.Visibility = Visibility.Hidden;
            _1946_SAM1.Visibility = Visibility.Visible;
            _1970_SAM1.Visibility = Visibility.Visible;
            _1982_SAM1.Visibility = Visibility.Visible;
        }

        private void _1970_SAM1_IsCheked(object sender, RoutedEventArgs e)
        {
            _1970_SAM.Visibility = Visibility.Visible;
            if (_1970_SAM1.IsChecked == true)
            {
                _1946_SAM1.Visibility = Visibility.Hidden;
                _1966_SAM1.Visibility = Visibility.Hidden;
                _1982_SAM1.Visibility = Visibility.Hidden;
            }
        }
        private void _1970_SAM1_Unchecked(object sender, RoutedEventArgs e)
        {
            _1970_SAM.Visibility = Visibility.Hidden;
            _1946_SAM1.Visibility = Visibility.Visible;
            _1966_SAM1.Visibility = Visibility.Visible;
            _1982_SAM1.Visibility = Visibility.Visible;
        }

        private void _1982_SAM1_IsCheked(object sender, RoutedEventArgs e)
        {
            _1982_SAM.Visibility = Visibility.Visible;
            if (_1982_SAM1.IsChecked == true)
            {
                _1946_SAM1.Visibility = Visibility.Hidden;
                _1966_SAM1.Visibility = Visibility.Hidden;
                _1970_SAM1.Visibility = Visibility.Hidden;
            }
        }
        private void _1982_SAM1_Unchecked(object sender, RoutedEventArgs e)
        {
            _1982_SAM.Visibility = Visibility.Hidden;
            _1946_SAM1.Visibility = Visibility.Visible;
            _1966_SAM1.Visibility = Visibility.Visible;
            _1970_SAM1.Visibility = Visibility.Visible;
        }

        private void _1922_MR1_IsCheked(object sender, RoutedEventArgs e)
        {
            _1922_MR.Visibility = Visibility.Visible;
            if (_1922_MR1.IsChecked == true)
            {
                _1946_MR1.Visibility = Visibility.Hidden;
                _1966_MR1.Visibility = Visibility.Hidden;
                _1970_MR1.Visibility = Visibility.Hidden;
                _1982_MR1.Visibility = Visibility.Hidden;
            }
        }
        private void _1922_MR1_Unchecked(object sender, RoutedEventArgs e)
        {
            _1922_MR.Visibility = Visibility.Hidden;
            _1946_MR1.Visibility = Visibility.Visible;
            _1966_MR1.Visibility = Visibility.Visible;
            _1970_MR1.Visibility = Visibility.Visible;
            _1982_MR1.Visibility = Visibility.Visible;
        }

        private void _1946_MR1_IsCheked(object sender, RoutedEventArgs e)
        {
            _1946_MR.Visibility = Visibility.Visible;
            if (_1946_MR1.IsChecked == true)
            {
                _1922_MR1.Visibility = Visibility.Hidden;
                _1966_MR1.Visibility = Visibility.Hidden;
                _1970_MR1.Visibility = Visibility.Hidden;
                _1982_MR1.Visibility = Visibility.Hidden;
            }
        }
        private void _1946_MR1_Unchecked(object sender, RoutedEventArgs e)
        {
            _1946_MR.Visibility = Visibility.Hidden;
            _1922_MR1.Visibility = Visibility.Visible;
            _1966_MR1.Visibility = Visibility.Visible;
            _1970_MR1.Visibility = Visibility.Visible;
            _1982_MR1.Visibility = Visibility.Visible;
        }

        private void _1966_MR1_IsCheked(object sender, RoutedEventArgs e)
        {
            _1966_MR.Visibility = Visibility.Visible;
            if (_1966_MR1.IsChecked == true)
            {
                _1946_MR1.Visibility = Visibility.Hidden;
                _1922_MR1.Visibility = Visibility.Hidden;
                _1970_MR1.Visibility = Visibility.Hidden;
                _1982_MR1.Visibility = Visibility.Hidden;
            }
        }
        private void _1966_MR1_Unchecked(object sender, RoutedEventArgs e)
        {
            _1966_MR.Visibility = Visibility.Hidden;
            _1946_MR1.Visibility = Visibility.Visible;
            _1922_MR1.Visibility = Visibility.Visible;
            _1970_MR1.Visibility = Visibility.Visible;
            _1982_MR1.Visibility = Visibility.Visible;
        }

        private void _1970_MR1_IsCheked(object sender, RoutedEventArgs e)
        {
            _1970_MR.Visibility = Visibility.Visible;
            if (_1970_MR1.IsChecked == true)
            {
                _1946_MR1.Visibility = Visibility.Hidden;
                _1966_MR1.Visibility = Visibility.Hidden;
                _1922_MR1.Visibility = Visibility.Hidden;
                _1982_MR1.Visibility = Visibility.Hidden;
            }
        }
        private void _1970_MR1_Unchecked(object sender, RoutedEventArgs e)
        {
            _1970_MR.Visibility = Visibility.Hidden;
            _1946_MR1.Visibility = Visibility.Visible;
            _1966_MR1.Visibility = Visibility.Visible;
            _1922_MR1.Visibility = Visibility.Visible;
            _1982_MR1.Visibility = Visibility.Visible;
        }

        private void _1982_MR1_IsCheked(object sender, RoutedEventArgs e)
        {
            _1982_MR.Visibility = Visibility.Visible;
            if (_1982_MR1.IsChecked == true)
            {
                _1946_MR1.Visibility = Visibility.Hidden;
                _1966_MR1.Visibility = Visibility.Hidden;
                _1922_MR1.Visibility = Visibility.Hidden;
                _1970_MR1.Visibility = Visibility.Hidden;
            }
        }
        private void _1982_MR1_Unchecked(object sender, RoutedEventArgs e)
        {
            _1982_MR.Visibility = Visibility.Hidden;
            _1946_MR1.Visibility = Visibility.Visible;
            _1966_MR1.Visibility = Visibility.Visible;
            _1922_MR1.Visibility = Visibility.Visible;
            _1970_MR1.Visibility = Visibility.Visible;
        }

        private void B1_IsCheked(object sender, RoutedEventArgs e)
        {
            Beaches.Visibility = Visibility.Visible;
            if (B1.IsChecked == true)
            {
                C1.Visibility = Visibility.Hidden;
                S1.Visibility = Visibility.Hidden;

            }
        }
        private void B1_Unchecked(object sender, RoutedEventArgs e)
        {
            Beaches.Visibility = Visibility.Hidden;
            C1.Visibility = Visibility.Visible;
            S1.Visibility = Visibility.Visible;
        }

        private void C1_IsCheked(object sender, RoutedEventArgs e)
        {
            Casinos.Visibility = Visibility.Visible;
            if (C1.IsChecked == true)
            {
                B1.Visibility = Visibility.Hidden;
                S1.Visibility = Visibility.Hidden;

            }
        }
        private void C1_Unchecked(object sender, RoutedEventArgs e)
        {
            Casinos.Visibility = Visibility.Hidden;
            B1.Visibility = Visibility.Visible;
            S1.Visibility = Visibility.Visible;
        }

        private void S1_IsCheked(object sender, RoutedEventArgs e)
        {
            SpacesOfBeyoglu.Visibility = Visibility.Visible;
            if (S1.IsChecked == true)
            {
                C1.Visibility = Visibility.Hidden;
                S1.Visibility = Visibility.Hidden;

            }
        }
        private void S1_Unchecked(object sender, RoutedEventArgs e)
        {
            SpacesOfBeyoglu.Visibility = Visibility.Hidden;
            C1.Visibility = Visibility.Visible;
            S1.Visibility = Visibility.Visible;
        }

        private void _1922_TF1_IsCheked(object sender, RoutedEventArgs e)
        {
            _1922_TF.Visibility = Visibility.Visible;
            if (_1922_TF1.IsChecked == true)
            {
                _1922_TT1.Visibility = Visibility.Hidden;
                _1922_TWT1.Visibility = Visibility.Hidden;

            }
        }
        private void _1922_TF1_Unchecked(object sender, RoutedEventArgs e)
        {
            _1922_TF.Visibility = Visibility.Hidden;
            _1922_TT1.Visibility = Visibility.Visible;
            _1922_TWT1.Visibility = Visibility.Visible;
        }

        private void _1922_TT1_IsCheked(object sender, RoutedEventArgs e)
        {
            _1922_TT.Visibility = Visibility.Visible;
            if (_1922_TT1.IsChecked == true)
            {
                _1922_TF1.Visibility = Visibility.Hidden;
                _1922_TWT1.Visibility = Visibility.Hidden;

            }
        }
        private void _1922_TT1_Unchecked(object sender, RoutedEventArgs e)
        {
            _1922_TT.Visibility = Visibility.Hidden;
            _1922_TF1.Visibility = Visibility.Visible;
            _1922_TWT1.Visibility = Visibility.Visible;
        }

        private void _1922_TWT1_IsCheked(object sender, RoutedEventArgs e)
        {
            _1922_TWT.Visibility = Visibility.Visible;
            if (_1922_TWT1.IsChecked == true)
            {
                _1922_TT1.Visibility = Visibility.Hidden;
                _1922_TF1.Visibility = Visibility.Hidden;

            }
        }
        private void _1922_TWT1_Unchecked(object sender, RoutedEventArgs e)
        {
            _1922_TWT.Visibility = Visibility.Hidden;
            _1922_TT1.Visibility = Visibility.Visible;
            _1922_TF1.Visibility = Visibility.Visible;
        }

        private void _1_MP1_IsCheked(object sender, RoutedEventArgs e)
        {
            _1_MP.Visibility = Visibility.Visible;
            if (_1_MP1.IsChecked == true)
            {
                _2_MP1.Visibility = Visibility.Hidden;
            }
        }
        private void _1_MP1_Unchecked(object sender, RoutedEventArgs e)
        {
            _1_MP.Visibility = Visibility.Hidden;
            _2_MP1.Visibility = Visibility.Visible;
        }

        private void _2_MP1_IsCheked(object sender, RoutedEventArgs e)
        {
            _2_MP.Visibility = Visibility.Visible;
            if (_2_MP1.IsChecked == true)
            {
                _1_MP1.Visibility = Visibility.Hidden;
            }
        }
        private void _2_MP1_Unchecked(object sender, RoutedEventArgs e)
        {
            _2_MP.Visibility = Visibility.Hidden;
            _1_MP1.Visibility = Visibility.Visible;
        }

        private void _1920_1994_CG1_IsCheked(object sender, RoutedEventArgs e)
        {
            _1920_1994_CG.Visibility = Visibility.Visible;
            if (_1920_1994_CG1.IsChecked == true)
            {
                _1930_CG1.Visibility = Visibility.Hidden;
            }
        }
        private void _1920_1994_CG1_Unchecked(object sender, RoutedEventArgs e)
        {
            _1920_1994_CG.Visibility = Visibility.Hidden;
            _1930_CG1.Visibility = Visibility.Visible;
        }

        private void _1930_CG1_IsCheked(object sender, RoutedEventArgs e)
        {
            _1930_CG.Visibility = Visibility.Visible;
            if (_1930_CG1.IsChecked == true)
            {
                _1920_1994_CG1.Visibility = Visibility.Hidden;
            }
        }
        private void _1930_CG1_Unchecked(object sender, RoutedEventArgs e)
        {
            _1930_CG.Visibility = Visibility.Hidden;
            _1920_1994_CG1.Visibility = Visibility.Visible;
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
            }

        }
    }
}