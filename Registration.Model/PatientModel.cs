﻿
using System;

namespace Registration.Model
{
    public class PatientModel
    {
        public Guid Id { get; set; }

        public string Name { get; set; }
        public string Surname { get; set; }

        public string Pesel { get; set; }

        public string PhoneNumber { get; set; }

        public string Email { get; set; }

        public string Address { get; set; }

        public DateTime CreationDate { get; set; }

        public string CreationBy { get; set; }

        public DateTime? LastModificationDate { get; set; }

        public string LastModificationBy { get; set; }      
    }

}