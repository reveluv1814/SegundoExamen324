<?php
include "conexion.php";
//selecciona el flujo y el proceso
$flujo=$_GET["flujo"];
$proceso=$_GET["proceso"];
$sql="select * from flujoproceso ";
$sql.="where Flujo='$flujo' and proceso='$proceso'";
$resultado=pg_query($con, $sql);
$fila=pg_fetch_array($resultado);

//llama a la pantalla de ese flujo
$pantalla=$fila['pantalla'];
$pantalla.=".php";
//llama al controlador de esa pantalla
$pantallalogica=$fila['pantalla'];
$pantallalogica.=".main.php";
//se hace un solapamiento en las variables 
$procesoanterior=$proceso;
$proceso=$fila['procesosiguiente'];
//llama a la sesion
include "procesos/".$pantallalogica;
?>
<html>
<body>
	Flujo de Procesos<br>
	<form action="motor.php" method="GET">
		<!--iframe src="pantalla.php"></iframe-->
		<input type="hidden" name="flujo" value="<?php echo $flujo;?>"/>
		<input type="hidden" name="proceso" value="<?php echo $proceso;?>"/>
		<input type="hidden" name="procesoanterior" value="<?php echo $procesoanterior;?>"/>
		<?php
		//var_dump($fila);
        //la pantalla
		include "procesos/".$pantalla;
		?>
		<input type="submit" name="Anterior" value="Anterior"/>
		<input type="submit" name="Siguiente" value="Siguiente"/>
	</form>
</body>
</html>