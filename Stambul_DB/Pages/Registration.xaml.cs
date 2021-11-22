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
using Stambul_DB.Pages;

namespace Stambul_DB.Pages


{
    /// <summary>
    /// Логика взаимодействия для Registration.xaml
    /// </summary>
    
    public partial class Registration : Window
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void SignUp_Click(object sender, RoutedEventArgs e)
        {
            if (UserName.Text == "" || Email.Text == "")
            {
                MessageBox.Show("Введите ваши данные");
            }
            else
            {
                User user = new User();

                user.Login = Login.Text;
                user.Password = Password.Text;
                user.Email = Email.Text;
                user.User_Name = UserName.Text;
                user.Id_Role = 2;
                MainWindow.dbEntities.User.Add(user);
                try
                {
                    MainWindow.dbEntities.SaveChanges();
                }
                catch
                {
                    MessageBox.Show("Такой логин уже существует");
                }
                finally
                {
                    MessageBox.Show("Успешно!");
                }
            }
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();
            this.Close();
            main.Show();
        }
    }
}
