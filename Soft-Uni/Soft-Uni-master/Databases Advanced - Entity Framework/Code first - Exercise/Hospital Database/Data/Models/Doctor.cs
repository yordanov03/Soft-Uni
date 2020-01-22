using System;
using System.Collections.Generic;
using System.Text;

namespace P01_HospitalDatabase.Data.Models
{
    public class Doctor
    {
        public Doctor()
        {

        }

        public Doctor(string name, string specialty)
        {
            this.Name = name;
            this.Specialty = specialty;
        }

        public int DoctorId { get; set; }
        public string Specialty { get; set; }
        public string Name { get; set; }

        public ICollection<Visitation> Visitations { get; set; } = new List<Visitation>();
        public ICollection<Patient> Patients { get; set; } = new List<Patient>();
    }
}
