<?php
session_start();
$id = $_GET["id"];
$sql="select u.Nomusuario from Usuario u, Rol r, RolUsuario rl where r.namerol = 'RepFrente' and u.id=".$id." and rl.Idusuario = ".$id." and rl.IdRol = r.IDrol";
$resultado=pg_query($con,$sql);
$fila=pg_fetch_array($resultado);
$_SESSION["id"]=$fila['nomusuario'];
//echo $_SESSION["nombre"];
?>