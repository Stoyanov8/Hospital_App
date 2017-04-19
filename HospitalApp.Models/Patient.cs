﻿using System;

namespace Models
{
    public class Patient
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Gender { get; set; }

        public DateTime? BirthDay  { get; set; }

        public string Address { get; set; }

        public string  PhoneNumber { get; set; }

    }
}