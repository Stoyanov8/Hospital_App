
using System.Windows;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using Hospital.App.Pages;
using System.Data.SqlClient;

namespace Hospital.App
{
    /// <summary>
    /// Interaction logic for Home.xaml
    /// </summary>
    public partial class Home : Window
    {
        public Home()
        {
            InitializeComponent();
        }
        private void MyInfo_click(object sender, RoutedEventArgs e)
        {
            Main.Content = new MyInfo();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            Main.Content = new Patients();
        }
    }
}
