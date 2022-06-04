<?php
session_start();

$nombrefrente= trim($_GET["nombrefrente"]);
$nomcandidato= trim($_GET["nomcandidato"]);
$cidentidad= trim($_GET["cidentidad"]);
$cnacimiento= trim($_GET["cnacimiento"]);
$ctitulo= trim($_GET["ctitulo"]);
$cantiguo= trim($_GET["cantiguedad"]);
$sql="update Frente set ";
$sql.="nomfrente='$nombrefrente', nomcandidato='$nomcandidato', ciidentidad = '$cidentidad', cnacimiento = '$cnacimiento',cantiguedad = '$cantiguo', ctitulo = '$ctitulo' ";
$sql.=" where nusuario ='".$_SESSION["id"]."'";
$resultado=pg_query($con,$sql);
?>