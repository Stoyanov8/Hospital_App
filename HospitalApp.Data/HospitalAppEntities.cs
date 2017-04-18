using Models;

namespace HospitalApp.Data
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class HospitalAppEntities : DbContext
    {
       
        public HospitalAppEntities()
            : base("name=HospitalAppEntities")
        {
           Database.SetInitializer(new DropCreateDatabaseAlways<HospitalAppEntities>());
        }


        public virtual DbSet<Employee> Employees { get; set; }


        public virtual DbSet<Disease> Diseases { get; set; }

        public virtual DbSet<Exam> Exams { get; set; }

        public virtual DbSet<Patient> Patients { get; set; }

        public virtual DbSet<Surgery> Surgeries { get; set; }

        public virtual DbSet<Rehabilitation> Rehabilitations { get; set; }

        public virtual DbSet<Room> Rooms { get; set; }

        public virtual DbSet<Doctor> Doctors { get; set; }
    }

}