
using System.Windows;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using Hospital.App.Pages;
using System.Data.SqlClient;
using System.Windows.Input;

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

        private void patients_click(object sender, RoutedEventArgs e)
        {
            Main.Content = new Patients();
        }

        private void myPatients_click(object sender, RoutedEventArgs e)
        {
            Main.Content = new myPatients();
            
        }

        private void Newpatient_Click(object sender, RoutedEventArgs e)
        {
            Main.Content = new newPatient();
        }

        private void editPatient_Click(object sender, RoutedEventArgs e)
        {
            Main.Content = new Edit();
        }

        private void NewRehabilitations_Click(object sender, RoutedEventArgs e)
        {
            Main.Content = new newRehabilitation();
        }

        private void newSurgery_Save_click(object sender, RoutedEventArgs e)
        {
            Main.Content = new NewSurgery();
        }
    }
}
