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
        [Route("api/SmartHealth/GetPatient/{patientId}")]
        public IHttpActionResult GetPatient(int patientId)
        {
            return Ok(_smartHealthRepository.GetPatient(patientId));
        }

        [HttpPost]
        [Route("api/SmartHealth/InsertPatient")]
        public IHttpActionResult InsertPatient(Patient patient)
        {
            _smartHealthRepository.InsertPatient(patient);
            return Ok("");
        }

        [HttpPost]
        [Route("api/SmartHealth/DeleteAppointment")]
        public IHttpActionResult DeleteAppointment(Appointment appointment)
        {
            _smartHealthRepository.DeleteAppointment(appointment);
            return Ok("");
        }

        [HttpGet]
        [Route("api/SmartHealth/GetDoctor/{doctorId}")]
        public IHttpActionResult GetDoctor(int doctorId)
        {
            return Ok(_smartHealthRepository.GetDoctor(doctorId));
        }

        [HttpGet]
        [Route("api/SmartHealth/GetDoctorAppointment/{doctorName}")]
        public IHttpActionResult GetDoctorAppointment(string doctorName)
        {
            return Ok(_smartHealthRepository.GetDoctorAppointment(doctorName));
        }

        [HttpGet]
        [Route("api/SmartHealth/GetDoctorAvailability/{doctorId}")]
        public IHttpActionResult GetDoctorAvailability(int doctorId)
        {
            return Ok(_smartHealthRepository.GetDoctorAvailability(doctorId));
        }

        [HttpGet]
        [Route("api/SmartHealth/GetDoctorID/{username}")]
        public IHttpActionResult GetDoctorID(string username)
        {
            return Ok(_smartHealthRepository.GetDoctorID(username));
        }

        [HttpGet]
        [Route("api/SmartHealth/GetMedicalHistory/{patientId}")]
        public IHttpActionResult GetMedicalHistory(int patientId)
        {
            return Ok(_smartHealthRepository.GetMedicalHistory(patientId));
        }

        [HttpGet]
        [Route("api/SmartHealth/GetPatientAppointment/{patientName}")]
        public IHttpActionResult GetPatientAppointment(string patientName)
        {
            return Ok(_smartHealthRepository.GetPatientAppointment(patientName));
        }

        [HttpGet]
        [Route("api/SmartHealth/GetPatientID/{username}")]
        public IHttpActionResult GetPatientID(string username)
        {
            return Ok(_smartHealthRepository.GetPatientID(username));
        }

        [HttpGet]
        [Route("api/SmartHealth/GetPrescriptionHistory/{doctorId}")]
        public IHttpActionResult GetPrescriptionHistory(int doctorId)
        {
            return Ok(_smartHealthRepository.GetPrescriptionHistory(doctorId));
        }

        [HttpPost]
        [Route("api/SmartHealth/InsertMedicalHistory")]
        public IHttpActionResult InsertMedicalHistory(MedicalHistory history)
        {
            _smartHealthRepository.InsertMedicalHistory(history);
            return Ok("");
        }

        [HttpPost]
        [Route("api/SmartHealth/InsertNewAppointment")]
        public IHttpActionResult InsertNewAppointment(Appointment appointment)
        {
            _smartHealthRepository.InsertNewAppointment(appointment);
            return Ok("");
        }

        [HttpPost]
        [Route("api/SmartHealth/InsertDoctor")]
        public IHttpActionResult InsertDoctor(Doctor doctor)
        {
            _smartHealthRepository.InsertDoctor(doctor);
            return Ok("");
        }

        [HttpPost]
        [Route("api/SmartHealth/InsertDoctorAvailability")]
        public IHttpActionResult InsertDoctorAvailability(DoctorAvailability availability)
        {
            _smartHealthRepository.InsertDoctorAvailability(availability);
            return Ok("");
        }

        [HttpPost]
        [Route("api/SmartHealth/InsertTreatment")]
        public IHttpActionResult InsertTreatment(Treatment treatment)
        {
            _smartHealthRepository.InsertTreatment(treatment);
            return Ok("");
        }

        [HttpPost]
        [Route("api/SmartHealth/InsertPrescriptionHistory")]
        public IHttpActionResult InsertPrescriptionHistory(PrescriptionHistory history)
        {
            _smartHealthRepository.InsertPrescriptionHistory(history);
            return Ok("");
        }

        [HttpPost]
        [Route("api/SmartHealth/InsertUsernamePassword")]
        public IHttpActionResult InsertUsernamePassword(UsernamePassword info)
        {
            _smartHealthRepository.InsertUsernamePassword(info);
            return Ok("");
        }

        [HttpPost]
        [Route("api/SmartHealth/ValidateCredentials")]
        public IHttpActionResult Login(UsernamePassword info)
        {
            return Ok(_smartHealthRepository.ValidateCredentials(info));
        }

        [HttpPost]
        [Route("api/SmartHealth/UpdateAppointment")]
        public IHttpActionResult UpdateAppointment(Appointment appointment)
        {
            _smartHealthRepository.UpdateAppointment(appointment);
            return Ok("");
        }

        [HttpPost]
        [Route("api/SmartHealth/UpdatePassword")]
        public IHttpActionResult UpdatePassword(UsernamePassword info)
        {
            _smartHealthRepository.UpdatePassword(info);
            return Ok("");
        }
    }
}
