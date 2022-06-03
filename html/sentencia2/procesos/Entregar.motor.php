<?php
session_start();

$idfrente= intval(trim($_GET["idfrente"]));
$horaentrega= $_GET["horaentrega"];
$fecha= $_GET["fecha"];
$sql="insert into Entrega (idfrente, horaentrega, fecha) values( $idfrente, '$horaentrega','$fecha')";
$resultado=pg_query($con,$sql);

?>