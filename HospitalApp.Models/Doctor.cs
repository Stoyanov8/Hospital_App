using System;
using System.Collections.Generic;

namespace Models
{
    public class Doctor
    {
        public Doctor()
        {
            this.Exams=new HashSet<Exam>();
            this.Rehabilitations = new HashSet<Rehabilitation>();
            this.Surgeries = new HashSet<Surgery>();
        }
        public int Id { get; set; }
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Gender { get; set; }

        public DateTime BirthDay { get; set; }

        public float Salary { get; set; }

        public string Password { get; set; }

        public string Specialty { get; set; }

        public virtual  ICollection<Exam> Exams { get; set; }

        public virtual ICollection<Surgery> Surgeries { get; set; }

        public virtual ICollection<Rehabilitation> Rehabilitations { get; set; }


    }
}