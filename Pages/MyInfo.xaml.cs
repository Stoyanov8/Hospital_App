using System.Linq;

namespace Hospital.App.Pages
{
    using HospitalApp.Data;
    using System.Windows.Controls;

    public partial class MyInfo : Page
    {
        public MyInfo()
        {
            InitializeComponent();
            using (var context = new HospitalAppEntities())
            {
                var firstName = context.Doctors.
                    Where(p => p.Password == Global.password)
                    .Select(f =>f.FirstName).First().ToString();

                var lastName = context.Doctors.
                  Where(p => p.Password == Global.password)
                  .Select(f => f.LastName).First().ToString();

                var gender = context.Doctors.
                 Where(p => p.Password == Global.password)
                 .Select(f => f.Gender).First().ToUpper();

               var birthday = context.Doctors.
                 Where(p => p.Password == Global.password)
                 .Select(f => f.HireDate).First().ToString();

                var salary = context.Doctors.
                 Where(p => p.Password == Global.password)
                 .Select(f => f.Salary).First().ToString();

                var speciality = context.Doctors.
                 Where(p => p.Password == Global.password)
                 .Select(f => f.Specialty).First().ToString();

                    
                FirstName.Text = firstName;
                LastName.Text = lastName;
                Gender.Text = gender;
                Birthdate.Text = birthday;
                Salary.Text = salary;
                Speciality.Text = speciality;
            }

        }
    }
}
