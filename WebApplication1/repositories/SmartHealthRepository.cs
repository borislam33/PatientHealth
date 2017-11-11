using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using WebApplication1.Models;

namespace WebApplication1.Repositories
{
    public class SmartHealthRepository
    {
        public Patient GetPatient(int patientID)
        {
            using (var db = new HealthDB())
            {
                try
                {
                    var patient = db.Database.SqlQuery<Patient>("EXEC [health].[GetPatient] @PatientID=@PatientID",
                        new SqlParameter("@PatientID", patientID)).FirstOrDefault();

                    return patient;
                }
                catch (DbEntityValidationException ex)
                {
                    string message = ex.EntityValidationErrors.SelectMany(errors => errors.ValidationErrors).Aggregate("", (current, errors) => current + ($"Property: {errors.PropertyName} Error: {errors.ErrorMessage}" + Environment.NewLine));
                    throw new Exception(message, ex);
                }
            }
        }

        public void InsertPatient(Patient patient)
        {
            using (var db = new HealthDB())
            {
                try
                {
                    db.Database.ExecuteSqlCommand("EXEC [health].[InsertTest] @FirstName=@FirstName, @LastName=@LastName, @Address=@Address, @DateOfBirth=@DateOfBirth, @PhoneNumber=@PhoneNumber",
                        new SqlParameter("@FirstName", patient.FirstName),
                        new SqlParameter("@LastName", patient.LastName),
                        new SqlParameter("@Address", patient.Address),
                        new SqlParameter("@DateOfBirth", patient.DateOfBirth),
                        new SqlParameter("@PhoneNumber", patient.PhoneNumber));
                }
                catch (DbEntityValidationException ex)
                {
                    string message = ex.EntityValidationErrors.SelectMany(errors => errors.ValidationErrors).Aggregate("", (current, errors) => current + ($"Property: {errors.PropertyName} Error: {errors.ErrorMessage}" + Environment.NewLine));
                    throw new Exception(message, ex);
                }
            }
        }
    }
}