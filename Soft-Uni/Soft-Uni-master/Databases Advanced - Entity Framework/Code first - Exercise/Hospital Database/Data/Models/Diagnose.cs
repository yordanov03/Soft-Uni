﻿using System;
using System.Collections.Generic;
using System.Text;

namespace P01_HospitalDatabase.Data.Models
{
    public class Diagnose
    {
        public Diagnose()
        {

        }

        public Diagnose(string name, string comments)
        {
            this.Name = name;
            this.Comments = comments;
        }
        public int DiagnoseId { get; set; }
        public string Name { get; set; }
        public string Comments { get; set; }
        public Patient Patient { get; set; }
        public int PatientID { get; set; }
    }
}
