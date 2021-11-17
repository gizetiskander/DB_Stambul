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
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
using Stambul_DB.db;
using Stambul_DB.Pages;

namespace Stambul_DB
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    
    public partial class MainWindow : Window
    {
        public static Istanbul_urban_dbEntities dbEntities = new Istanbul_urban_dbEntities();
        public static User authUser;
        public MainWindow()
        {
            InitializeComponent();
            
        }

        private void SignUp_Click(object sender, RoutedEventArgs e)
        {
            Registration window = new Registration();
            this.Close();
            window.Show();
        }

        private void SignIn_Click(object sender, RoutedEventArgs e)
        {
            foreach (var user in MainWindow.dbEntities.User)
            {
                if (user.Login == Login.Text.Trim())
                {
                    if (user.Password == Password.Text.Trim() && user.Id_Role == 2)
                    {
                        MessageBox.Show($"Привет Пользователь {user.Login}");
                        MainWindow.authUser = user;
                        MessageBox.Show($"{MainWindow.authUser}");
                    }
                    if (user.Password == Password.Text.Trim() && user.Id_Role == 1)
                    {
                        MessageBox.Show($"Привет админ {user.Login}");
                    }
                    IstanbulDB istanbulDB = new IstanbulDB();
                    this.Close();
                    istanbulDB.Show();
                }
            }
        }
    }
}
