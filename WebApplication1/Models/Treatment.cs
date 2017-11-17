using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Treatment
    {
        public int DoctorID { get; set; }
        public string TreatmentName { get; set; }
        public double Price { get; set; }
    }
}