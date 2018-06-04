var AttendanceService = function () {//το service έχει το πλεονέκτημα ότι δουλευει ανεξάρτητα από τον GigsController. O GigsController έχει σαν dependency το service. Reuseable code.
    var createAttendance = function (gigId, done, fail) {
        $.post("/api/attendances", { gigId: gigId })//δεν με ενδιαφέρει το button αλλά το gigId
            .done(done)
            .fail(fail);
    };

    var deleteAttendance = function (gigId, done, fail) {
        $.ajax({
            url: "/api/attendances/" + gigId,
            method: "DELETE"
        })
            .done(done)
            .fail(fail);
    };

    return {
        createAttendance: createAttendance,
        deleteAttendance: deleteAttendance
    };

}();//με τις δύο παρενθέσεις η function γίνεται ένα module iife που γίνεται κάτι σαν κλάση της C#