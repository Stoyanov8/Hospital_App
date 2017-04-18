using System;
using System.Data.SqlTypes;

namespace HospitalApp.Data.Dtos
{
    public class DoctorDto
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Gender { get; set; }

        public DateTime HireDate { get; set; }

        public float Salary { get; set; }

        public string Type { get; set; }

        public string Password { get; set; }

        public string Specialty { get; set; }
    }
}