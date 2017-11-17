







// Begin service functions
var insertedPatient = { Name: "John Doe", Address: "Massachusetts", DateOfBirth: "10/11/12", PhoneNumber: "123-412-2314", Username: "jdoe123" };

var patient;
function GetPatient(PatientID) {
    console.log('Getting patient with ID:');
    console.log(PatientID);
        $.ajax({
            type: "GET",
            url: "../api/SmartHealth/GetPatient/"+PatientID,
            dataType: "json",
            contentType: "text/html",
            success: function (data) {
                patient = data;
                console.log('Succssfully got patient:');
                console.log(patient);
            },
            error: WeSuckFunc
        });
}

function InsertPatient(Patient) {
    console.log('Inserting patient:')
    console.log(Patient);
        $.ajax({
            type: "POST",
            url: "../api/SmartHealth/InsertPatient/",
            dataType: "json",
            data: JSON.stringify(Patient),
            contentType: "application/json; charset=utf-8",
            success: function () {
                console.log('Successfully inserted patient');
            },
            error: WeSuckFunc
        });
}

function DeleteAppointment(Appointment) {
    console.log('Deleting appointment:')
    console.log(Appointment);
    $.ajax({
        type: "POST",
        url: "../api/SmartHealth/DeleteAppointment/",
        dataType: "json",
        data: JSON.stringify(Appointment),
        contentType: "application/json; charset=utf-8",
        success: function () {
            console.log('Successfully deleted appointment');
        },
        error: WeSuckFunc
    });
}

var doctor;
function GetDoctor(DoctorID) {
    console.log('Getting patient with ID:');
    console.log(DoctorID);
    $.ajax({
        type: "GET",
        url: "../api/SmartHealth/GetDoctor/" + DoctorID,
        dataType: "json",
        contentType: "text/html",
        success: function (data) {
            doctor = data;
            console.log('Succssfully got doctor:');
            console.log(doctor);
        },
        error: WeSuckFunc
    });
}

var doctorAppointments;
function GetDoctorAppointment(DoctorName) {
    console.log('Getting doctor appointments by doctor name:');
    console.log(DoctorName);
    $.ajax({
        type: "GET",
        url: "../api/SmartHealth/GetDoctorAppointment/" + DoctorName,
        dataType: "json",
        contentType: "text/html",
        success: function (data) {
            doctorAppointments = data;
            console.log('Succssfully got doctor appointments:');
            console.log(doctorAppointments);
        },
        error: WeSuckFunc
    });
}

var doctorAvailability;
function GetDoctorAvailability(DoctorID) {
    console.log('Getting doctor availability by doctor id:');
    console.log(DoctorID);
    $.ajax({
        type: "GET",
        url: "../api/SmartHealth/GetDoctorAvailability/" + DoctorID,
        dataType: "json",
        contentType: "text/html",
        success: function (data) {
            doctorAvailability = data;
            console.log('Succssfully got doctor availability:');
            console.log(doctorAvailability);
        },
        error: WeSuckFunc
    });
}

var doctorID;
function GetDoctorID(Username) {
    console.log('Getting doctor id by username');
    console.log(Username);
    $.ajax({
        type: "GET",
        url: "../api/SmartHealth/GetDoctorID/" + Username,
        dataType: "json",
        contentType: "text/html",
        success: function (data) {
            doctorID = data;
            console.log('Succssfully got doctor id:');
            console.log(doctorID);
        },
        error: WeSuckFunc
    });
}

var medicalHistory;
function GetMedicalHistory(PatientID) {
    console.log('Getting medical history by patient id:');
    console.log(PatientID);
    $.ajax({
        type: "GET",
        url: "../api/SmartHealth/GetMedicalHistory/" + PatientID,
        dataType: "json",
        contentType: "text/html",
        success: function (data) {
            medicalHistory = data;
            console.log('Succssfully got medical history:');
            console.log(medicalHistory);
        },
        error: WeSuckFunc
    });
}

var patientAppointments;
function GetPatientAppointment(PatientName) {
    console.log('Getting patient appointments by patient name:');
    console.log(PatientName);
    $.ajax({
        type: "GET",
        url: "../api/SmartHealth/GetPatientAppointment/" + PatientName,
        dataType: "json",
        contentType: "text/html",
        success: function (data) {
            patientAppointments = data;
            console.log('Succssfully got patient appointments:');
            console.log(patientAppointments);
        },
        error: WeSuckFunc
    });
}

