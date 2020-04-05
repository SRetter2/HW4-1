let i = 0
$(() => {
    $("#add-btn").on('click', function () {   
        i++;
        $("#my-form").append("<div class='col-md-6 col-md-offset-3 well'>" +
            "<div class='row'>"+
           " <span>Person</span>"+
            "<br />"+
            "<div class='col-md-6'>"+
               " <input type='text' name='ppl[" + i +"].FirstName' placeholder='FirstName' class='form-control' />"+
           " </div>"+
            "<div class='col-md-6'>"+
            "<input type='text' name='ppl[" + i +"].LastName' placeholder='LastName' class='form-control' />" +
            "</div>"+
            "<div class='col-md-6'>"+
            "<input type='text' name='ppl[" + i +"].Age' placeholder='Age' class='form-control' />"+
            "</div>"+
            "</div>");
    });
});