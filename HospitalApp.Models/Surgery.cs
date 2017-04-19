using System;

namespace Models
{
    public class Surgery
    {

        public int Id { get; set; }

        public DateTime SurgeryDate { get; set; }

        public int RoomId { get; set; }

        public Room Room { get; set; }

        public int PatientId { get; set; }

        public Patient Patient { get; set; }

        public int DiseaseId { get; set; }

        public Disease Disease { get; set; }

        public int DoctorId { get; set; }

        public Doctor Doctor { get; set; }

    }
}