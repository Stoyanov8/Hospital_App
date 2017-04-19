using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using HospitalApp.Data;
namespace HospitalApp.Import
{
    public class AddSurgery
    {
        public static void ImportSurgery()
        {
            using (var context = new HospitalAppEntities())
            {
                var surgery = new Surgery()
                {
                    SurgeryDate = new DateTime(2011,03,06),
                    RoomId = 11,
                    PatientId = 1,
                    DiseaseId = 2,
                    DoctorId = 3
                };
                context.Surgeries.Add(surgery);
                Console.WriteLine("Succesfuly added new surgery");
                context.SaveChanges();
            }
        }
    }
}
