$(document).ready(function () {
    $(".error").hide();
    $("#subscription_form").submit(function () {
        $(".error").hide();
        if ($("#email").val() === "" || !validateEmail($("#email").val()))
        {
            $("#errormessage").text("Please enter a valid email address to get a quote.");
            $(".error").show();
        }
        else
        {
            jQuery.ajax({
                url: 'assets/subscription.php',
                method: 'POST',
                data: $('#subscription_form').serialize()
            })

                    .done(function (response) {
                        // Do something with the response
                        if (responseText === "OK")

                        {

                            window.location.href = "index.html";

                        }

                        else

                        {

                            $("#errormessage").text(responseText);

                            $(".error").show();

                        }
                    });
        }

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
;