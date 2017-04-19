using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using HospitalApp.Data;
namespace HospitalApp.Import
{
    public class AddExam
    {
        public static void ImportExams()
        {
            using (var context=new HospitalAppEntities())
            {
                var exam = new Exam()
                {
                    ExamDate=new DateTime(2012,02,02),
                    RoomId=2,
                    PatientId=1,
                    DiseaseId=3,
                    DoctorId=1
                };
                context.Exams.Add(exam);
                Console.WriteLine("Succesfuly added new exam");
                context.SaveChanges();
            }
        }
    }
}
