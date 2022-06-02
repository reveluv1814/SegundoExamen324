<?php
$flujo = 'F1';
if(isset($_POST['procesosi'])){
    //echo "si dice"."<br> ";
    $procesosi = 'P8';
    header("Location: ./../principal.php?flujo=$flujo&proceso=$procesosi");
}
if(isset($_POST['procesono'])){
    //echo "no dice";
    $procesono = 'P9';
    header("Location: ../principal.php?flujo=$flujo&proceso=$procesono");
}
?>
