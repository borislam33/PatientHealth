using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class DoctorAvailability
    {
        public int DoctorID { get; set; }
        public TimeSpan MonStart { get; set; }
        public TimeSpan MonEnd { get; set; }
        public TimeSpan TuesStart { get; set; }
        public TimeSpan TuesEnd { get; set; }
        public TimeSpan WedStart { get; set; }
        public TimeSpan WedEnd { get; set; }
        public TimeSpan ThurStart { get; set; }
        public TimeSpan ThurEnd { get; set; }
        public TimeSpan FriStart { get; set; }
        public TimeSpan FriEnd { get; set; }
        public TimeSpan SatStart { get; set; }
        public TimeSpan SatEnd { get; set; }
        public TimeSpan SunStart { get; set; }
        public TimeSpan SunEnd { get; set; }
    }
}