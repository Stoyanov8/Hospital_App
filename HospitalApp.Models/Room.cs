using System.Collections.Generic;

namespace Models
{
    public class Room
    {
        public Room()
        {
            this.Exams=new HashSet<Exam>();
            this.Surgeries=new HashSet<Surgery>();
            this.Reahabilitations = new HashSet<Rehabilitation>();
        }
        public int Id { get; set; }

        public int Number { get; set; }

        public int Floor { get; set; }

        public virtual  ICollection<Exam> Exams { get; set; }

        public virtual ICollection<Surgery> Surgeries { get; set; }

        public virtual ICollection<Rehabilitation> Reahabilitations { get; set; }
    }
}