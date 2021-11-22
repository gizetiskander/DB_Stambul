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

namespace Stambul_DB.Pages
{
    /// <summary>
    /// Логика взаимодействия для Redirection.xaml
    /// </summary>
    public partial class Redirection : Window
    {
        public Redirection()
        {
            InitializeComponent();
        }

        private void Redirection_CM_Click(object sender, RoutedEventArgs e)
        {
            CityMaps cm = new CityMaps();
            this.Close();
            cm.Show();
        }

        private void Redirection_RM_Click(object sender, RoutedEventArgs e)
        {
            RegionalMaps rm = new RegionalMaps();
            this.Close();
            rm.Show();
        }

        private void Redirection_SM_Click(object sender, RoutedEventArgs e)
        {
            SpecialMaps sm = new SpecialMaps();
            this.Close();
            sm.Show();
        }

        private void Redirection_PM_Click(object sender, RoutedEventArgs e)
        {
            PervetitichMaps pm = new PervetitichMaps();
            this.Close();
            pm.Show();
        }
    }
}
