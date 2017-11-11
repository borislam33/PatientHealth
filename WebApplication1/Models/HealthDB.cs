using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public partial class HealthDB:DbContext
    {
        public HealthDB()
            : base("name=SmartHealthConnection") { }
    }
}