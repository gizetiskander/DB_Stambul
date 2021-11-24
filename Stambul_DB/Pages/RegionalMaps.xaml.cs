﻿using System;
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
    /// Логика взаимодействия для RegionalMaps.xaml
    /// </summary>
    public partial class RegionalMaps : Window
    {
        public static Istanbul_urban_dbEntities dbEntities = new Istanbul_urban_dbEntities();
        public RegionalMaps()
        {
            InitializeComponent();
            dbEntities = new Istanbul_urban_dbEntities();

            Regional_Maps.ItemsSource = dbEntities.Regional_Maps.ToList();
        }

        private void ButtonAdd(object sender, RoutedEventArgs e)
        {
            var q = Regional_Maps.SelectedItem as Regional_Maps;
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
                    dbEntities.Regional_Maps.Add(q);
                    dbEntities.SaveChanges();
                    Regional_Maps.ItemsSource = dbEntities.Regional_Maps.ToList();
                }
                catch
                {
                    MessageBox.Show("Удалите соединения связанные с этим данным или таких данных нет");
                }

            }
        }

        private void ButtonDel(object sender, RoutedEventArgs e)
        {
            var q = Regional_Maps.SelectedItem as Regional_Maps;
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
                    dbEntities.Regional_Maps.Remove(q);
                    dbEntities.SaveChanges();
                    Regional_Maps.ItemsSource = dbEntities.Regional_Maps.ToList();
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
                Regional_Maps rm = new Regional_Maps();
                playim.Source = image;
                rm.Image_RM = File.ReadAllBytes(ofdImage.FileName);
                dbEntities.Regional_Maps.Add(rm);
                dbEntities.SaveChanges();
            }
        }
    }
}
