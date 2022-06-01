<?php
session_start();
//cho "Hola: ".$_SESSION["id"];
//echo "<br>";

/*$sql="select * from alumno where id=".$_SESSION["id"];
$resultado=pg_query($con,$sql);
$fila=pg_fetch_array($resultado);
$nombrecompleto=$fila["nombrecompleto"]*/
?>
<h2>Bienvenido:&nbsp;&nbsp;&nbsp;<b><?php echo "".$_SESSION["id"]; ?></b></h2>

<!-- estilo-->
<style>
    h2{
        padding: 30px;
        color: #fff;
        background-color: #4C6983;
        width: 20%;
        border-radius: 40px;
        margin-left: 1%;
        font-weight: 100;
        font-size: 30px;
    }
    h2:hover{
        background-color: #222831;
    }
</style>