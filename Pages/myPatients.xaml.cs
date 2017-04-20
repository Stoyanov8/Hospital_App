using System;
using System.Collections.Generic;
using System.Data.Entity;
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

using System.Data.SqlClient;

namespace Hospital.App.Pages
{
    /// <summary>
    /// Interaction logic for myPatients.xaml
    /// </summary>
    public partial class myPatients : Page
    {
        public myPatients()
        {
            InitializeComponent();
            using (var context = new HospitalAppEntities())
            {
                var doc = context.Doctors
                    .Where(x => x.Password == Global.password)
                    .Select(d => d.Id)
                    .FirstOrDefault();
                var patientsFromExam = context.Exams
                    .Where(d => d.DoctorId == doc)
                    .Select(x=>x.PatientId)
                    .FirstOrDefault();
                var patients = context.Patients
                       .Where(p => p.Id == patientsFromExam).ToList();

                this.DataContext = patients;
            }
        }
    }
}
