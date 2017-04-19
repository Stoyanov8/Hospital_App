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
using HospitalApp.Data;
using Models;

namespace Hospital.App.Pages
{
    /// <summary>
    /// Interaction logic for newPatient.xaml
    /// </summary>
    public partial class newPatient : Page
    {
        public newPatient()
        {
            InitializeComponent();
        }

        private void newPatient_Save_click(object sender, RoutedEventArgs e)
        {
            using (var context = new HospitalAppEntities())
            {
                var patient = new Patient();
                patient.FirstName = FirstName.Text;
                patient.LastName = LastName.Text;
                patient.Address = Address.Text;
                patient.PhoneNumber = PhoneNumber.Text;
                context.Patients.Add(patient);
                context.SaveChanges();
            }
        }
    }
}
