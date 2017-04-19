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

namespace Hospital.App.Pages
{
    /// <summary>
    /// Interaction logic for Edit.xaml
    /// </summary>
    public partial class Edit : Page
    {
        public Edit()
        {
            InitializeComponent(); 

        }



        private void delete_check_click(object sender, RoutedEventArgs e)
        {
            using (var context = new HospitalAppEntities())

            {
                var id1 = Convert.ToInt32(id.Text);
                var fullname =
                    context.Patients.Where(x => x.Id == id1)
                        .Select(x => new {FullName = x.FirstName + " " + " " + x.LastName})
                        .FirstOrDefault();
                _delete.Visibility = Visibility.Visible;
                _delete.Content = $"Are you sure you want to remove {fullname.FullName}";
           
            id.Visibility = Visibility.Hidden;
            button.Visibility = Visibility.Hidden;
            label.Visibility = Visibility.Hidden;
            label_delete.Visibility = Visibility.Hidden;
            Yes.Visibility = Visibility.Visible;
            No.Visibility = Visibility.Visible;
                deletedmessage.Visibility = Visibility.Hidden;

            }
        }

        private void yes_click(object sender, RoutedEventArgs e)
        {
            using (var context = new HospitalAppEntities())

            {
                var id1 = Convert.ToInt32(this.id.Text);
                var ida = context.Patients.Where(x => x.Id == id1).FirstOrDefault();
                var fullname =
                    context.Patients.Where(x => x.Id == id1)
                        .Select(x => new { FullName = x.FirstName + " " + " " + x.LastName })
                        .FirstOrDefault();
                context.Patients.Remove(ida);
                context.SaveChanges();

                id.Visibility = Visibility.Visible;
                label.Visibility = Visibility.Visible;
                label_delete.Visibility = Visibility.Visible;
                Yes.Visibility = Visibility.Hidden;
                No.Visibility = Visibility.Hidden;
                button.Visibility = Visibility.Visible;
                Yes.Visibility = Visibility.Hidden;
                No.Visibility = Visibility.Hidden;
                _delete.Visibility = Visibility.Hidden;
                deletedmessage.Visibility = Visibility.Visible;
                deletedmessage.Content = $"{fullname.FullName} removed";
                
            }

        }

        private void no_click(object sender, RoutedEventArgs e)
        {

            id.Visibility = Visibility.Visible;
            label.Visibility = Visibility.Visible;
            label_delete.Visibility = Visibility.Visible;
            Yes.Visibility = Visibility.Hidden;
            No.Visibility = Visibility.Hidden;
            button.Visibility = Visibility.Visible;
            Yes.Visibility = Visibility.Hidden;
            No.Visibility = Visibility.Hidden;
            _delete.Visibility = Visibility.Hidden;


        }
    }
}