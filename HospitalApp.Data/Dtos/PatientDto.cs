using System;

namespace HospitalApp.Data.Dtos
{
    public class PatientDto
    {

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Gender { get; set; }

        public DateTime BirthDay { get; set; }

        public string Adress { get; set; }

        public int PhoneNumber { get; set; }


    }
}