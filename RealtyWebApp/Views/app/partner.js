$(document).ready(function () {
    $(".error").hide();
    // Variable to hold request
    var request;

// Bind to the submit event of our form
    $("#partner_form").submit(function (event) {
        $(".error").hide();
        if ($("#email").val() === "" || !validateEmail($("#email").val()))
        {
            $("#errormessage").text("Please enter a valid email address to register.");
            $(".error").show();
        }
        else
        {
            // Abort any pending request
            if (request) {
                request.abort();
            }
            // setup some local variables
            var $form = $(this);

            // Let's select and cache all the fields
            var $inputs = $form.find("input, select, button, textarea");

            // Serialize the data in the form
            var serializedData = $form.serialize();

            // Let's disable the inputs for the duration of the Ajax request.
            // Note: we disable elements AFTER the form data has been serialized.
            // Disabled form elements will not be serialized.
            $inputs.prop("disabled", true);

            // Fire off the request to /form.php
            request = $.ajax({
                url: "app.php",
                type: "post",
                data: serializedData

            });
            // Callback handler that will be called on success
            request.success(function (response, textStatus, jqXHR) {
                if (response === "OK")
                {
                    window.location.href = "thankyou.html";
                }
                else
                {
                    $("#errormessage").text(response);
                    $(".error").show();
                }

            });
        }


        // Callback handler that will be called on failure
        request.fail(function (jqXHR, textStatus, errorThrown) {
            // Log the error to the console
            console.error(
                    "The following error occurred: " +
                    textStatus, errorThrown

                    );

        });

        // Callback handler that will be called regardless
        // if the request failed or succeeded
        request.always(function () {
            // Reenable the inputs
            $inputs.prop("disabled", false);
        });

        // Prevent default posting of form
        event.preventDefault();
    });
});

function validateEmail(sEmail) {
    var filter = /^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$/;
    if (filter.test(sEmail)) {
        return true;
    }
    else {
        return false;
    }
}
