
var insertedPatient = { FirstName: "John", LastName: "Doe", Address: "Canada", DateOfBirth: "10/11/12", PhoneNumber: "123-412-2314" };
var patient;
function GetPatient(PatientID) {
    console.log(PatientID);
        $.ajax({
            type: "GET",
            url: "../api/test/GetPatient/"+PatientID,
            contentType: "text/html",
            success: function (data) {
                console.log(data);
                patient = data;
                console.log('hello');
                console.log(patient);
            },
            error: WeSuckFunc
        });
    }

function InsertPatient(Patient) {
    console.log(Patient);
        $.ajax({
            type: "POST",
            url: "../api/test/InsertPatient/",
            data: JSON.stringify(Patient),
            contentType:'text/html',
            //contentType: "application/json; charset=utf-8",
            success: function (data) {
                console.log('success');
            },
            error: WeSuckFunc
        });
    }

function WeSuckFunc() {
        console.log("You failed");
}
