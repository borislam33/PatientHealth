using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class MedicalHistory
    {
        public int PatientID { get; set; }
        public string Height { get; set; }
        public bool HideHistory { get; set; }
        public string Weight { get; set; }
        public string Allergies { get; set; }
        public string MedicalConditions { get; set; }
    }
}