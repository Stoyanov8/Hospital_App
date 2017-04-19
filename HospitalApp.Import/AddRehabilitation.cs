using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using HospitalApp.Data;
namespace HospitalApp.Import
{
    public class AddRehabilitation
    {
        public static void ImportRehabilitation()
        {
            using (var context = new HospitalAppEntities())
            {
                var rehabilitation = new Rehabilitation()
                {
                    RehabilitationStartDate=new DateTime(2012,02,03),
                    RehabilitationEndDate=new DateTime(2012,03,04),
                    RoomId=10,
                    PatientId=3,
                    DiseaseId=1,
                    DoctorId=2
                };
                context.Rehabilitations.Add(rehabilitation);
                Console.WriteLine("Succesfuly added new rehabilitation");
                context.SaveChanges();
            }
        }
    }
}
