using System;
using System.Collections.Generic;
using System.IO;
using HospitalApp.Data;
using HospitalApp.Data.Dtos;
using Models;
using Newtonsoft.Json;

namespace HospitalApp.Import
{
    public class AddPatient
    {
        public static void AddPatients()
        {
            var json = File.ReadAllText("../../../datasets/patiets.json");
            var patients = JsonConvert.DeserializeObject<IEnumerable<PatientDto>>(json);
            AddPatient.AddPatients(patients);
        }

        public static void AddPatients(IEnumerable<PatientDto> patients)
        {
            using (var context = new HospitalAppEntities())
            {
                foreach (var patient in patients)
                {
                    context.Patients.Add(new Patient
                    {
                        FirstName = patient.FirstName,
                        LastName = patient.LastName,
                        Gender = patient.Gender,
                        BirthDay = patient.BirthDay,
                        Adress = patient.Adress,
                        PhoneNumber = patient.PhoneNumber 

                    });

                }
                context.SaveChanges();
            }

        }
    }
}