<?php
    session_start();
    $_SESSION["tribunal"]="Tribunal Electoral";
?>
<h2>Bienvenido:&nbsp;&nbsp;&nbsp;<b><?php echo "".$_SESSION["tribunal"]; ?></b></h2>
<h1>Flujo de Proceso Condicionante</h1>

<h3>Proceso 6 y 7 </h3>
    <h4>Proceso Condicionante</h4>
controlar docs


<form action="procesos/MotorCondicionante.php" method="post" >
  fue aceptado? <br>
<input type="checkbox" name="procesosi" value="value1"> Sip
<input type="checkbox" name="procesono" value="value2"> Nop
<input type="submit" value="Submit"> 
</form>

<!-- estilo-->
<style>
    h1{
			text-align: center;
			font-family: 'Poppins', sans-serif;
			font-weight: 400;
    		font-size: 88px;
			top: 20%;
			color: #393E46;
		}
    h2{
        padding: 30px;
        color: #fff;
        background-color: #4C6983;
        width: 20%;
        border-radius: 40px;
        margin-left: 1%;
        margin-top: 2%;
        font-weight: 100;
        font-size: 30px;
    }
    h2:hover{
        background-color: #222831;
    }
    h3{
        font-size: 30px;
        font-weight: 400;
        text-align: center;
        color: #3A4750;
    }
    h4{
        font-size: 35px;
        font-weight: bold;
        text-align: center;
        color: #3A4750;
    }
</style>