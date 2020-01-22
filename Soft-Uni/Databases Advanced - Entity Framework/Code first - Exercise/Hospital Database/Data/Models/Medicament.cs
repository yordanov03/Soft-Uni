using System;
using System.Collections.Generic;
using System.Text;

namespace P01_HospitalDatabase.Data.Models
{
    public class Medicament
    {
        public Medicament()
        {

        }

        public Medicament(string name)
        {
            this.Name = name;
        }
        public int MedicamentID { get; set; }
        public string Name { get; set; }
        public ICollection<PatientMedicament> Perscriptions { get; set; } = new List<PatientMedicament>();
    }
}
