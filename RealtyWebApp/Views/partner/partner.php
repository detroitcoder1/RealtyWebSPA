<?php

//connection details
$host = "love2buyhouses.com.mysql";
$username = "love2buyhouses_com";
$password = "HVApZMYt";
$database = "love2buyhouses_com";
$phone = $_REQUEST['phone'];
$companyName = $_REQUEST['CompanyName'];
$email = $_REQUEST['email'];
$firstName= $_REQUEST['FirstName'];
$lastName= $_REQUEST['LastName'];
$message = "help me";

//make connection
$con = mysqli_connect($host, $username, $password);
if (!$con) {
    die("Unable to connect to database: ". mysql_error());
    exit();
}
$mydb = mysqli_select_db($con, "love2buyhouses_com") or die("Unable to select database");

//check for duplicates
// $sql="SELECT * FROM home_seller WHERE address = '$address'";
// $result = mysqli_query($con, $sql);
// if($result == false)
// {
//     echo 'The query failed.';
//     $message = "OK";
    
//     exit();
// }
// else if(mysqli_num_rows($result) > 1)
// {
//      echo 'This address has already been entered';
//     $message = "OK";
  
// }
// else
// {
   $result = mysqli_query($con,"INSERT INTO partner (firstName,lastName,companyName,phone,email) VALUES('$firstName','$lastName','$companyName','$phone','$email')");

   // echo $email;
    //if success
    if($result)
    {
        $message = "OK";
    }
 else {
        $message = "An error occured while subscription. Please try again later.". mysql_error();
    }
// }
mysqli_close($con);

echo $message;