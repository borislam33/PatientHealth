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
                    db.Database.ExecuteSqlCommand("EXEC [health].[InsertNewPatient] @Name=@FirstName, @Address=@Address, @DateOfBirth=@DateOfBirth, @PhoneNumber=@PhoneNumber, @Username=@Username",
                        new SqlParameter("@FirstName", patient.Name),
                        new SqlParameter("@Username", patient.Username),
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

        public void DeleteAppointment(Appointment appointment)
        {
            using (var db = new HealthDB())
            {
                try
                {
                    db.Database.ExecuteSqlCommand("EXEC [health].[DeleteAppointment] @PatientName=@PatientName, @DoctorName=@DoctorName, @Date=@Date",
                        new SqlParameter("@PatientName", appointment.PatientName),
                        new SqlParameter("@DoctorName", appointment.DoctorName),
                        new SqlParameter("@Date", appointment.Date));
                }
                catch (DbEntityValidationException ex)
                {
                    string message = ex.EntityValidationErrors.SelectMany(errors => errors.ValidationErrors).Aggregate("", (current, errors) => current + ($"Property: {errors.PropertyName} Error: {errors.ErrorMessage}" + Environment.NewLine));
                    throw new Exception(message, ex);
                }
            }
        }

        public Doctor GetDoctor(int doctorID)
        {
            using (var db = new HealthDB())
            {
                try
                {
                    var doctor = db.Database.SqlQuery<Doctor>("EXEC [health].[GetDoctor] @DoctorID=@DoctorID",
                        new SqlParameter("@DoctorID", doctorID)).FirstOrDefault();

                    return doctor;
                }
                catch (DbEntityValidationException ex)
                {
                    string message = ex.EntityValidationErrors.SelectMany(errors => errors.ValidationErrors).Aggregate("", (current, errors) => current + ($"Property: {errors.PropertyName} Error: {errors.ErrorMessage}" + Environment.NewLine));
                    throw new Exception(message, ex);
                }
            }
        }

        public List<Appointment> GetDoctorAppointment(string doctorName)
        {
            using (var db = new HealthDB())
            {
                try
                {
                    var appointments = db.Database.SqlQuery<Appointment>("EXEC [health].[GetDoctorAppointment] @DoctorName=@DoctorName",
                        new SqlParameter("@DoctorName", doctorName)).ToList();

                    return appointments;
                }
                catch (DbEntityValidationException ex)
                {
                    string message = ex.EntityValidationErrors.SelectMany(errors => errors.ValidationErrors).Aggregate("", (current, errors) => current + ($"Property: {errors.PropertyName} Error: {errors.ErrorMessage}" + Environment.NewLine));
                    throw new Exception(message, ex);
                }
            }
        }

        public DoctorAvailability GetDoctorAvailability(int doctorID)
        {
            using (var db = new HealthDB())
            {
                try
                {
                    var doctorAvailability = db.Database.SqlQuery<DoctorAvailability>("EXEC [health].[GetDoctorAvailability] @DoctorID=@DoctorID",
                        new SqlParameter("@DoctorID", doctorID)).FirstOrDefault();

                    return doctorAvailability;
                }
                catch (DbEntityValidationException ex)
                {
                    string message = ex.EntityValidationErrors.SelectMany(errors => errors.ValidationErrors).Aggregate("", (current, errors) => current + ($"Property: {errors.PropertyName} Error: {errors.ErrorMessage}" + Environment.NewLine));
                    throw new Exception(message, ex);
                }
            }
        }

        public int GetDoctorID(string username)
        {
            using (var db = new HealthDB())
            {
                try
                {
                    var doctorId = db.Database.SqlQuery<int>("EXEC [health].[GetDoctorID] @Username=@Username",
                        new SqlParameter("@Username", username)).FirstOrDefault();

                    return doctorId;
                }
                catch (DbEntityValidationException ex)
                {
                    string message = ex.EntityValidationErrors.SelectMany(errors => errors.ValidationErrors).Aggregate("", (current, errors) => current + ($"Property: {errors.PropertyName} Error: {errors.ErrorMessage}" + Environment.NewLine));
                    throw new Exception(message, ex);
                }
            }
        }

        public MedicalHistory GetMedicalHistory(int patientID)
        {
            using (var db = new HealthDB())
            {
                try
                {
                    var medicalHistory = db.Database.SqlQuery<MedicalHistory>("EXEC [health].[GetMedicalHistory] @PatientID=@PatientID",
                        new SqlParameter("@PatientID", patientID)).FirstOrDefault();

                    return medicalHistory;
                }
                catch (DbEntityValidationException ex)
                {
                    string message = ex.EntityValidationErrors.SelectMany(errors => errors.ValidationErrors).Aggregate("", (current, errors) => current + ($"Property: {errors.PropertyName} Error: {errors.ErrorMessage}" + Environment.NewLine));
                    throw new Exception(message, ex);
                }
            }
        }

        public List<Appointment> GetPatientAppointment(string patientName)
        {
            using (var db = new HealthDB())
            {
                try
                {
                    var appointments = db.Database.SqlQuery<Appointment>("EXEC [health].[GetPatientAppointment] @PatientName=@PatientName",
                        new SqlParameter("@PatientName", patientName)).ToList();

                    return appointments;
                }
                catch (DbEntityValidationException ex)
                {
                    string message = ex.EntityValidationErrors.SelectMany(errors => errors.ValidationErrors).Aggregate("", (current, errors) => current + ($"Property: {errors.PropertyName} Error: {errors.ErrorMessage}" + Environment.NewLine));
                    throw new Exception(message, ex);
                }
            }
        }

        public int GetPatientID(string username)
        {
            using (var db = new HealthDB())
            {
                try
                {
                    var patientId = db.Database.SqlQuery<int>("EXEC [health].[GetPatientID] @Username=@Username",
                        new SqlParameter("@Username", username)).FirstOrDefault();

                    return patientId;
                }
                catch (DbEntityValidationException ex)
                {
                    string message = ex.EntityValidationErrors.SelectMany(errors => errors.ValidationErrors).Aggregate("", (current, errors) => current + ($"Property: {errors.PropertyName} Error: {errors.ErrorMessage}" + Environment.NewLine));
                    throw new Exception(message, ex);
                }
            }
        }

        // Possibly will need to change this 
        public List<PrescriptionHistory> GetPrescriptionHistory(int doctorId)
        {
            using (var db = new HealthDB())
            {
                try
                {
                    var prescriptionHistory = db.Database.SqlQuery<PrescriptionHistory>("EXEC [health].[GetPrescriptionHistory] @DoctorID=@DoctorID",
                        new SqlParameter("@DoctorID", doctorId)).ToList();

                    return prescriptionHistory;
                }
                catch (DbEntityValidationException ex)
                {
                    string message = ex.EntityValidationErrors.SelectMany(errors => errors.ValidationErrors).Aggregate("", (current, errors) => current + ($"Property: {errors.PropertyName} Error: {errors.ErrorMessage}" + Environment.NewLine));
                    throw new Exception(message, ex);
                }
            }
        }

        public void InsertMedicalHistory(MedicalHistory history)
        {
            using (var db = new HealthDB())
            {
                try
                {
                    db.Database.ExecuteSqlCommand("EXEC [health].[InsertMedicalHistory] @PatientID=@PatientID, @Height=@Height, @HideHistory=@HideHistory, @Weight=@Weight, @Allergies=@Allergies, @MedicalConditions=@MedicalConditions",
                        new SqlParameter("@PatientID", history.PatientID),
                        new SqlParameter("@Height", history.Height),
                        new SqlParameter("@HideHistory", history.HideHistory),
                        new SqlParameter("@Weight", history.Weight),
                        new SqlParameter("@Allergies", history.Allergies),
                        new SqlParameter("@MedicalConditions", history.MedicalConditions));
                }
                catch (DbEntityValidationException ex)
                {
                    string message = ex.EntityValidationErrors.SelectMany(errors => errors.ValidationErrors).Aggregate("", (current, errors) => current + ($"Property: {errors.PropertyName} Error: {errors.ErrorMessage}" + Environment.NewLine));
                    throw new Exception(message, ex);
                }
            }
        }

        public void InsertNewAppointment(Appointment appointment)
        {
            using (var db = new HealthDB())
            {
                try
                {
                    db.Database.ExecuteSqlCommand("EXEC [health].[InsertNewAppointment] @DoctorName=@DoctorName, @PatientName=@PatientName, @Date=@Date, @Description=@Description, @isPending=@isPending",
                        new SqlParameter("@DoctorName", appointment.DoctorName),
                        new SqlParameter("@PatientName", appointment.PatientName),
                        new SqlParameter("@Date", appointment.Date),
                        new SqlParameter("@Description", appointment.Description),
                        new SqlParameter("@isPending", appointment.IsPending));
                }
                catch (DbEntityValidationException ex)
                {
                    string message = ex.EntityValidationErrors.SelectMany(errors => errors.ValidationErrors).Aggregate("", (current, errors) => current + ($"Property: {errors.PropertyName} Error: {errors.ErrorMessage}" + Environment.NewLine));
                    throw new Exception(message, ex);
                }
            }
        }

        public void InsertDoctor(Doctor doctor)
        {
            using (var db = new HealthDB())
            {
                try
                {
                    db.Database.ExecuteSqlCommand("EXEC [health].[InsertNewPatient] @Name=@Name, @Email=@Email, @Address=@Address, @DateOfBirth=@DateOfBirth, @Location=@Location, @ClinicName=@ClinicName, @Username=@Username, @Verified=@Verified",
                        new SqlParameter("@Name", doctor.Name),
                        new SqlParameter("@Email", doctor.Email),
                        new SqlParameter("@Address", doctor.Address),
                        new SqlParameter("@DateOfBirth", doctor.DateOfBirth),
                        new SqlParameter("@Location", doctor.Location),
                        new SqlParameter("@ClinicName", doctor.ClinicName),
                        new SqlParameter("@Username", doctor.Username),
                        new SqlParameter("@Verified", doctor.Verified));
                }
                catch (DbEntityValidationException ex)
                {
                    string message = ex.EntityValidationErrors.SelectMany(errors => errors.ValidationErrors).Aggregate("", (current, errors) => current + ($"Property: {errors.PropertyName} Error: {errors.ErrorMessage}" + Environment.NewLine));
                    throw new Exception(message, ex);
                }
            }
        }

        public void InsertDoctorAvailability(DoctorAvailability availability)
        {
            using (var db = new HealthDB())
            {
                try
                {
                    db.Database.ExecuteSqlCommand("EXEC [health].[InsertNewDoctorAvailability] @DoctorID=@DoctorID, @MonStart=@MonStart, @MonEnd=@MonEnd, @TuesStart=@TuesStart, @TuesEnd=@TuesEnd, @WedStart=@WedStart, @WedEnd=@WedEnd, @ThursStart=@ThursStart, @ThursEnd=@ThursEnd, @FriStart=@FriStart, @FriEnd=@FriEnd, @SatStart=@SatStart, @SatEnd=@SatEnd, @SunStart=@SunStart, @SunEnd=@SunEnd",
                        new SqlParameter("@DoctorID", availability.DoctorID),
                        new SqlParameter("@MonStart", availability.MonStart),
                        new SqlParameter("@MonEnd", availability.MonEnd),
                        new SqlParameter("@TuesStart", availability.TuesStart),
                        new SqlParameter("@TuesEnd", availability.TuesEnd),
                        new SqlParameter("@WedStart", availability.WedStart),
                        new SqlParameter("@WedEnd", availability.WedEnd),
                        new SqlParameter("@ThursStart", availability.ThurStart),
                        new SqlParameter("@ThursEnd", availability.ThurEnd),
                        new SqlParameter("@FriStart", availability.FriStart),
                        new SqlParameter("@FriEnd", availability.FriEnd),
                        new SqlParameter("@SatStart", availability.SatStart),
                        new SqlParameter("@SatEnd", availability.SatEnd),
                        new SqlParameter("@SunStart", availability.SunStart),
                        new SqlParameter("@SunEnd", availability.SunEnd));
                }
                catch (DbEntityValidationException ex)
                {
                    string message = ex.EntityValidationErrors.SelectMany(errors => errors.ValidationErrors).Aggregate("", (current, errors) => current + ($"Property: {errors.PropertyName} Error: {errors.ErrorMessage}" + Environment.NewLine));
                    throw new Exception(message, ex);
                }
            }
        }

        public void InsertTreatment(Treatment treatment)
        {
            using (var db = new HealthDB())
            {
                try
                {
                    db.Database.ExecuteSqlCommand("EXEC [health].[InsertNewTreatment] @DoctorID=@DoctorID, @TreatmentName=@TreatmentName, @Price=@Price",
                        new SqlParameter("@DoctorID", treatment.DoctorID),
                        new SqlParameter("@TreatmentName", treatment.TreatmentName),
                        new SqlParameter("@Price", treatment.Price));
                }
                catch (DbEntityValidationException ex)
                {
                    string message = ex.EntityValidationErrors.SelectMany(errors => errors.ValidationErrors).Aggregate("", (current, errors) => current + ($"Property: {errors.PropertyName} Error: {errors.ErrorMessage}" + Environment.NewLine));
                    throw new Exception(message, ex);
                }
            }
        }

        public void InsertPrescriptionHistory(PrescriptionHistory history)
        {
            using (var db = new HealthDB())
            {
                try
                {
                    db.Database.ExecuteSqlCommand("EXEC [health].[InsertPrescriptionHistory] @DoctorID=@DoctorID, @PatientName=@PatientName, @PreviousPrescriptions=@PreviousPrescriptions, @CurrentPrescriptions=@CurrentPrescriptions",
                        new SqlParameter("@DoctorID", history.DoctorID),
                        new SqlParameter("@PatientName", history.PatientName),
                        new SqlParameter("@PreviousPrescriptions", history.PreviousPrescriptions),
                        new SqlParameter("@CurrentPrescriptions", history.CurrentPrescriptions));
                }
                catch (DbEntityValidationException ex)
                {
                    string message = ex.EntityValidationErrors.SelectMany(errors => errors.ValidationErrors).Aggregate("", (current, errors) => current + ($"Property: {errors.PropertyName} Error: {errors.ErrorMessage}" + Environment.NewLine));
                    throw new Exception(message, ex);
                }
            }
        }

        public void InsertUsernamePassword(UsernamePassword info)
        {
            using (var db = new HealthDB())
            {
                try
                {
                    string hashedPassword = BCrypt.HashPassword(info.Password, BCrypt.GenerateSalt());

                    db.Database.ExecuteSqlCommand("EXEC [health].[InsertUsernamePassword] @Username=@Username, @Password=@Password",
                        new SqlParameter("@Username", info.Username),
                        new SqlParameter("@Password", hashedPassword));
                }
                catch (DbEntityValidationException ex)
                {
                    string message = ex.EntityValidationErrors.SelectMany(errors => errors.ValidationErrors).Aggregate("", (current, errors) => current + ($"Property: {errors.PropertyName} Error: {errors.ErrorMessage}" + Environment.NewLine));
                    throw new Exception(message, ex);
                }
            }
        }

        public bool ValidateCredentials(UsernamePassword info)
        {
            using (var db = new HealthDB())
            {
                try
                {

                    var passwordFromDB = db.Database.SqlQuery<string>("EXEC [health].[GetPassword] @Username=@Username",
                        new SqlParameter("@Username", info.Username)).FirstOrDefault();

                    return BCrypt.CheckPassword(info.Password, passwordFromDB);
                }
                catch (DbEntityValidationException ex)
                {
                    string message = ex.EntityValidationErrors.SelectMany(errors => errors.ValidationErrors).Aggregate("", (current, errors) => current + ($"Property: {errors.PropertyName} Error: {errors.ErrorMessage}" + Environment.NewLine));
                    throw new Exception(message, ex);
                }
            }
        }

        public void UpdateAppointment(Appointment appointment)
        {
            using (var db = new HealthDB())
            {
                try
                {
                    db.Database.ExecuteSqlCommand("EXEC [health].[UpdateAppointmentConfirm] @DoctorName=@DoctorName, @PatientName=@PatientName, @IsPending=@IsPending",
                        new SqlParameter("@DoctorName", appointment.DoctorName),
                        new SqlParameter("@PatientName", appointment.PatientName),
                        new SqlParameter("@IsPending", appointment.IsPending));
                }
                catch (DbEntityValidationException ex)
                {
                    string message = ex.EntityValidationErrors.SelectMany(errors => errors.ValidationErrors).Aggregate("", (current, errors) => current + ($"Property: {errors.PropertyName} Error: {errors.ErrorMessage}" + Environment.NewLine));
                    throw new Exception(message, ex);
                }
            }
        }

        public void UpdatePassword(UsernamePassword info)
        {
            using (var db = new HealthDB())
            {
                try
                {
                    string hashedPassword = BCrypt.HashPassword(info.Password, BCrypt.GenerateSalt());

                    db.Database.ExecuteSqlCommand("EXEC [health].[UpdateUsername-Password] @Username=@Username, @Password=@Password",
                        new SqlParameter("@Username", info.Username),
                        new SqlParameter("@Password", hashedPassword));
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