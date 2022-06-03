<?php
    if(isset($_GET["Anterior"]))
    {       
        header("Location: ../principal.php?flujo=F1&proceso=P9");
    }
    else{
    session_start();
    session_destroy();
    }
?>
<h1>Fin</h1>

<h3>Final del Proceso</h3>
    <h4>Flujo Terminado</h4>
    <form action="../index.php" method="get">
        <button type="submit" class="log-btn" >Volver a Inicio</button>
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