var patientID;
function GetPatientID(Username) {
    console.log('Getting patient id by username');
    console.log(Username);
    $.ajax({
        type: "GET",
        url: "../api/SmartHealth/GetPatientID/" + Username,
        dataType: "json",
        contentType: "text/html",
        success: function (data) {
            patientID = data;
            console.log('Succssfully got patient id:');
            console.log(patientID);
        },
        error: WeSuckFunc
    });
}

function InsertMedicalHistory(History) {
    console.log('Inserting medical history:')
    console.log(History);
    $.ajax({
        type: "POST",
        url: "../api/SmartHealth/InsertMedicalHistory/",
        dataType: "json",
        data: JSON.stringify(History),
        contentType: "application/json; charset=utf-8",
        success: function () {
            console.log('Successfully inserted medical history');
        },
        error: WeSuckFunc
    });
}

function InsertNewAppointment(Appointment) {
    console.log('Inserting new appointment:')
    console.log(Appointment);
    $.ajax({
        type: "POST",
        url: "../api/SmartHealth/InsertNewAppointment/",
        dataType: "json",
        data: JSON.stringify(Appointment),
        contentType: "application/json; charset=utf-8",
        success: function () {
            console.log('Successfully inserted new appointment');
        },
        error: WeSuckFunc
    });
}

function InsertDoctor(Doctor) {
    console.log('Inserting doctor:')
    console.log(Doctor);
    $.ajax({
        type: "POST",
        url: "../api/SmartHealth/InsertDoctor/",
        dataType: "json",
        data: JSON.stringify(Doctor),
        contentType: "application/json; charset=utf-8",
        success: function () {
            console.log('Successfully inserted doctor');
        },
        error: WeSuckFunc
    });
}

function InsertDoctorAvailability(Availability) {
    console.log('Inserting doctor availability:')
    console.log(Availability);
    $.ajax({
        type: "POST",
        url: "../api/SmartHealth/InsertDoctorAvailability/",
        dataType: "json",
        data: JSON.stringify(Availability),
        contentType: "application/json; charset=utf-8",
        success: function () {
            console.log('Successfully inserted doctor availability');
        },
        error: WeSuckFunc
    });
}

function InsertTreatment(Treatment) {
    console.log('Inserting treatment:')
    console.log(Treatment);
    $.ajax({
        type: "POST",
        url: "../api/SmartHealth/InsertTreatment/",
        dataType: "json",
        data: JSON.stringify(Treatment),
        contentType: "application/json; charset=utf-8",
        success: function () {
            console.log('Successfully inserted treatment');
        },
        error: WeSuckFunc
    });
}

function InsertPrescriptionHistory(History) {
    console.log('Inserting prescription history:')
    console.log(History);
    $.ajax({
        type: "POST",
        url: "../api/SmartHealth/InsertPrescriptionHistory/",
        dataType: "json",
        data: JSON.stringify(History),
        contentType: "application/json; charset=utf-8",
        success: function () {
            console.log('Successfully inserted prescription history');
        },
        error: WeSuckFunc
    });
}

function InsertUsernamePasssword(Info) {
    console.log('Inserting username and password:')
    console.log(Info);
    $.ajax({
        type: "POST",
        url: "../api/SmartHealth/InsertUsernamePassword/",
        dataType: "json",
        data: JSON.stringify(Info),
        contentType: "application/json; charset=utf-8",
        success: function () {
            console.log('Successfully inserted username and password');
        },
        error: WeSuckFunc
    });
}

function ValidateCredentials(Info) {
    console.log('Validating credentials:')
    console.log(Info);
    $.ajax({
        type: "POST",
        url: "../api/SmartHealth/ValidateCredentials/",
        dataType: "json",
        data: JSON.stringify(Info),
        contentType: "application/json; charset=utf-8",
        success: function (data) {
            console.log('Successfully validated credentials, can user log in?');
            console.log(data);
        },
        error: WeSuckFunc
    });
}

function UpdateAppointment(Appointment) {
    console.log('Updating appointment')
    console.log(Appointment);
    $.ajax({
        type: "POST",
        url: "../api/SmartHealth/UpdateAppointment/",
        dataType: "json",
        data: JSON.stringify(Appointment),
        contentType: "application/json; charset=utf-8",
        success: function () {
            console.log('Successfully updated appointment');
        },
        error: WeSuckFunc
    });
}

function UpdatePassword(Info) {
    console.log('Updating password for username:')
    console.log(Info);
    $.ajax({
        type: "POST",
        url: "../api/SmartHealth/UpdatePassword/",
        dataType: "json",
        data: JSON.stringify(Info),
        contentType: "application/json; charset=utf-8",
        success: function () {
            console.log('Successfully updated password');
        },
        error: WeSuckFunc
    });
}

function WeSuckFunc() {
        console.log("You failed");
}
