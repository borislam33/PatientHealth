using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class PrescriptionHistory
    {
        public int DoctorID { get; set; }
        public string PatientName { get; set; }
        public string PreviousPrescriptions { get; set; }
        public string CurrentPrescriptions { get; set; }
    }
}