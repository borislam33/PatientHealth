using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Data.Sql;
using System.Data.SqlClient;
using WebApplication1.Models;
using System.Web.UI.WebControls;
using WebApplication1.Repositories;

namespace WebApplication1.Controllers
{
    public class SmartHealthController : ApiController
    {
        SmartHealthRepository _smartHealthRepository = new SmartHealthRepository();


        [HttpGet]
        [Route("api/test/GetPatient/{patientId}")]
        public IHttpActionResult GetPatient(int patientId)
        {
            return Ok(_smartHealthRepository.GetPatient(patientId));
        }

        [HttpPost]
        [Route("api/test/InsertPatient")]
        public IHttpActionResult InsertPatient(Patient patient)
        {
            _smartHealthRepository.InsertPatient(patient);
            return Ok("");
        }
    }
}
