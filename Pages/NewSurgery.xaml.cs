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
    /// Interaction logic for NewSurgery.xaml
    /// </summary>
    public partial class NewSurgery : Page
    {
        public NewSurgery()
        {
            InitializeComponent();

            var context = new HospitalAppEntities();

            var sugery = context.Surgeries.ToList();
            this.DataContext = sugery;
        }
        private void newSurgery_Save_click(object sender, RoutedEventArgs e)
        {
            using (var context = new HospitalAppEntities())
            {
                var surgery = new Surgery();
                surgery.SurgeryDate = Convert.ToDateTime(SurgeryDate.Text);
                surgery.RoomId = Convert.ToInt32(RoomId.Text);
                surgery.PatientId = Convert.ToInt32(PatientId.Text);
                surgery.DiseaseId = Convert.ToInt32(DiseaseId.Text);
                surgery.DoctorId = Convert.ToInt32(DoctorId.Text);
                if (surgery.RoomId == 0 || surgery.PatientId == 0 || surgery.DiseaseId == 0 || surgery.DoctorId == 0)
                {
                    MessageBox.Show("Error: Check if there is any missing proparties or 0 values of Ids");
                }
                else
                {
                    context.Surgeries.Add(surgery);
                    added.Content = $"Surgeries added successfully!";
                    added.Visibility = Visibility.Visible;
                    context.SaveChanges();
                }
            }
        }
    }
}
