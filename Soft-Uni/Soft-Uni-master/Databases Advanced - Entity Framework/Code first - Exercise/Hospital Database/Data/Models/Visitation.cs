using System;
using System.Collections.Generic;
using System.Text;

namespace P01_HospitalDatabase.Data.Models
{
    public class Visitation
    {
        public Visitation()
        {

        }

        public Visitation(DateTime date, string comments)
        {
            this.Date = date;
            this.Comments = comments;
        }
        public int VisitationId { get; set; }
        public DateTime Date { get; set; }
        public string Comments { get; set; }
        public int PatientID { get; set; }
        public Patient Patient { get; set; }
        public int DoctorID { get; set; }
        public Doctor Doctor { get; set; }
    }
}
