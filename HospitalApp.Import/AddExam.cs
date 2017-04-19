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
                var exam2 = new Exam()
                {
                    ExamDate = new DateTime(2012, 02, 02),
                    RoomId = 4,
                    PatientId = 3,
                    DiseaseId = 1,
                    DoctorId = 1
                };
                var exam3 = new Exam()
                {
                    ExamDate = new DateTime(2012, 02, 02),
                    RoomId = 6,
                    PatientId = 2,
                    DiseaseId = 1,
                    DoctorId = 2
                };
                context.Exams.Add(exam);
                context.Exams.Add(exam2);
                context.Exams.Add(exam3);
                Console.WriteLine("Succesfuly added new exam");
                context.SaveChanges();
            }
        }
    }
}
