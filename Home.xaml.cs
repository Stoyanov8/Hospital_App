
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
            string con = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=master;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            SqlConnection SqlCon = new SqlConnection(con);
            SqlCon.Open();
            string FirstName = $"Select FirstName from Doctor Where {Global.password} == Password";
            string LastName = $"Select LastName from Doctor Where {Global.password} == Password";
            string Salary = $"Select Salary from Doctor Where {Global.password} == Password";
            string Gender = $"Select Gender from Doctor Where {Global.password} == Password";
            string BirthDay = $"Select Birthday from Doctor Where {Global.password} == Password";
            string type = $"Select Type from Doctor Where {Global.password} == Password";
            SqlCommand queryCommand = new SqlCommand(FirstName, SqlCon);
            SqlDataReader queryCommandReader = queryCommand.ExecuteReader();
            DataTable dataTable = new DataTable();
            dataTable.Load(queryCommandReader);
            SqlCon.Close();
        }
        private void MyInfo_click(object sender, RoutedEventArgs e)
        {
            Main.Content = new MyInfo();
        }
    }
}
