using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Doctor
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Email { get; set; }
        public string Location { get; set; }
        public string ClinicName { get; set; }
        public string Username { get; set; }
        public bool Verified { get; set; }
    }
}