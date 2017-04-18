using System;
using System.Collections.Generic;
using System.IO;
using HospitalApp.Data;
using HospitalApp.Data.Dtos;
using Models;
using Newtonsoft.Json;

namespace HospitalApp.Import
{
    public static class AddDoctor
    {
        public static void AddDoctors()
        {
            var json = File.ReadAllText("../../../datasets/doctors.json");
            var doctors = JsonConvert.DeserializeObject<IEnumerable<DoctorDto>>(json);
            AddDoctor.AddDoctors(doctors);
        }

        public static void AddDoctors(IEnumerable<DoctorDto> doctors)
        {
            using (var context = new HospitalAppEntities())
            {
                foreach (var doctor in doctors)
                {
                    context.Doctors.Add(new Doctor {
                        FirstName  = doctor.FirstName ,
                        LastName = doctor.LastName,
                        Gender = doctor.Gender,
                        BirthDay = doctor.BirthDay,
                        Salary = doctor.Salary,
                        Specialty = doctor.Specialty,
                        Password = doctor.Password
                    });
                    Console.WriteLine($"Added {doctor.FirstName} {doctor.LastName} in table Doctors!");
                }
                

                context.SaveChanges();
            }

        }
    }
}