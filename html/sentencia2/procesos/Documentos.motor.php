<?php
session_start();

$nombrefrente= trim($_GET["nombrefrente"]);
$nomcandidato= trim($_GET["nomcandidato"]);
$cidentidad= trim($_GET["cidentidad"]);
$cnacimiento= trim($_GET["cnacimiento"]);
$ctitulo= trim($_GET["ctitulo"]);
$cantiguo= trim($_GET["cantiguedad"]);


$sql="insert into Frente (nusuario, nomFrente, nomCandidato, ciIdentidad, cNacimiento, Ctitulo, Cantiguedad) values('".$_SESSION["id"]."', '$nombrefrente', '$nomcandidato','$cidentidad','$cnacimiento','$ctitulo','$cantiguo')";
$resultado=pg_query($con,$sql);
?>