<?php

//connection details
$host = "hhousee.com.mysql";
$username = "hhousee_com";
$password = "SzWxsYT8";
$database = "hhousee_com";
$Address = $_REQUEST['PropertyAddress'];
$FirstName = $_REQUEST['FirstName'];
$LastName = $_REQUEST['LastName'];
$phone = $_REQUEST['phone'];
$SSN = $_REQUEST['SSN'];
$FirstName2 = $_REQUEST['FirstName2'];
$LastName2 = $_REQUEST['LastName2'];
$SSN2 = $_REQUEST['SSN2'];
$occupants = $_REQUEST['occupants'];
$pets = $_REQUEST['pets'];
$previousAddress = $_REQUEST['previousAddress'];
$owned = $_REQUEST['owned'];
$leased = $_REQUEST['leased'];
$monthlyPayment = $_REQUEST['monthlyPayment'];
$occupation = $_REQUEST['occupation'];
$employer = $_REQUEST['employer'];
$employerName = $_REQUEST['employerName'];
$employerAddress = $_REQUEST['employerAddress'];
$howLong = $_REQUEST['employedLength'];
$annualIncome = $_REQUEST['annualIncome'];
$otherIncome = $_REQUEST['otherIncome'];
$debt = $_REQUEST['debt'];
$signature = $_REQUEST['signature'];
$employerPhone = $_REQUEST['employerPhone'];
$reference = $_REQUEST['reference'];
$referencePhone = $_REQUEST['referencePhone'];
$reference2 = $_REQUEST['reference2'];
$referencePhone2 = $_REQUEST['referencePhone2'];
$email = $_REQUEST['email'];


$message = "help me";

//make connection
$con = mysqli_connect($host, $username, $password);
if (!$con) {
    die("Unable to connect to database: " . mysql_error());
    exit();
}
$mydb = mysqli_select_db($con, "hhousee_com") or die("Unable to select database");

//check for duplicates
$sql = "SELECT * FROM APPLICANTS WHERE ADDRESS ='$Address' AND LASTNAME ='$LastName' AND HASSUBSCRIBED = true";
$result = mysqli_query($con, $sql);
if ($result == false) {
    echo 'The query failed.';
    $message = "OK";

    exit();
} else if (mysqli_num_rows($result) > 0) {

    $message = "You have already applied for this property";
} else {
    $result = mysqli_query($con, "INSERT INTO APPLICANTS (ADDRESS,FIRSTNAME,LASTNAME,SSN,
                                 FIRSTNAME2,LASTNAME2,SSN2,OCCUPANTS,PETS,PREVADDRESS,OWNED
                                 ,LEASED,PAYMENT,OCCUPATION,EMPLOYER,EMPLOYERNAME,EMPLOYERADDRESS
                                 ,HOWLONG,INCOME,INCOMEOTHER,DEBT,SIGNATURE,EMAIL,REFERENCE,
                                 REFERENCEPHONE,REFERENCE2,REFERENCEPHONE2,EMPLOYERPHONE,PHONE,HASSUBSCRIBED) VALUES
            ('$Address','$FirstName','$LastName','$SSN',
            '$FirstName2','$LastName2','$SSN2','$occupants','$pets','$previousAddress',
            '$owned','$leased','$monthlyPayment','$occupation','$employer','$employerName','$employerAddress',
            '$howLong','$annualIncome','$otherIncome','$debt','$signature','$email','$reference',
            '$referencePhone','$reference2','$referencePhone2','$employerPhone','$phone',true)");


    //if success
    if ($result) {
        $message = "OK";
    } else {
        $message = "An error occured while subscription. Please try again later." . mysqli_error($con);
    }
}
mysqli_close($con);

echo $message;
