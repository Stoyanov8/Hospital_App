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
    /// Interaction logic for newRehabilitation.xaml
    /// </summary>
    public partial class newRehabilitation : Page
    {
        public newRehabilitation()
        {
            InitializeComponent();
        }
        private void newRehabilitation_Save_click(object sender, RoutedEventArgs e)
        {
            using (var context = new HospitalAppEntities())
            {
                var rehabilitation = new Rehabilitation();
                rehabilitation.RehabilitationStartDate = Convert.ToDateTime(RehabilitationStartDate.Text);
                rehabilitation.RehabilitationEndDate = Convert.ToDateTime(RehabilitationEndDate.Text);
                rehabilitation.RoomId = Convert.ToInt32(RoomId.Text);
                rehabilitation.PatientId = Convert.ToInt32(PatientId.Text);
                rehabilitation.DiseaseId = Convert.ToInt32(DiseaseId.Text);
                rehabilitation.DoctorId = Convert.ToInt32(DoctorId.Text);
                if (rehabilitation.RoomId == 0 || rehabilitation.PatientId == 0 || rehabilitation.DiseaseId == 0 || rehabilitation.DoctorId == 0)
                {
                    MessageBox.Show("Error: Check if there is any missing proparties or 0 values of Ids");
                }
                else
                {
                    context.Rehabilitations.Add(rehabilitation);
                    added.Content = $"Rehabilitation added successfully!";
                    added.Visibility = Visibility.Visible;
                    context.SaveChanges();
                }
            }
        }
    }
}
