<?php
Class dbObj{
 /* Database connection */
  var $servername = "localhost";
  var $username = "root";
  var $password = "";
  var $dbname = "bookmark_rest";
  var $conn;

  function getConnstring() {
    $con = mysqli_connect($this->servername, $this->username, $this->password, $this->dbname) or die("Connection failed: " . mysqli_connect_error());
      
    /* check connection */
    if (mysqli_connect_errno()) {
       printf("Connect failed: %s\n", mysqli_connect_error());
       exit();
    } else {
       $this->conn = $con;
      }
      return $this->conn;
    }
  }
?>