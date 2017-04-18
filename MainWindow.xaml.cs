using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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
using HospitalApp.Data;
using Models;

namespace Hospital.App
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {

            InitializeComponent();

        }

        private async void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            Global.password = passBxPassword.Password;
            lblfrgtPass.Visibility = Visibility.Hidden;
            Mouse.OverrideCursor = Cursors.Wait;
            passBxPassword.IsEnabled = false;
            btnLogin.IsEnabled = false;
            using (var context = new HospitalAppEntities())
            {
                var pass = context.Doctors
                    .Select(p => p.Password)
                    .ToList();

                foreach (var pas in pass)
                {
                    if (Global.password == pas)
                    {
                        loadingGif.Visibility = Visibility.Visible;
                        await Task.Delay(3000);
                        Home home = new Home();
                        home.Show();
                        Close();
                        Mouse.OverrideCursor = Cursors.Arrow;
                    }
                }

                lblfrgtPass.Visibility = Visibility.Visible;
                lblfrgtPass.Content = "Forgot Password ?";
                passBxPassword.IsEnabled = true;
                passBxPassword.BorderBrush = Brushes.Red;
                btnLogin.IsEnabled = true;
                Mouse.OverrideCursor = null;
            }
        }


        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            App.Current.Shutdown();
        }
    }
}
