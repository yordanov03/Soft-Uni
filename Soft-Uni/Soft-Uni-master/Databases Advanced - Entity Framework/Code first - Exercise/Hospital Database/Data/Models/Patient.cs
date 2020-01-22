using System;
using System.Collections.Generic;
using System.Text;

namespace P01_HospitalDatabase.Data.Models 
{
    public class Patient
    {

        public Patient()
        {

        }

        public Patient(string firstName, string lastName, string address, string email, bool HasInsurance)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Address = address;
            this.Email = email;
            this.HasInsurance = HasInsurance = true;
        }
        public int PatientID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public bool HasInsurance { get; set; }
        public ICollection<PatientMedicament> Perscriptions { get; set; } = new List<PatientMedicament>();
        public ICollection<Diagnose> Diagnoses { get; set; } = new List<Diagnose>();
        public ICollection<Visitation> Visitations { get; set; } = new List<Visitation>();
    }
}
